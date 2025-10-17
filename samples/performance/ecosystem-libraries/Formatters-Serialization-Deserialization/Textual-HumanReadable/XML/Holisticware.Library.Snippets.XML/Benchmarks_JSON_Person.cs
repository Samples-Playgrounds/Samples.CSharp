using BenchmarkDotNet.Attributes;

using Holisticware.Library.Snippets.Models;


using FormatterSystemTextJson=Core.Data.Formatters.Text.JSON.System.Text.Json.Formatter;
using FormatterNewtonsoftJSONNET=Core.Data.Formatters.Text.JSON.Newtonsoft.JSON.NET.Formatter;
using FormatterSpanJSON=Core.Data.Formatters.Text.JSON.SpanJSON.Formatter;
using FormatterNetJSON=Core.Data.Formatters.Text.JSON.NetJSON.Formatter;
using FormatterSerdeNET=Core.Data.Formatters.Text.JSON.Serde.NET.Formatter;
using FormatterUtf8Json=Core.Data.Formatters.Text.JSON.Utf8Json.Formatter;

namespace Holisticware.Library.Snippets.JSON;


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
                                       Benchmarks_JSON_Person
{
    static
                                        Benchmarks_JSON_Person
                                        (
                                        )
    {
        return;
    }
    
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
                                        json_people =
                                                    """
                                                    [
                                                        {"Name":"Jon Doe","Age":30,"City":"New York"},
                                                        {"Name":"Jane Smith","Age":28,"City":"Los Angeles"},
                                                        {"Name":"Bob Wilson","Age":42,"City":"Chicago"}
                                                    ]
                                                    """;

    public static readonly
        string
                                        json_person =
                                                    """
                                                    {"Name":"Jon Doe","Age":30,"City":"New York"}
                                                    """;
                
    [Benchmark]
    public
        string?
                                        Test_01_System_Text_Json_01_Serialize
                                        (
                                        )
    {
        return FormatterSystemTextJson.Serialize(obj_person);
    }
    

    [Benchmark]
    public
        Person?
                                        Test_01_System_Text_Json_02_Deserialize
                                        (
                                        )
    {
        return FormatterSystemTextJson.Deserialize<Person>(json_person);
    }

    
    
    
    [Benchmark]
    public
        string?
                                        Test_02_Newtonsoft_JSON_NET_01_Serialize
                                        (
                                        )
    {
        return FormatterNewtonsoftJSONNET.Serialize(obj_person);
    }
    

    [Benchmark]
    public
        string?
                                        Test_02_Newtonsoft_JSON_NET_01_Serialize_People
                                        (
                                        )
    {
        return FormatterNewtonsoftJSONNET.Serialize(obj_people);
    }
    
    [Benchmark]
    public
        Person?
                                        Test_02_Newtonsoft_JSON_NET_02_Deserialize
                                        (
                                        )
    {
        return FormatterNewtonsoftJSONNET.Deserialize<Person>(json_person);
    }
    
    
    [Benchmark]
    public
        string?
                                        Test_03_SpanJSON_01_Serialize
                                        (
                                        )
    {
        return FormatterSpanJSON.Serialize(obj_person);
    }
    

    [Benchmark]
    public
        Person?
                                        Test_03_SpanJSON_02_Deserialize
                                        (
                                        )
    {
        return FormatterSpanJSON.Deserialize<Person>(json_person);
    }
    
    
    [Benchmark]
    public
        string?
                                        Test_04_NetJSON_01_Serialize
                                        (
                                        )
    {
        return FormatterNetJSON.Serialize(obj_person);
    }
    

    [Benchmark]
    public
        Person?
                                        Test_04_NetJSON_02_Deserialize
                                        (
                                        )
    {
        return FormatterNetJSON.Deserialize<Person>(json_person);
    }
    
    
    /*
    [Benchmark]
    public
        string?
                                        Test_05_SerdeNET_01_Serialize
                                        (
                                        )
    {
        return FormatterSerdeNET.Serialize(obj_person);
    }

    [Benchmark]
    public
        Person?
                                        Test_05_SerdeNET_02_Deserialize
                                        (
                                        )
    {
        return FormatterSerdeNET.Deserialize<Person>(json_person);
    }
    */
     
    
    [Benchmark]
    public
        string?
                                        Test_06_Utf8Json_01_Serialize
                                        (
                                        )
    {
        return FormatterUtf8Json.Serialize(obj_person);
    }
    

    [Benchmark]
    public
        Person?
                                        Test_06_Utf8Json_02_Deserialize
                                        (
                                        )
    {
        return FormatterUtf8Json.Deserialize<Person>(json_person);
    }
   
}
            