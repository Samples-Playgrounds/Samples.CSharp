namespace Basics04.Strings;

public partial class
                                        Strings
{
    [BenchmarkDotNet.Attributes.Benchmark]
    public
    int
                                    IndexOf_String_API
                                    (
                                    )
    {
        Console.WriteLine($"idx = {test_01.IndexOf("_")}");

        return test_01.IndexOf("_");
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
    int
                                    IndexOf_With_Pattern_Matching
                                    (
                                    )
    {
        if (test_01.IndexOf("_") is int idx && idx > 0)
        {
            Console.WriteLine($"idx = {idx}");
            return idx;
        }

        return -1;
    }

}
