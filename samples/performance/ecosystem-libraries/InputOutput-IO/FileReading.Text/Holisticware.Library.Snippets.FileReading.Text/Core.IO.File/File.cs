namespace Core.IO;

public partial class
                                        File
{
    static
                                        File()
    {
        ReadAllTextImplementation 
            = ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString;
        
        return;
    }

    public static
        Func<string, string>
                                        ReadAllTextImplementation
    {
        get;
        set;
    } 
    
    public static
        string
                                        ReadAllText
                                        (
                                            string file_path
                                        )
    {
        return ReadAllTextDelegate(file_path);
    }

    private static readonly 
        Microsoft.IO.RecyclableMemoryStreamManager 
                                        rmsm = new Microsoft.IO.RecyclableMemoryStreamManager();

    public static
        string
                                        ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString
                                        (
                                            string file_path
                                        )
    {
        using System.IO.FileStream fs = new System.IO.FileStream
                                                            (
                                                                file_path,
                                                                FileMode.Open,
                                                                FileAccess.Read,
                                                                FileShare.Read
                                                            );
        using Microsoft.IO.RecyclableMemoryStream ms = rmsm.GetStream();
        fs.CopyTo(ms);
        using System.IO.StreamReader sr = new System.IO.StreamReader(ms);
        
        Span<char> buffer = new char[4096].AsSpan();
        int numberRead;
        using Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder();
        while ((numberRead = sr.ReadBlock(buffer)) > 0)
        {
            sb.Append(buffer[..numberRead]);
        }
        
        return sb.ToString();        
    }
    
}