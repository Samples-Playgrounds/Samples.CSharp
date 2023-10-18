``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.0 (23A344) [Darwin 23.0.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2


```
|                 Method |     Mean |     Error |    StdDev |
|----------------------- |---------:|----------:|----------:|
|     If_PatternMatching | 8.459 ns | 0.0459 ns | 0.0358 ns |
| If_RelationalOperators | 8.492 ns | 0.1763 ns | 0.1649 ns |
