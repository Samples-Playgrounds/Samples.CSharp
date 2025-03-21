using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.FileReading.Text;

Summary summary_read_alltext = BenchmarkRunner.Run<Benchmarks_FileReading_Text_ReadAllText>();
Summary summary_read_alllines = BenchmarkRunner.Run<Benchmarks_FileReading_Text_ReadAllLines>();

/*
string content = string.Empty;

Core.IO.File.ReadAllTextImplementation
        = Core.IO.File.ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString;

content = Core.IO.File.ReadAllText("test-data/steps-01/kb.1.txt");
*/

return;