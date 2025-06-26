# CliWrap

readme.md

```
dotnet run \
    --configuration Release \
    --framework net9.0
    -- \
    --job short \
    --runtimes net8.0 net9.0 net10.0
```
  
* https://github.com/Tyrrrz/CliWrap
    
*   https://dev.to/tyrrrz/cliwrap-execute-shell-commands-with-extensive-support-for-piping-3gm8

*   Stop using the Process class for CLI interactions in .NET

    *   https://www.youtube.com/watch?v=Pt-0KM5SxmI

## Tips & Tricks

1.  Test_14_CliWrap_StandardOutput_AsString_Via_Delegate_StrngBuilder_BuiltIn

    ```csharp
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe(PipeTarget.ToStringBuilder(sb))
                                ;

        return sb.ToString();
    ```


2.  Test_25_CliWrap_StandardOutput_AsStringArray_Via_Delegate


    ```csharp
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe
                                    (
                                        PipeTarget.ToDelegate
                                                    (
                                                        (s => stdout_2.Add(s))
                                                    )
                                    );
    ```

3.  Test_12_CliWrap_StandardOutput_AsString_Via_Delegate_StringBuider


    ```csharp
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe
                                    (
                                        PipeTarget.ToDelegate
                                                    (
                                                        (s => sb.Append(s))
                                                    )
                                    );
    ```

4.  Test_13_CliWrap_StandardOutput_AsString_Via_Delegate_ZString


    ```csharp
        cmd = global::CliWrap.Cli
                                .Wrap("javac")
                                .WithArguments("--version")
                                .WithStandardOutputPipe
                                    (
                                        PipeTarget.ToDelegate
                                                    (
                                                        (s => sbz.Append(s))
                                                    )
                                    );
        return sb.ToString();
    ```

## Bwnchmarks

### 20250626

```
BenchmarkDotNet v0.15.2, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.5.25277.114
  [Host]   : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  .NET 9.0 : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  .NET 8.0 : .NET 8.0.17 (8.0.1725.26602), Arm64 RyuJIT AdvSIMD
```


