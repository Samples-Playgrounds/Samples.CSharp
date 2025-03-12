using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;

namespace Holisticware.Library.Snippets.ControlStructures.RangeMatching;

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
                                        Benchmarks_ControlStructures_RangeMatching
{
    [Benchmark]
    [Arguments(1100)]
    [Arguments(1000)]
    [Arguments(940)]
    [Arguments(900)]
    [Arguments(870)]
    [Arguments(800)]
    [Arguments(470)]
    [Arguments(-100)]
    public
        double
                                        range_of_ints_to_double_with_if
                                        (
                                            int price
                                        )
    {
        double percent;

        if ( 1000 <= price)
        {
            percent = 10.0;
        }
        else if (price >= 900 && price < 1000)
        {
            percent = 9.0;
        }
        else if (price >= 800 && price < 900)
        {
            percent = 8.0;
        }
        else
        {
            percent = 0.0;
        }
        
        return percent;
    }
    
    [Benchmark]
    [Arguments(1100)]
    [Arguments(1000)]
    [Arguments(940)]
    [Arguments(900)]
    [Arguments(870)]
    [Arguments(800)]
    [Arguments(470)]
    [Arguments(-100)]
    public
        double
                                        range_of_ints_to_double_with_ternary_operators
                                        (
                                            int price
                                        )   
    {
        double percent = 0.0;

        switch
            ( 
                price >= 1000                ? "Range 1" :
                price >= 900 && price < 1000 ? "Range 2" :
                price >= 800 && price < 900  ? "Range 3" :
                price > 1 ? "Range 3" : 
                "Range default"
            )
        {
            case "Range 1":
                percent = 10.0;
                break;
            case "Range 2":
                percent = 9.0;
                break;
            case "Range 3":
                percent = 8.0;
                break;
            case "Range default":
                percent = 0.0;
                break;
        }
        
        return percent;
    }
    
    [Benchmark]
    [Arguments(1100)]
    [Arguments(1000)]
    [Arguments(940)]
    [Arguments(900)]
    [Arguments(870)]
    [Arguments(800)]
    [Arguments(470)]
    [Arguments(-100)]
    public
        double
                                        range_of_ints_to_double_with_switch_csharp_7
                                        (
                                            int price
                                        )
    {
        double percent = 0.0;
        
        switch(price)
        {
            case int n when ( n >= 1000 ):
                percent = 10.0;
                break;
            case int n when ( 900 <= n && n < 1000 ):
                percent = 9.0;
                break;
            case int n when ( 800 <= n && n < 900 ):
                percent = 8.0;
                break;
            default:
                percent = 0.0;
                break;
        };
        
        return percent;
    }

    [Benchmark]
    [Arguments(1100)]
    [Arguments(1000)]
    [Arguments(940)]
    [Arguments(900)]
    [Arguments(870)]
    [Arguments(800)]
    [Arguments(470)]
    [Arguments(-100)]
    public
        double
                                        range_of_ints_to_double_with_switch_csharp_8
                                        (
                                            int price
                                        )
    {
        double percent = price switch
        {
            int n when n >= 1000            => 10.0,
            int n when n >= 900 && n < 1000 => 9.0,
            int n when n >= 800 && n < 900  => 8.0,
            // default value
            _ => 0.0 
        };
        
        return percent;
    }

    [Benchmark]
    [Arguments(1100)]
    [Arguments(1000)]
    [Arguments(940)]
    [Arguments(900)]
    [Arguments(870)]
    [Arguments(800)]
    [Arguments(470)]
    [Arguments(-100)]
    public
        double
                                        range_of_ints_to_double_with_switch_csharp_9
                                        (
                                            int price
                                        )
    {
        double percent = price switch
        {
            >= 1000           => 10.0,
            >= 900 and < 1000 => 9.0,
            >= 800 and < 900  => 8.0,
            // default value
            _ => 0f
        };
        
        return percent;
    }
    
    [Benchmark]
    [Arguments(1100)]
    [Arguments(1000)]
    [Arguments(940)]
    [Arguments(900)]
    [Arguments(870)]
    [Arguments(800)]
    [Arguments(470)]
    [Arguments(-100)]
    public
        double
                                        range_of_ints_to_double_with_dictionary
                                        (
                                            int price
                                        )
    {
        double percent = 0.0;
        
        Dictionary<Func<int, bool>, Action> switch_as_directory = new()
        {
            { 
                price => price >= 1000,
                () => percent = 10.0
            },
            { 
                price => price >= 900 && price < 1000,
                () => percent = 9.0
            },
            { 
                price => price >= 800 && price < 900,
                () => percent = 8.0
            },
            // default value difficult to model
            { 
                price => price < 800 || 1000 < price,
                () => percent = 0.0
            },
        };
        
        return percent;
    }
    
}
