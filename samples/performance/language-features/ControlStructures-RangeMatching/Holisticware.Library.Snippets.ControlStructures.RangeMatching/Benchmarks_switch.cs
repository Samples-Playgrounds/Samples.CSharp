using System.Collections;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;
using TestModels;

namespace Holisticware.Library.Snippets.ControlStructures.Switching;

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
                                        Benchmarks_ControlStructures_Switch
{
    [Benchmark]
    public
        int
                                        case_01
                                        (
                                            int number
                                        )
    {
        /*
        number switch
        {
            { Is1: true } => 1,
            { Is2: true } => 2,
            { Is3: true } => 3,
            _ => 4
        };
        */

        return number;
    }
    
    [Benchmark]
    public
        int
                                        case_02
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_01
                                        (
                                            int number
                                        )
    {
        // 1. Basic Switch Statement (C# 7.0+)
        switch (number)
        {
            case 1:
                // code
                break;
            case 2:
                // code
                break;
            default:
                // code
                break;
        }
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_02
                                        (
                                            int number
                                        )
    {
        // 2. Switch Expression (C# 8.0+)
        string result = number switch
        {
            1 => "1",
            2 => "2",
            _ => "default"
        };
        
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_03
                                        (
                                            int number
                                        )
    {
        // 3. Switch Statement with Range Patterns (C# 8.0+)
        switch (number)
        {
            case >= 0 and <= 10:
                Console.WriteLine("Between 0 and 10");
                break;
            case > 10:
                Console.WriteLine("Greater than 10");
                break;
            default:
                Console.WriteLine("Negative or zero");
                break;
        }
        
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_04
                                        (
                                            int number
                                        )
    {
        object obj = number;

        // 4. Switch Statement with Pattern Matching
        switch (obj)
        {
            case int i when i > 0:
                Console.WriteLine($"Positive integer: {i}");
                break;
            case string s when s.Length > 5:
                Console.WriteLine($"Long string: {s}");
                break;
            case null:
                Console.WriteLine("Null value");
                break;
            case var x when x.GetType().Name == "MyType":
                Console.WriteLine("Custom type");
                break;
            default:
                Console.WriteLine("Other");
                break;
        }
        
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_05
                                        (
                                            int number
                                        )
    {
        object obj = number;
        
        // 5. Switch Statement with Type Patterns
        switch (obj)
        {
            case int:
                Console.WriteLine("Integer");
                break;
            case string s when s.Length > 0:
                Console.WriteLine($"String: {s}");
                break;
            case List<string> list when list.Count > 0:
                Console.WriteLine("Non-empty string list");
                break;
            case IEnumerable enumerable when enumerable.Cast<object>().Any():
                Console.WriteLine("Non-empty collection");
                break;
            default:
                Console.WriteLine("Unknown type");
                break;
        }
        
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_06
                                        (
                                            int number
                                        )
    {
        (int, int) t;
        int x = number;
        int y = 0;
        
        // 6. Switch Statement with Tuple Patterns (C# 8.0+)
        switch ((x, y))
        {
            case (0, 0):
                Console.WriteLine("Origin");
                break;
            case (_, 0) when x > 0:
                Console.WriteLine("Positive X-axis");
                break;
            case (0, _) when y > 0:
                Console.WriteLine("Positive Y-axis");
                break;
            case (_, _) when x > 0 && y > 0:
                Console.WriteLine("First quadrant");
                break;
            default:
                Console.WriteLine("Other position");
                break;
        }
        
        return number;
    }
    
    static
        int 
                                        Point
                                        (
                                            int x,
                                            int y
                                        )
    {
        return x + y;
    }
    
    [Benchmark]
    public
        int
                                        switch_07
                                        (
                                            Point point
                                        )
    {
        // 7. Switch Statement with Positional Patterns (C# 8.0+)
        switch (point)
        {
            case Point(0, 0):
                Console.WriteLine("Origin");
                break;
            case Point(var x, 0) when x > 0:
                Console.WriteLine("Positive X-axis");
                break;
            case Point(0, var y) when y > 0:
                Console.WriteLine("Positive Y-axis");
                break;
            default:
                Console.WriteLine("Other point");
                break;
        }
        
        return point.X;
    }
    

    
    [Benchmark]
    public
        int
                                        switch_11
                                        (
                                            Integer number
                                        )
    {
        if ( number.Is1 == true )
        {
            return 1;
        }
        else if ( number.Is2 == true )
        {
            return 2;
        }
        else if ( number.Is3 == true )
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
    
    [Benchmark]
    public
        int
                                        switch_12
                                        (
                                            Integer number
                                        )
    {
        if(number.Is1) return 1;
        if(number.Is2) return 2;
        if(number.Is3) return 3;
        return 4;
    }
    
    [Benchmark]
    public
        int
                                        switch_13
                                        (
                                            Integer number
                                        )
    {
        // is this condition true ? yes : no
        return 
            number.Is1 ? 1 :
            number.Is2 ? 2 :
            number.Is3 ? 3 :
            4;
    }
    
    [Benchmark]
    public
        int
                                        switch_14
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_15
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_16
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_17
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_18
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_19
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
    [Benchmark]
    public
        int
                                        switch_20
                                        (
                                            int number
                                        )
    {
        return number;
    }
    
}
/*
*/
