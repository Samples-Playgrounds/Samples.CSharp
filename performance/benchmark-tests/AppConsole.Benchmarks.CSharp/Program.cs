
/*
dotnet run \
    --project ./AppConsole.Benchmarks.CSharp/AppConsole.Benchmarks.CSharp.csproj \
        -c Release \
        -f net6.0

*/
BenchmarkDotNet.Reports.Summary summary = null;

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Basics01.ControlStructures.ControlStructures>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine
                                        (
                                            "..", "..", "..", 
                                            "Basics01.ControlStructures.ControlStructures.log"
                                        ),
                    true
                );

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Basics02.Loops.Loops>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine
                                        (
                                            "..", "..", "..", 
                                            "Basics02.Loops.Loops.log"
                                        ),
                    true
                );


summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Basics03.NullChecks.NullCheck>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine
                                        (
                                            "..", "..", "..", 
                                            "Basics03.NullChecks.NullCheck.log"
                                        ),
                    true
                );

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Basics04.Strings.Strings>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine
                                        (
                                            "..", "..", "..", 
                                            "Basics04.Strings.Strings.log"
                                        ),
                    true
                );

return;
