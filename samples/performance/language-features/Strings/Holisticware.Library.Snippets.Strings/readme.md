# Benchmrks for `String`

readme.md

## Strings

*   https://www.meziantou.net/some-performance-tricks-with-dotnet-strings.htm

### Create / Join/ Concatenate

https://apisof.net/catalog/0ea2d97d848a21bf37885c4d35fcad2a

### Split

*   https://www.infoworld.com/article/3626790/how-to-split-strings-efficiently-in-c-sharp.html

*   https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm
  
*   https://endjin.com/blog/2023/09/optimising-dotnet-code-4-avoiding-allocations-using-span-t

*   https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm

*   https://stackoverflow.com/questions/77343199/string-split-for-span

*   https://medium.com/codenx/net-9-readonlyspan-char-split-947d6e1211e6

*   https://clipperhouse.com/split/

    *   https://github.com/clipperhouse/Split.net

https://www.azalio.io/how-to-split-strings-efficiently-in-c/

https://www.answeroverflow.com/m/1078607141134401616

#### `StringTokenizer`

*   https://learn.microsoft.com/en-us/dotnet/core/extensions/primitives#the-stringtokenizer-type  

*   https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.primitives.stringtokenizer

## Results

### 20250812

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.6 (24G84) [Darwin 24.6.0]
Apple M4 Max, 1 CPU, 16 logical and 16 physical cores
.NET SDK 9.0.303
[Host]   : .NET 8.0.19 (8.0.1925.36514), Arm64 RyuJIT AdvSIMD
.NET 8.0 : .NET 8.0.19 (8.0.1925.36514), Arm64 RyuJIT AdvSIMD
.NET 9.0 : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
```


| Method                                       | Runtime  | Mean      | Error     | StdDev    | Gen0   | Allocated |
|--------------------------------------------- |--------- |----------:|----------:|----------:|-------:|----------:|
| StringCreate_Complex                         | .NET 8.0 |  11.68 ns |  0.015 ns |  0.013 ns | 0.0086 |      72 B |
| StringCreate_Complex                         | .NET 9.0 |  13.57 ns |  0.033 ns |  0.029 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 8.0 |  15.19 ns |  0.040 ns |  0.034 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 9.0 |  16.58 ns |  0.038 ns |  0.036 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 9.0 |  17.02 ns |  0.027 ns |  0.024 ns | 0.0086 |      72 B |
| String_Interpolation                         | .NET 9.0 |  23.59 ns |  0.035 ns |  0.033 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 8.0 |  24.01 ns |  0.092 ns |  0.086 ns | 0.0153 |     128 B |
| String_Interpolation                         | .NET 8.0 |  26.83 ns |  0.024 ns |  0.022 ns | 0.0086 |      72 B |
| Cysharp_Text_ZString_Concat                  | .NET 8.0 |  26.95 ns |  0.034 ns |  0.031 ns | 0.0086 |      72 B |
| StringBuilderExact24                         | .NET 8.0 |  27.07 ns |  0.057 ns |  0.053 ns | 0.0229 |     192 B |
| Cysharp_Text_ZString_Concat                  | .NET 9.0 |  27.14 ns |  0.103 ns |  0.080 ns | 0.0086 |      72 B |
| StringBuilderExact24                         | .NET 9.0 |  28.52 ns |  0.056 ns |  0.053 ns | 0.0229 |     192 B |
| StringBuilderEstimate100                     | .NET 8.0 |  31.92 ns |  0.086 ns |  0.081 ns | 0.0411 |     344 B |
| StringBuilderEstimate100                     | .NET 9.0 |  33.08 ns |  0.065 ns |  0.060 ns | 0.0411 |     344 B |
| String_Concat                                | .NET 9.0 |  33.19 ns |  0.150 ns |  0.140 ns | 0.0181 |     152 B |
| StringAddition                               | .NET 9.0 |  33.58 ns |  0.342 ns |  0.320 ns | 0.0181 |     152 B |
| ValueStringBuilder_Append                    | .NET 9.0 |  33.99 ns |  0.083 ns |  0.078 ns | 0.0086 |      72 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 9.0 |  34.62 ns |  0.215 ns |  0.180 ns | 0.0181 |     152 B |
| Cysharp_Text_ZaString_                       | .NET 8.0 |  36.90 ns |  0.116 ns |  0.109 ns | 0.0086 |      72 B |
| String_Concat                                | .NET 8.0 |  37.37 ns |  0.767 ns |  0.941 ns | 0.0181 |     152 B |
| StringAddition                               | .NET 8.0 |  37.52 ns |  0.791 ns |  1.135 ns | 0.0181 |     152 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 8.0 |  38.53 ns |  0.768 ns |  0.788 ns | 0.0181 |     152 B |
| Cysharp_Text_ZString_Join                    | .NET 9.0 |  39.52 ns |  0.197 ns |  0.184 ns | 0.0153 |     128 B |
| Cysharp_Text_ZaString_                       | .NET 9.0 |  40.21 ns |  0.241 ns |  0.225 ns | 0.0086 |      72 B |
| Cysharp_Text_ZString_Join                    | .NET 8.0 |  42.26 ns |  0.146 ns |  0.137 ns | 0.0153 |     128 B |
| StringBuilder                                | .NET 8.0 |  44.68 ns |  0.176 ns |  0.164 ns | 0.0334 |     280 B |
| ValueStringBuilder_Append                    | .NET 8.0 |  45.10 ns |  0.210 ns |  0.196 ns | 0.0086 |      72 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 9.0 |  45.71 ns |  0.343 ns |  0.321 ns | 0.0181 |     152 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 8.0 |  46.20 ns |  0.164 ns |  0.153 ns | 0.0334 |     280 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 8.0 |  47.29 ns |  0.165 ns |  0.146 ns | 0.0181 |     152 B |
| String_Format                                | .NET 9.0 |  47.92 ns |  0.042 ns |  0.035 ns | 0.0086 |      72 B |
| StringBuilder                                | .NET 9.0 |  48.01 ns |  0.139 ns |  0.130 ns | 0.0334 |     280 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 9.0 |  49.65 ns |  0.161 ns |  0.151 ns | 0.0334 |     280 B |
| String_Format                                | .NET 8.0 |  76.99 ns |  0.354 ns |  0.331 ns | 0.0153 |     128 B |
| Cysharp_Text_ZString_Format                  | .NET 9.0 |  84.04 ns |  0.590 ns |  0.552 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Format                  | .NET 8.0 |  93.83 ns |  1.267 ns |  1.185 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 8.0 | 706.19 ns | 11.272 ns | 10.544 ns | 7.8125 |   65632 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 9.0 | 793.98 ns | 10.547 ns |  9.866 ns | 7.8125 |   65632 B |

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.6 (24G84) [Darwin 24.6.0]
Apple M4 Max, 1 CPU, 16 logical and 16 physical cores
.NET SDK 9.0.303
[Host]   : .NET 8.0.19 (8.0.1925.36514), Arm64 RyuJIT AdvSIMD
.NET 8.0 : .NET 8.0.19 (8.0.1925.36514), Arm64 RyuJIT AdvSIMD
.NET 9.0 : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
```

