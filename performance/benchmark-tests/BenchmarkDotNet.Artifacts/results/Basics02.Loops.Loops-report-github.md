``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.0 (23A344) [Darwin 23.0.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
|                                                    Method |      Mean |     Error |    StdDev |
|---------------------------------------------------------- |----------:|----------:|----------:|
|                          Foreach_Over_Array_Sum_As_Double |  6.001 ns | 0.0707 ns | 0.0627 ns |
|          For_Over_Array_Sum_As_Double_Length_Recalculated |  7.339 ns | 0.1747 ns | 0.1548 ns |
|     For_Over_Array_Sum_As_Double_Length_PreCalculted_long |  9.485 ns | 0.1193 ns | 0.0996 ns |
|      For_Over_Array_Sum_As_Double_Length_PreCalculted_int |  7.143 ns | 0.0442 ns | 0.0369 ns |
|                             LINQ_Method_Syntax_Over_Array |  7.306 ns | 0.0708 ns | 0.0591 ns |
|                             LINQ_Query_Syntax_Over_Array_ | 49.655 ns | 0.1990 ns | 0.1764 ns |
|                      Foreach_Over_Span_With_Sum_As_Double |  6.240 ns | 0.0356 ns | 0.0333 ns |
|      For_Over_Span_With_Sum_As_Double_Length_Recalculated |  6.257 ns | 0.0549 ns | 0.0428 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long |  7.413 ns | 0.0827 ns | 0.0774 ns |
|  For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int |  6.900 ns | 0.1729 ns | 0.1850 ns |
