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
//[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[HideColumns("Error", "StdDev")]
public partial class
                                       Benchmarks_XML_Weather
{
    private static readonly
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager = new ();

    private static
        global::System.Xml.Serialization.XmlSerializer
                                        serializer_xsxs_1 = new XmlSerializer(typeof(Models.Weather));

    private static
        global::System.Runtime.Serialization.DataContractSerializer
                                        serializer_rdc_1 = new DataContractSerializer(typeof(Models.Weather));


    [Benchmark]
    public
        void
                                        Test_01_Initialize_01_System_Xml_Serialization_XmlSerializer_Create
                                        (
                                        )
    {
        serializer_xsxs_1 = new global::System.Xml.Serialization.XmlSerializer(typeof(Weather));

        return;
    }

    [Benchmark]
    public
        void
                                        Test_02_Initialize_01_System_Runtime_Serialization_DataContractSerializer_Create
                                        (
                                        )
    {
        serializer_rdc_1 = new global::System.Runtime.Serialization.DataContractSerializer(typeof(Weather));

        return;
    }

    [Benchmark]
    public
        string
                                        Test_11_Serialize_01_System_Runtime_Serialization_Serialize_with_MemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::System.IO.MemoryStream ms = new ())
        {
            serializer_rdc_1.WriteObject(ms, Benchmarks_XML.weather);
            result = System.Text.Encoding.UTF8.GetString(ms.GetBuffer(), 0, (int)ms.Position);
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_11_Serialize_02_System_Runtime_Serialization_Serialize_with_RecyclableMemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            serializer_rdc_1.WriteObject(ms, Benchmarks_XML.weather);
            result = System.Text.Encoding.UTF8.GetString(ms.GetBuffer(), 0, (int)ms.Position);
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_Serialize_01_System_Xml_Serialization_Serialize_with_MemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::System.IO.MemoryStream ms = new ())
        {
            using(StringWriter textWriter = new StringWriter())
            {
                serializer_xsxs_1.Serialize(textWriter, Benchmarks_XML.weather);
                result = textWriter.ToString();
            }
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_Serialize_02_System_Xml_Serialization_Serialize_with_RecyclableMemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            using(StringWriter textWriter = new StringWriter())
            {
                serializer_xsxs_1.Serialize(textWriter, Benchmarks_XML.weather);
                result = textWriter.ToString();
            }
        }

        return result;
    }
}
