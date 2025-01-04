using Microsoft.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Holisticware.Library.Snippets.MemoryStream;

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
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[HideColumns("Error", "StdDev")]
public partial class
                                        Benchmarks_MemoryStream
{
    public static readonly RecyclableMemoryStreamManager rmsm_static = new();
    
    [Benchmark]
    [Arguments("files/email50.csv")]
    public
        void
                                        File_csv_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        System.IO.MemoryStream ms = new ();

        using (FileStream fs = File.OpenRead(file))
        {
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }

        return;
    }
    
    [Benchmark]
    [Arguments("files/email50.csv")]
    public
        void
                                        File_csv_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/Izvjesce-o-provedbi-ZPPI-za-2023.doc")]
    public
        void
                                        File_doc_01_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        System.IO.MemoryStream ms = new ();

        using (FileStream fs = File.OpenRead(file))
        {
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }

        return;
    }
    
    [Benchmark]
    [Arguments("files/Izvjesce-o-provedbi-ZPPI-za-2023.doc")]
    public
        void
                                        File_doc_01_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/Sazetak-Izvjesca-o-provedbi-ZPPI-za-2023.doc")]
    public
        void
                                        File_doc_02_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        System.IO.MemoryStream ms = new ();

        using (FileStream fs = File.OpenRead(file))
        {
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }

        return;
    }
    
    [Benchmark]
    [Arguments("files/Sazetak-Izvjesca-o-provedbi-ZPPI-za-2023.doc")]
    public
        void
                                        File_doc_02_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/17818489.zip")]
    public
        void
                                        File_zip_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        System.IO.MemoryStream ms = new ();

        using (FileStream fs = File.OpenRead(file))
        {
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }

        return;
    }
    
    [Benchmark]
    [Arguments("files/17818489.zip")]
    public
        void
                                        File_zip_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.45.19.jpeg")]
    public
        void
                                        File_jpeg_01_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        System.IO.MemoryStream ms = new ();

        using (FileStream fs = File.OpenRead(file))
        {
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }

        return;
    }
    
    [Benchmark]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.45.19.jpeg")]
    public
        void
                                        File_jpeg_01_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.57.27.jpeg")]
    public
        void
                                        File_jpeg_02_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        System.IO.MemoryStream ms = new ();

        using (FileStream fs = File.OpenRead(file))
        {
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }

        return;
    }
    
    [Benchmark]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.57.27.jpeg")]
    public
        void
                                        File_jpeg_02_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/plavi-tjedan.jpg")]
    public
        void
                                        File_jpg_01_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        System.IO.MemoryStream ms = new ();

        using (FileStream fs = File.OpenRead(file))
        {
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }

        return;
    }
    
    [Benchmark]
    [Arguments("files/plavi-tjedan.jpg")]
    public
        void
                                        File_jpg_01_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
}
