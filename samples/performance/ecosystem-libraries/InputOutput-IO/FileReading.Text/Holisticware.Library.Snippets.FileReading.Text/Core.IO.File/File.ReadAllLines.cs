using System.Buffers;

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
        using System.IO.StreamReader reader = new (fs);

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
        using System.IO.MemoryStream ms = new ();
        fs.CopyTo(ms);
        using System.IO.StreamReader reader = new (ms);

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
        using System.IO.StreamReader reader = new (ms);

        List<string> lines = new();
        while (reader.ReadLine() is { } line)
        {
            lines.Add(line);
        }

        return lines.ToArray();
    }

    // https://github.com/jo-ninja/ReadLinesBenchmarks/blob/master/ReadLinesBenchmarks/Program.cs

    public static async
        Task<string[]>
                                        ReadAllLinesAndSplitWithPipelinesRecyclableMemoryStream_1
                                        (
                                            string file_path
                                        )
    {
        ReadOnlySpan<byte> newline =
                                    System.Text.Encoding.UTF8.GetBytes(System.Environment.NewLine)
                                                                .AsSpan()
                                    /*
                                    new[]
                                    [
                                        (byte)'\r', (byte)'\n'
                                    ]
                                    */
                                    ;

        using System.IO.FileStream fs = System.IO.File.OpenRead(file_path);
        System.IO.Pipelines.PipeReader pr = System.IO.Pipelines.PipeReader.Create(fs);
        List<string> lines = new();
        /*
        List<ReadOnlySpan<byte>> lines = new();

        while (true)
        {
            System.IO.Pipelines.ReadResult file_data = await pr.ReadAsync();

            // convert to Buffer
            System.Buffers.ReadOnlySequence<byte> file_data_buffer = file_data.Buffer;

            System.Buffers.SequenceReader<byte> reader = new (file_data_buffer);

            while (!reader.End)
            {
                // Read the whole line till the new line is found
                if (reader.TryReadToAny(out ReadOnlySpan<byte> line, newline, true))
                {
                    lines.Add(line);
                }
                else
                {
                    break; // we don't have a delimiter (newline) in the current data
                }

            }

            return reader.Position; // returning the Last position of the reader


            pr.AdvanceTo(sequencePosition, file_data_buffer.End);

            if (file_data.IsCompleted)
            {
                break;
            }
        }
        */

        return lines.ToArray();
    }

    private static
        System.IO.Pipelines.Pipe
                                        pipeline = new();

    public static async
        Task<string[]>
                                        ReadAllLinesAndSplitWithPipelinesRecyclableMemoryStream
                                        (
                                            string file_path
                                        )
    {
        using FileStream stream = new(file_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

        Task writing = ReadLinesAsync(stream, pipeline.Writer);
        string[] lines = await ProcessLinesAsync(pipeline.Reader);
        await writing;

        return lines;
    }

    private static
        List<string>
                                        lines = new();


    private static async
        Task<string[]>
                                        ProcessLinesAsync
                                        (
                                            System.IO.Pipelines.PipeReader reader
                                        )
    {
        while (true)
        {
            System.IO.Pipelines.ReadResult result = await reader.ReadAsync();
            ReadOnlySequence<byte> buffer = result.Buffer;
            SequenceReader<byte> seqReader = new(buffer);

            while (seqReader.TryReadTo(out ReadOnlySequence<byte> read_only_sequence_line, (byte)'\n'))
            {
                string line = GetString(read_only_sequence_line).TrimEnd('\r');
                lines.Add(line);
            }

            reader.AdvanceTo(seqReader.Position, buffer.End);

            if (result.IsCompleted)
            {
                break;
            }
        }
        await reader.CompleteAsync();

        return lines.ToArray();
    }

    private static
        string
                                        GetString
                                        (
                                            System.Buffers.ReadOnlySequence<byte> sequence
                                        )
    {
        if (sequence.IsSingleSegment)
        {
            return System.Text.Encoding.UTF8.GetString(sequence.First.Span);
        }

        return System.Text.Encoding.UTF8.GetString(sequence.ToArray());
    }

    private static
        int
                                        bufferSize = 4096;

    static async
        Task
                                        ReadLinesAsync
                                        (
                                            Stream stream,
                                            System.IO.Pipelines.PipeWriter writer
                                        )
    {
        while (true)
        {
            Memory<byte> memory = writer.GetMemory(bufferSize);
            int bytesRead = await stream.ReadAsync(memory);
            if (bytesRead == 0)
            {
                break;
            }
            writer.Advance(bytesRead);
            System.IO.Pipelines.FlushResult result = await writer.FlushAsync();
            if (result.IsCompleted)
            {
                break;
            }
        }

        await writer.CompleteAsync();

        return;
    }

}
