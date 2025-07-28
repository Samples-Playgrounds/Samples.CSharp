```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M4 Max, 1 CPU, 16 logical and 16 physical cores
.NET SDK 9.0.303
  [Host]   : .NET 9.0.8 (9.0.825.36510), Arm64 RyuJIT AdvSIMD
  .NET 8.0 : .NET 8.0.19 (8.0.1925.36006), Arm64 RyuJIT AdvSIMD
  .NET 9.0 : .NET 9.0.8 (9.0.825.36510), Arm64 RyuJIT AdvSIMD


```
| Method                                    | Runtime  | input                | delimiter | delimiters | Mean       | Error     | StdDev    | Gen0   | Allocated |
|------------------------------------------ |--------- |--------------------- |---------- |----------- |-----------:|----------:|----------:|-------:|----------:|
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ,         | ?          |   2.457 ns | 0.0211 ns | 0.0187 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ;         | ?          |   2.463 ns | 0.0119 ns | 0.0111 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ;         | ?          |   2.727 ns | 0.0101 ns | 0.0089 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [78] | \t        | ?          |   2.748 ns | 0.0080 ns | 0.0067 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [82] | \t        | ?          |   2.781 ns | 0.0138 ns | 0.0129 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 8.0 | adsad(...)sasds [69] | ,         | ?          |   2.795 ns | 0.0046 ns | 0.0039 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [82] | \t        | ?          |   3.157 ns | 0.0188 ns | 0.0167 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ,         | ?          |   3.188 ns | 0.0151 ns | 0.0126 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [78] | \t        | ?          |   3.241 ns | 0.0141 ns | 0.0118 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ;         | ?          |   3.517 ns | 0.0112 ns | 0.0105 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ,         | ?          |   3.524 ns | 0.0048 ns | 0.0040 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopStringNative | .NET 9.0 | adsad(...)sasds [69] | ;         | ?          |   3.536 ns | 0.0357 ns | 0.0334 ns | 0.0029 |      24 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | ?         | Char[2]    | 127.358 ns | 0.3432 ns | 0.3042 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | ?         | Char[1]    | 128.524 ns | 0.6385 ns | 0.5973 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 8.0 | adsad(...)sasds [69] | ?         | Char[2]    | 130.452 ns | 0.5742 ns | 0.4795 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | ?         | Char[1]    | 140.422 ns | 0.9839 ns | 0.8216 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | ?         | Char[2]    | 140.602 ns | 0.8386 ns | 0.7844 ns | 0.0706 |     592 B |
| HolisticWare_Core_String_ChopWithSpan     | .NET 9.0 | adsad(...)sasds [69] | ?         | Char[2]    | 141.664 ns | 0.8901 ns | 0.7433 ns | 0.0706 |     592 B |
