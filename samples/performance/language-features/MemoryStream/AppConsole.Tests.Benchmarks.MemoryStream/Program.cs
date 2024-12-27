using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.MemoryStream;

Summary summary = BenchmarkRunner.Run<Benchmarks_MemoryStream>();

return;