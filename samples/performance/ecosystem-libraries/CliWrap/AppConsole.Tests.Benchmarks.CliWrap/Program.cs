using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;

using Holisticware.Library.Snippets.CliWrap;

Summary summary = BenchmarkRunner.Run<Benchmarks_Console_CliWrap_StdOut>
                                                    (
                                                        DefaultConfig.Instance
                                                                        // relative from csproj project file
                                                                        .WithArtifactsPath("./BenchmarkDotNet.Artifacts")
                                                    );


string content = string.Empty;

return;
