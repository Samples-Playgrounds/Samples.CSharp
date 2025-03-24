using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Holisticware.Library.Snippets.Methods.Calls;
using Holisticware.Library.Snippets.Strings;

Summary summary_concatenation = BenchmarkRunner.Run<Benchmarks_Methods_Calls>();

return;