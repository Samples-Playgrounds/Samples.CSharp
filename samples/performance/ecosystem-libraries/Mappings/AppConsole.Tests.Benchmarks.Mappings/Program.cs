using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.Mappings;

Summary summary = BenchmarkRunner.Run<Benchmarks_Mappings>();

string content = string.Empty;

return;