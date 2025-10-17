# XML

readme.md

https://github.com/MarkPflug/Sylvan/blob/main/docs/Csv/Sylvan.Data.Csv.md

https://code-maze.com/csharp-xml-deserialization/

*   Microsoft.XmlSerializer.Generator

    *   https://gist.github.com/filipnavara/1e8831c256498bad53b3aae94af87a20

## Bwnchmarks

### 20251017

```
BenchmarkDotNet v0.14.0, macOS 26.0.1 (25A362) [Darwin 25.0.0]
Apple M4 Max, 1 CPU, 16 logical and 16 physical cores
.NET SDK 9.0.305
  [Host]     : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
```
#### XML

| Method                                                                           | Mean               | Median             | Rank | Gen0     | Gen1     | Gen2    | Allocated |
|--------------------------------------------------------------------------------- |-------------------:|-------------------:|-----:|---------:|---------:|--------:|----------:|
| Test_01_System_Xml_Serialization_XmlSerializer_01_SerializeNaive                 |      2,859.6201 ns |      2,863.3788 ns |    9 |   2.0599 |   0.0458 |       - |   17265 B |
| Test_01_System_Xml_Serialization_XmlSerializer_01_SerializeCached                |      1,139.0196 ns |      1,139.4246 ns |    7 |   1.8368 |   0.0439 |       - |   15400 B |
| Test_01_System_Xml_Serialization_XmlSerializer_02_DeserializeNaive               |      3,398.3914 ns |      3,397.7610 ns |   10 |   1.6479 |   0.0610 |       - |   13905 B |
| Test_01_System_Xml_Serialization_XmlSerializer_02_DeserializeCached              |      1,745.4872 ns |      1,747.4174 ns |    8 |   1.4343 |   0.0458 |       - |   12040 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_01_SerializeNaive    |        973.5442 ns |        972.2368 ns |    4 |   1.8177 |   0.0305 |       - |   15224 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_01_SerializeCached   |      1,059.7995 ns |      1,058.2190 ns |    6 |   1.8272 |        - |       - |   15304 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_02_DeserializeNaive  |      1,151.7114 ns |      1,151.2736 ns |    7 |   1.3657 |   0.0439 |       - |   11424 B |
| Test_02_System_Runtime_Serialization_DataContractSerializer_02_DeserializeCached |      1,022.9212 ns |      1,023.0029 ns |    5 |   1.3065 |   0.0458 |       - |   10936 B |
| Test_03_NetBike_01_SerializeNaive                                                |     88,668.4222 ns |     88,730.1534 ns |   11 |   2.8076 |   1.3428 |       - |   24454 B |
| Test_03_NetBike_01_SerializeCached                                               |        958.1063 ns |        958.7429 ns |    4 |   1.7643 |   0.0420 |       - |   14784 B |
| Test_03_NetBike_02_DeserializeNaive                                              |    138,844.6695 ns |    138,690.7858 ns |   12 |   2.4414 |   1.2207 |       - |   22176 B |
| Test_03_NetBike_02_DeserializeCached                                             |      1,005.5386 ns |      1,004.5280 ns |    5 |   1.3084 |   0.0458 |       - |   10944 B |
| Test_03_YAXLib_01_SerializeNaive                                                 |          0.0060 ns |          0.0000 ns |    1 |        - |        - |       - |         - |
| Test_03_YAXLib_01_SerializeCached                                                |          0.0963 ns |          0.0940 ns |    2 |        - |        - |       - |         - |
| Test_03_YAXLib_02_DeserializeNaive                                               |          0.0088 ns |          0.0000 ns |    1 |        - |        - |       - |         - |
| Test_03_YAXLib_02_DeserializeCached                                              |          0.0177 ns |          0.0000 ns |    1 |        - |        - |       - |         - |
| Test_04_ServiceStackText_01_SerializeNaive                                       |        810.5966 ns |        810.6283 ns |    3 |   1.0328 |   0.0191 |       - |    8648 B |
| Test_04_ServiceStackText_02_DeserializeNaive                                     |                 NA |                 NA |    ? |       NA |       NA |      NA |        NA |
| Test_05_ExtendedXmlSerializer_01_SerializeNaive                                  | 16,028,864.0865 ns | 16,019,834.6250 ns |   13 | 562.5000 | 281.2500 | 62.5000 | 4944692 B |
| Test_05_ExtendedXmlSerializer_01_DeserializeNaiveMemoryStream                    |                 NA |                 NA |    ? |       NA |       NA |      NA |        NA |


