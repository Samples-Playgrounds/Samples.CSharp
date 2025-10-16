namespace Core.Data.Formatters.Text.Utilities;

/// <summary>
/// 
/// </summary>
public static partial class
                                        StringExtensions
{
    private static readonly 
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager
                                        = new ();
    
        public static
        string
                                        StringFromStream
                                        (
                                            this global::System.IO.Stream s
                                        )
    {
        return StringFromStream(s, global::System.Text.Encoding.Unicode);
    }
    

    public static
        string
                                        StringFromStream
                                        (
                                            this global::System.IO.Stream s,
                                            global::System.Text.Encoding e
                                        )
    {
        string? result = default(string);
        
        s.Position = 0;
        using (TextReader r = new StreamReader(s, e))
        {
            result = r.ReadToEnd();
        }

        return result;
    }
    
    public static
        global::System.IO.MemoryStream
                                        ToMemoryStream
                                        (
                                            this string str
                                        )
    
    {
        global::System.IO.MemoryStream stream = new ();
        global::System.IO.StreamWriter writer = new (stream);
        writer.Write(str);
        writer.Flush();
        stream.Position = 0;
        return stream;
    }
    
    public static
        global::System.IO.MemoryStream
                                        RecyclableMemoryStream
                                        (
                                            this string str
                                        )

    {
        Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream();
        global::System.IO.StreamWriter w = new (ms);
        w.Write(str);
        w.Flush();
        ms.Position = 0;
        return ms;
    }
}