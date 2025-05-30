using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.CharacterSeparatedValues.CSV;

Summary summary = BenchmarkRunner.Run<Benchmarks_CSV>();

string content = string.Empty;

return;