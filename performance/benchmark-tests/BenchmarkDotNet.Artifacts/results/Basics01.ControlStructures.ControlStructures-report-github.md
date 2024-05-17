```

BenchmarkDotNet v0.13.12, macOS Sonoma 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.100-preview.1.24101.2
  [Host]     : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD


```
| Method                 | Mean     | Error     | StdDev    |
|----------------------- |---------:|----------:|----------:|
| If_PatternMatching     | 5.106 ns | 0.0471 ns | 0.0393 ns |
| If_RelationalOperators | 8.499 ns | 0.0623 ns | 0.0583 ns |
