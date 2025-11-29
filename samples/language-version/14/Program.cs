#!/usr/bin/dotnet run
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

//--- Result Monad ---

var f = Abs((string x) => x.Split('|')) 
        ^ Abs((string[] x) => (int.Parse(x[0]), x[1]))
        ^ Abs(((int, string) x) => (x.Item1, decimal.Parse(x.Item2)))
        ^ Abs(((int, decimal) x) => x.Item2 / x.Item1)
        ^ Abs((decimal x) => x.ToString());

//--------------------

//--- Pattern Matching, by Continuation Monad ---

var match = (Result<string> source) => source
| ((string value) => value)
| (fail => $"Error: {fail.SourceException.Message}");

var partialMatch = (Result<string> source) => source
| ((string value) => $"{value} (Partial match passed)");

//-----------------------------------------------

//--- Sample programs ---

Console.WriteLine("[Program #1]");
Console.WriteLine(match(f("10|123.456")).Value);

Console.WriteLine("[Program #2]");
Console.WriteLine(match(f("10,123.456")).Value);

Console.WriteLine("[Program #3]");
Console.WriteLine(match(f("10")).Value);

Console.WriteLine("[Program #4]");
Console.WriteLine(match(f("10|123***456")).Value);

Console.WriteLine("[Program #5]");
Console.WriteLine(match(f("0|123.456")).Value);

try
{
    Console.WriteLine("[Program #6]");
    Console.WriteLine(partialMatch(f("10|123.456")).Value);

    Console.WriteLine("[Program #7]");
    Console.WriteLine(partialMatch(f("10|123***456")).Value);
}
catch (SwitchExpressionException e)
{
    Console.WriteLine($"{e.GetType().ToString()}: {e.Message} (Partial match failed)");
}

//-----------------------

static Func<T, TResult> Abs<T, TResult>(Func<T, TResult> func) => func;


//--- Result Monad Implementation ---

readonly record struct Result<T>
{ 
    [MemberNotNullWhen(false, nameof(Fail))] public bool IsValue {get;}
    public T Value {get;}  
    public ExceptionDispatchInfo? Fail {get;}

    internal Result(bool isValue, T value, ExceptionDispatchInfo? fail)
    {
        IsValue = isValue; Value = value; Fail = fail;
    }
}

delegate Result<TResult> ResultFunc<T, TResult>(T value);

static class ResultMonadExtensions
{
    extension<T>(Result<T> self)
    {
        public static Result<T> FromValue(T value) => new(true, value, null);
        public static Result<T> FromFail(ExceptionDispatchInfo fail) => new(false, default!, fail);
        public Result<T2> Bind<T2>(ResultFunc<T, T2> right) => self.IsValue ? right(self.Value) : FromFail<T2>(self.Fail);
    }
    extension<T, TResult>(Func<T, TResult> func)
    {
        public ResultFunc<T, TResult> Resultify() => v => 
            { try { return FromValue(func(v)); } catch (Exception e) { return FromFail<TResult>(ExceptionDispatchInfo.Capture(e)); } };
    }
    extension<T, T2, T3>(ResultFunc<T, T2>)
    {
        public static ResultFunc<T, T3> operator ^ (ResultFunc<T, T2> left, ResultFunc<T2, T3> right) => v => left(v).Bind(right);
    }
    extension<T, T2, T3>(Func<T2, T3>)
    {
        public static ResultFunc<T, T3> operator ^ (ResultFunc<T, T2> left, Func<T2, T3> right) => left ^ right.Resultify();
        public static ResultFunc<T, T3> operator ^ (Func<T, T2> left, Func<T2, T3> right) => left.Resultify() ^ right;
    }
}

//--------------------------------


//--- Continuation Monad Implementation ---

public delegate T2 Cont<T, T2>(Func<T, T2> suspended);

