# Benchmrks for `String`

## Concatenation

*   `string.Join`

*   `string.Concat`

*   `StringBuilder`

    *   https://andrewlock.net/series/a-deep-dive-on-stringbuilder/

*   `Cysharp.Text.ZString`

*   `ValueStringBuilder`

    *   https://source.dot.net/#System.Text.RegularExpressions/src/libraries/Common/src/System/Text/ValueStringBuilder.cs

    *   https://andrewlock.net/a-deep-dive-on-stringbuilder-part-6-vaulestringbuilder-a-stack-based-string-builder/

    *   https://linkdotnet.github.io/StringBuilder/articles/getting_started.html

    *   https://steven-giesel.com/blogPost/66075e5c-c95a-44c4-8030-cd45d7855d1c/net-tips-and-tricks-valuestringbuilder

    *   https://linkdotnet.github.io/StringBuilder/

# Strings

readme.md

## 20250728

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


## 20241222

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

StringBuilder size

```
[Params(1, 1_000, 10_000, 50_000, 999_999, 1_000_000, 1_500_000)]
```

https://www.infoworld.com/article/2270600/how-to-improve-stringbuilder-performance-in-c-sharp.html

### `StringBuilderCache`

*   https://github.com/Azure/diagnostics-eventflow/blob/master/src/Microsoft.Diagnostics.EventFlow.EtwUtilities/StringBuilderCache.cs

## `string.Create()`


```
string.Create();
```

    https://www.graymatterdeveloper.com/2020/04/09/fun-string-create/index.html

    https://www.reddit.com/r/dotnet/comments/15dr3gk/string_concatenation_benchmarks_in_net_8/

Split

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

