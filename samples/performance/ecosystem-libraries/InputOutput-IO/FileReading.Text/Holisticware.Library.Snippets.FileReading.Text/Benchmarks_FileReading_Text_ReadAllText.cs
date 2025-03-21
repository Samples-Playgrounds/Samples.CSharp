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
                                        Benchmarks_FileReading_Text_ReadAllText
{
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        File_ReadAllLines_StringBuilder
                                        (
                                            string file_path_test_data
                                        )
    {
        string[] lines = File.ReadAllLines(file_path_test_data);
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        foreach (var line in lines)
        {
            stringBuilder.AppendLine(line);
        }

        stringBuilder.Length -= Environment.NewLine.Length;

        return stringBuilder.ToString();
    }

    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        File_ReadAllLines_ZString
                                        (
                                            string file_path_test_data
                                        )
    {
        string[] lines = File.ReadAllLines(file_path_test_data);
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();
        foreach (string line in lines)
        {
            sb.AppendLine(line);
        }

        return sb.ToString();
    }

    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        File_ReadAllText
                                        (
                                            string file_path_test_data
                                        )
    {
        return System.IO.File.ReadAllText(file_path_test_data);
    }

    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadLine_StringBuilder
                                        (
                                            string file_path_test_data
                                        )
    {
        using StreamReader sr = new StreamReader(file_path_test_data);
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        while (sr.ReadLine() is { } fileLine)
        {
            sb.AppendLine(fileLine);
        }

        return sb.ToString();
    }
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadLine_ZString
                                        (
                                            string file_path_test_data
                                        )
    {
        using StreamReader sr = new StreamReader(file_path_test_data);
        
        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();

        while (sr.ReadLine() is { } fileLine)
        {
            sb.AppendLine(fileLine);
        }

        return sb.ToString();
    }

    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadToEnd
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.StreamReader sr = new System.IO.StreamReader(file_path_test_data);
        
        return sr.ReadToEnd();
    }
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadBlock_StringBuilder
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.StreamReader sr = new System.IO.StreamReader(file_path_test_data);
        
        char[] buffer = new char[4096];
        int numberRead;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        while ((numberRead = sr.ReadBlock(buffer, 0, buffer.Length)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadBlock_ZString
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.StreamReader sr = new System.IO.StreamReader(file_path_test_data);
        
        char[] buffer = new char[4096];
        int numberRead;
        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();
        while ((numberRead = sr.ReadBlock(buffer, 0, buffer.Length)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadBlock_ArrayPool_StringBuilder
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.StreamReader sr = new System.IO.StreamReader(file_path_test_data);
        
        char[] buffer = System.Buffers.ArrayPool<char>.Shared.Rent(4096);
        int numberRead;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        while ((numberRead = sr.ReadBlock(buffer, 0, buffer.Length)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadBlock_ArrayPool_ZString
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.StreamReader sr = new System.IO.StreamReader(file_path_test_data);
        
        char[] buffer = System.Buffers.ArrayPool<char>.Shared.Rent(4096);
        int numberRead;
        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();
        while ((numberRead = sr.ReadBlock(buffer, 0, buffer.Length)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadBlock_Span_StringBuilder
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.StreamReader sr = new System.IO.StreamReader(file_path_test_data);
        
        Span<char> buffer = new char[4096].AsSpan();
        int numberRead;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        while ((numberRead = sr.ReadBlock(buffer)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_ReadBlock_Span_ZString
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.StreamReader sr = new System.IO.StreamReader(file_path_test_data);
        
        Span<char> buffer = new char[4096].AsSpan();
        int numberRead;
        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();
        while ((numberRead = sr.ReadBlock(buffer)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }    
    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_FileStream_BufferedStream_ReadLine_ZString
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.FileStream fs = new System.IO.FileStream
                                                            (
                                                                file_path_test_data,
                                                                FileMode.Open,
                                                                FileAccess.Read,
                                                                FileShare.Read
                                                            );
        using System.IO.BufferedStream bs = new System.IO.BufferedStream(fs);
        using System.IO.StreamReader sr = new System.IO.StreamReader(bs);
        
        Span<char> buffer = new char[4096].AsSpan();
        int numberRead;
        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();
        while ((numberRead = sr.ReadBlock(buffer)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        StreamReader_FileStream_MemoryStream_ReadLine_ZString
                                        (
                                            string file_path_test_data
                                        )
    {
        using System.IO.FileStream fs = new System.IO.FileStream
                                                            (
                                                                file_path_test_data,
                                                                FileMode.Open,
                                                                FileAccess.Read,
                                                                FileShare.Read
                                                            );
        using System.IO.MemoryStream ms = new System.IO.MemoryStream();
        fs.CopyTo(ms);
        using System.IO.StreamReader sr = new System.IO.StreamReader(ms);
        
        Span<char> buffer = new char[4096].AsSpan();
        int numberRead;
        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();
        while ((numberRead = sr.ReadBlock(buffer)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }
    
    private static readonly 
        Microsoft.IO.RecyclableMemoryStreamManager 
                                        rmsm = new Microsoft.IO.RecyclableMemoryStreamManager();

    [GlobalSetup(Target = nameof(ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect))]
    public
        void
                                        Setup_ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect
                                        (
                                        )
    {
        Core.IO.File.ReadAllTextImplementation 
                = Core.IO.File.ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString;
        
        return;
    }
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllText(file_path_test_data);
    }    
    
    [Benchmark]
    [Arguments("td/192.txt")]
    [Arguments("td/258.txt")]
    [Arguments("td/519.1mb.csv")]
    [Arguments("td/530.2mb.csv")]
    [Arguments("td/545.5mb.csv")]
    [Arguments("td/509.10mb.csv")]
    [Arguments("td/558.50mb.csv")]
    public
        string
                                        ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct
                                        (
                                            string file_path_test_data
                                        )
    {
        return Core.IO.File.ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString
                                                                                (
                                                                                    file_path_test_data
                                                                                );
    }    
}