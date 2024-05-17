```

BenchmarkDotNet v0.13.12, macOS Sonoma 14.3.1 (23D60) [Darwin 23.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.100-preview.1.24101.2
  [Host]     : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.0 (9.0.24.8009), Arm64 RyuJIT AdvSIMD


```
| Method                        | Mean     | Error     | StdDev    |
|------------------------------ |---------:|----------:|----------:|
| IndexOf_String_API            | 3.312 μs | 0.0643 μs | 0.0741 μs |
| IndexOf_With_Pattern_Matching | 3.330 μs | 0.0650 μs | 0.1069 μs |
