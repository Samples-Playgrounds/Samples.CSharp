namespace Core.IO;

/// <summary>
/// File reading helpers.
///
/// Note:
///     *   this is for benchmarking purposes only
///     *   as soon as benchmarks are done and code is refactored it is moved to the repo where testing
///         and packaging is done
///     *   https://github.com/HolisticWare-Libraries/HolisticWare.Core.IO
/// </summary>
public partial class
                                        File
{
    static
                                        File
                                        (
                                        )
    {
        ReadAllTextImplementation
            = ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString;
        ReadAllLinesImplementation
            = ReadAllLinesWithFileReadAllLines;

        return;
    }

    public static
        System.Func<string, string>
                                        ReadAllTextImplementation
    {
        get;
        set;
    }

    public static
        Func<string, string[]>
                                        ReadAllLinesImplementation
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
        return ReadAllTextImplementation(file_path);
    }

    public static
        string
                                        ReadAllLines
                                        (
                                            string file_path
                                        )
    {
        return ReadAllTextImplementation(file_path);
    }

    private static readonly
        Microsoft.IO.RecyclableMemoryStreamManager
                                        rmsm = new Microsoft.IO.RecyclableMemoryStreamManager();


}