| Method                                                                    | Job      | Runtime  | Mean          | Median        | Gen0   | Allocated |
|-------------------------------------------------------------------------- |--------- |--------- |--------------:|--------------:|-------:|----------:|
| Test_14_CliWrap_StandardOutput_AsString_Via_Delegate_StrngBuilder_BuiltIn | .NET 9.0 | .NET 9.0 |      15.92 us |      16.04 us | 0.0916 |     840 B |
| Test_25_CliWrap_StandardOutput_AsStringArray_Via_Delegate                 | .NET 9.0 | .NET 9.0 |      15.95 us |      16.11 us | 0.1221 |    1080 B |
| Test_25_CliWrap_StandardOutput_AsStringArray_Via_Delegate                 | .NET 8.0 | .NET 8.0 |      15.96 us |      16.10 us | 0.1221 |    1272 B |
| Test_14_CliWrap_StandardOutput_AsString_Via_Delegate_StrngBuilder_BuiltIn | .NET 8.0 | .NET 8.0 |      15.97 us |      16.11 us | 0.1221 |    1032 B |
| Test_12_CliWrap_StandardOutput_AsString_Via_Delegate_StringBuider         | .NET 9.0 | .NET 9.0 |      16.00 us |      16.10 us | 0.1221 |    1080 B |
| Test_12_CliWrap_StandardOutput_AsString_Via_Delegate_StringBuider         | .NET 8.0 | .NET 8.0 |      16.00 us |      16.16 us | 0.1221 |    1272 B |
| Test_13_CliWrap_StandardOutput_AsString_Via_Delegate_ZString              | .NET 8.0 | .NET 8.0 |      16.02 us |      16.14 us | 0.1221 |    1272 B |
| Test_13_CliWrap_StandardOutput_AsString_Via_Delegate_ZString              | .NET 9.0 | .NET 9.0 |      16.03 us |      16.16 us | 0.1221 |    1080 B |
| Test_01_System_Diagnostic_Process_StandardOutput                          | .NET 9.0 | .NET 9.0 |  18,164.32 us |  17,561.12 us |      - |   59663 B |
| Test_01_System_Diagnostic_Process_StandardOutput                          | .NET 8.0 | .NET 8.0 |  19,346.97 us |  19,355.09 us |      - |   59760 B |
| Test_22_CliWrap_StandardOutput_AsStringArray_Via_Piped_Delegate           | .NET 9.0 | .NET 9.0 | 102,620.06 us | 102,682.60 us |      - |  106315 B |
| Test_11_CliWrap_StandardOutput_AsString_From_Result                       | .NET 9.0 | .NET 9.0 | 105,445.85 us | 105,381.55 us |      - |   96291 B |
| Test_34_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync              | .NET 9.0 | .NET 9.0 | 106,098.14 us | 106,126.86 us |      - |   98283 B |
| Test_22_CliWrap_StandardOutput_AsStringArray_Via_Piped_Delegate           | .NET 8.0 | .NET 8.0 | 106,406.90 us | 106,367.80 us |      - |  160798 B |
| Test_24_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync              | .NET 9.0 | .NET 9.0 | 108,674.80 us | 108,580.23 us |      - |   98931 B |
| Test_11_CliWrap_StandardOutput_AsString_From_Result                       | .NET 8.0 | .NET 8.0 | 110,290.79 us | 110,140.96 us |      - |   98125 B |
| Test_21_CliWrap_StandardOutput_AsStringArray_From_Result                  | .NET 8.0 | .NET 8.0 | 110,446.74 us | 110,432.37 us |      - |   98301 B |
| Test_24_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync              | .NET 8.0 | .NET 8.0 | 110,950.98 us | 111,065.70 us |      - |  100808 B |
| Test_34_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync              | .NET 8.0 | .NET 8.0 | 111,108.94 us | 111,175.28 us |      - |  101096 B |
| Test_21_CliWrap_StandardOutput_AsStringArray_From_Result                  | .NET 9.0 | .NET 9.0 | 112,318.59 us | 112,468.97 us |      - |   96467 B |
| Test_23_CliWrap_StandardOutput_AsStringArray_Via_Observable               | .NET 8.0 | .NET 8.0 | 227,572.01 us | 227,485.78 us |      - |  196989 B |
| Test_23_CliWrap_StandardOutput_AsStringArray_Via_Observable               | .NET 9.0 | .NET 9.0 | 232,666.19 us | 232,707.22 us |      - |  193744 B |



### 20250526

// * Summary *

BenchmarkDotNet v0.14.0, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.4.25258.110
[Host]     : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD
DefaultJob : .NET 9.0.4 (9.0.425.16305), Arm64 RyuJIT AdvSIMD


| Method                                                                    | Mean          | Median        | Gen0   | Allocated |
|-------------------------------------------------------------------------- |--------------:|--------------:|-------:|----------:|
| Test_14_CliWrap_StandardOutput_AsString_Via_Delegate_StrngBuilder_BuiltIn |      15.33 us |      15.29 us | 0.0916 |     816 B |
| Test_13_CliWrap_StandardOutput_AsString_Via_Delegate_ZString              |      15.35 us |      15.31 us | 0.1221 |    1056 B |
| Test_25_CliWrap_StandardOutput_AsStringArray_Via_Delegate                 |      15.39 us |      15.30 us | 0.1221 |    1056 B |
| Test_12_CliWrap_StandardOutput_AsString_Via_Delegate_StringBuider         |      15.40 us |      15.42 us | 0.1221 |    1056 B |
| Test_01_System_Diagnostic_Process_StandardOutput                          |  24,987.70 us |  24,343.43 us |      - |   58646 B |
| Test_21_CliWrap_StandardOutput_AsStringArray_From_Result                  | 114,073.71 us | 113,676.14 us |      - |   95638 B |
| Test_22_CliWrap_StandardOutput_AsStringArray_Via_Piped_Delegate           | 114,910.29 us | 114,927.24 us |      - |  105744 B |
| Test_24_CliWrap_StandardOutput_AsStringArray_Via_ListenAsync              | 117,194.12 us | 117,781.29 us |      - |   98520 B |
| Test_11_CliWrap_StandardOutput_AsString_From_Result                       | 120,209.77 us | 118,196.33 us |      - |   95628 B |
| Test_23_CliWrap_StandardOutput_AsStringArray_Via_Observable               | 245,998.98 us | 244,852.78 us |      - |  191917 B |


### 20250525

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