#### JSON

| Method                                          | Mean      | Rank | Gen0   | Gen1   | Allocated |
|------------------------------------------------ |----------:|-----:|-------:|-------:|----------:|
| Test_01_System_Text_Json_01_Serialize           | 116.69 ns |    4 | 0.0134 |      - |     112 B |
| Test_01_System_Text_Json_02_Deserialize         | 182.36 ns |    6 | 0.0143 |      - |     120 B |
| Test_02_Newtonsoft_JSON_NET_01_Serialize        | 251.73 ns |    7 | 0.1702 |      - |    1424 B |
| Test_02_Newtonsoft_JSON_NET_01_Serialize_People | 683.37 ns |    9 | 0.2232 |      - |    1872 B |
| Test_02_Newtonsoft_JSON_NET_02_Deserialize      | 389.42 ns |    8 | 0.3257 | 0.0005 |    2728 B |
| Test_03_SpanJSON_01_Serialize                   |  53.10 ns |    1 | 0.0134 |      - |     112 B |
| Test_03_SpanJSON_02_Deserialize                 |  85.77 ns |    3 | 0.0143 |      - |     120 B |
| Test_04_NetJSON_01_Serialize                    |  67.52 ns |    2 | 0.0172 |      - |     144 B |
| Test_04_NetJSON_02_Deserialize                  | 163.88 ns |    5 | 0.0296 |      - |     248 B |




### 20250531

Weather

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.4.25258.110
[Host]     : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD
DefaultJob : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD
```

| Method                                                                                  | Mean         | Gen0   | Gen1   | Allocated |
|---------------------------------------------------------------------------------------- |-------------:|-------:|-------:|----------:|
| Test_01_Initialize_01_System_Xml_Serialization_XmlSerializer_Create                     | 1,230.818 ns | 0.2079 |      - |    1752 B |
| Test_02_Initialize_01_System_Runtime_Serialization_DataContractSerializer_Create        |    10.000 ns | 0.0115 |      - |      96 B |
| Test_11_Serialize_01_System_Runtime_Serialization_Serialize_with_MemoryStream           | 1,400.371 ns | 0.5379 |      - |    4504 B |
| Test_11_Serialize_02_System_Runtime_Serialization_Serialize_with_RecyclableMemoryStream | 1,640.740 ns | 0.3815 |      - |    3192 B |
| Test_12_Serialize_01_System_Xml_Serialization_Serialize_with_MemoryStream               | 2,269.674 ns | 2.0981 | 0.0801 |   17592 B |
| Test_12_Serialize_02_System_Xml_Serialization_Serialize_with_RecyclableMemoryStream     | 2,594.518 ns | 2.1248 | 0.0572 |   17808 B |



Iris

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.4.25258.110
[Host]     : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD
DefaultJob : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD
```

| Method                                                                                  | Mean        | Gen0   | Gen1   | Allocated |
|---------------------------------------------------------------------------------------- |------------:|-------:|-------:|----------:|
| Test_01_Initialize_01_System_Xml_Serialization_XmlSerializer_Create                     | 1,440.42 ns | 0.2060 |      - |    1736 B |
| Test_02_Initialize_01_System_Runtime_Serialization_DataContractSerializer_Create        |    10.17 ns | 0.0115 |      - |      96 B |
| Test_11_Serialize_01_System_Runtime_Serialization_Serialize_with_MemoryStream           |   810.63 ns | 0.3052 | 0.0010 |    2560 B |
| Test_11_Serialize_02_System_Runtime_Serialization_Serialize_with_RecyclableMemoryStream | 1,149.48 ns | 0.2918 |      - |    2456 B |
| Test_12_Serialize_01_System_Xml_Serialization_Serialize_with_MemoryStream               | 1,437.82 ns | 1.9054 | 0.0343 |   15952 B |
| Test_12_Serialize_02_System_Xml_Serialization_Serialize_with_RecyclableMemoryStream     | 1,748.89 ns | 1.9302 | 0.0572 |   16168 B |



