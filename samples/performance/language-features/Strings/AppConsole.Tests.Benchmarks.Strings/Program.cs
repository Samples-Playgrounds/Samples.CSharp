using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.Strings;

Summary summary_concatenation = BenchmarkRunner.Run<Benchmarks_Strings_Concatenation>();
Summary summary_split = BenchmarkRunner.Run<Benchmarks_Strings_Split>();

return;