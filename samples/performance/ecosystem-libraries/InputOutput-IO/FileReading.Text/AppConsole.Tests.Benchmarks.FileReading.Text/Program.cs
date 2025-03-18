using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.ControlStructures.RangeMatching;

Summary summary = BenchmarkRunner.Run<Benchmarks_FileReading_Text>();

string content = string.Empty;

Core.IO.File.ReadAllTextImplementation 
        = Core.IO.File.ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString;

content = Core.IO.File.ReadAllText("test-data/192.txt");

return;