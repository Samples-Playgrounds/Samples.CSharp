```

BenchmarkDotNet v0.13.12, macOS Sonoma 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.100-preview.1.24101.2
  [Host]     : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD


```
| Method                                                    | Mean      | Error     | StdDev    |
|---------------------------------------------------------- |----------:|----------:|----------:|
| Foreach_Over_Array_Sum_As_Double                          |  4.369 ns | 0.1008 ns | 0.0943 ns |
| For_Over_Array_Sum_As_Double_Length_Recalculated          |  5.768 ns | 0.0730 ns | 0.0682 ns |
| For_Over_Array_Sum_As_Double_Length_PreCalculted_long     |  5.016 ns | 0.0623 ns | 0.0582 ns |
| For_Over_Array_Sum_As_Double_Length_PreCalculted_int      |  4.618 ns | 0.0524 ns | 0.0437 ns |
| LINQ_Method_Syntax_Over_Array                             |  3.241 ns | 0.0361 ns | 0.0301 ns |
| LINQ_Query_Syntax_Over_Array_                             | 28.393 ns | 0.3868 ns | 0.3618 ns |
| Foreach_Over_Span_With_Sum_As_Double                      |  3.971 ns | 0.0504 ns | 0.0472 ns |
| For_Over_Span_With_Sum_As_Double_Length_Recalculated      |  3.957 ns | 0.0635 ns | 0.0594 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long |  4.240 ns | 0.0499 ns | 0.0467 ns |
| For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int  |  4.247 ns | 0.0514 ns | 0.0480 ns |