| Method                                    | Runtime  | input                | delimiter | delimiters | Mean       | Error     | StdDev    | Gen0   | Allocated |
|------------------------------------------ |--------- |--------------------- |---------- |----------- |-----------:|----------:|----------:|-------:|----------:|
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [82] | \t        | ?          |   2.451 ns | 0.0106 ns | 0.0089 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [78] | \t        | ?          |   2.466 ns | 0.0118 ns | 0.0111 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ;         | ?          |   2.709 ns | 0.0127 ns | 0.0113 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ,         | ?          |   2.713 ns | 0.0152 ns | 0.0142 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ;         | ?          |   2.779 ns | 0.0095 ns | 0.0084 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ,         | ?          |   2.787 ns | 0.0148 ns | 0.0131 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [78] | \t        | ?          |   3.176 ns | 0.0147 ns | 0.0138 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ,         | ?          |   3.514 ns | 0.0240 ns | 0.0212 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [82] | \t        | ?          |   3.517 ns | 0.0072 ns | 0.0060 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ;         | ?          |   3.520 ns | 0.0083 ns | 0.0074 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ,         | ?          |   3.531 ns | 0.0134 ns | 0.0125 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ;         | ?          |   3.532 ns | 0.0362 ns | 0.0283 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | ?         | Char[1]    | 128.324 ns | 0.5921 ns | 0.5249 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | ?         | Char[2]    | 131.172 ns | 0.4931 ns | 0.4118 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | ?         | Char[2]    | 131.715 ns | 0.4330 ns | 0.3839 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | ?         | Char[1]    | 138.439 ns | 0.7859 ns | 0.7351 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | ?         | Char[2]    | 139.241 ns | 1.2182 ns | 1.0799 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | ?         | Char[2]    | 140.874 ns | 1.7254 ns | 1.6139 ns | 0.0706 |     592 B |



