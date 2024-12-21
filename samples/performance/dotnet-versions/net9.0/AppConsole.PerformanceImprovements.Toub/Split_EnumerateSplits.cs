using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AppConsole.PerformanceImprovements.Toub;

public partial class 
                                        Split_EnumerateSplits
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
    */
    public static
        void
                                        CollectData_net90_String_AsSpan_Split
                                        (
                                        )
    {
        for (int trial = 0; trial < 10; trial++)
        {
            long mem = GC.GetTotalAllocatedBytes();
            sw.Restart();
            
            foreach (Range range in text.AsSpan().Split(' '))
            {
                ReadOnlySpan<char> word = text.AsSpan(range);
                if (/*word_counts*/lookup.TryGetValue(word, out int count))
                {
                    count = count + 1;
                }
                else
                {
                    /*word_counts*/lookup[word] = 1;
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