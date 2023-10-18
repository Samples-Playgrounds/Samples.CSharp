``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.0 (23A344) [Darwin 23.0.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
|                 Method |     Mean |     Error |    StdDev |
|----------------------- |---------:|----------:|----------:|
|     If_PatternMatching | 8.911 ns | 0.1147 ns | 0.1016 ns |
| If_RelationalOperators | 7.381 ns | 0.1040 ns | 0.0869 ns |