### 20250321

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.2.25164.34
[Host]   : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
.NET 9.0 : .NET 9.0.3 (9.0.325.11113), Arm64 RyuJIT AdvSIMD
```


| Method                                    | Runtime  | input                | delimiters | Mean      | Error    | StdDev   | Gen0   | Allocated |
|------------------------------------------ |--------- |--------------------- |----------- |----------:|---------:|---------:|-------:|----------:|
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | Char[2]    |  71.98 ns | 0.160 ns | 0.150 ns | 0.0497 |     416 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | Char[1]    |  72.20 ns | 0.225 ns | 0.200 ns | 0.0497 |     416 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | Char[2]    |  75.09 ns | 0.167 ns | 0.156 ns | 0.0497 |     416 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | Char[1]    |  77.78 ns | 0.240 ns | 0.201 ns | 0.0497 |     416 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | Char[2]    |  78.32 ns | 0.220 ns | 0.195 ns | 0.0497 |     416 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | Char[2]    |  78.52 ns | 0.207 ns | 0.183 ns | 0.0497 |     416 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | Char[2]    | 123.77 ns | 0.365 ns | 0.342 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | Char[2]    | 123.96 ns | 0.345 ns | 0.305 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | Char[1]    | 128.75 ns | 0.229 ns | 0.191 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | Char[2]    | 161.61 ns | 0.261 ns | 0.244 ns | 0.0707 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | Char[2]    | 161.72 ns | 0.257 ns | 0.227 ns | 0.0707 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | Char[1]    | 161.92 ns | 0.180 ns | 0.168 ns | 0.0707 |     592 B |

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.2.25164.34
[Host]   : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), Arm64 RyuJIT AdvSIMD
.NET 9.0 : .NET 9.0.3 (9.0.325.11113), Arm64 RyuJIT AdvSIMD
```

