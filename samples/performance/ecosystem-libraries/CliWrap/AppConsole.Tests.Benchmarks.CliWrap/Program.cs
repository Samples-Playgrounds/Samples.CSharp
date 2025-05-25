using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.CliWrap;

Summary summary = BenchmarkRunner.Run<Benchmarks_Console_CliWrap_StdOut>();

string content = string.Empty;

return;