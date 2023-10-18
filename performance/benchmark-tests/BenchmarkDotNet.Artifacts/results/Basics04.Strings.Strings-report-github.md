``` ini

BenchmarkDotNet=v0.13.5, OS=macOS 14.0 (23A344) [Darwin 23.0.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
|                        Method |     Mean |     Error |    StdDev |
|------------------------------ |---------:|----------:|----------:|
|            IndexOf_String_API | 5.609 μs | 0.1112 μs | 0.1484 μs |
| IndexOf_With_Pattern_Matching | 5.529 μs | 0.1105 μs | 0.1182 μs |