| Method                                       | Runtime  | Mean      | Error    | StdDev   | Gen0   | Allocated |
|--------------------------------------------- |--------- |----------:|---------:|---------:|-------:|----------:|
| StringCreate_Complex                         | .NET 8.0 |  11.80 ns | 0.025 ns | 0.022 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 8.0 |  15.32 ns | 0.190 ns | 0.178 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 9.0 |  15.41 ns | 0.053 ns | 0.047 ns | 0.0086 |      72 B |
| StringCreate_Complex                         | .NET 9.0 |  15.48 ns | 0.028 ns | 0.023 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 9.0 |  18.62 ns | 0.040 ns | 0.034 ns | 0.0086 |      72 B |
| String_Interpolation                         | .NET 9.0 |  23.29 ns | 0.065 ns | 0.061 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 8.0 |  25.50 ns | 0.058 ns | 0.054 ns | 0.0153 |     128 B |
| StringBuilderExact24                         | .NET 8.0 |  25.96 ns | 0.067 ns | 0.056 ns | 0.0229 |     192 B |
| Cysharp_Text_ZString_Concat                  | .NET 8.0 |  26.87 ns | 0.053 ns | 0.050 ns | 0.0086 |      72 B |
| Cysharp_Text_ZString_Concat                  | .NET 9.0 |  26.88 ns | 0.054 ns | 0.045 ns | 0.0086 |      72 B |
| StringBuilderExact24                         | .NET 9.0 |  27.04 ns | 0.056 ns | 0.052 ns | 0.0229 |     192 B |
| String_Interpolation                         | .NET 8.0 |  27.08 ns | 0.072 ns | 0.060 ns | 0.0086 |      72 B |
| StringBuilderEstimate100                     | .NET 9.0 |  31.36 ns | 0.135 ns | 0.119 ns | 0.0411 |     344 B |
| String_Concat                                | .NET 9.0 |  33.46 ns | 0.071 ns | 0.063 ns | 0.0181 |     152 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 9.0 |  33.46 ns | 0.115 ns | 0.102 ns | 0.0181 |     152 B |
| StringBuilderEstimate100                     | .NET 8.0 |  34.24 ns | 0.102 ns | 0.096 ns | 0.0411 |     344 B |
| StringPlus                                   | .NET 9.0 |  35.63 ns | 0.100 ns | 0.093 ns | 0.0181 |     152 B |
| Cysharp_Text_ZString_Join                    | .NET 9.0 |  38.01 ns | 0.080 ns | 0.071 ns | 0.0153 |     128 B |
| StringPlus                                   | .NET 8.0 |  38.95 ns | 0.079 ns | 0.070 ns | 0.0181 |     152 B |
| String_Concat                                | .NET 8.0 |  39.03 ns | 0.098 ns | 0.087 ns | 0.0181 |     152 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 8.0 |  39.09 ns | 0.112 ns | 0.099 ns | 0.0181 |     152 B |
| Cysharp_Text_ZString_Join                    | .NET 8.0 |  41.20 ns | 0.139 ns | 0.130 ns | 0.0153 |     128 B |
| StringBuilder                                | .NET 8.0 |  45.44 ns | 0.146 ns | 0.137 ns | 0.0334 |     280 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 9.0 |  47.17 ns | 0.120 ns | 0.112 ns | 0.0181 |     152 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 8.0 |  47.37 ns | 0.116 ns | 0.109 ns | 0.0334 |     280 B |
| StringBuilder                                | .NET 9.0 |  47.80 ns | 0.091 ns | 0.076 ns | 0.0334 |     280 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 9.0 |  49.16 ns | 0.151 ns | 0.134 ns | 0.0334 |     280 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 8.0 |  50.98 ns | 0.140 ns | 0.131 ns | 0.0181 |     152 B |
| String_Format                                | .NET 9.0 |  51.16 ns | 0.129 ns | 0.121 ns | 0.0086 |      72 B |
| String_Format                                | .NET 8.0 |  76.11 ns | 0.194 ns | 0.172 ns | 0.0153 |     128 B |
| Cysharp_Text_ZString_Format                  | .NET 9.0 |  77.92 ns | 0.181 ns | 0.169 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Format                  | .NET 8.0 |  87.55 ns | 0.344 ns | 0.287 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 8.0 | 644.09 ns | 2.061 ns | 1.609 ns | 7.8125 |   65632 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 9.0 | 733.50 ns | 9.615 ns | 8.523 ns | 7.8125 |   65632 B |



### 20241222

