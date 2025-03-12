# Null-Checking-Nullable

collection expression vs collection initializer

1.  arrays 

    no difference

2.  lists

    collection expression is faster

## References/Links

*   https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/collection-expressions

    *    https://devblogs.microsoft.com/dotnet/refactor-your-code-with-collection-expressions/

*   https://dev.to/devleader/collection-initializers-and-collection-expressions-in-c-simplified-code-examples-3c9e

*   https://stackoverflow.com/questions/42981178/performance-difference-with-various-list-initialization-and-population-technique

*   https://devleader.ca/2024/03/31/collection-initializer-performance-in-c-how-to-get-an-87-boost

*   https://www.reddit.com/r/csharp/comments/1c2cu20/when_to_use_vs_explicit_type/

*   https://sharplab.io/#v2:C4LghgzsA0AmIGoA+ABATARgLACgUGYACdQgYUIG9dCbiiUAWQgWQAoBKQ62qnW/wgEsAdsADaAXSGiIAfQwBubgOnipI4HLRKcygQGMAFmABOkwkdNzFe/pbNT7WnSpq3aKDAAZznr9ZdXP19vZ1x3Gg1rQgBeQjFCDGhCNGT8ZIlAlSjZNFjCYQBTAHdzCkTk1MJ0wgBfHQiLYxNouISAckJ25O7uroU+zManXPyi0qlyzr7enoHk+sbGv1b4wgAiDeT16B2NhT2hviDQ0bjxso2trb31g4WsgUaNQjB8m2OVP0IIfIASdZgIFvChgWp3JafOq4WpAA===

## Results

### 20250227

| Method                                                              | Mean       | Median     | Gen0   | Gen1   | Allocated |
|-------------------------------------------------------------------- |-----------:|-----------:|-------:|-------:|----------:|
| array_of_ints_using_collection_expression_elements_as_variables     |  5.4640 ns |  5.4136 ns | 0.0076 |      - |      64 B |
| array_of_ints_using_collection_initializer_elements_as_variables    |  5.2728 ns |  5.2586 ns | 0.0076 |      - |      64 B |
| array_of_ints_using_collection_expression_elements_as_literals      |  5.6364 ns |  5.5691 ns | 0.0076 |      - |      64 B |
| array_of_ints_using_collection_initializer_elements_as_literals     |  5.9372 ns |  5.8830 ns | 0.0076 |      - |      64 B |
| array_of_strings_using_collection_expression_elements_as_variables  | 20.6632 ns | 20.6166 ns | 0.0124 |      - |     104 B |
| array_of_strings_using_collection_initializer_elements_as_variables | 20.8551 ns | 20.8187 ns | 0.0124 |      - |     104 B |
| array_of_strings_using_collection_expression_elements_as_literals   |  7.0104 ns |  6.8499 ns | 0.0124 |      - |     104 B |
| array_of_strings_using_collection_initializer_elements_as_literals  |  6.8807 ns |  6.8785 ns | 0.0124 |      - |     104 B |
| Array_ints_empty_using_collection_expression                        |  0.0017 ns |  0.0010 ns |      - |      - |         - |
| Array_ints_empty_using_collection_initializer                       |  3.9881 ns |  3.9864 ns | 0.0029 |      - |      24 B |
| Array_ints_empty_using_Array_Empty                                  |  0.0033 ns |  0.0000 ns |      - |      - |         - |
| Array_ints_empty_using_Enumerable_Empty                             |  2.1062 ns |  2.1042 ns |      - |      - |         - |
| array_ints_1                                                        |  4.3788 ns |  4.3774 ns | 0.0048 |      - |      40 B |
| array_ints_2                                                        |  4.3671 ns |  4.3632 ns | 0.0048 |      - |      40 B |
| array_chars_1                                                       |  4.1685 ns |  4.1704 ns | 0.0038 |      - |      32 B |
| array_chars_2                                                       |  4.2055 ns |  4.2104 ns | 0.0038 |      - |      32 B |
| array_strings_1                                                     |  4.5922 ns |  4.5943 ns | 0.0057 |      - |      48 B |
| array_strings_2                                                     |  4.6001 ns |  4.6002 ns | 0.0057 |      - |      48 B |
| list_ints_1_collection_expression                                   | 10.6274 ns | 10.6366 ns | 0.0086 |      - |      72 B |
| list_ints_2_collection_initializer                                  | 11.2763 ns | 11.2774 ns | 0.0086 |      - |      72 B |
| list_chars_1_collection_expression                                  | 10.3400 ns | 10.3423 ns | 0.0076 |      - |      64 B |
| list_chars_2_collection_initializer                                 | 11.3081 ns | 11.2903 ns | 0.0076 |      - |      64 B |
| list_strings_1_collection_expression                                | 11.1753 ns | 11.1831 ns | 0.0096 |      - |      80 B |
| list_strings_2_collection_initializer                               | 16.0486 ns | 16.0575 ns | 0.0105 |      - |      88 B |
| array_jaggged_01_collection_initialization                          | 18.4329 ns | 18.4241 ns | 0.0201 |      - |     168 B |
| array_jaggged_01_collection_expression                              | 18.3282 ns | 18.2999 ns | 0.0201 |      - |     168 B |
| list_of_lists_01_collection_expression                              | 43.1621 ns | 43.1592 ns | 0.0353 |      - |     296 B |
| list_of_lists_01_collection_initializer                             | 52.4508 ns | 52.4545 ns | 0.0363 | 0.0001 |     304 B |






