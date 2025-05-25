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
public partial class
                                       Benchmarks_Console_CliWrap_StdOut
{
    [Benchmark]
    public async
        Task<string[]>
                                        f_00
                                        (
                                        )
    {
        List<string> stdout = new();
        System.Diagnostics.Process?     process = default;

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
                                                                            stdout.Add(args.Data);
                                                                        }
                                                                    );

        process.Start();

        return stdout.ToArray();
    }
    
    [Benchmark]
    public async
        Task<string[]>
                                        f_01
                                        (
                                        )
    {
        global::CliWrap.Command cmd = global::CliWrap.Cli
                                                        .Wrap("javac")
                                                        .WithArguments("--version")
                                                        ;
        global::CliWrap.Buffered.BufferedCommandResult result = await cmd.ExecuteBufferedAsync();
        string[] stdout = result.StandardOutput.Split
                                                    (
                                                        new string[] { "\r\n", "\n", "\r" },
                                                        StringSplitOptions.None
                                                    );

        return stdout.ToArray();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        f_02
                                        (
                                        )
    {
        List<string> stdout = new();
        global::CliWrap.Command cmd = global::CliWrap.Cli
                                                        .Wrap("javac")
                                                        .WithArguments("--version")
                                                        |
                                                        stdout.Add
                                                        ;
        await cmd.ExecuteBufferedAsync();
        
        return stdout.ToArray();
    }

    [Benchmark]
    public async
        Task<string[]>
                                        f_03
                                        (
                                        )
    {
        global::CliWrap.Command cmd = global::CliWrap.Cli
                                                        .Wrap("javac")
                                                        .WithArguments("--version")
                                                        ;
        var stdout = await cmd
                            .Observe()
                            .OfType<global::CliWrap.EventStream.StandardOutputCommandEvent>()
                            .Select(e => e.Text)
                            .ToArray()
                            ;
        await cmd.ExecuteBufferedAsync();
        
        return stdout.ToArray();
    }
    
    [Benchmark]
    public async
        Task<string[]>
                                        f_04
                                        (
                                        )
    {
        List<string> stdout = new();
        global::CliWrap.Command cmd = global::CliWrap.Cli
                                                        .Wrap("javac")
                                                        .WithArguments("--version")
                                                        ;
        await foreach (global::CliWrap.EventStream.CommandEvent cmd_event in cmd.ListenAsync())
        {
            if (cmd_event is StandardOutputCommandEvent soec)
            {
                stdout.Add(soec.Text);
            }
        }

        return stdout.ToArray();
    }
    
    [Benchmark]
    public async
        Task<string[]>
                                        f_05
                                        (
                                        )
    {
        List<string> stdout = new();
        global::CliWrap.Command cmd = global::CliWrap.Cli
                                                        .Wrap("javac")
                                                        .WithArguments("--version")
                                                        .WithStandardOutputPipe
                                                            (
                                                                PipeTarget.ToDelegate
                                                                            (
                                                                                (s => stdout.Add(s))
                                                                            )
                                                            );

        return stdout.ToArray();
    }
    
    [Benchmark]
    public async
        Task<string>
                                        f_11
                                        (
                                        )
    {
        System.Text.StringBuilder sb = new();
        List<string> stdout = new();
        global::CliWrap.Command cmd = global::CliWrap.Cli
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
                                        f_12
                                        (
                                        )
    {
        using(Cysharp.Text.Utf16ValueStringBuilder sb = Cysharp.Text.ZString.CreateStringBuilder())
        {
            List<string> stdout = new();
            global::CliWrap.Command cmd = global::CliWrap.Cli
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
    }
    
    [Benchmark]
    public async
        Task<string>
                                        f_13
                                        (
                                        )
    {
        System.Text.StringBuilder sb = new();
        List<string> stdout = new();
        global::CliWrap.Command cmd = global::CliWrap.Cli
                                                        .Wrap("javac")
                                                        .WithArguments("--version")
                                                        .WithStandardOutputPipe(PipeTarget.ToStringBuilder(sb))
                                                        ;

        return sb.ToString();
    }
    
}