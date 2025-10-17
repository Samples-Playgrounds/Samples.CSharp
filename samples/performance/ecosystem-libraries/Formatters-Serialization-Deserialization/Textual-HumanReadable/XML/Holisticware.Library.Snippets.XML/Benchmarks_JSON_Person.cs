using BenchmarkDotNet.Attributes;

using Holisticware.Library.Snippets.Models;


using FormatterSystemTextJson=Core.Data.Formatters.Text.JSON.System.Text.Json.Formatter;
using FormatterNewtonsoftJSONNET=Core.Data.Formatters.Text.JSON.Newtonsoft.JSON.NET.Formatter;
using FormatterSpanJSON=Core.Data.Formatters.Text.JSON.SpanJSON.Formatter;
using FormatterNetJSON=Core.Data.Formatters.Text.JSON.NetJSON.Formatter;
using FormatterSerdeNET=Core.Data.Formatters.Text.JSON.Serde.NET.Formatter;

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
                                                    
                                                    """;

    public static readonly
        string
                                        json_person =
                                                    """
                                                    
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
    
    /*
    [Benchmark]
    public
        Person?
                                        Test_01_System_Text_Json_01_Deserialize
                                        (
                                        )
    {
        return FormatterSystemTextJson.Deserialize<Person>(json_person);
    }
    */
}
            