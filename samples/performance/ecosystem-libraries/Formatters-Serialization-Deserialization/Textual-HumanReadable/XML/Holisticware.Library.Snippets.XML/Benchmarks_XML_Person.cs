using BenchmarkDotNet.Attributes;

using Holisticware.Library.Snippets.Models;


using FormatterXmlSerializer=Core.Data.Formatters.Text.XML.System.Xml.Serialization.XmlSerializer.Formatter;
using FormatterDataContracSerializer=Core.Data.Formatters.Text.XML.System.Runtime.Serialization.DataContractSerializer.Formatter;
using FormatterNetBike=Core.Data.Formatters.Text.XML.NetBike.Formatter;
using FormatterYAXLib=Core.Data.Formatters.Text.XML.YAXLib.Formatter;
using FormatterServiceStackText=Core.Data.Formatters.Text.XML.ServiceStack.Text.Formatter;
using FormatterExtendedXmlSerializer=Core.Data.Formatters.Text.XML.ExtendedXmlSerializer.Formatter;

namespace Holisticware.Library.Snippets.XML;


[RankColumn(BenchmarkDotNet.Mathematics.NumeralSystem.Arabic)]
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
                                       Benchmarks_XML_Person
{
    static
                                        Benchmarks_XML_Person
                                        (
                                        )
    {
        FormatterXmlSerializer.Cache.Add
                                        (
                                            typeof(Person),
                                            new global::System.Xml.Serialization.XmlSerializer(typeof(Person))
                                        );       

        FormatterDataContracSerializer.Cache.Add
                                        (
                                            typeof(Person),
                                            new global::System.Runtime.Serialization.DataContractSerializer
                                                                                            (
                                                                                                typeof(Person),
                                                                                                "Person",
                                                                                                ""
                                                                                            )
                                        ); 
        return;
    }
    
    private static readonly
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager = new ();
    
    public static readonly
        Person
                                        obj_person = new ()
                                                    {
                                                        Name = "Jon Doe",
                                                        Age = 30,
                                                        City = "New York"
                                                    };

    public static readonly
        People
                                        obj_people = new ()
                                                    {
                                                        new Person()
                                                        {
                                                            Name = "Jon Doe",
                                                            Age = 30,
                                                            City = "New York"
                                                        },
                                                        new Person()
                                                        {
                                                            Name = "Jane Smith",
                                                            Age = 28,
                                                            City = "Los Angeles"
                                                        },
                                                        new Person()
                                                        {
                                                            Name = "Bob Wilson",
                                                            Age = 42,
                                                            City = "Chicago"
                                                        },
                                                    };

    public static readonly
        string
                                        xml_people =
                                                    """
                                                    <?xml version='1.0'?>
                                                    <People>
                                                        <Person id='1'>
                                                            <Name>John Doe</Name>
                                                            <Age>30</Age>
                                                            <City>New York</City>
                                                        </Person>
                                                        <Person id='2'>
                                                            <Name>Jane Smith</Name>
                                                            <Age>28</Age>
                                                            <City>Los Angeles</City>
                                                        </Person>
                                                        <Person id='3'>
                                                            <Name>Bob Wilson</Name>
                                                            <Age>42</Age>
                                                            <City>Chicago</City>
                                                        </Person>
                                                    </People>
                                                    """;

    public static readonly
        string
                                        xml_person =
                                                    """
                                                    <Person>
                                                        <Name>John Doe</Name>
                                                        <Age>30</Age>
                                                        <City>New York</City>
                                                    </Person>
                                                    """;
                
    [Benchmark]
    public
        string?
                                        Test_01_System_Xml_Serialization_XmlSerializer_01_SerializeNaive
                                        (
                                        )
    {
        return FormatterXmlSerializer.SerializeNaive<Person>(obj_person);
    }
    
    [Benchmark]
    public
        string?
                                        Test_01_System_Xml_Serialization_XmlSerializer_01_SerializeCached
                                        (
                                        )
    {
        return FormatterXmlSerializer.SerializeCached<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_01_System_Xml_Serialization_XmlSerializer_02_DeserializeNaive
                                        (
                                        )
    {
        return FormatterXmlSerializer.DeserializeNaive<Person>(xml_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_01_System_Xml_Serialization_XmlSerializer_02_DeserializeCached
                                        (
                                        )
    {
        return FormatterXmlSerializer.DeserializeCached<Person>(xml_person);
    }
    
    [Benchmark]
    public
        string?
                                        Test_02_System_Runtime_Serialization_DataContractSerializer_01_SerializeNaive
                                        (
                                        )
    {
        return FormatterDataContracSerializer.SerializeNaive<Person>(obj_person);
    }
    
    [Benchmark]
    public
        string?
                                        Test_02_System_Runtime_Serialization_DataContractSerializer_01_SerializeCached
                                        (
                                        )
    {
        return FormatterDataContracSerializer.SerializeCached<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_02_System_Runtime_Serialization_DataContractSerializer_02_DeserializeNaive
                                        (
                                        )
    {
        return FormatterDataContracSerializer.DeserializeNaive<Person>(xml_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_02_System_Runtime_Serialization_DataContractSerializer_02_DeserializeCached
                                        (
                                        )
    {
        return FormatterDataContracSerializer.DeserializeCached<Person>(xml_person);
    }
    
    
    
    
    [Benchmark]
    public
        string?
                                        Test_03_NetBike_01_SerializeNaive
                                        (
                                        )
    {
        return FormatterNetBike.SerializeNaive<Person>(obj_person);
    }
    
    [Benchmark]
    public
        string?
                                        Test_03_NetBike_01_SerializeCached
                                        (
                                        )
    {
        return FormatterNetBike.SerializeCached<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_03_NetBike_02_DeserializeNaive
                                        (
                                        )
    {
        return FormatterNetBike.DeserializeNaive<Person>(xml_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_03_NetBike_02_DeserializeCached
                                        (
                                        )
    {
        return FormatterNetBike.DeserializeCached<Person>(xml_person);
    }
    
    
    
    
    [Benchmark]
    public
        string?
                                        Test_03_YAXLib_01_Serialize
                                        (
                                        )
    {
        return FormatterYAXLib.Serialize<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_03_YAXLib_02_Deserialize
                                        (
                                        )
    {
        return FormatterYAXLib.Deserialize<Person>(xml_person);
    }
    
    
    
    
    [Benchmark]
    public
        string?
                                        Test_04_ServiceStackText_01_SerializeNaive
                                        (
                                        )
    {
        return FormatterServiceStackText.SerializeNaive<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_04_ServiceStackText_02_DeserializeNaive
                                        (
                                        )
    {
        return FormatterServiceStackText.DeserializeNaive<Person>(xml_person);
    }
    
    
    
    
    
    
    [Benchmark]
    public
        string?
                                        Test_05_ExtendedXmlSerializer_01_SerializeNaive
                                        (
                                        )
    {
        return FormatterExtendedXmlSerializer.SerializeNaive<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_05_ExtendedXmlSerializer_01_DeserializeNaiveMemoryStream
                                        (
                                        )
    {
        return FormatterExtendedXmlSerializer.DeserializeNaiveMemoryStream<Person>(xml_person);
    }
    
}
            