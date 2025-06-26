/// <summary>
/// Provides high-performance, pipeline-based file reading and writing utilities for line-by-line processing.
/// </summary>
using System.Buffers;
using System.IO;
using System.IO.Pipelines;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.IO;

public static partial class
                                        File
{
    /// <summary>
    /// Asynchronously reads all lines from a file using System.IO.Pipelines for maximum throughput.
    /// </summary>
    /// <param name="file_path">The path to the file to read.</param>
    /// <returns>An array of lines read from the file.</returns>
    public static async
        Task<string[]>
                                        ReadAllLinesWithPipelinesAsync
                                        (
                                            string file_path
                                        )
    {
        await using FileStream file_stream = new
                                            (
                                                file_path,
                                                FileMode.Open,
                                                FileAccess.Read,
                                                FileShare.Read,
                                                4096,
                                                FileOptions.Asynchronous | FileOptions.SequentialScan
                                            );
        Pipe pipe = new();
        Task writing = FillPipeAsync(file_stream, pipe.Writer);
        Task<string[]> reading = ReadPipeAsync(pipe.Reader);
        await Task.WhenAll(writing, reading);
        string[] lines = await reading;

        return lines;
    }

    /// <summary>
    /// Asynchronously fills a PipeWriter from a stream.
    /// </summary>
    /// <param name="stream">The input stream.</param>
    /// <param name="pipe_writer">The PipeWriter to fill.</param>
    private static async
        Task
                                        FillPipeAsync
                                        (
                                            Stream stream,
                                            PipeWriter pipe_writer
                                        )
    {
        const int minimum_buffer_size = 4096;

        while (true)
        {
            Memory<byte> memory = pipe_writer.GetMemory(minimum_buffer_size);
            int bytes_read = await stream.ReadAsync(memory);
            if (bytes_read == 0)
                break;
            pipe_writer.Advance(bytes_read);
            FlushResult flush_result = await pipe_writer.FlushAsync();
            if (flush_result.IsCompleted)
                break;
        }
        await pipe_writer.CompleteAsync();

        return;
    }

    /// <summary>
    /// Asynchronously reads lines from a PipeReader.
    /// </summary>
    /// <param name="pipe_reader">The PipeReader to read from.</param>
    /// <returns>An array of lines read from the pipe.</returns>
    private static async
        Task<string[]>
                                        ReadPipeAsync
                                        (
                                            PipeReader pipe_reader
                                        )
    {
        List<string> lines = new();

        while (true)
        {
            ReadResult read_result = await pipe_reader.ReadAsync();
            ReadOnlySequence<byte> buffer = read_result.Buffer;
            SequencePosition? position;
            do
            {
                position = buffer.PositionOf((byte)'\n');
                if (position != null)
                {
                    ReadOnlySequence<byte> line = buffer.Slice(0, position.Value);
                    lines.Add(ProcessLine(line));
                    buffer = buffer.Slice(buffer.GetPosition(1, position.Value));
                }
            }
            while (position != null);
            pipe_reader.AdvanceTo(buffer.Start, buffer.End);
            if (read_result.IsCompleted)
            {
                break;
            }
        }
        await pipe_reader.CompleteAsync();

        return lines.ToArray();
    }

    /// <summary>
    /// Synchronously reads all lines from a file using System.IO.Pipelines.
    /// </summary>
    /// <param name="file_path">The path to the file to read.</param>
    /// <returns>An array of lines read from the file.</returns>
    public static
        string[]
                                        ReadAllLinesWithPipelines
                                        (
                                            string file_path
                                        )
    {
        using FileStream file_stream = new
                                        (
                                            file_path,
                                            FileMode.Open,
                                            FileAccess.Read,
                                            FileShare.Read,
                                            4096,
                                            FileOptions.SequentialScan
                                        );
        Pipe pipe = new();
        FillPipe(file_stream, pipe.Writer);
        string[] lines = ReadPipe(pipe.Reader);

        return lines;
    }

    /// <summary>
    /// Synchronously fills a PipeWriter from a stream.
    /// </summary>
    /// <param name="stream">The input stream.</param>
    /// <param name="pipe_writer">The PipeWriter to fill.</param>
    private static
        void
                                        FillPipe
                                        (
                                            Stream stream,
                                            PipeWriter pipe_writer
                                        )
    {
        const int minimum_buffer_size = 4096;

        while (true)
        {
            Memory<byte> memory = pipe_writer.GetMemory(minimum_buffer_size);
            int bytes_read = stream.Read(memory.Span);
            if (bytes_read == 0)
                break;
            pipe_writer.Advance(bytes_read);
            FlushResult flush_result = pipe_writer.FlushAsync().GetAwaiter().GetResult();
            if (flush_result.IsCompleted)
                break;
        }
        pipe_writer.CompleteAsync().GetAwaiter().GetResult();

        return;
    }

    /// <summary>
    /// Synchronously reads lines from a PipeReader.
    /// </summary>
    /// <param name="pipe_reader">The PipeReader to read from.</param>
    /// <returns>An array of lines read from the pipe.</returns>
    public static
        string[]
                                        ReadPipe
                                        (
                                            PipeReader pipe_reader
                                        )
    {
        List<string> lines = new();

        while (true)
        {
            ReadResult read_result = pipe_reader.ReadAsync().GetAwaiter().GetResult();
            ReadOnlySequence<byte> buffer = read_result.Buffer;
            SequencePosition? position;
            do
            {
                position = buffer.PositionOf((byte)'\n');
                if (position != null)
                {
                    ReadOnlySequence<byte> line = buffer.Slice(0, position.Value);
                    lines.Add(ProcessLine(line));
                    buffer = buffer.Slice(buffer.GetPosition(1, position.Value));
                }
            }
            while (position != null);
            pipe_reader.AdvanceTo(buffer.Start, buffer.End);
            if (read_result.IsCompleted)
            {
                break;
            }
        }
        pipe_reader.CompleteAsync().GetAwaiter().GetResult();

        return lines.ToArray();
    }

    /// <summary>
    /// Asynchronously writes all lines to a file using System.IO.Pipelines for maximum throughput.
    /// </summary>
    /// <param name="file_path">The path to the file to write.</param>
    /// <param name="lines">The lines to write to the file.</param>
    public static async
        Task
                                        WriteLinesAsync
                                        (
                                            string file_path,
                                            IEnumerable<string> lines
                                        )
    {
        await using FileStream file_stream = new
                                                (
                                                    file_path,
                                                    FileMode.Create,
                                                    FileAccess.Write,
                                                    FileShare.None,
                                                    4096,
                                                    FileOptions.Asynchronous | FileOptions.SequentialScan
                                                );
        Pipe pipe = new();
        Task writing = FillPipeWriterAsync(file_stream, pipe.Reader);
        Task reading = WritePipeAsync(pipe.Writer, lines);
        await Task.WhenAll(writing, reading);

        return;
    }

    /// <summary>
    /// Asynchronously writes lines to a PipeWriter.
    /// </summary>
    /// <param name="pipe_writer">The PipeWriter to write to.</param>
    /// <param name="lines">The lines to write.</param>
    private static async
        Task
                                        WritePipeAsync
                                        (
                                            PipeWriter pipe_writer,
                                            IEnumerable<string> lines
                                        )
    {
        foreach (string line in lines)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(line + "\n");
            pipe_writer.Write(buffer);
        }
        await pipe_writer.CompleteAsync();

        return;
    }

    /// <summary>
    /// Asynchronously writes data from a PipeReader to a stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="pipe_reader">The PipeReader to read from.</param>
    private static async
        Task
                                        FillPipeWriterAsync
                                        (
                                            Stream stream,
                                            PipeReader pipe_reader
                                        )
    {
        while (true)
        {
            ReadResult read_result = await pipe_reader.ReadAsync();
            ReadOnlySequence<byte> buffer = read_result.Buffer;
            foreach (var segment in buffer)
            {
                await stream.WriteAsync(segment);
            }
            pipe_reader.AdvanceTo(buffer.End);
            if (read_result.IsCompleted)
                break;
        }
        await pipe_reader.CompleteAsync();
    }

    /// <summary>
    /// Synchronously writes all lines to a file using System.IO.Pipelines.
    /// </summary>
    /// <param name="file_path">The path to the file to write.</param>
    /// <param name="lines">The lines to write to the file.</param>
    public static
        void
                                        WriteLines
                                        (
                                            string file_path,
                                            IEnumerable<string> lines
                                        )
    {
        using FileStream file_stream = new
                                        (
                                            file_path,
                                            FileMode.Create,
                                            FileAccess.Write,
                                            FileShare.None,
                                            4096,
                                            FileOptions.SequentialScan
                                        );
        Pipe pipe = new();
        FillPipeWriter(file_stream, pipe.Reader);
        WritePipe(pipe.Writer, lines);
    }

    /// <summary>
    /// Synchronously writes lines to a PipeWriter.
    /// </summary>
    /// <param name="pipe_writer">The PipeWriter to write to.</param>
    /// <param name="lines">The lines to write.</param>
    private static
        void
                                        WritePipe
                                        (
                                            PipeWriter pipe_writer,
                                            IEnumerable<string> lines
                                        )
    {
        foreach (string line in lines)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(line + "\n");
            pipe_writer.Write(buffer);
        }
        pipe_writer.CompleteAsync().GetAwaiter().GetResult();

        return;
    }

    /// <summary>
    /// Synchronously writes data from a PipeReader to a stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="pipe_reader">The PipeReader to read from.</param>
    private static
        void
                                        FillPipeWriter
                                        (
                                            Stream stream,
                                            PipeReader pipe_reader
                                        )
    {
        while (true)
        {
            ReadResult read_result = pipe_reader.ReadAsync().GetAwaiter().GetResult();
            ReadOnlySequence<byte> buffer = read_result.Buffer;
            foreach (var segment in buffer)
            {
                stream.Write(segment.Span);
            }
            pipe_reader.AdvanceTo(buffer.End);
            if (read_result.IsCompleted)
            {
                break;
            }
        }
        pipe_reader.CompleteAsync().GetAwaiter().GetResult();

        return;
    }

    /// <summary>
    /// Decodes a line from a ReadOnlySequence<byte> to a string.
    /// </summary>
    /// <param name="line">The line as a ReadOnlySequence<byte>.</param>
    /// <returns>The decoded string.</returns>
    private static
        string
                                        ProcessLine
                                        (
                                            ReadOnlySequence<byte> line
                                        )
    {
        if (line.IsSingleSegment)
        {
            return System.Text.Encoding.UTF8.GetString(line.FirstSpan);
        }
        else
        {
            byte[] buffer = line.ToArray();
            return System.Text.Encoding.UTF8.GetString(buffer);
        }
    }
}
