using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;

namespace Holisticware.Library.Snippets.CollectionInitializersExpressions;

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
                                        Benchmarks_CollectionInitializersExpressions
{
    int zero = 0;
    int one = 1;
    int two = 2;
    int three = 3;
    int four = 4;
    int five = 5;
    int six = 6;
    int seven = 7;
    int eight = 8;
    int nine = 9;
    
    string hydrogen = "H";
    string helium = "He";
    string lithium = "Li";
    string beryllium = "Be";
    string boron = "B";
    string carbon = "C";
    string nitrogen = "N";
    string oxygen = "O";
    string fluorine = "F";
    string neon = "Ne";

    private int[] numbers;
    private string[] elements;
    
    [Benchmark]
    public
        int[]
                                        array_of_ints_using_collection_expression_elements_as_variables
                                        (
                                        )
    {
        numbers = 
                    [
                        zero,
                        one,
                        two,
                        three,
                        four,
                        five,
                        six,
                        seven,
                        eight,
                        nine
                    ];

        return numbers;
    }
    
    [Benchmark]
    public
        int[]
                                        array_of_ints_using_collection_initializer_elements_as_variables
                                        (
                                        )
    {
        numbers = 
                    new int[]
                    {
                        zero,
                        one,
                        two,
                        three,
                        four,
                        five,
                        six,
                        seven,
                        eight,
                        nine
                    };

        return numbers;
    }
    
    [Benchmark]
    public
        int[]
                                        array_of_ints_using_collection_expression_elements_as_literals
                                        (
                                        )
    {
        numbers = 
                    [
                        0,
                        1,
                        2,
                        3,
                        4,
                        5,
                        6,
                        7,
                        8,
                        9
                    ];

        return numbers;
    }
    
    [Benchmark]
    public
        int[]
                                        array_of_ints_using_collection_initializer_elements_as_literals
                                        (
                                        )
    {
        numbers = 
                    new int[]
                    {
                        0,
                        1,
                        2,
                        3,
                        4,
                        5,
                        6,
                        7,
                        8,
                        9
                    };

        return numbers;
    }
    
    [Benchmark]
    public
        string[]
                                        array_of_strings_using_collection_expression_elements_as_variables
                                        (
                                        )
    {
        elements = 
                    [
                        hydrogen, 
                        helium, 
                        lithium, 
                        beryllium, 
                        boron, 
                        carbon, 
                        nitrogen, 
                        oxygen, 
                        fluorine, 
                        neon
                    ];

        return elements;
    }
    
    [Benchmark]
    public
        string[]
                                        array_of_strings_using_collection_initializer_elements_as_variables
                                        (
                                        )
    {
        elements = 
                    new string[]
                    {
                        hydrogen, 
                        helium, 
                        lithium, 
                        beryllium, 
                        boron, 
                        carbon, 
                        nitrogen, 
                        oxygen, 
                        fluorine, 
                        neon
                    };

        return elements;
    }
    
    [Benchmark]
    public
        string[]
                                        array_of_strings_using_collection_expression_elements_as_literals
                                        (
                                        )
    {
        elements = 
                    [
                        "H", 
                        "He", 
                        "Li", 
                        "Be", 
                        "B", 
                        "C", 
                        "N", 
                        "O", 
                        "F", 
                        "Ne"
                    ];

        return elements;
    }
    
    [Benchmark]
    public
        string[]
                                        array_of_strings_using_collection_initializer_elements_as_literals
                                        (
                                        )
    {
        elements = 
                    new string[]
                    {
                        "H", 
                        "He", 
                        "Li", 
                        "Be", 
                        "B", 
                        "C", 
                        "N", 
                        "O", 
                        "F", 
                        "Ne"
                    };

        return elements;
    }
    
    int[] array_ints_empty;
    IEnumerable<int> enumerable_ints_empty;
    
    [Benchmark]
    public
        int[]
                                        Array_ints_empty_using_collection_expression
                                        (
                                        )
    {
        array_ints_empty = 
                            [
                            ];
        
        return array_ints_empty;
    }

    [Benchmark]
    public
        int[]
                                        Array_ints_empty_using_collection_initializer
        (
        )
    {
        array_ints_empty = new int[]
                                {
                                } ;

        return array_ints_empty;
    }

    [Benchmark]
    public
        int[]
                                        Array_ints_empty_using_Array_Empty
        (
        )
    {
        array_ints_empty = Array.Empty<int>();

        return array_ints_empty;
    }
    
    [Benchmark]
    public
        int[]
                                        Array_ints_empty_using_Enumerable_Empty
        (
        )
    {
        enumerable_ints_empty = Enumerable.Empty<int>();

        return enumerable_ints_empty.ToArray();
    }
    
    // https://sharplab.io/#v2:C4LghgzsA0AmIGoA+ABATARgLACgUGYACdQgYUIG9dCbiiUAWQgWQAoBKQ62qnW/wgEsAdsADaAXSGiIAfQwBubgOnipI4HLRKcygQGMAFmABOkwkdNzFe/pbNT7WnSpq3aKDAAZznr9ZdXP19vZ1x3Gg1rQgBeQjFCDGhCNGT8ZIlAlSjZNFjCYQBTAHdzCkTk1MJ0wgBfHQiLYxNouISAckJ25O7uroU+zManXPyi0qlyzr7enoHk+sbGv1b4wgAiDeT16B2NhT2hviDQ0bjxso2trb31g4WsgUaNQjB8m2OVP0IIfIASdZgIFvChgWp3JafOq4WpAA===    

    int[] ints_11;
    int[] ints_12;

    char[] chars_11;
    char[] chars_12;
        
    string[] strings_11;
    string[] strings_12;
    
    [Benchmark]
    public
        void
                                        array_ints_1
                                        (
                                        )
    {
        ints_11 = [ 1, 2, 3, ];

        return;
    }

    [Benchmark]
    public
        void
                                        array_ints_2
                                        (
                                        )
    {
        ints_12 = new[] { 1, 2, 3, };

        return;
    }

    [Benchmark]
    public
        void
                                        array_chars_1
                                        (
                                        )
    {
        chars_11 = [ ' ', ',', ';', ];

        return;
    }
    
    [Benchmark]
    public
        void
                                        array_chars_2
                                        (
                                        )
    {
        chars_12 = new[] { ' ', ',', ';', };

        return;
    }
    
    [Benchmark]
    public
        void
                                        array_strings_1
                                        (
                                        )
    {
        strings_11 = [ " ", ",", ";", ];

        return;
    }
    
    [Benchmark]
    public
        void
                                        array_strings_2
                                        (
                                        )
    {
        strings_12 = new[] { " ", ",", ";", };

        return;
    }
    
    List<int> ints_21;
    List<int> ints_22;

    List<char> chars_21;
    List<char> chars_22;
        
    List<string> strings_21;
    List<string> strings_22;


    [Benchmark]
    public
        void
                                        list_ints_1_collection_expression
                                        (
                                        )
    {
        ints_21 = [ 1, 2, 3, ];

        return;
    }

    [Benchmark]
    public
        void
                                        list_ints_2_collection_initializer
                                        (
                                        )
    {
        ints_22 = new List<int>{ 1, 2, 3, };

        return;
    }

    [Benchmark]
    public
        void
                                        list_chars_1_collection_expression
                                        (
                                        )
    {
        chars_21 = [ ' ', ',', ';', ];

        return;
    }
    
    [Benchmark]
    public
        void
                                        list_chars_2_collection_initializer
                                        (
                                        )
    {
        chars_22 = new List<char> { ' ', ',', ';', };

        return;
    }
    
    [Benchmark]
    public
        void
                                        list_strings_1_collection_expression
                                        (
                                        )
    {
        strings_21 = [ " ", ",", ";", ];

        return;
    }
    
    [Benchmark]
    public
        void
                                        list_strings_2_collection_initializer
                                        (
                                        )
    {
        strings_22 = new List<string> { " ", ",", ";", };

        return;
    }
    
}
