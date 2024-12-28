# Benchmrks for `Regex`

| Method                                                            | Mean            | Error        | StdDev       | Gen0   | Gen1   | Allocated |
|------------------------------------------------------------------ |----------------:|-------------:|-------------:|-------:|-------:|----------:|
| Method_Local_Static_Call_Regex_Match_None                         |        77.51 ns |     0.185 ns |     0.154 ns |      - |      - |         - |
| Method_Local_Static_Call_Regex_Match_Compiled                     |        28.79 ns |     0.073 ns |     0.061 ns |      - |      - |         - |
| Method_Local_Object_Regex_Match_None                              |     2,633.23 ns |    21.558 ns |    20.165 ns | 0.7210 | 0.0076 |    6032 B |
| Method_Local_Object_Regex_Match_Compiled                          | 1,237,030.47 ns | 8,126.061 ns | 6,785.629 ns | 1.9531 |      - |   20292 B |
| Method_Local_Lazy_Object_Regex_Match_None                         |     2,627.17 ns |     7.584 ns |     6.723 ns | 0.7286 | 0.0076 |    6104 B |
| Method_Local_Lazy_Object_Regex_Match_Compiled                     | 1,239,442.82 ns | 8,208.376 ns | 7,276.511 ns | 1.9531 |      - |   20363 B |
| Class_Member_Object_Regex_Match_None                              |        74.68 ns |     0.223 ns |     0.197 ns |      - |      - |         - |
| Class_Member_Object_Regex_Match_Compiled                          |        24.96 ns |     0.096 ns |     0.090 ns |      - |      - |         - |
| Class_Static_Member_Object_Regex_Match_None                       |        74.76 ns |     0.269 ns |     0.239 ns |      - |      - |         - |
| Class_Static_Member_Object_Regex_Match_Compiled                   |        24.48 ns |     0.039 ns |     0.033 ns |      - |      - |         - |
| Class_Static_Member_Object_Regex_Match_SourceCodeGenerated_Method |        25.24 ns |     0.064 ns |     0.060 ns |      - |      - |         - |

