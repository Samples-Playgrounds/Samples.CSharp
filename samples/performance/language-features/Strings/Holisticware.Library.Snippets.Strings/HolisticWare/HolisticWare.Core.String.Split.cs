namespace Core;

public static partial class
                                        String
{
    public static 
        Func<string, char[], string[]>
                                        ChopStringImplementation
                                        = ChopStringNative;
    
    public static 
        string[]
                                        Chop
                                        (
                                            this string input,
                                            char[] delimiters
                                        )
    {
        return ChopStringImplementation(input, delimiters);
    }

    public static 
        string[]
                                        ChopStringNative
                                        (
                                            this string input,
                                            char[] delimiters
                                        )
    {
        return input.Split(delimiters, StringSplitOptions.None);
    }
    
    public static 
        string[]
                                        ChopWithSpan
                                        (
                                            this string input,
                                            char[] delimiters
                                        )
    {
        ReadOnlySpan<char> span = input.AsSpan();
        // char[] delimiters = new char[] { ',', ';' };

        List<string> tokens = new ();

        int start = 0;
        while (start < span.Length)
        {
            int end = span.Slice(start).IndexOfAny(delimiters);
            if (end == -1)
            {
                end = span.Length - start;
            }

            ReadOnlySpan<char> token = span.Slice(start, end);
            start += end + 1;
        
            tokens.Add(token.ToString());
        }

        return tokens.ToArray();
    }
}