using System.Runtime.Serialization;
using System.Xml.Serialization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;


using Holisticware.Library.Snippets.XML.Models;


namespace Holisticware.Library.Snippets.XML;


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
                                       Benchmarks_XML
{
    private static readonly
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager = new ();

    private static
        global::System.Xml.Serialization.XmlSerializer
                                        serializer_xsxs_1 = new XmlSerializer(typeof(Models.Weather));

    private static
        global::System.Xml.Serialization.XmlSerializer
                                        serializer_xsxs_2 = new XmlSerializer(typeof(Models.Iris));

    private static
        global::System.Runtime.Serialization.DataContractSerializer
                                        serializer_rdc_1 = new DataContractSerializer(typeof(Models.Weather));


    private static
        global::System.Runtime.Serialization.DataContractSerializer
                                        serializer_rdc_2 = new DataContractSerializer(typeof(Models.Weather));


    [Benchmark]
    public
        void
                                        Test_01_System_Xml_Serialization_XmlSerializer_Create_Weather
                                        (
                                        )
    {
        serializer_xsxs_1 = new global::System.Xml.Serialization.XmlSerializer(typeof(Weather));

        return;
    }

    [Benchmark]
    public
        void
                                        Test_01_System_Xml_Serialization_XmlSerializer_Create_Iris
                                        (
                                        )
    {
        serializer_xsxs_2 = new global::System.Xml.Serialization.XmlSerializer(typeof(Iris));

        return;
    }

    [Benchmark]
    public
        void
                                        Test_02_System_Runtime_Serialization_DataContractSerializer_Create_Weather
                                        (
                                        )
    {
        serializer_rdc_1 = new global::System.Runtime.Serialization.DataContractSerializer(typeof(Weather));

        return;
    }

    [Benchmark]
    public
        void
                                        Test_02_System_Runtime_Serialization_DataContractSerializer_Create_Iris
                                        (
                                        )
    {
        serializer_rdc_2 = new global::System.Runtime.Serialization.DataContractSerializer(typeof(Iris));

        return;
    }

    [Benchmark]
    public
        string
                                        Test_11_System_Runtime_Serialization_Serialize_with_MemoryStream_Weather
                                        (
                                        )
    {
        string result = default;

        using (global::System.IO.MemoryStream ms = new ())
        {
            serializer_rdc_1.WriteObject(ms, Benchmarks_XML.weather);

            ms.Seek(0, global::System.IO.SeekOrigin.Begin);

            using (global::System.IO.StreamReader sr = new (ms))
            {
                result = sr.ReadToEnd();
            }
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_11_System_Runtime_Serialization_Serialize_with_RecyclableMemoryStream_Weather
                                        (
                                        )
    {
        string result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            serializer_rdc_1.WriteObject(ms, Benchmarks_XML.weather);

            ms.Seek(0, global::System.IO.SeekOrigin.Begin);

            using (global::System.IO.StreamReader sr = new (ms))
            {
                result = sr.ReadToEnd();
            }
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_System_Xml_Serialization_Serialize_with_MemoryStream_Weather
                                        (
                                        )
    {
        string result = default;

        using (global::System.IO.MemoryStream ms = new ())
        {
            serializer_xsxs_1.Serialize(ms, Benchmarks_XML.weather);

            ms.Seek(0, global::System.IO.SeekOrigin.Begin);

            using (global::System.IO.StreamReader sr = new (ms))
            {
                result = sr.ReadToEnd();
            }
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_System_Xml_Serialization_Serialize_with_MemoryStream_Iris
                                        (
                                        )
    {
        string result = default;

        using (global::System.IO.MemoryStream ms = new ())
        {
            serializer_xsxs_2.Serialize(ms, Benchmarks_XML.iris);

            ms.Seek(0, global::System.IO.SeekOrigin.Begin);

            using (global::System.IO.StreamReader sr = new (ms))
            {
                result = sr.ReadToEnd();
            }
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_System_Xml_Serialization_Serialize_with_RecyclableMemoryStream_Weather
                                        (
                                        )
    {
        string result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            serializer_xsxs_1.Serialize(ms, Benchmarks_XML.weather);

            ms.Seek(0, global::System.IO.SeekOrigin.Begin);

            using (global::System.IO.StreamReader sr = new (ms))
            {
                result = sr.ReadToEnd();
            }
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_System_Xml_Serialization_Serialize_with_RecyclableMemoryStream_Iris
                                        (
                                        )
    {
        string result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            serializer_xsxs_2.Serialize(ms, Benchmarks_XML.iris);

            ms.Seek(0, global::System.IO.SeekOrigin.Begin);

            using (global::System.IO.StreamReader sr = new (ms))
            {
                result = sr.ReadToEnd();
            }
        }

        return result;
    }
}