static class ContMonadExtensions
{
    extension<T, T2>(Cont<T, T2> cont)
    {
        public static Cont<T, T2> Return(T source) => sus => sus(source);
        public Cont<T3, T2> Bind<T3>(Func<T, Cont<T3, T2>> binder) =>
            sus => cont((T s) => binder(s)(sus));
    }
}

static class ResultCpsExtensions
{
    extension<T>(Result<T> self)
    {
        public bool TryToValue([NotNullWhen(true)] out T? value) => 
            (value = self.IsValue ? self.Value : default) is not null;

        public bool TryToFail([NotNullWhen(true)] out ExceptionDispatchInfo? fail) => 
            (fail = self.IsValue ? default : self.Fail) is not null;

        public bool TryMatch<T2>(Func<T, T2>? caseOfValue, Func<ExceptionDispatchInfo, T2>? caseOfFail, [NotNullWhen(true)] out T2? matched)
        {
            if (caseOfValue is not null && self.TryToValue(out var value)) { matched = caseOfValue(value)!; return true; }
            else if (caseOfFail is not null && self.TryToFail(out var fail)) { matched = caseOfFail(fail)!; return true; }
            else { matched = default; return false; }
        }
    }

    public readonly record struct TryMatchArgs<T, T2>(Func<T, T2>? CaseOfValue, Func<ExceptionDispatchInfo, T2>? CaseOfFail);
    public readonly record struct Domain<T, T2>(Result<T> Source, TryMatchArgs<T, T2> TryMatchArgs, T2? Result);

    extension<T, T2>(Domain<T, T2> dom)
    {
        private T2? Match(Func<Domain<T, T2>, T2?> continuation) => 
            dom.Result is { } ensuredResult ? ensuredResult :
            dom.TryMatchArgs is var subDom &&
            dom.Source.TryMatch(subDom.CaseOfValue, subDom.CaseOfFail, out var matched) ? matched : continuation(dom);
    }
    extension<T, T2>(Cont<Domain<T, T2>, Domain<T, T2>> self)
    {
        private static Cont<Domain<T, T2>, Domain<T, T2>> BindCont(Cont<Domain<T, T2>, Domain<T, T2>> cont, Func<Domain<T, T2>, Cont<Domain<T, T2>, Domain<T, T2>>> binder) => cont.Bind(binder);

        public static Cont<Domain<T, T2>, Domain<T, T2>> operator | (Cont<Domain<T, T2>, Domain<T, T2>> cont, Func<T, T2> caseOfValue) =>
            BindCont(cont, (dom => sus => new (dom.Source, default, Match<T,T2>(new(dom.Source, new(caseOfValue, default), dom.Result), d => sus(d).Result))));
            
        public static Cont<Domain<T, T2>, Domain<T, T2>> operator | (Cont<Domain<T, T2>, Domain<T, T2>> cont, Func<ExceptionDispatchInfo, T2>? caseOfFail) =>
            BindCont(cont, (dom => sus => new (dom.Source, default, Match<T,T2>(new(dom.Source, new(default, caseOfFail), dom.Result), d => sus(d).Result))));
        
        public T2 Value => self(x => x).Result is { } ensured ? ensured : throw new SwitchExpressionException("Pattern matching is not exhaustive.");
    }
    extension<T, T2>(Result<T> self)
    {
        private Cont<Domain<T, T2>, Domain<T, T2>> ToCont() => ContMonadExtensions.Return<Domain<T, T2>, Domain<T, T2>>(new(self,new(default,default),default));

        public static Cont<Domain<T, T2>, Domain<T, T2>> operator | (Result<T> source, Func<T, T2> caseOfValue) => source.ToCont<T,T2>() | caseOfValue;

        public static Cont<Domain<T, T2>, Domain<T, T2>> operator | (Result<T> source, Func<ExceptionDispatchInfo, T2> caseOfFail) => source.ToCont<T,T2>() | caseOfFail;
    }   
}

//---------------------------------------------