using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.CollectionInitializersExpressions;

Summary summary = BenchmarkRunner.Run<Benchmarks_CollectionInitializersExpressions>();

return;