| Method                                       | Runtime  | Mean      | Error    | StdDev   | Gen0   | Allocated |
|--------------------------------------------- |--------- |----------:|---------:|---------:|-------:|----------:|
| StringCreate_Complex                         | .NET 8.0 |  11.89 ns | 0.015 ns | 0.014 ns | 0.0086 |      72 B |
| StringCreate_Complex                         | .NET 9.0 |  12.98 ns | 0.051 ns | 0.045 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 8.0 |  15.05 ns | 0.035 ns | 0.031 ns | 0.0086 |      72 B |
| StringCreate_Simple                          | .NET 9.0 |  15.71 ns | 0.039 ns | 0.036 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 9.0 |  18.51 ns | 0.105 ns | 0.098 ns | 0.0086 |      72 B |
| String_Interpolation                         | .NET 9.0 |  23.50 ns | 0.048 ns | 0.045 ns | 0.0086 |      72 B |
| String_Join                                  | .NET 8.0 |  25.48 ns | 0.042 ns | 0.040 ns | 0.0153 |     128 B |
| String_Interpolation                         | .NET 8.0 |  26.78 ns | 0.065 ns | 0.060 ns | 0.0086 |      72 B |
| Cysharp_Text_ZString_Concat                  | .NET 9.0 |  26.91 ns | 0.058 ns | 0.052 ns | 0.0086 |      72 B |
| StringBuilderExact24                         | .NET 9.0 |  27.14 ns | 0.030 ns | 0.027 ns | 0.0229 |     192 B |
| Cysharp_Text_ZString_Concat                  | .NET 8.0 |  27.21 ns | 0.023 ns | 0.018 ns | 0.0086 |      72 B |
| StringBuilderExact24                         | .NET 8.0 |  30.10 ns | 0.082 ns | 0.069 ns | 0.0229 |     192 B |
| StringBuilderEstimate100                     | .NET 8.0 |  30.31 ns | 0.064 ns | 0.057 ns | 0.0411 |     344 B |
| StringBuilderEstimate100                     | .NET 9.0 |  31.33 ns | 0.171 ns | 0.151 ns | 0.0411 |     344 B |
| String_Concat                                | .NET 9.0 |  33.33 ns | 0.080 ns | 0.074 ns | 0.0181 |     152 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 9.0 |  33.82 ns | 0.099 ns | 0.092 ns | 0.0181 |     152 B |
| StringPlus                                   | .NET 9.0 |  35.52 ns | 0.135 ns | 0.113 ns | 0.0181 |     152 B |
| Cysharp_Text_ZString_Join                    | .NET 9.0 |  38.10 ns | 0.065 ns | 0.061 ns | 0.0153 |     128 B |
| StringPlus                                   | .NET 8.0 |  38.97 ns | 0.060 ns | 0.057 ns | 0.0181 |     152 B |
| String_Concat                                | .NET 8.0 |  39.06 ns | 0.085 ns | 0.075 ns | 0.0181 |     152 B |
| HolisticWare_Core_String_ConcatWithConcat    | .NET 8.0 |  39.94 ns | 0.231 ns | 0.193 ns | 0.0181 |     152 B |
| Cysharp_Text_ZString_Join                    | .NET 8.0 |  41.25 ns | 0.053 ns | 0.044 ns | 0.0153 |     128 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 8.0 |  47.96 ns | 0.113 ns | 0.100 ns | 0.0334 |     280 B |
| StringBuilder                                | .NET 9.0 |  48.05 ns | 0.163 ns | 0.153 ns | 0.0334 |     280 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 9.0 |  48.50 ns | 0.262 ns | 0.245 ns | 0.0181 |     152 B |
| StringBuilder_Core_Text_StringBuilderCache   | .NET 9.0 |  48.99 ns | 0.124 ns | 0.116 ns | 0.0334 |     280 B |
| HolisticWare_Core_String_ConcatWithJoin      | .NET 8.0 |  50.70 ns | 0.217 ns | 0.181 ns | 0.0181 |     152 B |
| String_Format                                | .NET 9.0 |  50.98 ns | 0.050 ns | 0.042 ns | 0.0086 |      72 B |
| StringBuilder                                | .NET 8.0 |  52.81 ns | 0.093 ns | 0.087 ns | 0.0334 |     280 B |
| String_Format                                | .NET 8.0 |  75.61 ns | 0.175 ns | 0.163 ns | 0.0153 |     128 B |
| Cysharp_Text_ZString_Format                  | .NET 9.0 |  77.62 ns | 0.156 ns | 0.146 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Format                  | .NET 8.0 |  86.62 ns | 0.241 ns | 0.226 ns | 0.0095 |      80 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 8.0 | 642.71 ns | 4.512 ns | 4.221 ns | 7.8125 |   65632 B |
| Cysharp_Text_ZString_Utf16ValueStringBuilder | .NET 9.0 | 753.77 ns | 6.522 ns | 5.446 ns | 7.8125 |   65632 B |


