using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;

using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;

namespace Holisticware.Library.Snippets.Globbing;

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
//[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[HideColumns("Error", "StdDev")]
public partial class
                                        Benchmarks_Globbing
{

    [Arguments("/Users/Shared/Projects/e/learning")]
    public
        string[]
                                        Globbing_Microsoft_Extensions_FileSystemGlobbing_Matcher
                                        (
                                            string path
                                        )
    {
        Microsoft.Extensions.FileSystemGlobbing.Matcher matcher = new();
        matcher.AddIncludePatterns(new[] { "*.txt", "*.asciidoc", "*.md" });

        PatternMatchingResult result = matcher.Execute
                                                (
                                                    new DirectoryInfoWrapper
                                                            (
                                                                new DirectoryInfo(path)
                                                            )
                                                );

        string[] results = result.Files.Select(s => s.Path).ToArray();
        
        return results;
    }

    [Arguments("/Users/Shared/Projects/e/learning")]
    public
        string[]
                                        Globbing_Dotnet_Glob
                                        (
                                            string path
                                        )
    {
        DotNet.Globbing.Glob glob = DotNet.Globbing.Glob.Parse
                                                            (
                                                            "*.md", 
                                                            DotNet.Globbing.GlobOptions.None
                                                            );
        foreach(var file in glob.EnumerateFiles("rootDirectory"))
        {
            Console.WriteLine(file);
        }        
        return results;
    }
}