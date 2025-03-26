using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Holisticware.Library.Snippets.Channels;

Summary summary = BenchmarkRunner.Run<Benchmarks_Channels>();

string content = string.Empty;

return;