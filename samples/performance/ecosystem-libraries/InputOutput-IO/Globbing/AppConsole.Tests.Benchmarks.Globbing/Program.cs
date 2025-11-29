using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.Globbing;

string timestamp = DateTime.Now.ToString("yyyy-MM-dd-T-HH-mm-ss");
string path = $"./BenchmarkDotNet.Artifacts/{timestamp}/";

Summary summary_read_alltext = BenchmarkRunner.Run<Benchmarks_Globbing>
                                                    (
                                                        DefaultConfig.Instance
                                                                        // relative from csproj project file
                                                                        .WithArtifactsPath(path)
                                                    );


return;
