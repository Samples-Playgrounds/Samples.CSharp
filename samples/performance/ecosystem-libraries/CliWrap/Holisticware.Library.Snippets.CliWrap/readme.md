# CliWrap

readme.md

*   https://github.com/Tyrrrz/CliWrap
    
*   https://dev.to/tyrrrz/cliwrap-execute-shell-commands-with-extensive-support-for-piping-3gm8

*   Stop using the Process class for CLI interactions in .NET

    *   https://www.youtube.com/watch?v=Pt-0KM5SxmI


## Bwnchmarks

### 20250526

// * Summary *

BenchmarkDotNet v0.14.0, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.4.25258.110
[Host]     : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD
DefaultJob : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD


| Method                                                                    | Mean          | Gen0   | Allocated |
|-------------------------------------------------------------------------- |--------------:|-------:|----------:|
| Test_23_CliWrap_StandardOutput_AsString_Via_Delegate_ZString              |      15.29 us | 0.0916 |     992 B |
| Test_22_CliWrap_StandardOutput_AsString_Via_Delegate_StringBuider         |      15.30 us | 0.1221 |    1088 B |
| Test_24_CliWrap_StandardOutput_AsString_Via_Delegate_StrngBuilder_BuiltIn |      15.32 us | 0.0916 |     824 B |
| Test_15_CliWrap_StandardOutput_AsStringArray_Via_Delegate                 |      15.33 us | 0.0916 |    1016 B |
| Test_01_System_Diagnostic_Process_StandardOutput                          |  24,320.15 us |      - |   58681 B |
| Test_12_CliWrap_StandardOutput_AsStringArray_Via_Piped_Delegate           | 110,315.35 us |      - |  104776 B |
| Test_21_CliWrap_StandardOutput_AsString_From_Result                       | 110,805.92 us |      - |   95392 B |
| Test_11_CliWrap_StandardOutput_AsStringArray_From_Result                  | 112,912.02 us |      - |   95568 B |
| Test_14_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync              | 116,452.50 us |      - |   97200 B |
| Test_13_CliWrap_StandardOutput_AsStringArray_Via_Observable               | 217,606.77 us |      - |  191925 B |

