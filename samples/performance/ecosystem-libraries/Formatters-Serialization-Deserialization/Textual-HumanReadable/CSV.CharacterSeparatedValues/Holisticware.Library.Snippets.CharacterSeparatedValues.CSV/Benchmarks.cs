using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;

using CsvHelper;
using nietras.SeparatedValues;

using Holisticware.Library.Snippets.CharacterSeparatedValues.CSV.Models;


namespace Holisticware.Library.Snippets.CharacterSeparatedValues.CSV;

using System.Linq;
using System.Collections.Generic;

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
                                       Benchmarks_CSV
{
    [Benchmark]
    public
        void
                                        Test_01_CsvHelper_weather
                                        (
                                        )
    {
        // https://github.com/JoshClose/CsvHelper
        // https://joshclose.github.io/CsvHelper/examples/reading
        using (StreamReader reader = new StreamReader("Data/weather.csv"))
        using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
        {
            IEnumerable<Weather> records = csv.GetRecords<Models.Weather>();
        }
 
        return;
    }
    
    [Benchmark]
    public
        void
                                        Test_01_CsvHelper_iris
                                        (
                                        )
    {
        // https://github.com/JoshClose/CsvHelper
        // https://joshclose.github.io/CsvHelper/examples/reading
        using (StreamReader reader = new StreamReader("Data/iris.csv"))
        using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
        {
            IEnumerable<Weather> records = csv.GetRecords<Models.Weather>();
        }
 
        return;
    }
    
    [Benchmark]
    public
        void
                                        Test_02_Sep_weather
                                        (
                                        )
    {
        // https://github.com/nietras/Sep
        using SepReader reader = nietras.SeparatedValues.Sep.Reader().FromFile("Data/weather.csv");
 
        return;
    }
    
    [Benchmark]
    public
        void
                                        Test_02_Sep_iris
                                        (
                                        )
    {
        // https://github.com/nietras/Sep
        using SepReader reader = nietras.SeparatedValues.Sep.Reader().FromFile("Data/iris.csv");
 
        return;
    }
    
    [Benchmark]
    public
        void
                                        Test_03_Sylvan_Data_CSV_weather
                                        (
                                        )
    {
        // https://github.com/MarkPflug/Sylvan/blob/main/docs/Csv/Sylvan.Data.Csv.md
        Sylvan.StringPool pool = new Sylvan.StringPool();
        Sylvan.Data.Csv.CsvDataReaderOptions opts = new Sylvan.Data.Csv.CsvDataReaderOptions
                                                                                {
                                                                                    StringFactory = pool.GetString
                                                                                };
        Sylvan.Data.Csv.CsvDataReader csv1 = Sylvan.Data.Csv.CsvDataReader.Create("Data/weather.csv", opts);
 
        return;
    }
    
    [Benchmark]
    public
        void
                                        Test_03_Sylvan_Data_CSV_iris
                                        (
                                        )
    {
        // https://github.com/MarkPflug/Sylvan/blob/main/docs/Csv/Sylvan.Data.Csv.md
        Sylvan.StringPool pool = new Sylvan.StringPool();
        Sylvan.Data.Csv.CsvDataReaderOptions opts = new Sylvan.Data.Csv.CsvDataReaderOptions
                                                                                {
                                                                                    StringFactory = pool.GetString
                                                                                };
        Sylvan.Data.Csv.CsvDataReader csv1 = Sylvan.Data.Csv.CsvDataReader.Create("Data/iris.csv", opts);
 
        return;
    }
    
}