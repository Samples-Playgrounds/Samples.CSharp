using Microsoft.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Holisticware.Library.Snippets.MemoryStream;

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
                                        Benchmarks_Numeric
{
    [Benchmark]
    [Arguments(7.0, 6.0, 4.0, 191.7)]
    public
        double
                                        Calculate_Somatotype_Endomorphic_Parameters
                                        (
                                            double skinfold_SubTriceps,
                                            double skinfold_SubScapular,
                                            double skinfold_SupraIliac,
                                            double Height
                                        )
    {
        
        double endomorphic_sum =
                                (
                                    skinfold_SubTriceps
                                    +
                                    skinfold_SubScapular
                                    +
                                    skinfold_SupraIliac
                                )
                                * 170.18 / Height
                            ;

        double endomorhpic_X = 
                -0.7182
                +
                0.1451 * endomorphic_sum
                +
                - 0.00068 * (endomorphic_sum * endomorphic_sum)
                +
                0.0000014 * (endomorphic_sum * endomorphic_sum * endomorphic_sum)
            ;

        return endomorhpic_X;
    }
    
    const double const_skinfold_SubTriceps = 7.0;
    const double const_skinfold_SubScapular = 6.0;
    const double const_skinfold_SupraIliac = 4.0;
    const double const_Height = 191.7;
    const double const_p_178_18 = 170.18;
    const double const_n_0_7182 = -0.7182;
    const double const_p_0_1451 = 0.1451;
    const double const_p_0_00068 = 0.00068;
    const double const_p_0_0000014 = 0.0000014;

    [Benchmark]
    [Arguments(7.0, 6.0, 4.0, 191.7)]
    public
        double
                                        Calculate_Somatotype_Endomorphic_Constants
                                        (
                                            double skinfold_SubTriceps,
                                            double skinfold_SubScapular,
                                            double skinfold_SupraIliac,
                                            double Height
                                        )
    {
        
        double endomorphic_sum =
                                (
                                    skinfold_SubTriceps
                                    +
                                    skinfold_SubScapular
                                    +
                                    skinfold_SupraIliac
                                )
                                * const_p_178_18 / const_Height
                            ;

        double endomorhpic_X = 
                const_n_0_7182
                +
                const_p_0_1451 * endomorphic_sum
                +
                - const_p_0_00068 * (endomorphic_sum * endomorphic_sum)
                +
                const_p_0_0000014 * (endomorphic_sum * endomorphic_sum * endomorphic_sum)
            ;

        return endomorhpic_X;
    }
    

}
