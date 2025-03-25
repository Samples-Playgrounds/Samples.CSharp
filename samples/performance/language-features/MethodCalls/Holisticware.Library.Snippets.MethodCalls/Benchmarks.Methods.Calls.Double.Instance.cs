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
    
    [Benchmark]
    [Arguments(2)]
    [Arguments(-2)]
    [Arguments(434234723)]
    [Arguments(-434234723)]
    public
        int
                                        InstanceMethodDoubleViaFuncDelegate
                                        (
                                            int arg
                                        )
    {
        return c.InstanceMethodDoubleImplementation(arg);
    }
    
}
