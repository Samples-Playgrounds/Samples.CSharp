# Benchmrks for Method Calls

readme.md

*   https://dev.to/aloneguid/c-net-method-call-performance-facts-1koi




## Results


### 20250324

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.2.25164.34
[Host]   : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
.NET 9.0 : .NET 9.0.3 (9.0.325.11113), Arm64 RyuJIT AdvSIMD
.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
```


| Method                    | Runtime  | Mean      | Error     | StdDev    | Median    | Allocated |
|-------------------------- |--------- |----------:|----------:|----------:|----------:|----------:|
| InstanceMethodDouble      | .NET 9.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         - |
| StaticMethodDouble        | .NET 8.0 | 0.0010 ns | 0.0012 ns | 0.0011 ns | 0.0011 ns |         - |
| StaticMethodDouble        | .NET 9.0 | 0.0040 ns | 0.0032 ns | 0.0028 ns | 0.0048 ns |         - |
| InstanceMethodDouble      | .NET 8.0 | 0.0343 ns | 0.0020 ns | 0.0019 ns | 0.0347 ns |         - |
| InstanceMethodDoubleAsync | .NET 9.0 | 0.6056 ns | 0.0039 ns | 0.0036 ns | 0.6059 ns |         - |
| InstanceMethodDoubleAsync | .NET 8.0 | 0.8697 ns | 0.0033 ns | 0.0029 ns | 0.8702 ns |         - |
| StaticMethodDoubleAsync   | .NET 9.0 | 6.0815 ns | 0.0261 ns | 0.0231 ns | 6.0766 ns |         - |
| StaticMethodDoubleAsync   | .NET 8.0 | 6.5021 ns | 0.0151 ns | 0.0134 ns | 6.5026 ns |         - |

