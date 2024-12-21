using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AppConsole.PerformanceImprovements.Toub;

public partial class 
                                        SearchValues_of_String
{
    static string text = 
            // File.ReadAllText("./leo-tolstoy--war-and-peace.txt")
            File.ReadAllText("./pride-n-prejudice.txt")
        ;

    private string[] days_of_week = [ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" ];
    
    // Frequencies of word occurences
    static Dictionary<string, int> word_counts = [];
    static Dictionary<string, int>.AlternateLookup<ReadOnlySpan<char>> lookup  = word_counts.GetAlternateLookup<ReadOnlySpan<char>>();

    static Stopwatch sw = new();
    
    /*
    */
    public static
        void
                                        CollectData_net90_Search_Mutiple
                                        (
                                        )
    {
        for (int trial = 0; trial < 10; trial++)
        {
            int count_days_of_week = 0;
            
            long mem = GC.GetTotalAllocatedBytes();
            sw.Restart();
            
            for (int i = 0; i < text.Length; i++)
            {
                foreach (string dow in days_of_week)
                {
                    if (text.AsSpan().StartsWith(dow))
                    {
                        count_days_of_week++;
                        break;
                    }
                }
            }
            sw.Stop();
            mem = GC.GetTotalAllocatedBytes() - mem;
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000.0} s      Allocated Bytes: { mem / 1024.0 / 1024.0 } MB");
            
            GC.Collect();
        }
        
        return;
    }

    /*
    */
    public static
        void 
                                        CollectData_net90_EnumerateSplits_GetAlternateLookup
                                        (
                                        )
    {
        for (int trial = 0; trial < 10; trial++)
        {
            long mem = GC.GetTotalAllocatedBytes();
            sw.Restart();
            
            foreach (Range range in RegexHelper.Whitespace.EnumerateSplits(text))
            {
                ReadOnlySpan<char> word2 = text.AsSpan(range);
                if (/*word_counts*/lookup.ContainsKey(word2))
                {
                    /*word_counts*/lookup[word2]++;
                }
                else
                {
                    /*word_counts*/lookup[word2] = 1;
                }
            }
            sw.Stop();
            mem = GC.GetTotalAllocatedBytes() - mem;
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000.0} s      Allocated Bytes: { mem / 1024.0 / 1024.0 } MB");
            
            GC.Collect();
        }
    }

    /*
    */
    public static
        void 
                                        CollectData_net70_EnumerateSplits
                                        (
                                        )
    {
        for (int trial = 0; trial < 10; trial++)
        {
            long mem = GC.GetTotalAllocatedBytes();
            sw.Restart();
            foreach (Range range in RegexHelper.Whitespace.EnumerateSplits(text))
            {
                string word = text[range];
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
            
            foreach (string part in RegexHelper.Whitespace.Split(text))
            {
                string word = part;
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
                @"\s+",
                RegexOptions.None,
                matchTimeoutMilliseconds: 1000 // security to prevent malicious input
            )
        ]
        public static partial 
            Regex 
                                        Whitespace
        {
            get;
        }
    }
}