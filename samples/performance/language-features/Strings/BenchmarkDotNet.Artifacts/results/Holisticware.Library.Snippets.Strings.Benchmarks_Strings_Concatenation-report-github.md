```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M4 Max, 1 CPU, 16 logical and 16 physical cores
.NET SDK 9.0.303
  [Host]   : .NET 9.0.8 (9.0.825.36510), Arm64 RyuJIT AdvSIMD
  .NET 8.0 : .NET 8.0.19 (8.0.1925.36006), Arm64 RyuJIT AdvSIMD
  .NET 9.0 : .NET 9.0.8 (9.0.825.36510), Arm64 RyuJIT AdvSIMD


```
| Method                                       | Runtime  | Mean      | Error     | StdDev    | Gen0   | Allocated |
|--------------------------------------------- |--------- |----------:|----------:|----------:|-------:|----------:|
| StringCreate_Complex                         | .NET 8.0 |  11.72 ns |  0.025 ns |  0.024 ns | 0.0086 |      72 B |
| StringCreate_Complex                         | .NET 9.0 |  13.61 ns |  0.056 ns |  0.052 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 8.0 |  15.60 ns |  0.057 ns |  0.051 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 9.0 |  16.88 ns |  0.026 ns |  0.022 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 9.0 |  16.96 ns |  0.170 ns |  0.159 ns | 0.0086 |      72 B |
| String_Interpolation                         | .NET 9.0 |  23.42 ns |  0.107 ns |  0.095 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 8.0 |  24.41 ns |  0.061 ns |  0.054 ns | 0.0153 |     128 B |
| Cysharp_Text_ZString_Concat                  | .NET 9.0 |  27.43 ns |  0.038 ns |  0.036 ns | 0.0086 |      72 B |
| String_Interpolation                         | .NET 8.0 |  27.52 ns |  0.033 ns |  0.029 ns | 0.0086 |      72 B |
| Cysharp_Text_ZString_Concat                  | .NET 8.0 |  27.67 ns |  0.030 ns |  0.027 ns | 0.0086 |      72 B |
| StringBuilderExact24                         | .NET 8.0 |  28.07 ns |  0.078 ns |  0.069 ns | 0.0229 |     192 B |
| StringBuilderExact24                         | .NET 9.0 |  28.63 ns |  0.081 ns |  0.068 ns | 0.0229 |     192 B |
| StringBuilderEstimate100                     | .NET 8.0 |  32.91 ns |  0.120 ns |  0.112 ns | 0.0411 |     344 B |
| StringBuilderEstimate100                     | .NET 9.0 |  33.50 ns |  0.070 ns |  0.066 ns | 0.0411 |     344 B |
| ValueStringBuilder_Append                    | .NET 9.0 |  33.72 ns |  0.211 ns |  0.198 ns | 0.0086 |      72 B |
| String_Concat                                | .NET 9.0 |  33.91 ns |  0.583 ns |  0.546 ns | 0.0181 |     152 B |
| StringAddition                               | .NET 9.0 |  34.15 ns |  0.456 ns |  0.426 ns | 0.0181 |     152 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 9.0 |  34.82 ns |  0.471 ns |  0.440 ns | 0.0181 |     152 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 8.0 |  37.02 ns |  0.265 ns |  0.207 ns | 0.0181 |     152 B |
| StringAddition                               | .NET 8.0 |  37.98 ns |  0.788 ns |  0.773 ns | 0.0181 |     152 B |
| Cysharp_Text_ZString_Join                    | .NET 9.0 |  38.96 ns |  0.137 ns |  0.128 ns | 0.0153 |     128 B |
| String_Concat                                | .NET 8.0 |  39.23 ns |  0.822 ns |  1.751 ns | 0.0181 |     152 B |
| Cysharp_Text_ZString_Join                    | .NET 8.0 |  41.89 ns |  0.042 ns |  0.038 ns | 0.0153 |     128 B |
| StringBuilder                                | .NET 8.0 |  44.60 ns |  0.048 ns |  0.042 ns | 0.0334 |     280 B |
| ValueStringBuilder_Append                    | .NET 8.0 |  44.90 ns |  0.062 ns |  0.058 ns | 0.0086 |      72 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 9.0 |  45.16 ns |  0.130 ns |  0.116 ns | 0.0181 |     152 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 8.0 |  47.00 ns |  0.122 ns |  0.114 ns | 0.0334 |     280 B |
| StringBuilder                                | .NET 9.0 |  47.97 ns |  0.138 ns |  0.129 ns | 0.0334 |     280 B |
| String_Format                                | .NET 9.0 |  48.19 ns |  0.106 ns |  0.099 ns | 0.0086 |      72 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 8.0 |  48.44 ns |  0.988 ns |  0.924 ns | 0.0181 |     152 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 9.0 |  49.41 ns |  0.161 ns |  0.151 ns | 0.0334 |     280 B |
| String_Format                                | .NET 8.0 |  74.02 ns |  0.553 ns |  0.491 ns | 0.0153 |     128 B |
| Cysharp_Text_ZString_Format                  | .NET 9.0 |  83.55 ns |  0.395 ns |  0.350 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Format                  | .NET 8.0 |  93.94 ns |  0.987 ns |  0.923 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 8.0 | 732.72 ns |  8.988 ns |  8.407 ns | 7.8125 |   65632 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 9.0 | 852.28 ns | 11.634 ns | 10.883 ns | 7.8125 |   65632 B |
