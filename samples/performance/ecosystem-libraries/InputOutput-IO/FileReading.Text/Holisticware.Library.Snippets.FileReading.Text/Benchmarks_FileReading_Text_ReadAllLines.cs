using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;

namespace Holisticware.Library.Snippets.FileReading.Text;

[MemoryDiagnoser]
// [ThreadingDiagnoser]
// [ExceptionDiagnoser]
[AsciiDocExporter]
[CsvExporter]
[CsvMeasurementsExporter]
[HtmlExporter]
[PlainExporter]
[RPlotExporter]
[JsonExporterAttribute.Brief]
[JsonExporterAttribute.BriefCompressed]
[JsonExporterAttribute.Full]
[JsonExporterAttribute.FullCompressed]
[MarkdownExporterAttribute.Default]
[MarkdownExporterAttribute.GitHub]
[MarkdownExporterAttribute.StackOverflow]
[MarkdownExporterAttribute.Atlassian]
[XmlExporterAttribute.Brief]
[XmlExporterAttribute.BriefCompressed]
[XmlExporterAttribute.Full]
[XmlExporterAttribute.FullCompressed]
//[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[HideColumns("Error", "StdDev")]
public partial class
                                        Benchmarks_FileReading_Text_ReadAllLines
{
    //------------------------------------------------------------------------------------------------------------------
    [GlobalSetup(Target = nameof(ReadAllLinesWithFileReadAllLines_InDirect))]
    public
        void
                                        Setup_ReadAllLinesWithFileReadAllLines_InDirect
                                        (
                                        )
    {
        Core.IO.File.ReadAllLinesImplementation 
                = Core.IO.File.ReadAllLinesWithFileReadAllLines;
        
        return;
    }
    
    [Benchmark]
    [Arguments("td/s1/kb.1.txt")]
    [Arguments("td/s1/kb.2.txt")]
    [Arguments("td/s1/kb.5.txt")]
    [Arguments("td/s1/kb.10.txt")]
    [Arguments("td/s1/kb.20.txt")]
    [Arguments("td/s1/kb.50.txt")]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        ReadAllLinesWithFileReadAllLines_InDirect
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllLines(file_path_test_data);
    }    
    
    [Benchmark]
    [Arguments("td/s1/kb.1.txt")]
    [Arguments("td/s1/kb.2.txt")]
    [Arguments("td/s1/kb.5.txt")]
    [Arguments("td/s1/kb.10.txt")]
    [Arguments("td/s1/kb.20.txt")]
    [Arguments("td/s1/kb.50.txt")]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string[]
                                        ReadAllLinesWithFileReadAllLines_Direct
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllLinesWithFileReadAllLines
                                                (
                                                    file_path_test_data
                                                );
    }    
    //------------------------------------------------------------------------------------------------------------------
 
    //------------------------------------------------------------------------------------------------------------------
    [GlobalSetup(Target = nameof(ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect))]
    public
        void
                                        Setup_ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect
                                        (
                                        )
    {
        Core.IO.File.ReadAllLinesImplementation 
                = Core.IO.File.ReadAllLinesWithFileOpenReadAndStreamReaderReadLine;
        
        return;
    }
    
    [Benchmark]
    [Arguments("td/s1/kb.1.txt")]
    [Arguments("td/s1/kb.2.txt")]
    [Arguments("td/s1/kb.5.txt")]
    [Arguments("td/s1/kb.10.txt")]
    [Arguments("td/s1/kb.20.txt")]
    [Arguments("td/s1/kb.50.txt")]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllLines(file_path_test_data);
    }    
    
    [Benchmark]
    [Arguments("td/s1/kb.1.txt")]
    [Arguments("td/s1/kb.2.txt")]
    [Arguments("td/s1/kb.5.txt")]
    [Arguments("td/s1/kb.10.txt")]
    [Arguments("td/s1/kb.20.txt")]
    [Arguments("td/s1/kb.50.txt")]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string[]
                                        ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllLinesWithFileOpenReadAndStreamReaderReadLine
                                                (
                                                    file_path_test_data
                                                );
    }    
    //------------------------------------------------------------------------------------------------------------------

    //------------------------------------------------------------------------------------------------------------------
    [GlobalSetup(Target = nameof(ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect))]
    public
        void
                                        Setup_ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect
                                        (
                                        )
    {
        Core.IO.File.ReadAllLinesImplementation 
                = Core.IO.File.ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine;
        
        return;
    }
    
    [Benchmark]
    [Arguments("td/s1/kb.1.txt")]
    [Arguments("td/s1/kb.2.txt")]
    [Arguments("td/s1/kb.5.txt")]
    [Arguments("td/s1/kb.10.txt")]
    [Arguments("td/s1/kb.20.txt")]
    [Arguments("td/s1/kb.50.txt")]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllLines(file_path_test_data);
    }    
    
    [Benchmark]
    [Arguments("td/s1/kb.1.txt")]
    [Arguments("td/s1/kb.2.txt")]
    [Arguments("td/s1/kb.5.txt")]
    [Arguments("td/s1/kb.10.txt")]
    [Arguments("td/s1/kb.20.txt")]
    [Arguments("td/s1/kb.50.txt")]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string[]
                                        ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine
                                                (
                                                    file_path_test_data
                                                );
    }    
    //------------------------------------------------------------------------------------------------------------------
    
    
}