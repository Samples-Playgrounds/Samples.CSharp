using System;
using System.Threading.Tasks;
using Microsoft.IO;
using System.Buffers;
using System.IO.Pipelines;
using System.IO;
using System.Text;

class Program
{
    static async Task Main(string[] args)
    {
        string filePath = "employees.csv";
        string[] lines = await ReadLines(filePath);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    private static async Task<string[]> ReadLines(string filePath)
    {
        using FileStream stream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        Pipe pipeline = new();

        Task writing = ReadLinesAsync(stream, pipeline.Writer);
        string[] lines = await ProcessLinesAsync(pipeline.Reader);
        await writing;

        return lines;
    }

    private static async Task<string[]> ProcessLinesAsync(PipeReader reader)
    {
        List<string> lines = new();

        while (true)
        {
            ReadResult result = await reader.ReadAsync();
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

    private static string GetString(ReadOnlySequence<byte> sequence)
    {
        if (sequence.IsSingleSegment)
        {
            return Encoding.UTF8.GetString(sequence.First.Span);
        }

        return Encoding.UTF8.GetString(sequence.ToArray());
    }

    static async Task ReadLinesAsync(Stream stream, PipeWriter writer)
    {
        const int bufferSize = 4096;
        while (true)
        {
            Memory<byte> memory = writer.GetMemory(bufferSize);
            int bytesRead = await stream.ReadAsync(memory);
            if (bytesRead == 0)
                break;
            writer.Advance(bytesRead);
            FlushResult result = await writer.FlushAsync();
            if (result.IsCompleted) break;
        }
        await writer.CompleteAsync();
    }
}
