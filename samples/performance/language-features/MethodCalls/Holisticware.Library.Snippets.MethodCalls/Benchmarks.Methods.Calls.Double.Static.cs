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
                                        StaticMethodDouble
                                        (
                                            int arg
                                        )
    {
        return ContainerForMethods.StaticMethodDouble(arg);
    }

    [Benchmark]
    [Arguments(2)]
    [Arguments(-2)]
    [Arguments(434234723)]
    [Arguments(-434234723)]
    public async
        Task<int>
                                        StaticMethodDoubleAsync
                                        (
                                            int arg
                                        )
    {
        return await ContainerForMethods.StaticMethodDoubleAsync(arg);
    }
    
    [Benchmark]
    [Arguments(2)]
    [Arguments(-2)]
    [Arguments(434234723)]
    [Arguments(-434234723)]
    public
        int
                                        StaticMethodDoubleViaFuncDelegate
                                        (
                                            int arg
                                        )
    {
        return ContainerForMethods.StaticMethodDoubleImplementation(arg);
    }

}
