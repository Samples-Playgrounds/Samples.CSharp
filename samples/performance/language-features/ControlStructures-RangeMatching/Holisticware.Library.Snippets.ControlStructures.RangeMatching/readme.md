# Range Checking

*   https://stackoverflow.com/questions/20147879/switch-case-can-i-use-a-range-instead-of-a-one-number

*   https://hackajob.com/talent/blog/better-c-switch-statements-for-a-range-of-values

*   https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns

*   https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements

*   https://www.linkedin.com/pulse/handle-cases-range-c-javascript-ziv-ben-or/

*   https://medium.com/@time4ish/csharp-switch-statement-vs-switch-expression-explained-b0046058eee6

## Results

### 20250312

| Method                                         | price | Mean        | Median      | Gen0   | Allocated |
|----------------------------------------------- |------ |------------:|------------:|-------:|----------:|
| range_of_ints_to_double_with_if                | -100  |   0.2917 ns |   0.2921 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | -100  |   1.5949 ns |   1.5968 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | -100  |   0.2952 ns |   0.2951 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | -100  |   0.2943 ns |   0.2944 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | -100  |   0.0005 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | -100  | 276.5204 ns | 275.9440 ns | 0.0887 |     744 B |
| range_of_ints_to_double_with_if                | 470   |   0.3123 ns |   0.3122 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | 470   |   2.3024 ns |   2.2865 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | 470   |   0.2966 ns |   0.2966 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | 470   |   0.2950 ns |   0.2936 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | 470   |   0.0021 ns |   0.0002 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | 470   | 273.7333 ns | 273.9444 ns | 0.0887 |     744 B |
| range_of_ints_to_double_with_if                | 800   |   0.2920 ns |   0.2927 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | 800   |   2.5258 ns |   2.5209 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | 800   |   0.2989 ns |   0.2984 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | 800   |   0.3004 ns |   0.3007 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | 800   |   0.0007 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | 800   | 275.0689 ns | 274.2837 ns | 0.0887 |     744 B |
| range_of_ints_to_double_with_if                | 870   |   0.3272 ns |   0.3187 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | 870   |   2.3394 ns |   2.3150 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | 870   |   0.2475 ns |   0.2451 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | 870   |   0.3310 ns |   0.3132 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | 870   |   0.0064 ns |   0.0005 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | 870   | 275.6314 ns | 275.7712 ns | 0.0887 |     744 B |
| range_of_ints_to_double_with_if                | 900   |   0.0000 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | 900   |   1.4122 ns |   1.4145 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | 900   |   0.0017 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | 900   |   0.0011 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | 900   |   0.0020 ns |   0.0020 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | 900   | 274.9898 ns | 275.4191 ns | 0.0887 |     744 B |
| range_of_ints_to_double_with_if                | 940   |   0.0001 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | 940   |   1.3996 ns |   1.3999 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | 940   |   0.0001 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | 940   |   0.0013 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | 940   |   0.0009 ns |   0.0001 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | 940   | 274.4123 ns | 274.7126 ns | 0.0887 |     744 B |
| range_of_ints_to_double_with_if                | 1000  |   0.0006 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | 1000  |   0.7707 ns |   0.7706 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | 1000  |   0.0004 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | 1000  |   0.0013 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | 1000  |   0.0012 ns |   0.0007 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | 1000  | 276.4994 ns | 276.5963 ns | 0.0887 |     744 B |
| range_of_ints_to_double_with_if                | 1100  |   0.0050 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_ternary_operators | 1100  |   0.7610 ns |   0.7613 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_7   | 1100  |   0.0021 ns |   0.0016 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_8   | 1100  |   0.0001 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_switch_csharp_9   | 1100  |   0.0000 ns |   0.0000 ns |      - |         - |
| range_of_ints_to_double_with_dictionary        | 1100  | 337.2014 ns | 337.5084 ns | 0.0887 |     744 B |








