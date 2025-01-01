using Microsoft.IO;
using BenchmarkDotNet.Attributes;

namespace Holisticware.Library.Snippets.MemoryStream;

[MemoryDiagnoser]
public partial class
                                        Benchmarks_MemoryStream
{
    public static readonly RecyclableMemoryStreamManager rmsm_static = new();
    
    [Benchmark]
    [Arguments("files/email50.csv")]
    [Arguments("files/Izvjesce-o-provedbi-ZPPI-za-2023.doc")]
    [Arguments("files/Sazetak-Izvjesca-o-provedbi-ZPPI-za-2023.doc")]
    [Arguments("files/17818489.zip")]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.45.19.jpeg")]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.57.27.jpeg")]
    [Arguments("files/plavi-tjedan.jpg")]
    public
        void
                                        File_doc_to_MemoryStream
                                        (
                                            string file
                                        )
    {
        using (FileStream fs = File.OpenRead(file))
        {
            System.IO.MemoryStream ms = new ();
            ms.SetLength(fs.Length);
            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
        }
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/email50.csv")]
    [Arguments("files/Izvjesce-o-provedbi-ZPPI-za-2023.doc")]
    [Arguments("files/Sazetak-Izvjesca-o-provedbi-ZPPI-za-2023.doc")]
    [Arguments("files/17818489.zip")]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.45.19.jpeg")]
    [Arguments("files/WhatsApp Image 2024-11-06 at 11.57.27.jpeg")]
    [Arguments("files/plavi-tjedan.jpg")]
    public
        void
                                        File_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream
                                        (
                                            string file
                                        )
    {
        RecyclableMemoryStream rms = rmsm_static.GetStream(File.ReadAllBytes(file));
        
        return;
    }
}