## Diverse

Errors for desearialization `Data/weather.srs.xml`

```
| Test_21_Deserialize_01_System_Runtime_Serialization_with_MemoryStream                   | 3,889.49 ns | 1.6174 | 0.0305 |   13560 B |
| Test_21_Deserialize_02_System_Runtime_Serialization_with_RecyclableMemoryStream         |          NA |     NA |     NA |        NA |
| Test_22_Deserialize_01_System_Xml_Serialization_with_MemoryStream                       |          NA |     NA |     NA |        NA |
| Test_22_Deserialize_02_System_Xml_Serialization_with_RecyclableMemoryStream             |          NA |     NA |     NA |        NA |

```

```
// Benchmark: Benchmarks_XML_Weather.Test_21_Deserialize_02_System_Runtime_Serialization_with_RecyclableMemoryStream: DefaultJob

System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
 ---> System.Xml.XmlException: Unexpected end of file.
 
```

```
// Benchmark: Benchmarks_XML_Weather.Test_22_Deserialize_01_System_Xml_Serialization_with_MemoryStream: DefaultJob

System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
 ---> System.InvalidOperationException: There is an error in XML document (1, 2).
 ---> System.InvalidOperationException: <Weather xmlns='http://schemas.datacontract.org/2004/07/Holisticware.Library.Snippets.XML.Models'> was not expected.
```


```
// Benchmark: Benchmarks_XML_Weather.Test_22_Deserialize_02_System_Xml_Serialization_with_RecyclableMemoryStream: DefaultJob
/
System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
 ---> System.InvalidOperationException: There is an error in XML document (0, 0).
 ---> System.Xml.XmlException: Root element is missing.
```


Errors for desearialization `Data/weather.srs.xml`

```
```

## Diverse

*   https://stackoverflow.com/questions/9502356/improve-performance-of-xmlserializer

https://github.com/morgankenyon/BenchmarkExamples/tree/master/src

https://ryaremchuk.blogspot.com/2012/10/xml-serialization.html

https://www.reddit.com/r/programming/comments/1496el/high_performance_xml_serialization_in_net/

https://www.reddit.com/r/csharp/comments/dqkgtr/is_there_no_really_good_xml_serialization_library/

So far I tried quite a lot of different libraries:

Default XmlSerializer

Using the XmlAttributeOverrides I could configure the serialization without touching the data classes

A naming strategy could by implemented via this hack

Sadly, converters for specific scenarios / parts of the data structure are not supported

Default DataContractSerializer

Can't be used because XML attributes are not supported

YAXLib

Supports a lot more scenarios via its attributes

There is no way to apply the serialization information without touching the data classes

ExtendedXmlSerializer

Supports converters for custom serialization

Sadly, I could not find a way in the documentation to serialize lists without serializing .NET-specific type information and internal properties like Capacity

NetBike.XML

Supports configuration without touching the data classes (by building custom contracts)

Supports naming strategies for camelCasing

Sadly, it is not maintained for two years and is not available for .NET Standard (however I could fork and transfer the project)

Actually, I did already work on the serialization to JSON (via Newtonsoft) and BSON (via MongoDB Adapter) and it all worked like a charm, so I wondered if there is a library for XML that provides an equal amount of features.


https://medium.com/@maximn/serialization-performance-comparison-xml-binary-json-p-ad737545d227

https://learn.microsoft.com/en-us/dotnet/standard/serialization/binaryformatter-migration-guide/choose-a-serializer

https://aloiskraus.wordpress.com/2022/11/23/net-serialization-roundup-2022/
