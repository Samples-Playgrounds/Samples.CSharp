using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace Holisticware.Library.Snippets.Regex;

[MemoryDiagnoser]
public partial class
                                        Benchmarks_Regex
{
    private static readonly
        System.Text.RegularExpressions.Regex
                                        rx_static_none 
                                            = new 
                                            (
                                                @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                RegexOptions.None,
                                                matchTimeout: TimeSpan.FromSeconds(1)
                                            );
    
    private static readonly
        System.Text.RegularExpressions.Regex
                                        rx_static_compiled
                                            = new 
                                            (
                                                @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                RegexOptions.Compiled,
                                                matchTimeout: TimeSpan.FromSeconds(1)
                                            );

    private readonly
        System.Text.RegularExpressions.Regex
                                        rx_local_none 
                                        = new 
                                            (
                                                @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                RegexOptions.None,
                                                matchTimeout: TimeSpan.FromSeconds(1)
                                            );
    
    private readonly
        System.Text.RegularExpressions.Regex
                                        rx_local_compiled
                                            = new 
                                            (
                                                @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                RegexOptions.Compiled,
                                                matchTimeout: TimeSpan.FromSeconds(1)
                                            );

    private
        List<string>
                                        data_test_urls 
                                        = new()
                                            {
                                                @"https://github.com/moljac",
                                                @"https://learn.microsoft.com/en-us/training/modules/csharp-null-safety/?source=recommendations",
                                                @"https://www.reddit.com/r/csharp/comments/yrkl90/generatedregex_in_static_class/?rdt=62675",
                                            };

    private static
        List<string>
                                        data_test_urls_static 
                                        = new()
                                            {
                                                @"https://github.com/moljac",
                                                @"https://learn.microsoft.com/en-us/training/modules/csharp-null-safety/?source=recommendations",
                                                @"https://www.reddit.com/r/csharp/comments/yrkl90/generatedregex_in_static_class/?rdt=62675",
                                            };
    
    [Benchmark]
    public
        void
                                        Method_Local_Static_Call_Regex_Match_None
                                        (
                                        )
    {
        System.Text.RegularExpressions.Match m;
        
        m = System.Text.RegularExpressions.Regex.Match
                                                (
                                                    @"https://github.com/moljac",
                                                    @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                    RegexOptions.None,
                                                    matchTimeout: TimeSpan.FromSeconds(1)
                                                );
        return;
    }
    
    [Benchmark]
    public
        void
                                        Method_Local_Static_Call_Regex_Match_Compiled
                                        (
                                        )
    {
        System.Text.RegularExpressions.Match m;
        
        m = System.Text.RegularExpressions.Regex.Match
                                                (
                                                    @"https://github.com/moljac",
                                                    @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                    RegexOptions.Compiled,
                                                    matchTimeout: TimeSpan.FromSeconds(1)
                                                );
        return;
    }

    [Benchmark]
    public
        void
                                        Method_Local_Object_Regex_Match_None
                                        (
                                        )
    {
        System.Text.RegularExpressions.Regex r = new 
                                                (
                                                    @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                    RegexOptions.None,
                                                    matchTimeout: TimeSpan.FromSeconds(1)
                                                );

        System.Text.RegularExpressions.Match m;

        m = r.Match(@"https://github.com/moljac");

        return;
    }

    [Benchmark]
    public
        void
                                        Method_Local_Object_Regex_Match_Compiled
                                        (
                                        )
    {
        System.Text.RegularExpressions.Regex r = new 
                                                (
                                                    @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                                    RegexOptions.Compiled,
                                                    matchTimeout: TimeSpan.FromSeconds(1)
                                                );

        System.Text.RegularExpressions.Match m;

        m = r.Match(@"https://github.com/moljac");

        return;
    }
    
    [Benchmark]
    public
        void
                                        Method_Local_Lazy_Object_Regex_Match_None
                                        (
                                        )
    {
        Lazy<System.Text.RegularExpressions.Regex> lr;
        lr = new Lazy<System.Text.RegularExpressions.Regex>
        (
            () => new System.Text.RegularExpressions.Regex
                    (
                        @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                        RegexOptions.None,
                        matchTimeout: TimeSpan.FromSeconds(1)
                    )
        ); 

        System.Text.RegularExpressions.Match m;

        m = lr.Value.Match(@"https://github.com/moljac");

        return;
    }

    [Benchmark]
    public
        void
                                        Method_Local_Lazy_Object_Regex_Match_Compiled
                                        (
                                        )
    {
        Lazy<System.Text.RegularExpressions.Regex> lr;
        lr = new Lazy<System.Text.RegularExpressions.Regex>
        (
            () => new System.Text.RegularExpressions.Regex
                    (
                        @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                        RegexOptions.Compiled,
                        matchTimeout: TimeSpan.FromSeconds(1)
                    )
        ); 

        System.Text.RegularExpressions.Match m;

        m = lr.Value.Match(@"https://github.com/moljac");

        return;
    }

    [Benchmark]
    public
        void
                                        Class_Member_Object_Regex_Match_None
                                        (
                                        )
    {
        System.Text.RegularExpressions.Match m;

        m = rx_local_none.Match(@"https://github.com/moljac");

        return;
    }

    [Benchmark]
    public
        void
                                        Class_Member_Object_Regex_Match_Compiled
                                        (
                                        )
    {
        System.Text.RegularExpressions.Match m;
            
        m = rx_static_compiled.Match(@"https://github.com/moljac");

        return;
    }

    [Benchmark]
    public
        void
                                        Class_Static_Member_Object_Regex_Match_None
                                        (
                                        )
    {
        System.Text.RegularExpressions.Match m;
            
        m = rx_static_none.Match(@"https://github.com/moljac");

        return;
    }

    [Benchmark]
    public
        void
                                        Class_Static_Member_Object_Regex_Match_Compiled
                                        (
                                        )
    {
        System.Text.RegularExpressions.Match m;
            
        m = rx_local_compiled.Match(@"https://github.com/moljac");

        return;
    }
    
    [Benchmark]
    public
        void
                                        Class_Static_Member_Object_Regex_Match_SourceCodeGenerated_Method
                                        (
                                        )
    {
        System.Text.RegularExpressions.Match m;
        
        m = RegexHelper.RegexURLHelperClassStaticMethodSourceCodeGenerated().Match(@"https://github.com/moljac");

        return;
    }

    internal static partial class RegexHelper
    {
        // .NET 9 allows partial properties
        [
            GeneratedRegex 
                (
                    @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", 
                    RegexOptions.None,
                    // security aspect: preventing malicious input
                    matchTimeoutMilliseconds: 300
                )
        ]
        public static partial 
            System.Text.RegularExpressions.Regex
                                        RegexURLHelperClassStaticMethodSourceCodeGenerated();
        
        /*
         20241118 error
       */
        [
            GeneratedRegex
            (
                @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                RegexOptions.None,
                // security aspect: preventing malicious input
                matchTimeoutMilliseconds: 300
            )
        ]
        public static partial
            System.Text.RegularExpressions.Regex
                                        RegexURLHelperClassStaticPropertySourceCodeGenerated
        {
            get;
        }
        
        public static readonly 
            System.Text.RegularExpressions.Regex
                                        RegexURLHelperClassStaticProperty
                                        =
                                        new 
                                        (
                                            @"^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$",
                                            RegexOptions.Compiled,		
                                            TimeSpan.FromMilliseconds(300)					// against malicious input
                                        );

        
        
    }
    
}
