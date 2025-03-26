using BenchmarkDotNet.Attributes;
using Holisticware.Library.Snippets.Strings.HolisticWare;

namespace Holisticware.Library.Snippets.Methods.Calls;

public partial class
                                        Benchmarks_Methods_Calls
{
    [Benchmark]
    [Arguments(2)]
    [Arguments(-2)]
    [Arguments(434234723)]
    [Arguments(-434234723)]
    public
        int
                                        InstanceMethodDouble
                                        (
                                            int arg
                                        )
    {
        return c.InstanceMethodDouble(arg);
    }
    
    [Benchmark]
    [Arguments(2)]
    [Arguments(-2)]
    [Arguments(434234723)]
    [Arguments(-434234723)]
    public
        Task<int>
                                        InstanceMethodDoubleAsync
                                        (
                                            int arg
                                        )
    {
        return c.InstanceMethodDoubleAsync(arg);
    }

    //------------------------------------------------------------------------------------------------------------------
    [GlobalSetup(Target = nameof(InstanceMethodDoubleViaFuncDelegate_InDirect))]
    public
        void
                                        Setup_InstanceMethodDoubleViaFuncDelegate_InDirect
                                        (
                                        )
    {
        c.InstanceMethodDoubleImplementation 
                                        = c.InstanceMethodDouble;
        
        return;
    }

    [Benchmark]
    [Arguments(2)]
    [Arguments(-2)]
    [Arguments(434234723)]
    [Arguments(-434234723)]
    public
        int
                                        InstanceMethodDoubleViaFuncDelegate_InDirect
                                        (
                                            int arg
                                        )
    {
        return c.InstanceMethodDoubleImplementation(arg);
    }

    [Benchmark]
    [Arguments(2)]
    [Arguments(-2)]
    [Arguments(434234723)]
    [Arguments(-434234723)]
    public
        int
                                        InstanceMethodDoubleViaFuncDelegate_Direct
                                        (
                                            int arg
                                        )
    {
        return c.InstanceMethodDouble(arg);
    }
    //------------------------------------------------------------------------------------------------------------------
    
}
