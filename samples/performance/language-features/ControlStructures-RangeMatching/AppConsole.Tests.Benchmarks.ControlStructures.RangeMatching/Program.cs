using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.ControlStructures.RangeMatching;

Summary summary = BenchmarkRunner.Run<Benchmarks_ControlStructures_RangeMatching>();

return;