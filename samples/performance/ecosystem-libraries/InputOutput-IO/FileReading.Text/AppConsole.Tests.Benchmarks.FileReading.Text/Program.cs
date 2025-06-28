using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.FileReading.Text;

string timestamp = DateTime.Now.ToString("yyyy-MM-dd-T-HH-mm-ss");
string path = $"./BenchmarkDotNet.Artifacts/{timestamp}/";

Summary summary_read_alltext = BenchmarkRunner.Run<Benchmarks_FileReading_Text_ReadAllText>
                                                    (
                                                        DefaultConfig.Instance
                                                                        // relative from csproj project file
                                                                        .WithArtifactsPath(path)
                                                    );
Summary summary_read_alllines = BenchmarkRunner.Run<Benchmarks_FileReading_Text_ReadAllLines>
                                                    (
                                                        DefaultConfig.Instance
                                                                        // relative from csproj project file
                                                                        .WithArtifactsPath(path)
                                                    );


string content = string.Empty;
Core.IO.File.ReadAllTextImplementation
        = Core.IO.File.ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString;

content = Core.IO.File.ReadAllText("td/s1/kb.1.txt");

return;