| Method                   | Runtime  | Mean      | Error    | StdDev   | Gen0   | Allocated |
|------------------------- |--------- |----------:|---------:|---------:|-------:|----------:|
| StringCreate_Complex     | .NET 8.0 |  11.82 ns | 0.049 ns | 0.043 ns | 0.0086 |      72 B |
| StringCreate_Complex     | .NET 9.0 |  12.92 ns | 0.053 ns | 0.050 ns | 0.0086 |      72 B |
| StringCreate_Simple      | .NET 8.0 |  15.07 ns | 0.046 ns | 0.043 ns | 0.0086 |      72 B |
| StringCreate_Simple      | .NET 9.0 |  15.61 ns | 0.090 ns | 0.079 ns | 0.0086 |      72 B |
| StringJoin               | .NET 9.0 |  18.52 ns | 0.057 ns | 0.053 ns | 0.0086 |      72 B |
| StringInterpolation      | .NET 9.0 |  23.47 ns | 0.062 ns | 0.058 ns | 0.0086 |      72 B |
| StringJoin               | .NET 8.0 |  25.43 ns | 0.061 ns | 0.057 ns | 0.0153 |     128 B |
| StringBuilderExact24     | .NET 8.0 |  26.12 ns | 0.035 ns | 0.030 ns | 0.0229 |     192 B |
| StringInterpolation      | .NET 8.0 |  26.76 ns | 0.049 ns | 0.044 ns | 0.0086 |      72 B |
| ZString_Concat           | .NET 9.0 |  26.88 ns | 0.089 ns | 0.079 ns | 0.0086 |      72 B |
| ZString_Concat           | .NET 8.0 |  27.00 ns | 0.112 ns | 0.100 ns | 0.0086 |      72 B |
| StringBuilderExact24     | .NET 9.0 |  27.02 ns | 0.076 ns | 0.067 ns | 0.0229 |     192 B |
| StringBuilderEstimate100 | .NET 9.0 |  31.34 ns | 0.114 ns | 0.107 ns | 0.0411 |     344 B |
| StringPlus               | .NET 9.0 |  33.32 ns | 0.123 ns | 0.109 ns | 0.0181 |     152 B |
| StringConcat             | .NET 9.0 |  33.33 ns | 0.088 ns | 0.078 ns | 0.0181 |     152 B |
| StringBuilderEstimate100 | .NET 8.0 |  33.85 ns | 0.114 ns | 0.106 ns | 0.0411 |     344 B |
| ZString_Join             | .NET 9.0 |  38.08 ns | 0.084 ns | 0.075 ns | 0.0153 |     128 B |
| StringPlus               | .NET 8.0 |  38.44 ns | 0.312 ns | 0.277 ns | 0.0181 |     152 B |
| StringConcat             | .NET 8.0 |  38.57 ns | 0.184 ns | 0.163 ns | 0.0181 |     152 B |
| ZString_Join             | .NET 8.0 |  41.14 ns | 0.133 ns | 0.125 ns | 0.0153 |     128 B |
| StringBuilder            | .NET 8.0 |  45.25 ns | 0.099 ns | 0.088 ns | 0.0334 |     280 B |
| StringBuilder            | .NET 9.0 |  47.85 ns | 0.105 ns | 0.098 ns | 0.0334 |     280 B |
| StringFormat             | .NET 9.0 |  51.48 ns | 0.122 ns | 0.114 ns | 0.0086 |      72 B |
| StringFormat             | .NET 8.0 |  75.98 ns | 0.235 ns | 0.196 ns | 0.0153 |     128 B |
| ZString_Format           | .NET 9.0 |  77.76 ns | 0.209 ns | 0.195 ns | 0.0095 |      80 B |
| ZString_Format           | .NET 8.0 |  85.62 ns | 0.301 ns | 0.282 ns | 0.0095 |      80 B |
| ZString_StringBuilder    | .NET 8.0 | 607.55 ns | 3.599 ns | 3.367 ns | 7.8125 |   65632 B |
| ZString_StringBuilder    | .NET 9.0 | 731.50 ns | 6.494 ns | 6.075 ns | 7.8125 |   65632 B |



