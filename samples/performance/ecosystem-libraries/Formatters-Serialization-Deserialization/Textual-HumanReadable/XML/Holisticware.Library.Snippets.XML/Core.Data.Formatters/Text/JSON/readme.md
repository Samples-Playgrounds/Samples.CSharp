# JSON

## Benchmarks

### 20251018

```
BenchmarkDotNet v0.14.0, macOS 26.0.1 (25A362) [Darwin 25.0.0]
Apple M4 Max, 1 CPU, 16 logical and 16 physical cores
.NET SDK 9.0.305
  [Host]     : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
```

| Method                                          | Mean      | Rank | Gen0   | Gen1   | Allocated |
|------------------------------------------------ |----------:|-----:|-------:|-------:|----------:|
| Test_01_System_Text_Json_01_Serialize           |  84.82 ns |    4 | 0.0134 |      - |     112 B |
| Test_01_System_Text_Json_02_Deserialize         | 131.76 ns |    7 | 0.0143 |      - |     120 B |
| Test_02_Newtonsoft_JSON_NET_01_Serialize        | 179.78 ns |    8 | 0.1702 |      - |    1424 B |
| Test_02_Newtonsoft_JSON_NET_01_Serialize_People | 485.51 ns |   10 | 0.2232 |      - |    1872 B |
| Test_02_Newtonsoft_JSON_NET_02_Deserialize      | 285.89 ns |    9 | 0.3257 | 0.0005 |    2728 B |
| Test_03_SpanJSON_01_Serialize                   |  38.06 ns |    1 | 0.0134 |      - |     112 B |
| Test_03_SpanJSON_02_Deserialize                 |  59.70 ns |    3 | 0.0143 |      - |     120 B |
| Test_04_NetJSON_01_Serialize                    |  50.68 ns |    2 | 0.0172 |      - |     144 B |
| Test_04_NetJSON_02_Deserialize                  | 115.63 ns |    6 | 0.0296 |      - |     248 B |
| Test_06_Utf8Json_01_Serialize                   |  50.23 ns |    2 | 0.0220 |      - |     184 B |
| Test_06_Utf8Json_02_Deserialize                 |  89.36 ns |    5 | 0.0229 |      - |     192 B |



