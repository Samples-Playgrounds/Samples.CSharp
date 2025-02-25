# Benchmrks for `Regex`

## Results

### 20250102

| Method                                                            | Mean            | Error         | StdDev        | Completed Work Items | Lock Contentions | Exceptions | Gen0   | Gen1   | Allocated |
|------------------------------------------------------------------ |----------------:|--------------:|--------------:|---------------------:|-----------------:|-----------:|-------:|-------:|----------:|
| Class_Member_Object_Regex_Match_Compiled                          |        24.74 ns |      0.057 ns |      0.053 ns |                    - |                - |          - |      - |      - |         - |
| Class_Static_Member_Object_Regex_Match_Compiled                   |        25.35 ns |      0.059 ns |      0.052 ns |                    - |                - |          - |      - |      - |         - |
| Class_Static_Member_Object_Regex_Match_SourceCodeGenerated_Method |        25.44 ns |      0.083 ns |      0.078 ns |                    - |                - |          - |      - |      - |         - |
| Method_Local_Static_Call_Regex_Match_Compiled                     |        28.26 ns |      0.084 ns |      0.075 ns |                    - |                - |          - |      - |      - |         - |
| Class_Static_Member_Object_Regex_Match_None                       |        73.83 ns |      0.175 ns |      0.155 ns |                    - |                - |          - |      - |      - |         - |
| Class_Member_Object_Regex_Match_None                              |        73.96 ns |      0.173 ns |      0.162 ns |                    - |                - |          - |      - |      - |         - |
| Method_Local_Static_Call_Regex_Match_None                         |        75.10 ns |      0.382 ns |      0.357 ns |                    - |                - |          - |      - |      - |         - |
| Method_Local_Object_Regex_Match_None                              |     2,551.38 ns |      7.276 ns |      6.806 ns |                    - |                - |          - | 0.7210 | 0.0076 |    6032 B |
| Method_Local_Lazy_Object_Regex_Match_None                         |     2,758.60 ns |      5.211 ns |      4.874 ns |                    - |                - |          - | 0.7286 | 0.0076 |    6104 B |
| Method_Local_Object_Regex_Match_Compiled                          | 1,207,803.93 ns | 12,017.185 ns | 11,240.882 ns |                    - |                - |          - | 1.9531 |      - |   20292 B |
| Method_Local_Lazy_Object_Regex_Match_Compiled                     | 1,220,948.62 ns |  8,834.008 ns |  8,263.337 ns |                    - |                - |          - | 1.9531 |      - |   20363 B |


