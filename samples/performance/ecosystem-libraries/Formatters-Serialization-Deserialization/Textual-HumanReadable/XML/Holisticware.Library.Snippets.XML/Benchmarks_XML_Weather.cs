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

    private static
        string
                                        content =
                                            """
                                            <?xml version="1.0" encoding="utf-8"?>
                                            <Weather xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                                                <MinTemp>10</MinTemp>
                                                <MaxTemp>20</MaxTemp>
                                                <Rainfall>5</Rainfall>
                                                <Evaporation>3</Evaporation>
                                                <Sunshine>8</Sunshine>
                                                <WindGustDir>N</WindGustDir>
                                                <WindGustSpeed>30</WindGustSpeed>
                                                <WindDir9am>NE</WindDir9am>
                                                <WindDir3pm>SE</WindDir3pm>
                                                <WindSpeed9am>15</WindSpeed9am>
                                                <WindSpeed3pm>20</WindSpeed3pm>
                                                <Humidity9am>60</Humidity9am>
                                                <Humidity3pm>50</Humidity3pm>
                                                <Pressure9am>1010</Pressure9am>
                                                <Pressure3pm>1005</Pressure3pm>
                                                <Cloud9am>2</Cloud9am>
                                                <Cloud3pm>1</Cloud3pm>
                                                <Temp9am>0</Temp9am>
                                                <Temp3pm>0</Temp3pm>
                                                <RISK_MM>0</RISK_MM>
                                            </Weather>
                                            """
                                            // System.IO.File.ReadAllText("Data/weather.srs.xml")
                                            ;

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
            using(StringWriter tw = new ())
            {
                serializer_xsxs_1.Serialize(tw, Benchmarks_XML.weather);
                result = tw.ToString();
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
            using(StringWriter tw = new ())
            {
                serializer_xsxs_1.Serialize(tw, Benchmarks_XML.weather);
                result = tw.ToString();
            }
        }

        return result;
    }

    [Benchmark]
    public
        Models.Weather
                                        Test_21_Deserialize_01_System_Runtime_Serialization_with_MemoryStream
                                        (
                                        )
    {
        Models.Weather result = default;

        using (System.IO.MemoryStream ms = new (System.Text.Encoding.UTF8.GetBytes(content)))
        {
            result = (Weather) serializer_rdc_1.ReadObject(ms);
        }

        return result;
    }

    [Benchmark]
    public
        Models.Weather
                                        Test_21_Deserialize_02_System_Runtime_Serialization_with_RecyclableMemoryStream
                                        (
                                        )
    {
        Models.Weather result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            ms.Write(buffer, 0, buffer.Length);
            result = (Weather) serializer_rdc_1.ReadObject(ms);
        }

        return result;
    }

    [Benchmark]
    public
        Models.Weather?
                                        Test_22_Deserialize_01_System_Xml_Serialization_with_MemoryStream
                                        (
                                        )
    {
        Models.Weather? result = default;

        using (System.IO.MemoryStream ms = new (System.Text.Encoding.UTF8.GetBytes(content)))
        {
            result = (Weather) serializer_xsxs_1.Deserialize(ms);
        }

        return result;
    }

    [Benchmark]
    public
        Models.Weather
                                        Test_22_Deserialize_02_System_Xml_Serialization_with_RecyclableMemoryStream
                                        (
                                        )
    {
        Models.Weather result = default;

        using (global::Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            ms.Write(buffer, 0, buffer.Length);
            result = (Weather) serializer_xsxs_1.Deserialize(ms);
        }

        return result;
    }
}
