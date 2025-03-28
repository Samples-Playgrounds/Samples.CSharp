using BenchmarkDotNet.Attributes;

namespace Holisticware.Library.Snippets.Strings;

[MemoryDiagnoser]
[Config(typeof(Config))]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90)]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[HideColumns(BenchmarkDotNet.Columns.Column.Job, BenchmarkDotNet.Columns.Column.RatioSD, BenchmarkDotNet.Columns.Column.AllocRatio)]
public partial class
                                        Benchmarks_Strings_Concatenation
{
    private class 
                                        Config 
                                        :
                                        BenchmarkDotNet.Configs.ManualConfig
    {
        public 
                                        Config
                                        (
                                        )
        {
            SummaryStyle =
                BenchmarkDotNet.Reports.SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Percentage);
        }
    }
    

    string title = "Mr.";
    string firstName = "Name";
    string middleName = "MName"; 
    string lastName = "NameLast";

    [Benchmark]
    public
        string
                                        HolisticWare_Core_String_ConcatWithConcat
                                        (
                                        )
    {
        return global::Core.String.ConcatWithConcat
                                        (
                                            new string[]
                                            {
                                                title,
                                                " ",
                                                firstName,
                                                " ",
                                                middleName,
                                                " ",
                                                lastName
                                            }
                                        );
    }

    [Benchmark]
    public
        string
                                        HolisticWare_Core_String_ConcatWithJoin
                                        (
                                        )
    {
        return global::Core.String.ConcatWithJoin
                                        (
                                            new string[]
                                            {
                                                title,
                                                " ",
                                                firstName,
                                                " ",
                                                middleName,
                                                " ",
                                                lastName
                                            }
                                        );
    }
    
    [Benchmark]
    public 
        string 
                                        Cysharp_Text_ZString_Utf16ValueStringBuilder
                                        (
                                        )
    {
        Cysharp.Text.Utf16ValueStringBuilder zstring_stringBuilder_method_local = Cysharp.Text.ZString.CreateStringBuilder();

        zstring_stringBuilder_method_local.Append(title);
        zstring_stringBuilder_method_local.Append(' ');
        zstring_stringBuilder_method_local.Append(firstName);
        zstring_stringBuilder_method_local.Append(' ');
        zstring_stringBuilder_method_local.Append(middleName);
        zstring_stringBuilder_method_local.Append(' ');
        zstring_stringBuilder_method_local.Append(lastName);
        
        return zstring_stringBuilder_method_local.ToString();
    }

    [Benchmark]
    public 
        string 
                                        Cysharp_Text_ZString_Concat
                                        (
                                        )
    {
        // same as x + y + z
        //_ = Cysharp.Text.ZString.Concat(title, " ", firstName, " ", middleName, " ", lastName);
        
        return Cysharp.Text.ZString.Concat(title, " ", firstName, " ", middleName, " ", lastName);

    }

    [Benchmark]
    public 
        string 
                                        Cysharp_Text_ZString_Format
                                        (
                                        )
    {
        // also can use numeric format strings
        /*
        _ = Cysharp.Text.ZString.Format
                                    (
                                        "{0:20}, {1:20}, {2:20}, {3:20}",
                                        title, firstName, middleName, lastName
                                    );
        */
        // also can use numeric format strings
        return Cysharp.Text.ZString.Format
                                    (
                                        "{0:20}, {1:20}, {2:20}, {3:20}",
                                        title, firstName, middleName, lastName
                                    );

    }

    [Benchmark]
    public
        string
                                        Cysharp_Text_ZString_Join
                                        (
                                        )
    {
        return Cysharp.Text.ZString.Join
                                    (
                                        ',', 
                                        title, firstName, middleName, lastName
                                    );

    }
    
    [Benchmark]
    public
        string
                                        StringBuilder
                                        (
                                        )
    {
        System.Text.StringBuilder stringBuilder = new();

        return stringBuilder
            .Append(title).Append(' ')
            .Append(firstName).Append(' ')
            .Append(middleName).Append(' ')
            .Append(lastName).ToString();
    }

    [Benchmark]
    public
        string
                                        StringBuilder_Core_Text_StringBuilderCache
                                        (
                                        )
    {
        System.Text.StringBuilder stringBuilder = Core.Text.StringBuilderCache.Acquire();

        return stringBuilder
            .Append(title).Append(' ')
            .Append(firstName).Append(' ')
            .Append(middleName).Append(' ')
            .Append(lastName).ToString();
    }
    
    [Benchmark]
    public
        string
                                        StringBuilderExact24
                                        (
                                        )
    {
        System.Text.StringBuilder stringBuilder = new(24);

        return stringBuilder
            .Append(title).Append(' ')
            .Append(firstName).Append(' ')
            .Append(middleName).Append(' ')
            .Append(lastName).ToString();
    }

    [Benchmark]
    public
        string
                                        StringBuilderEstimate100
                                        (
                                        )
    {
        System.Text.StringBuilder stringBuilder = new(100);

        return stringBuilder
            .Append(title).Append(' ')
            .Append(firstName).Append(' ')
            .Append(middleName).Append(' ')
            .Append(lastName).ToString();
    }

    [Benchmark]
    public
        string
                                        StringAddition
                                        (
                                        )
    {
        return 
            title 
            + ' ' + 
            firstName 
            + ' ' +
            middleName 
            + ' ' + 
            lastName
            ;
    }

    [Benchmark]
    public
        string
                                        String_Format
                                        (
                                        )
    {
        return string.Format("{0} {1} {2} {3}",
            title, firstName, middleName, lastName);
    }

    [Benchmark]
    public
        string
                                        String_Interpolation
                                        (
                                        )
    {
        return
                $"{title} {firstName} {middleName} {lastName}";
    }

    [Benchmark]
    public
        string
                                        String_Join
                                        (
                                        )
    {
        return string.Join(" ", title, firstName,
            middleName, lastName);
    }

    [Benchmark]
    public
        string
                                        String_Concat
                                        (
                                        )
    {
        return string.
            Concat(new string[] { title, " ", firstName, " ", middleName, " ", lastName });
    }

    #if NET8_0_OR_GREATER || NETSTANDARD2_1
    // https://www.reddit.com/r/dotnet/comments/wgwct9/what_is_the_use_case_for_netstandard21/
    // https://apisof.net/catalog/0ea2d97d848a21bf37885c4d35fcad2a
    [Benchmark]
    public string StringCreate_Simple()
    {
        return 
            string.Create
                    (
                        title.Length + firstName.Length + middleName.Length + lastName.Length + 3,
                        (title, firstName, middleName, lastName),
                        (span, state) 
                            => 
                            span.TryWrite
                                    (
                                        $"{state.title} {state.firstName} {state.middleName} {state.lastName}", 
                                        out _
                                    )
                    );
    }
    
    [Benchmark]
    public 
        string
                                        StringCreate_Complex
                                        (
                                        )
    {
        return 
            String.Create
                    (
                        title.Length + firstName.Length + middleName.Length + lastName.Length + 3,
                        (title, firstName, middleName, lastName),
                        (span, state) =>
                        {
                            state.title.AsSpan().CopyTo(span);
                            span = span.Slice(state.title.Length);
                            span[0] = ' ';
                            span = span.Slice(1);

                            state.firstName.AsSpan().CopyTo(span);
                            span = span.Slice(state.firstName.Length);
                            span[0] = ' ';
                            span = span.Slice(1);

                            state.middleName.AsSpan().CopyTo(span);
                            span = span.Slice(state.middleName.Length);
                            span[0] = ' ';
                            span = span.Slice(1);

                            state.lastName.AsSpan().CopyTo(span);
                        }
                    );
    }
    #endif
}
