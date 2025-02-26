```

BenchmarkDotNet v0.13.12, macOS Sonoma 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.100-preview.1.24101.2
  [Host]     : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD


```
| Method                 | Mean           | Error        | StdDev        |
|----------------------- |---------------:|-------------:|--------------:|
| DoWork_IfEnabled_true  | 3,282,588.4 ns | 64,901.76 ns | 113,670.20 ns |
| DoWork_IfEnabled_false |       315.8 ns |      4.17 ns |       3.90 ns |
| DoWork_Delegate        | 3,394,852.6 ns | 66,603.05 ns | 131,467.93 ns |
| DoWork_Delegate_null   |             NA |           NA |            NA |
| DoWork_Delegate_NoOp   |       336.5 ns |      3.25 ns |       2.72 ns |

Benchmarks with issues:
  ControlStructures_IfEnabled_VS_Delegate.DoWork_Delegate_null: DefaultJob
