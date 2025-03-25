using BenchmarkDotNet.Attributes;
using Holisticware.Library.Snippets.Strings.HolisticWare;

namespace Holisticware.Library.Snippets.Methods.Calls;

[MemoryDiagnoser]
[Config(typeof(Config))]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90)]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[HideColumns(BenchmarkDotNet.Columns.Column.Job, BenchmarkDotNet.Columns.Column.RatioSD, BenchmarkDotNet.Columns.Column.AllocRatio)]
public partial class
                                        Benchmarks_Methods_Calls
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
    
    private 
        ContainerForMethods 
                                        c = new();
    
}
