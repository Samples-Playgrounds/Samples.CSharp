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
/// https://www.linkedin.com/pulse/efficient-reading-large-csv-files-leonardo-jacques-da-silva-1laaf/
///     https://github.com/leosul/FileReadWritePerformance
///     
public partial class
                                        File
{
    public static
        string[][]
                                        ReadAllLinesAndSplitWithReadAllLines
                                        (
                                            string file_path,
                                            char[] separators,
                                            Func<string[], string> line_transformer = null
                                        )
    {
        string[] lines = System.IO.File.ReadAllLines(file_path);
        string[][] lines_split = new string[lines.Length][];

        int i = 0;
        foreach (var line in lines)
        {
            string[] line_split = line.Split(',');
            if (line_transformer != null)
            {
                line_split = line.Split(separators);
                lines_split[i] = line_split;
            }
        }

        return lines_split;
    }
}