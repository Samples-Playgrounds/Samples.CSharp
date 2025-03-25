# Benchmrks for Method Calls

readme.md

*   https://dev.to/aloneguid/c-net-method-call-performance-facts-1koi

    *   https://www.aloneguid.uk/posts/2021/05/csharp-method-call-performance/

*   https://stackoverflow.com/questions/12279438/performance-of-static-methods-vs-instance-methods

*   https://stackoverflow.com/questions/2142062/are-static-methods-more-efficient


## Results

### 20250325

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.2.25164.34
[Host]   : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
.NET 9.0 : .NET 9.0.3 (9.0.325.11113), Arm64 RyuJIT AdvSIMD
.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
```


| Method                              | Runtime  | arg        | Mean       | Error     | StdDev    | Median     | Gen0   | Allocated |
|------------------------------------ |--------- |----------- |-----------:|----------:|----------:|-----------:|-------:|----------:|
| InstanceMethodDouble                | .NET 9.0 | -434234723 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 9.0 | -434234723 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| StaticMethodDouble                  | .NET 8.0 | -2         |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| StaticMethodDouble                  | .NET 9.0 | -2         |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| InstanceMethodDouble                | .NET 9.0 | -2         |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 9.0 | -2         |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| StaticMethodDouble                  | .NET 9.0 | 2          |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| InstanceMethodDouble                | .NET 9.0 | 2          |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 9.0 | 2          |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| InstanceMethodDouble                | .NET 9.0 | 434234723  |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| StaticMethodDouble                  | .NET 8.0 | 2          |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      - |         - |
| StaticMethodDouble                  | .NET 9.0 | 434234723  |  0.0009 ns | 0.0014 ns | 0.0012 ns |  0.0004 ns |      - |         - |
| StaticMethodDouble                  | .NET 9.0 | -434234723 |  0.0011 ns | 0.0015 ns | 0.0013 ns |  0.0008 ns |      - |         - |
| StaticMethodDouble                  | .NET 8.0 | -434234723 |  0.0013 ns | 0.0017 ns | 0.0015 ns |  0.0008 ns |      - |         - |
| StaticMethodDouble                  | .NET 8.0 | 434234723  |  0.0051 ns | 0.0042 ns | 0.0037 ns |  0.0051 ns |      - |         - |
| InstanceMethodDouble                | .NET 8.0 | -2         |  0.0384 ns | 0.0020 ns | 0.0018 ns |  0.0384 ns |      - |         - |
| InstanceMethodDouble                | .NET 8.0 | 434234723  |  0.0511 ns | 0.0037 ns | 0.0035 ns |  0.0512 ns |      - |         - |
| InstanceMethodDouble                | .NET 8.0 | -434234723 |  0.0521 ns | 0.0039 ns | 0.0035 ns |  0.0528 ns |      - |         - |
| InstanceMethodDouble                | .NET 8.0 | 2          |  0.0595 ns | 0.0025 ns | 0.0023 ns |  0.0597 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 8.0 | -434234723 |  0.0637 ns | 0.0032 ns | 0.0030 ns |  0.0630 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 8.0 | -2         |  0.0640 ns | 0.0021 ns | 0.0020 ns |  0.0639 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 8.0 | 434234723  |  0.0653 ns | 0.0033 ns | 0.0029 ns |  0.0662 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 8.0 | 2          |  0.0659 ns | 0.0017 ns | 0.0016 ns |  0.0660 ns |      - |         - |
| InstanceMethodDoubleViaFuncDelegate | .NET 9.0 | 434234723  |  0.0827 ns | 0.0029 ns | 0.0027 ns |  0.0828 ns |      - |         - |
| InstanceMethodDoubleAsync           | .NET 9.0 | 2          |  0.8178 ns | 0.0063 ns | 0.0059 ns |  0.8181 ns |      - |         - |
| InstanceMethodDoubleAsync           | .NET 8.0 | 2          |  0.8700 ns | 0.0051 ns | 0.0048 ns |  0.8699 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 9.0 | 434234723  |  0.9032 ns | 0.0033 ns | 0.0029 ns |  0.9033 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 8.0 | 434234723  |  0.9042 ns | 0.0056 ns | 0.0052 ns |  0.9028 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 8.0 | -434234723 |  0.9056 ns | 0.0035 ns | 0.0033 ns |  0.9054 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 8.0 | 2          |  0.9073 ns | 0.0033 ns | 0.0028 ns |  0.9083 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 9.0 | -2         |  0.9078 ns | 0.0033 ns | 0.0031 ns |  0.9077 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 9.0 | -434234723 |  0.9089 ns | 0.0037 ns | 0.0033 ns |  0.9094 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 9.0 | 2          |  0.9127 ns | 0.0067 ns | 0.0056 ns |  0.9135 ns |      - |         - |
| StaticMethodDoubleViaFuncDelegate   | .NET 8.0 | -2         |  0.9136 ns | 0.0057 ns | 0.0054 ns |  0.9148 ns |      - |         - |
| StaticMethodDoubleAsync             | .NET 9.0 | 2          |  6.5835 ns | 0.0244 ns | 0.0228 ns |  6.5862 ns |      - |         - |
| InstanceMethodDoubleAsync           | .NET 8.0 | -434234723 |  6.6187 ns | 0.0184 ns | 0.0164 ns |  6.6232 ns | 0.0086 |      72 B |
| InstanceMethodDoubleAsync           | .NET 8.0 | 434234723  |  6.6287 ns | 0.0352 ns | 0.0294 ns |  6.6297 ns | 0.0086 |      72 B |
| InstanceMethodDoubleAsync           | .NET 8.0 | -2         |  6.7267 ns | 0.0262 ns | 0.0232 ns |  6.7204 ns | 0.0086 |      72 B |
| InstanceMethodDoubleAsync           | .NET 9.0 | -2         |  6.7957 ns | 0.0361 ns | 0.0338 ns |  6.7895 ns | 0.0086 |      72 B |
| InstanceMethodDoubleAsync           | .NET 9.0 | -434234723 |  6.8405 ns | 0.0204 ns | 0.0191 ns |  6.8421 ns | 0.0086 |      72 B |
| InstanceMethodDoubleAsync           | .NET 9.0 | 434234723  |  6.8442 ns | 0.0348 ns | 0.0326 ns |  6.8444 ns | 0.0086 |      72 B |
| StaticMethodDoubleAsync             | .NET 8.0 | 434234723  | 16.9565 ns | 0.1202 ns | 0.1124 ns | 16.9087 ns | 0.0172 |     144 B |
| StaticMethodDoubleAsync             | .NET 8.0 | -434234723 | 17.1161 ns | 0.0389 ns | 0.0345 ns | 17.1244 ns | 0.0172 |     144 B |
| StaticMethodDoubleAsync             | .NET 9.0 | -434234723 | 17.2884 ns | 0.0794 ns | 0.0743 ns | 17.3050 ns | 0.0172 |     144 B |
| StaticMethodDoubleAsync             | .NET 8.0 | -2         | 17.2894 ns | 0.0844 ns | 0.0705 ns | 17.2731 ns | 0.0172 |     144 B |
| StaticMethodDoubleAsync             | .NET 9.0 | -2         | 17.3323 ns | 0.0507 ns | 0.0449 ns | 17.3382 ns | 0.0172 |     144 B |
| StaticMethodDoubleAsync             | .NET 9.0 | 434234723  | 17.3370 ns | 0.0572 ns | 0.0535 ns | 17.3416 ns | 0.0172 |     144 B |
| StaticMethodDoubleAsync             | .NET 8.0 | 2          | 26.2463 ns | 0.0817 ns | 0.0764 ns | 26.2237 ns |      - |         - |



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

