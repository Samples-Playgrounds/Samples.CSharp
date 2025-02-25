using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace Holisticware.Library.Snippets.Regex;

[MemoryDiagnoser]
public partial class
                                        Benchmarks_Nullable_NullChecks
{
    [Benchmark]
    [Arguments("files/email50.csv")]
    [Arguments("")]
    [Arguments(null)]
    [Arguments(default(string))]
    public
        void
                                        Null_Check_string_is_null
                                        (
                                            string file
                                        )
    {
        if (file is null)
        {
        }
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/email50.csv")]
    [Arguments("")]
    [Arguments(null)]
    [Arguments(default(string))]
    public
        void
                                        Null_Check_string_operator_equivalence
                                        (
                                            string file
                                        )
    {
        if (file == null)
        {
        }
        
        return;
    }
    
    [Benchmark]
    [Arguments("files/email50.csv")]
    [Arguments("")]
    [Arguments(null)]
    [Arguments(default(System.IO.MemoryStream))]
    public
        void
                                        Null_Check_string_operator_equivalence
                                        (
                                            object file
                                        )
    {
        if (file == null)
        {
        }
        
        return;
    }
    
}
