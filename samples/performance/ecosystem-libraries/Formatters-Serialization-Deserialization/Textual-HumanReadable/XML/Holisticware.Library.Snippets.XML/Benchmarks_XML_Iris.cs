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
                                       Benchmarks_XML_Iris
{
    private static readonly
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager = new ();

    private static
        global::System.Xml.Serialization.XmlSerializer
                                        serializer_xsxs_2 = new XmlSerializer(typeof(Models.Iris));

    private static
        global::System.Runtime.Serialization.DataContractSerializer
                                        serializer_rdc_2 = new DataContractSerializer(typeof(Models.Iris));

    private static
        string
                                        content = System.IO.File.ReadAllText("Data/iris.xml");


    [Benchmark]
    public
        void
                                        Test_01_Initialize_01_System_Xml_Serialization_XmlSerializer_Create
                                        (
                                        )
    {
        serializer_xsxs_2 = new global::System.Xml.Serialization.XmlSerializer(typeof(Iris));

        return;
    }

    [Benchmark]
    public
        void
                                        Test_02_Initialize_01_System_Runtime_Serialization_DataContractSerializer_Create
                                        (
                                        )
    {
        serializer_rdc_2 = new global::System.Runtime.Serialization.DataContractSerializer(typeof(Iris));

        return;
    }

    [Benchmark]
    public
        string
                                        Test_11_Serialize_01_System_Runtime_Serialization_with_MemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::System.IO.MemoryStream ms = new ())
        {
            serializer_rdc_2.WriteObject(ms, Benchmarks_XML.iris);
            result = System.Text.Encoding.UTF8.GetString(ms.GetBuffer(), 0, (int)ms.Position);
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_11_Serialize_02_System_Runtime_Serialization_with_RecyclableMemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            serializer_rdc_2.WriteObject(ms, Benchmarks_XML.iris);
            result = System.Text.Encoding.UTF8.GetString(ms.GetBuffer(), 0, (int)ms.Position);
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_Serialize_01_System_Xml_Serialization_with_MemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::System.IO.MemoryStream ms = new ())
        {
            using(StringWriter tw = new ())
            {
                serializer_xsxs_2.Serialize(tw, Benchmarks_XML.iris);
                result = tw.ToString();
            }
        }

        return result;
    }

    [Benchmark]
    public
        string
                                        Test_12_Serialize_02_System_Xml_Serialization_with_RecyclableMemoryStream
                                        (
                                        )
    {
        string result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            using(StringWriter tw = new ())
            {
                serializer_xsxs_2.Serialize(tw, Benchmarks_XML.iris);
                result = tw.ToString();
            }
        }

        return result;
    }

    [Benchmark]
    public
        Models.Iris
                                        Test_21_Deserialize_01_System_Runtime_Serialization_with_MemoryStream
                                        (
                                        )
    {
        Models.Iris result = default;

        using (System.IO.MemoryStream ms = new (System.Text.Encoding.UTF8.GetBytes(content)))
        {
            result = (Iris)serializer_rdc_2.ReadObject(ms);
        }

        return result;
    }

    [Benchmark]
    public
        Models.Iris
                                        Test_21_Deserialize_02_System_Runtime_Serialization_with_RecyclableMemoryStream
                                        (
                                        )
    {
        Models.Iris result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            result = (Iris)serializer_rdc_2.ReadObject(ms);
        }

        return result;
    }

    [Benchmark]
    public
        Models.Iris
                                        Test_22_Deserialize_01_System_Xml_Serialization_with_MemoryStream
                                        (
                                        )
    {
        Models.Iris result = default;

        using (System.IO.MemoryStream ms = new (System.Text.Encoding.UTF8.GetBytes(content)))
        {
            result = (Iris)serializer_xsxs_2.Deserialize(ms);
        }

        return result;
    }

    [Benchmark]
    public
        Models.Iris
                                        Test_22_Deserialize_02_System_Xml_Serialization_with_RecyclableMemoryStream
                                        (
                                        )
    {
        Models.Iris result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            result = (Iris)serializer_xsxs_2.Deserialize(ms);
        }

        return result;
    }
}
