using BenchmarkDotNet.Attributes;

using Holisticware.Library.Snippets.XML.Models;


using FormatterXmlSerializer=Core.Data.Formatters.Text.XML.System.Xml.Serialization.XmlSerializer.Formatter;
using FormatterDataContracSerializer=Core.Data.Formatters.Text.XML.System.Runtime.Serialization.DataContractSerializer.Formatter;

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
                                                    <Person id='1'>
                                                        <Name>John Doe</Name>
                                                        <Age>30</Age>
                                                        <City>New York</City>
                                                    </Person>
                                                    """;
                
    [Benchmark]
    public
        string?
                                        Test_01_Serialize_01_System_Xml_Serialization_SerializeNaive
                                        (
                                        )
    {
        return FormatterXmlSerializer.SerializeNaive<Person>(obj_person);
    }
    
    [Benchmark]
    public
        string?
                                        Test_01_Serialize_01_System_Xml_Serialization_SerializeCached
                                        (
                                        )
    {
        return FormatterXmlSerializer.SerializeCached<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_01_Deserialize_02_System_Xml_Serialization_DeserializeNaive
                                        (
                                        )
    {
        return FormatterXmlSerializer.DeserializeNaive<Person>(xml_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_01_Deserialize_01_System_Xml_Serialization_DeserializeCached
                                        (
                                        )
    {
        return FormatterXmlSerializer.DeserializeCached<Person>(xml_person);
    }
    
    [Benchmark]
    public
        string?
                                        Test_02_Serialize_02_System_Runtime_Serialization_SerializeNaive
                                        (
                                        )
    {
        return FormatterDataContracSerializer.SerializeNaive<Person>(obj_person);
    }
    
    [Benchmark]
    public
        string?
                                        Test_02_Serialize_01_System_Runtime_Serialization_SerializeCached
                                        (
                                        )
    {
        return FormatterDataContracSerializer.SerializeCached<Person>(obj_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_02_Deserialize_02_System_Runtime_Serialization_DeserializeNaive
                                        (
                                        )
    {
        return FormatterDataContracSerializer.DeserializeNaive<Person>(xml_person);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_01_Deserialize_02_System_Xml_Serialization_DeserializeCached
                                        (
                                        )
    {
        return FormatterDataContracSerializer.DeserializeCached<Person>(xml_person);
    }
    
}
            