using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;


namespace Holisticware.Library.Snippets.CliWrap;

using global::CliWrap;
using System.Linq;
using System.Reactive.Linq;
using System.Collections.Generic;
using global::CliWrap.Buffered;
using global::CliWrap.EventStream;

[MemoryDiagnoser]
// [ThreadingDiagnoser]
// [ExceptionDiagnoser]
[AsciiDocExporter]
[CsvExporter]
[CsvMeasurementsExporter]
[HtmlExporter]
[PlainExporter]
[RPlotExporter]
[JsonExporterAttribute.Brief]
[JsonExporterAttribute.BriefCompressed]
[JsonExporterAttribute.Full]
[JsonExporterAttribute.FullCompressed]
[MarkdownExporterAttribute.Default]
[MarkdownExporterAttribute.GitHub]
[MarkdownExporterAttribute.StackOverflow]
[MarkdownExporterAttribute.Atlassian]
[XmlExporterAttribute.Brief]
[XmlExporterAttribute.BriefCompressed]
[XmlExporterAttribute.Full]
[XmlExporterAttribute.FullCompressed]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[HideColumns("Error", "StdDev")]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90)]
public partial class
                                       Benchmarks_Console_CliWrap_StdOut
{
    System.Text.StringBuilder                              sb = new();
    private Cysharp.Text.Utf16ValueStringBuilder           sbz = Cysharp.Text.ZString.CreateStringBuilder();
    System.Diagnostics.Process?                            process = default;
    global::CliWrap.Command                                cmd = default;
    private global::CliWrap.Buffered.BufferedCommandResult result = default;
    string                                                 stdout_1 = string.Empty;
    List<string>                                           stdout_2 = new();
    string[]                                               stdout_3 = default;


    [Benchmark]
    public async
        Task<string[]>
                                        Test_01_System_Diagnostic_Process_StandardOutput
                                        (
                                        )
    {
        process = new ()
                    {
                        StartInfo = new System.Diagnostics.ProcessStartInfo()
                        {
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            FileName = "javac",
                            Arguments = $"--version"
                        }
                    };
        process.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler
                                                                    (
                                                                        (sender, args) =>
                                                                        {
                                                                            stdout_2.Add(args.Data);
                                                                        }
                                                                    );
        process.Start();

        return stdout_2.ToArray();
    }

    [Benchmark]
    public async
        Task<string>
                                        Test_11_CliWrap_StandardOutput_AsString_From_Result
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                ;
        global::CliWrap.Buffered.BufferedCommandResult result = await cmd.ExecuteBufferedAsync();

        return result.StandardOutput;
    }

    [Benchmark]
    public async
        Task<string>
                                        Test_12_CliWrap_StandardOutput_AsString_Via_Delegate_StringBuider
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe
                                    (
                                        PipeTarget.ToDelegate
                                                    (
                                                        (s => sb.Append(s))
                                                    )
                                    );

        return sb.ToString();
    }

    [Benchmark]
    public async
        Task<string>
                                        Test_13_CliWrap_StandardOutput_AsString_Via_Delegate_ZString
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe
                                    (
                                        PipeTarget.ToDelegate
                                                    (
                                                        (s => sbz.Append(s))
                                                    )
                                    );
        return sb.ToString();
    }

    [Benchmark]
    public async
        Task<string>
                                        Test_14_CliWrap_StandardOutput_AsString_Via_Delegate_StrngBuilder_BuiltIn
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe(PipeTarget.ToStringBuilder(sb))
                                ;

        return sb.ToString();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        Test_21_CliWrap_StandardOutput_AsStringArray_From_Result
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                ;
        global::CliWrap.Buffered.BufferedCommandResult result = await cmd.ExecuteBufferedAsync();
        stdout_3 = result.StandardOutput.Split
                                            (
                                                new string[] { "\r\n", "\n", "\r" },
                                                StringSplitOptions.None
                                            );

        return stdout_3.ToArray();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        Test_22_CliWrap_StandardOutput_AsStringArray_Via_Piped_Delegate
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                |
                                stdout_2.Add
                                ;
        await cmd.ExecuteBufferedAsync();

        return stdout_2.ToArray();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        Test_23_CliWrap_StandardOutput_AsStringArray_Via_Observable
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                ;
        stdout_3 = await cmd
                            .Observe()
                            .OfType<global::CliWrap.EventStream.StandardOutputCommandEvent>()
                            .Select(e => e.Text)
                            .ToArray()
                            ;
        await cmd.ExecuteBufferedAsync();

        return stdout_3.ToArray();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        Test_24_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                ;
        await foreach (global::CliWrap.EventStream.CommandEvent cmd_event in cmd.ListenAsync())
        {
            if (cmd_event is StandardOutputCommandEvent soec)
            {
                stdout_2.Add(soec.Text);
            }
        }

        return stdout_2.ToArray();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        Test_25_CliWrap_StandardOutput_AsStringArray_Via_Delegate
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe
                                    (
                                        PipeTarget.ToDelegate
                                                    (
                                                        (s => stdout_2.Add(s))
                                                    )
                                    );

        return stdout_2.ToArray();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        Test_34_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync
                                        (
                                        )
    {
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                ;
        await foreach (global::CliWrap.EventStream.CommandEvent cmd_event in cmd.ListenAsync())
        {
            switch (cmd_event)
            {
                case StartedCommandEvent sce:
                    Console.WriteLine($"Started: {sce.ProcessId}");
                    break;
                case StandardErrorCommandEvent sece:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"err> {sece.Text}");
                    break;
                case StandardOutputCommandEvent soce:
                    Console.WriteLine($"out> {soce.Text}");
                    break;
                default:
                    break;
            }
        }

        return stdout_2.ToArray();
    }

}
