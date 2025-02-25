using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.Regex;

Summary summary = BenchmarkRunner.Run<Benchmarks_Nullable_NullChecks>();

return;