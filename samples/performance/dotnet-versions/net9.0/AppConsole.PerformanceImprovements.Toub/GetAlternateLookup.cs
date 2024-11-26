using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AppConsole.PerformanceImprovements.Toub;

public partial class 
                                        GetAlternateLookup
{
    static string text = 
            // File.ReadAllText("./leo-tolstoy--war-and-peace.txt")
            File.ReadAllText("./pride-n-prejudice.txt")
        ;
    // Frequencies of word occurences
    static Dictionary<string, int> word_counts = [];
    static Dictionary<string, int>.AlternateLookup<ReadOnlySpan<char>> lookup  = word_counts.GetAlternateLookup<ReadOnlySpan<char>>();

    static Stopwatch sw = new();


    /*
    Time: 0,043 s      Allocated Bytes: 4,760711669921875 MB
    Time: 0,040 s      Allocated Bytes: 4,1959991455078125 MB
    Time: 0,039 s      Allocated Bytes: 4,200767517089844 MB
    Time: 0,039 s      Allocated Bytes: 4,199554443359375 MB
    Time: 0,039 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,040 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,053 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,048 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,037 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,044 s      Allocated Bytes: 4,199211120605469 MB   
    */
    public static
        void 
                                        CollectData_net90_EnumerateMatches_GetAlternateLookup
                                        (
                                        )
    {
        for (int trial = 0; trial < 10; trial++)
        {
            long mem = GC.GetTotalAllocatedBytes();
            sw.Restart();

            foreach (ValueMatch value_match in RegexHelper.Words.EnumerateMatches(text))
            {
                string word = text.Substring(value_match.Index, value_match.Length);
                if (/*word_counts*/lookup.ContainsKey(word))
                {
                    word_counts[word]++;
                }
                else
                {
                    word_counts.Add(word, 1);
                }
            }
            sw.Stop();
            mem = GC.GetTotalAllocatedBytes() - mem;
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000.0} s      Allocated Bytes: { mem / 1024.0 / 1024.0 } MB");
            
            GC.Collect();
        }
    }

    /*
    Time: 0,050 s      Allocated Bytes: 4,762016296386719 MB
    Time: 0,039 s      Allocated Bytes: 4,20391845703125 MB
    Time: 0,044 s      Allocated Bytes: 4,201820373535156 MB
    Time: 0,039 s      Allocated Bytes: 4,199592590332031 MB
    Time: 0,039 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,051 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,048 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,040 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,035 s      Allocated Bytes: 4,199211120605469 MB
    Time: 0,035 s      Allocated Bytes: 4,199211120605469 MB
    */
    public static
        void 
                                        CollectData_net70_EnumerateMatches
                                        (
                                        )
    {
        for (int trial = 0; trial < 10; trial++)
        {
            long mem = GC.GetTotalAllocatedBytes();
            sw.Restart();

            foreach (ValueMatch value_match in RegexHelper.Words.EnumerateMatches(text))
            {
                string word = text.Substring(value_match.Index, value_match.Length);
                if (word_counts.ContainsKey(word))
                {
                    word_counts[word]++;
                }
                else
                {
                    word_counts.Add(word, 1);
                }
            }
            sw.Stop();
            mem = GC.GetTotalAllocatedBytes() - mem;
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000.0} s      Allocated Bytes: { mem / 1024.0 / 1024.0 } MB");
            
            GC.Collect();
        }
    }

    /*
    Time: 0,087 s      Allocated Bytes: 32,306739807128906 MB
    Time: 0,064 s      Allocated Bytes: 31,745521545410156 MB
    Time: 0,061 s      Allocated Bytes: 31,74292755126953 MB
    Time: 0,069 s      Allocated Bytes: 31,743377685546875 MB
    Time: 0,075 s      Allocated Bytes: 31,743576049804688 MB
    Time: 0,070 s      Allocated Bytes: 31,744522094726562 MB
    Time: 0,063 s      Allocated Bytes: 31,743255615234375 MB
    Time: 0,054 s      Allocated Bytes: 31,743865966796875 MB
    Time: 0,053 s      Allocated Bytes: 31,74347686767578 MB
    Time: 0,052 s      Allocated Bytes: 31,74388885498047 MB

    */
    public static
        void 
                                        CollectData_Naive
                                        (
                                        )
    {
        for (int trial = 0; trial < 10; trial++)
        {
            long mem = GC.GetTotalAllocatedBytes();
            sw.Restart();

            foreach (Match match in RegexHelper.Words.Matches(text))
            {
                string word = match.Value;
                if (word_counts.ContainsKey(word))
                {
                    word_counts[word]++;
                }
                else
                {
                    word_counts.Add(word, 1);
                }
            }
            sw.Stop();
            mem = GC.GetTotalAllocatedBytes() - mem;
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000.0} s      Allocated Bytes: { mem / 1024.0 / 1024.0 } MB");
            
            GC.Collect();
        }
    }
    
    internal static partial class 
                                        RegexHelper
    {
        // .NET 9 allows partial properties
        [
            GeneratedRegex
            (
                @"\b\w+\b",
                RegexOptions.None,
                matchTimeoutMilliseconds: 1000 // security to prevent malicious input
            )
        ]
        public static partial 
            Regex 
                                        Words
        {
            get;
        }
    }
}