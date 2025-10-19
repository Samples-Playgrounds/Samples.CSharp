# XML

## Benchmarks

### 20251018

```
BenchmarkDotNet v0.14.0, macOS 26.0.1 (25A362) [Darwin 25.0.0]
Apple M4 Max, 1 CPU, 16 logical and 16 physical cores
.NET SDK 9.0.305
  [Host]     : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
```

| Method                                                                           | Mean               | Median             | Rank | Gen0     | Gen1     | Gen2    | Allocated |
|--------------------------------------------------------------------------------- |-------------------:|-------------------:|-----:|---------:|---------:|--------:|----------:|
| Test_01_System_Xml_Serialization_XmlSerializer_01_SerializeNaive                 |      1,913.6238 ns |      1,910.9572 ns |    9 |   2.0599 |   0.0534 |       - |   17265 B |
| Test_01_System_Xml_Serialization_XmlSerializer_01_SerializeCached                |        784.9351 ns |        784.1559 ns |    7 |   1.8377 |   0.0439 |       - |   15400 B |
| Test_01_System_Xml_Serialization_XmlSerializer_02_DeserializeNaive               |      2,307.9399 ns |      2,308.7096 ns |   10 |   1.6556 |   0.0534 |       - |   13905 B |
| Test_01_System_Xml_Serialization_XmlSerializer_02_DeserializeCached              |      1,171.2990 ns |      1,172.1911 ns |    8 |   1.4400 |   0.0515 |       - |   12040 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_01_SerializeNaive    |        676.4602 ns |        676.6530 ns |    4 |   1.8177 |   0.0315 |       - |   15224 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_01_SerializeCached   |        743.1255 ns |        743.2777 ns |    6 |   1.8272 |        - |       - |   15304 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_02_DeserializeNaive  |        804.9033 ns |        805.6322 ns |    7 |   1.3657 |   0.0439 |       - |   11424 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_02_DeserializeCached |        710.3648 ns |        709.6480 ns |    5 |   1.3075 |   0.0458 |       - |   10936 B |
| Test_03_NetBike_01_SerializeNaive                                                |     59,563.8915 ns |     59,621.4142 ns |   11 |   2.8076 |   1.3428 |       - |   24454 B |
| Test_03_NetBike_01_SerializeCached                                               |        654.8410 ns |        654.7134 ns |    3 |   1.7643 |   0.0429 |       - |   14784 B |
| Test_03_NetBike_02_DeserializeNaive                                              |     94,365.0978 ns |     94,349.8179 ns |   12 |   2.5635 |   1.2207 |  0.1221 |   22181 B |
| Test_03_NetBike_02_DeserializeCached                                             |        702.7234 ns |        702.6545 ns |    5 |   1.3084 |   0.0467 |       - |   10944 B |
| Test_03_YAXLib_01_SerializeNaive                                                 |          0.0000 ns |          0.0000 ns |    1 |        - |        - |       - |         - |
| Test_03_YAXLib_01_SerializeCached                                                |          0.0203 ns |          0.0000 ns |    1 |        - |        - |       - |         - |
| Test_03_YAXLib_02_DeserializeNaive                                               |          0.0006 ns |          0.0000 ns |    1 |        - |        - |       - |         - |
| Test_03_YAXLib_02_DeserializeCached                                              |          0.0020 ns |          0.0000 ns |    1 |        - |        - |       - |         - |
| Test_04_ServiceStackText_01_SerializeNaive                                       |        576.9531 ns |        577.1855 ns |    2 |   1.0328 |   0.0191 |       - |    8648 B |
| Test_04_ServiceStackText_02_DeserializeNaive                                     |                 NA |                 NA |    ? |       NA |       NA |      NA |        NA |
| Test_05_ExtendedXmlSerializer_01_SerializeNaive                                  | 11,245,246.3979 ns | 11,244,225.2656 ns |   13 | 578.1250 | 281.2500 | 78.1250 | 4943538 B |
| Test_05_ExtendedXmlSerializer_01_DeserializeNaiveMemoryStream                    |                 NA |                 NA |    ? |       NA |       NA |      NA |        NA |


## Diverse

*   https://kalapos.net/Blog/ShowPost/how-the-evil-system-xml-serialization-xmlserializer-class-can-bring-a-server-with-32gb-ram-down