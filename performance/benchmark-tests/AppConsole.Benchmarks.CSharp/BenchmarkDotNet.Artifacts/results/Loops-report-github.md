``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.0 (23A344) [Darwin 23.0.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2


```
|                                                    Method |       Mean |     Error |    StdDev |     Median |
|---------------------------------------------------------- |-----------:|----------:|----------:|-----------:|
|                          Foreach_Over_Array_Sum_As_Double |   8.112 ns | 0.1751 ns | 0.1552 ns |   8.047 ns |
|          For_Over_Array_Sum_As_Double_Length_Recalculated |   7.584 ns | 0.1902 ns | 0.4701 ns |   7.356 ns |
|     For_Over_Array_Sum_As_Double_Length_PreCalculted_long |   9.657 ns | 0.0553 ns | 0.0432 ns |   9.654 ns |
|      For_Over_Array_Sum_As_Double_Length_PreCalculted_int |   9.717 ns | 0.1651 ns | 0.1378 ns |   9.674 ns |
|                             LINQ_Method_Syntax_Over_Array |  73.250 ns | 0.2338 ns | 0.2187 ns |  73.192 ns |
|                             LINQ_Query_Syntax_Over_Array_ | 126.144 ns | 1.2367 ns | 1.0327 ns | 125.720 ns |
|                      Foreach_Over_Span_With_Sum_As_Double |   7.029 ns | 0.1062 ns | 0.0887 ns |   7.039 ns |
|      For_Over_Span_With_Sum_As_Double_Length_Recalculated |   6.535 ns | 0.0578 ns | 0.0483 ns |   6.548 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long |   7.491 ns | 0.1341 ns | 0.1255 ns |   7.449 ns |
|  For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int |   7.021 ns | 0.1252 ns | 0.1110 ns |   7.004 ns |