```csharp
Cysharp.Text.Utf16ValueStringBuilder _buffer = Cysharp.Text.ZString.CreateStringBuilder();
```

```csharp
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
```

*   https://github.com/Cysharp/ZString/

*   https://github.com/Cysharp/ZString/blob/master/README.md

https://stackoverflow.com/questions/53180372/fastest-way-to-concatenate-readonlyspanchar-in-c-sharp

https://stackoverflow.com/questions/75069944/efficient-way-to-concatenate-strings-using-c-sharp

https://stackoverflow.com/questions/21078/most-efficient-way-to-concatenate-strings

https://www.reddit.com/r/dotnet/comments/15dr3gk/string_concatenation_benchmarks_in_net_8/

    https://gist.github.com/davepcallan/2063c516d6ea377e6c161bbc39c58701  

https://www.meziantou.net/micro-optimization-concatenating-a-string-with-a-char-using-string-concat.htm

https://www.reddit.com/r/dotnet/comments/15dr3gk/string_concatenation_benchmarks_in_net_8/

https://programmingpulse.vercel.app/blog/an-ultimate-guide-to-maximizing-performance-with-span-in-csharp

https://code-maze.com/csharp-how-to-convert-string-to-span/

https://steven-giesel.com/blogPost/969cc5e7-da27-4742-ae9a-ab7a66715ff6

https://quill.codes/posts/improve-performance-with-string-create/

https://www.meziantou.net/stringbuilder-performance-pitfalls.htm

https://linkdotnet.github.io/tips-and-tricks/strings/

https://andrewlock.net/series/a-deep-dive-on-stringbuilder/

StringBuilder size

```
[Params(1, 1_000, 10_000, 50_000, 999_999, 1_000_000, 1_500_000)]
```

https://www.infoworld.com/article/2270600/how-to-improve-stringbuilder-performance-in-c-sharp.html

https://www.reddit.com/r/csharp/comments/w465w2/does_c_care_any_more_about_string_builder/

Strings are still immutable, but Roslyn will optimize it in some cases. It won't optimize if you're concating in a loop, for example. So on each iteration, you'll have to copy a bigger and bigger prefix string, so the loop ends up being quadratic in time.

## `string.Create()`


```
string.Create();
```

    https://www.graymatterdeveloper.com/2020/04/09/fun-string-create/index.html

    https://www.reddit.com/r/dotnet/comments/15dr3gk/string_concatenation_benchmarks_in_net_8/

## Split

    https://medium.com/codenx/net-9-readonlyspan-char-split-947d6e1211e6

    ReadOnlySpan<char>.Split()

```
namespace System
{
    public static class MemoryExtensions
    {
        public static int Split(this ReadOnlySpan<char> source, Span<Range> destination, char separator, StringSplitOptions options = StringSplitOptions.None);
    }
}
```

https://apisof.net/catalog/68407f45a8c8650ee64f6000f6c2ce6f

https://apisof.net/catalog/900e7aa16261db25c301df6b4c5554e0

