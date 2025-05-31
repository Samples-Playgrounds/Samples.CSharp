# CliWrap

readme.md

https://github.com/MarkPflug/Sylvan/blob/main/docs/Csv/Sylvan.Data.Csv.md


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



