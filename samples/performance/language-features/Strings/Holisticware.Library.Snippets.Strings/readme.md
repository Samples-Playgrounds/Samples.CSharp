# Benchmrks for `String`

readme.md

## Strings

*   https://www.meziantou.net/some-performance-tricks-with-dotnet-strings.htm


### Split

*   https://www.infoworld.com/article/3626790/how-to-split-strings-efficiently-in-c-sharp.html

*   https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm
  
*   https://endjin.com/blog/2023/09/optimising-dotnet-code-4-avoiding-allocations-using-span-t

*   https://www.meziantou.net/split-a-string-into-lines-without-allocation.htm

*   https://stackoverflow.com/questions/77343199/string-split-for-span

#### `StringTokenizer`

*   https://learn.microsoft.com/en-us/dotnet/core/extensions/primitives#the-stringtokenizer-type
*   https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.primitives.stringtokenizer

## Results


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

