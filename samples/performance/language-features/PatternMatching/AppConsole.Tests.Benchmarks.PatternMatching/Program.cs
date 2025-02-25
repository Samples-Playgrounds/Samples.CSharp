using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.PatternMatching;

Summary summary = BenchmarkRunner.Run<Benchmarks_PatternMatching>();

return;