# XML

readme.md

https://github.com/MarkPflug/Sylvan/blob/main/docs/Csv/Sylvan.Data.Csv.md

https://code-maze.com/csharp-xml-deserialization/

*   Microsoft.XmlSerializer.Generator

    *   https://gist.github.com/filipnavara/1e8831c256498bad53b3aae94af87a20

## Bwnchmarks

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
