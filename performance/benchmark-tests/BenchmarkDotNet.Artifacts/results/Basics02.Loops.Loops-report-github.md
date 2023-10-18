``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.0 (23A344) [Darwin 23.0.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
|                                                    Method |      Mean |     Error |    StdDev |
|---------------------------------------------------------- |----------:|----------:|----------:|
|                          Foreach_Over_Array_Sum_As_Double |  6.091 ns | 0.0842 ns | 0.0704 ns |
|          For_Over_Array_Sum_As_Double_Length_Recalculated |  7.386 ns | 0.1503 ns | 0.1954 ns |
|     For_Over_Array_Sum_As_Double_Length_PreCalculted_long |  9.531 ns | 0.1763 ns | 0.1810 ns |
|      For_Over_Array_Sum_As_Double_Length_PreCalculted_int |  7.192 ns | 0.1273 ns | 0.0994 ns |
|                             LINQ_Method_Syntax_Over_Array |  7.343 ns | 0.0634 ns | 0.0529 ns |
|                             LINQ_Query_Syntax_Over_Array_ | 49.376 ns | 0.2477 ns | 0.2196 ns |
|                      Foreach_Over_Span_With_Sum_As_Double |  6.286 ns | 0.0752 ns | 0.0667 ns |
|      For_Over_Span_With_Sum_As_Double_Length_Recalculated |  6.210 ns | 0.0519 ns | 0.0433 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long |  7.443 ns | 0.1337 ns | 0.1185 ns |
|  For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int |  6.743 ns | 0.0477 ns | 0.0446 ns |
