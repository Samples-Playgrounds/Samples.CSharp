namespace Core.IO;

/// <summary>
/// File reading helpers.
///
///     ReadAllLines
/// Note:
///     this is for benchmarking purposes only
///     as soon as benchmarks are done and code is refactored it is moved to the repo where testing and packaging is done
///     https://github.com/HolisticWare-Libraries/HolisticWare.Core.IO
/// </summary>
/// https://stackoverflow.com/questions/8037070/whats-the-fastest-way-to-read-a-text-file-line-by-line
/// https://cc.davelozinski.com/c-sharp/fastest-way-to-read-text-files
/// https://medium.com/@nuno.caneco/c-file-readlines-vs-file-readalllines-4742d738064e
public partial class
                                        File
{
        public static
        string[]
                                        ReadAllLinesWithFileReadAllLines
                                        (
                                            string file_path
                                        )
    {
        return System.IO.File.ReadAllLines(file_path);
    }
        
        public static
        string[]
                                        ReadAllLinesWithFileOpenReadAndStreamReaderReadLine
                                        (
                                            string file_path
                                        )
    {
        using System.IO.FileStream fs = System.IO.File.OpenRead(file_path);
        using System.IO.StreamReader reader = new System.IO.StreamReader(fs);
        
        List<string> lines = new();
        while (reader.ReadLine() is { } line)
        {
            lines.Add(line);
        }

        return lines.ToArray();
    }
        
        public static
        string[]
                                        ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine
                                        (
                                            string file_path
                                        )
    {
        using System.IO.FileStream fs = System.IO.File.OpenRead(file_path);
        using System.IO.MemoryStream ms = new System.IO.MemoryStream();
        fs.CopyTo(ms);
        using System.IO.StreamReader reader = new System.IO.StreamReader(ms);
        
        List<string> lines = new();
        while (reader.ReadLine() is { } line)
        {
            lines.Add(line);
        }

        return lines.ToArray();
    }
        
    public static
        string[]
                                        ReadAllLinesAndSplitWithFileOpenReadRecyclableMemoryStream
                                        (
                                            string file_path
                                        )
    {
        using Microsoft.IO.RecyclableMemoryStream ms = rmsm.GetStream();
        using System.IO.FileStream fs = System.IO.File.OpenRead(file_path);
        fs.CopyTo(ms);
        using System.IO.StreamReader reader = new System.IO.StreamReader(ms);
        
        List<string> lines = new();
        while (reader.ReadLine() is { } line)
        {
            lines.Add(line);
        }

        return lines.ToArray();
    }
}