using Microsoft.IO;
using BenchmarkDotNet.Attributes;
using Core;

namespace Holisticware.Library.Snippets.Strings;

[MemoryDiagnoser]
[Config(typeof(Config))]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90)]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[HideColumns(BenchmarkDotNet.Columns.Column.Job, BenchmarkDotNet.Columns.Column.RatioSD, BenchmarkDotNet.Columns.Column.AllocRatio)]
public partial class
                                        Benchmarks_Strings_Split
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
    
    
    [Benchmark]
    [Arguments("adsadasafsaa;dsadadsa,dasdassdasdasd;sdsdsdsl;dasdasddas,20202,dsasds", new char[] { ',', ';' })]
    [Arguments("adsadasafsaa;dsadadsa;dasdassdasdasd;sdsdsdsl;dasdasddas;20202;dsasds", new char[] { ',', ';' })]
    [Arguments("adsadasafsaa;dsadadsa;dasdassdasdasd;sdsdsdsl;dasdasddas;20202;dsasds", new char[] { ';' })]
    public
        string[]
                                        HolisticWare_Core_String_ChopStringNative
                                        (
                                            string input,
                                            //[Values(',', ';')] char[] delimiters
                                            char[] delimiters
                                        )
    {
        return input.ChopStringNative(new char[] { ',', ';' });
    }

    [Benchmark]
    [Arguments("adsadasafsaa;dsadadsa,dasdassdasdasd;sdsdsdsl;dasdasddas,20202,dsasds", new char[] { ',', ';' })]
    [Arguments("adsadasafsaa;dsadadsa;dasdassdasdasd;sdsdsdsl;dasdasddas;20202;dsasds", new char[] { ',', ';' })]
    [Arguments("adsadasafsaa;dsadadsa;dasdassdasdasd;sdsdsdsl;dasdasddas;20202;dsasds", new char[] { ';' })]
    public
        string[]
                                        HolisticWare_Core_String_ChopWithSpan
                                        (
                                            string input,
                                            //[Values(',', ';')] char[] delimiters
                                            char[] delimiters
                                        )
    {
        return input.ChopWithSpan(new char[] { ',', ';' });
    }
}
