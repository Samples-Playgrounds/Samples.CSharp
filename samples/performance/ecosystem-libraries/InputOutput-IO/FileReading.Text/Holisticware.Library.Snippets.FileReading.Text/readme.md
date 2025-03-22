# FileReading


## Text

*   https://code-maze.com/csharp-fastest-way-to-read-text-file/

    *   https://github.com/CodeMazeBlog/CodeMazeGuides/tree/main/files-csharp/FastestWayToReadATextFileInCsharp

*   https://cc.davelozinski.com/c-sharp/fastest-way-to-read-text-files

*   https://cc.davelozinski.com/c-sharp/the-fastest-way-to-read-and-process-text-files

*   https://lemire.me/blog/2024/10/17/how-fast-can-you-parse-a-csv-file-in-c/

*   https://www.joelverhagen.com/blog/2020/12/fastest-net-csv-parsers

    *   https://github.com/joelverhagen/NCsvPerf/pulls

## Binary

*   https://stackoverflow.com/questions/8624071/save-and-load-memorystream-to-from-a-file

*   https://www.reddit.com/r/csharp/comments/5sv0t1/the_absolute_fastest_way_to_read_bytes_from_a/


## Results

```
BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.2.25164.34
  [Host]     : .NET 9.0.3 (9.0.325.11113), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.3 (9.0.325.11113), Arm64 RyuJIT AdvSIMD
```


| Method                                                                                | file_path_test_data | Mean          | Gen0       | Gen1      | Gen2      | Allocated    |
|-------------------------------------------------------------------------------------- |-------------------- |--------------:|-----------:|----------:|----------:|-------------:|
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/192.txt          |   1,338.61 us |    13.6719 |         - |         - |    111.82 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/192.txt          |  12,129.89 us |   171.8750 |  171.8750 |  171.8750 |  38680.19 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/192.txt          |   1,337.15 us |    13.6719 |         - |         - |    111.82 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/192.txt          |  12,097.74 us |   171.8750 |  171.8750 |  171.8750 |  38680.19 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/192.txt          |   1,347.73 us |    13.6719 |         - |         - |    111.82 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/192.txt          |   7,189.10 us |  2492.1875 | 2492.1875 | 2492.1875 |  65414.55 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/258.txt          |   3,304.82 us |    50.7813 |         - |         - |    428.87 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/258.txt          | 129,091.35 us | 15500.0000 | 8250.0000 | 2250.0000 | 163046.95 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/258.txt          |   3,308.88 us |    50.7813 |         - |         - |    428.87 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/258.txt          | 128,979.90 us | 15500.0000 | 8250.0000 | 2250.0000 | 163046.95 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/258.txt          |   3,322.54 us |    50.7813 |         - |         - |    428.87 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/258.txt          |  14,270.74 us |   984.3750 |  984.3750 |  984.3750 | 130949.49 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/509.10mb.csv     |     570.23 us |     4.8828 |         - |         - |     43.74 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/509.10mb.csv     |  17,037.17 us |  3718.7500 | 2218.7500 | 1000.0000 |  30659.41 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/509.10mb.csv     |     572.15 us |     4.8828 |         - |         - |     43.74 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/509.10mb.csv     |  17,066.61 us |  3718.7500 | 2218.7500 | 1000.0000 |  30659.17 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/509.10mb.csv     |     584.31 us |     4.8828 |         - |         - |     43.74 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/509.10mb.csv     |   3,629.74 us |  1996.0938 | 1996.0938 | 1996.0938 |  32646.26 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/519.1mb.csv      |      82.87 us |     1.5869 |         - |         - |     13.64 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/519.1mb.csv      |   2,004.67 us |   496.0938 |  328.1250 |  164.0625 |   3626.41 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/519.1mb.csv      |      83.67 us |     1.5869 |         - |         - |     13.64 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/519.1mb.csv      |   2,004.99 us |   496.0938 |  332.0313 |  164.0625 |   3626.46 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/519.1mb.csv      |      83.13 us |     1.5869 |         - |         - |     13.64 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/519.1mb.csv      |     305.99 us |   523.9258 |  522.4609 |  522.4609 |   3973.38 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/530.2mb.csv      |     129.94 us |     1.7090 |         - |         - |     14.99 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/530.2mb.csv      |   2,808.70 us |   746.0938 |  371.0938 |  371.0938 |   6745.73 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/530.2mb.csv      |     131.89 us |     1.7090 |         - |         - |     14.99 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/530.2mb.csv      |   2,820.78 us |   746.0938 |  371.0938 |  371.0938 |   6745.73 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/530.2mb.csv      |     130.59 us |     1.7090 |         - |         - |     14.99 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/530.2mb.csv      |     606.98 us |  1007.8125 | 1006.8359 | 1006.8359 |   8069.46 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/545.5mb.csv      |     273.92 us |     2.4414 |         - |         - |     22.02 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/545.5mb.csv      |   9,839.98 us |  2125.0000 | 1375.0000 |  687.5000 |  15586.29 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/545.5mb.csv      |     276.00 us |     2.4414 |         - |         - |     22.02 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/545.5mb.csv      |   9,886.63 us |  2125.0000 | 1375.0000 |  687.5000 |  15586.42 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/545.5mb.csv      |     276.52 us |     2.4414 |         - |         - |     22.02 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/545.5mb.csv      |   1,675.55 us |  1000.0000 |  998.0469 |  998.0469 |  16261.48 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/558.50mb.csv     |   4,295.60 us |    78.1250 |         - |         - |    664.32 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/558.50mb.csv     |  98,312.11 us | 16833.3333 | 9333.3333 | 2333.3333 |  146841.1 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/558.50mb.csv     |   4,307.18 us |    78.1250 |         - |         - |    664.32 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/558.50mb.csv     |  95,113.31 us | 16800.0000 | 9200.0000 | 2200.0000 | 146840.35 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/558.50mb.csv     |   4,298.57 us |    78.1250 |         - |         - |    664.32 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/558.50mb.csv     |  15,937.04 us |   968.7500 |  968.7500 |  968.7500 | 130949.51 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/s1/kb.1.txt      |      25.04 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/s1/kb.1.txt      |      24.93 us |     1.3428 |    0.0305 |         - |      11.1 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/s1/kb.1.txt      |      24.97 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/s1/kb.1.txt      |      24.83 us |     1.3428 |    0.0305 |         - |      11.1 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/s1/kb.1.txt      |      24.96 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/s1/kb.1.txt      |      24.20 us |     0.6714 |         - |         - |      5.58 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/s1/kb.10.txt     |      25.72 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/s1/kb.10.txt     |      29.92 us |     4.0283 |    0.3662 |         - |     33.32 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/s1/kb.10.txt     |      25.59 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/s1/kb.10.txt     |      29.96 us |     4.0283 |    0.2441 |         - |     33.32 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/s1/kb.10.txt     |      25.56 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/s1/kb.10.txt     |      25.10 us |     1.7395 |    0.0305 |         - |     14.46 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/s1/kb.2.txt      |      25.07 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/s1/kb.2.txt      |      25.65 us |     1.6479 |    0.0610 |         - |     13.64 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/s1/kb.2.txt      |      25.05 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/s1/kb.2.txt      |      25.55 us |     1.6479 |    0.0305 |         - |     13.64 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/s1/kb.2.txt      |      25.07 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/s1/kb.2.txt      |      24.36 us |     0.7935 |         - |         - |      6.56 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/s1/kb.20.txt     |      26.27 us |     1.5259 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/s1/kb.20.txt     |      34.93 us |     7.0801 |    1.0376 |         - |        58 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/s1/kb.20.txt     |      26.22 us |     1.5259 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/s1/kb.20.txt     |      34.82 us |     7.0801 |    0.7324 |         - |        58 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/s1/kb.20.txt     |      26.21 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/s1/kb.20.txt     |      26.31 us |     2.9602 |    0.1526 |         - |     24.32 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/s1/kb.5.txt      |      25.61 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/s1/kb.5.txt      |      27.23 us |     2.5635 |    0.1526 |         - |     20.96 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/s1/kb.5.txt      |      25.53 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/s1/kb.5.txt      |      27.26 us |     2.5635 |    0.1221 |         - |     20.96 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/s1/kb.5.txt      |      25.59 us |     1.5564 |         - |         - |     12.77 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/s1/kb.5.txt      |      24.93 us |     1.1597 |         - |         - |      9.52 KB |
| ReadAllLinesWithFileReadAllLines_InDirect                                             | td/s1/kb.50.txt     |      27.98 us |     1.5259 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileReadAllLines_Direct                                               | td/s1/kb.50.txt     |      50.39 us |    15.8691 |    4.3945 |         - |       130 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_InDirect                          | td/s1/kb.50.txt     |      28.07 us |     1.5259 |         - |         - |     12.77 KB |
| ReadAllLinesWithFileOpenReadAndStreamReaderReadLine_Direct                            | td/s1/kb.50.txt     |      49.69 us |    15.8691 |    3.2349 |         - |       130 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_InDirect | td/s1/kb.50.txt     |      28.03 us |     1.5259 |         - |         - |     12.77 KB |
| ReadAllLinesAndSplitWithFileOpenReadToMemoryStreamAndAndStreamReaderReadLine_Direct   | td/s1/kb.50.txt     |      27.83 us |     6.5308 |    0.4272 |         - |     53.92 KB |



### 20250318


| Method                                                          | file                 | Mean          | Gen0       | Gen1       | Gen2      | Allocated    |
|---------------------------------------------------------------- |--------------------- |--------------:|-----------:|-----------:|----------:|-------------:|
| File_ReadAllLines_StringBuilder                                 | test-data/192.txt    |  21,746.69 us |   343.7500 |   343.7500 |  343.7500 | 116039.02 KB |
| File_ReadAllLines_ZString                                       | test-data/192.txt    |  17,703.25 us |   343.7500 |   343.7500 |  343.7500 |  77351.79 KB |
| File_ReadAllText                                                | test-data/192.txt    |  15,172.82 us |  5765.6250 |  3265.6250 | 1359.3750 |  77534.08 KB |
| StreamReader_ReadLine_StringBuilder                             | test-data/192.txt    |  21,605.03 us |   343.7500 |   343.7500 |  343.7500 |  116038.9 KB |
| StreamReader_ReadLine_ZString                                   | test-data/192.txt    |  17,818.43 us |   343.7500 |   343.7500 |  343.7500 |  77351.67 KB |
| StreamReader_ReadToEnd                                          | test-data/192.txt    |  15,522.56 us |  5750.0000 |  3250.0000 | 1359.3750 |  77534.08 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-data/192.txt    |  19,088.65 us | 10500.0000 |  4156.2500 | 1968.7500 | 116327.46 KB |
| StreamReader_ReadBlock_ZString                                  | test-data/192.txt    |   6,234.68 us |  4750.0000 |    31.2500 |   31.2500 |   38925.2 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-data/192.txt    |  19,003.16 us | 10500.0000 |  4156.2500 | 1968.7500 | 116327.33 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-data/192.txt    |   6,249.69 us |  4750.0000 |    31.2500 |   31.2500 |   38925.2 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-data/192.txt    |  15,895.56 us |  5750.0000 |  3250.0000 | 1343.7500 |  77541.83 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-data/192.txt    |  12,376.09 us |   171.8750 |   171.8750 |  171.8750 |  38688.11 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-data/192.txt    |  12,426.09 us |   171.8750 |   171.8750 |  171.8750 |  38688.17 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-data/192.txt    |   7,259.89 us |  2500.0000 |  2500.0000 | 2500.0000 |  65422.56 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-data/192.txt    |   1,370.70 us |    13.6719 |          - |         - |    111.83 KB |
| File_ReadAllLines_StringBuilder                                 | test-data/258.txt    | 187,357.55 us | 27333.3333 | 16000.0000 | 4666.6667 | 319745.33 KB |
| File_ReadAllLines_ZString                                       | test-data/258.txt    | 144,911.93 us | 15500.0000 |  8250.0000 | 2000.0000 | 241207.61 KB |
| File_ReadAllText                                                | test-data/258.txt    |  31,158.43 us | 10937.5000 |  5937.5000 | 1750.0000 | 163223.52 KB |
| StreamReader_ReadLine_StringBuilder                             | test-data/258.txt    |  62,651.71 us | 26500.0000 | 10750.0000 | 3625.0000 | 273941.29 KB |
| StreamReader_ReadLine_ZString                                   | test-data/258.txt    |  50,072.54 us | 14333.3333 |          - |         - | 195410.88 KB |
| StreamReader_ReadToEnd                                          | test-data/258.txt    |  31,288.14 us | 10937.5000 |  6000.0000 | 1750.0000 | 163223.07 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-data/258.txt    |  39,653.42 us | 22000.0000 |  8923.0769 | 2923.0769 | 244893.65 KB |
| StreamReader_ReadBlock_ZString                                  | test-data/258.txt    |  13,599.87 us | 10000.0000 |    93.7500 |   78.1250 |  81933.48 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-data/258.txt    |  39,643.47 us | 22000.0000 |  8923.0769 | 2923.0769 | 244893.62 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-data/258.txt    |  13,598.61 us | 10000.0000 |    93.7500 |   78.1250 |  81933.48 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-data/258.txt    |  32,787.36 us | 10937.5000 |  6000.0000 | 1750.0000 | 163231.39 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-data/258.txt    |  25,971.45 us |   125.0000 |   125.0000 |  125.0000 |   81434.2 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-data/258.txt    |  25,881.02 us |   125.0000 |   125.0000 |  125.0000 |  81434.27 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-data/258.txt    |  14,542.09 us |   984.3750 |   984.3750 |  984.3750 |  130957.5 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-data/258.txt    |   3,324.51 us |    50.7813 |          - |         - |    428.88 KB |
| File_ReadAllLines_StringBuilder                                 | test-(...)b.csv [22] |  26,492.38 us |  6656.2500 |  3656.2500 | 1968.7500 |   72510.4 KB |
| File_ReadAllLines_ZString                                       | test-(...)b.csv [22] |  23,220.51 us |  3625.0000 |  2093.7500 |  750.0000 |  51529.76 KB |
| File_ReadAllText                                                | test-(...)b.csv [22] |   7,409.64 us |  3335.9375 |  1906.2500 |  992.1875 |  41854.83 KB |
| StreamReader_ReadLine_StringBuilder                             | test-(...)b.csv [22] |  15,192.60 us |  6656.2500 |  3015.6250 | 1562.5000 |  66947.43 KB |
| StreamReader_ReadLine_ZString                                   | test-(...)b.csv [22] |  11,957.04 us |  3343.7500 |   312.5000 |  281.2500 |  45966.77 KB |
| StreamReader_ReadToEnd                                          | test-(...)b.csv [22] |   7,416.18 us |  3343.7500 |  1906.2500 |  984.3750 |  41854.92 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-(...)b.csv [22] |   9,895.11 us |  5937.5000 |  2703.1250 |  953.1250 |   62794.4 KB |
| StreamReader_ReadBlock_ZString                                  | test-(...)b.csv [22] |   3,258.49 us |  2570.3125 |    23.4375 |         - |   21015.5 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-(...)b.csv [22] |  10,072.01 us |  5937.5000 |  2687.5000 |  968.7500 |  62794.55 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-(...)b.csv [22] |   3,270.73 us |  2570.3125 |    23.4375 |         - |   21015.5 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-(...)b.csv [22] |   7,677.63 us |  3328.1250 |  1890.6250 |  984.3750 |  41862.77 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-(...)b.csv [22] |   6,217.29 us |   226.5625 |   226.5625 |  226.5625 |  20887.57 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-(...)b.csv [22] |   6,271.61 us |   226.5625 |   226.5625 |  226.5625 |  20887.63 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-(...)b.csv [22] |   3,678.62 us |  1984.3750 |  1980.4688 | 1980.4688 |  32654.27 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-(...)b.csv [22] |     557.02 us |     4.8828 |          - |         - |     43.75 KB |
| File_ReadAllLines_StringBuilder                                 | test-(...)b.csv [21] |   2,717.27 us |   996.0938 |   687.5000 |  687.5000 |   8525.98 KB |
| File_ReadAllLines_ZString                                       | test-(...)b.csv [21] |   2,229.72 us |   562.5000 |   414.0625 |  273.4375 |   6065.46 KB |
| File_ReadAllText                                                | test-(...)b.csv [21] |     616.21 us |   650.3906 |   469.7266 |  347.6563 |   4913.26 KB |
| StreamReader_ReadLine_StringBuilder                             | test-(...)b.csv [21] |   1,488.62 us |   998.0469 |   660.1563 |  337.8906 |   7841.24 KB |
| StreamReader_ReadLine_ZString                                   | test-(...)b.csv [21] |   1,272.04 us |   562.5000 |   210.9375 |  203.1250 |   5380.95 KB |
| StreamReader_ReadToEnd                                          | test-(...)b.csv [21] |     617.96 us |   650.3906 |   469.7266 |  347.6563 |   4913.21 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-(...)b.csv [21] |   1,268.53 us |   998.0469 |   644.5313 |  394.5313 |   7367.47 KB |
| StreamReader_ReadBlock_ZString                                  | test-(...)b.csv [21] |     386.01 us |   302.2461 |     8.7891 |         - |   2470.31 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-(...)b.csv [21] |   1,274.75 us |   998.0469 |   646.4844 |  394.5313 |   7367.47 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-(...)b.csv [21] |     394.84 us |   302.2461 |     8.7891 |         - |   2470.31 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-(...)b.csv [21] |     646.93 us |   651.3672 |   475.5859 |  347.6563 |   4921.13 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-(...)b.csv [21] |     606.16 us |   203.1250 |   201.1719 |  201.1719 |   2455.61 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-(...)b.csv [21] |     613.55 us |   203.1250 |   201.1719 |  201.1719 |   2455.77 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-(...)b.csv [21] |     317.17 us |   524.4141 |   521.9727 |  521.9727 |   3981.39 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-(...)b.csv [21] |      87.60 us |     1.5869 |          - |         - |     13.66 KB |
| File_ReadAllLines_StringBuilder                                 | test-(...)b.csv [21] |   6,573.64 us |  2156.2500 |  1492.1875 |  992.1875 |  15750.03 KB |
| File_ReadAllLines_ZString                                       | test-(...)b.csv [21] |   5,242.15 us |   976.5625 |   765.6250 |  375.0000 |  11232.62 KB |
| File_ReadAllText                                                | test-(...)b.csv [21] |   1,178.70 us |  1109.3750 |   802.7344 |  554.6875 |   9018.17 KB |
| StreamReader_ReadLine_StringBuilder                             | test-(...)b.csv [21] |   2,570.28 us |  2125.0000 |  1476.5625 |  996.0938 |  14410.26 KB |
| StreamReader_ReadLine_ZString                                   | test-(...)b.csv [21] |   2,482.88 us |   871.0938 |   234.3750 |  210.9375 |   9892.19 KB |
| StreamReader_ReadToEnd                                          | test-(...)b.csv [21] |   1,151.34 us |  1109.3750 |   804.6875 |  554.6875 |   9018.14 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-(...)b.csv [21] |   3,213.20 us |  2042.9688 |  1484.3750 |  937.5000 |  13531.23 KB |
| StreamReader_ReadBlock_ZString                                  | test-(...)b.csv [21] |     685.45 us |   553.7109 |    15.6250 |         - |   4530.99 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-(...)b.csv [21] |   3,212.77 us |  2039.0625 |  1480.4688 |  933.5938 |  13531.04 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-(...)b.csv [21] |     689.84 us |   553.7109 |    15.6250 |         - |   4530.99 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-(...)b.csv [21] |   1,172.00 us |  1109.3750 |   800.7813 |  554.6875 |   9026.13 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-(...)b.csv [21] |   1,236.27 us |   154.2969 |   152.3438 |  152.3438 |   4503.49 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-(...)b.csv [21] |   1,237.96 us |   154.2969 |   152.3438 |  152.3438 |   4503.55 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-(...)b.csv [21] |     610.43 us |  1006.8359 |  1006.8359 | 1006.8359 |   8077.47 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-(...)b.csv [21] |     130.64 us |     1.7090 |          - |         - |        15 KB |
| File_ReadAllLines_StringBuilder                                 | test-(...)b.csv [21] |  13,749.95 us |  3640.6250 |  1984.3750 |  984.3750 |  36900.72 KB |
| File_ReadAllLines_ZString                                       | test-(...)b.csv [21] |  11,788.02 us |  1906.2500 |  1140.6250 |  421.8750 |  26217.16 KB |
| File_ReadAllText                                                | test-(...)b.csv [21] |   3,390.30 us |  2257.8125 |  1578.1250 |  996.0938 |  21335.17 KB |
| StreamReader_ReadLine_StringBuilder                             | test-(...)b.csv [21] |   6,755.00 us |  3515.6250 |  1765.6250 |  984.3750 |  34104.52 KB |
| StreamReader_ReadLine_ZString                                   | test-(...)b.csv [21] |   6,152.29 us |  1875.0000 |   343.7500 |  312.5000 |  23420.42 KB |
| StreamReader_ReadToEnd                                          | test-(...)b.csv [21] |   3,395.21 us |  2304.6875 |  1613.2813 |  996.0938 |  21335.58 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-(...)b.csv [21] |   5,418.99 us |  3234.3750 |  1625.0000 |  992.1875 |  32003.37 KB |
| StreamReader_ReadBlock_ZString                                  | test-(...)b.csv [21] |   1,643.73 us |  1308.5938 |    27.3438 |         - |  10712.69 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-(...)b.csv [21] |   5,388.36 us |  3234.3750 |  1625.0000 |  992.1875 |  32003.29 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-(...)b.csv [21] |   1,628.08 us |  1308.5938 |    27.3438 |         - |  10712.69 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-(...)b.csv [21] |   3,391.21 us |  2265.6250 |  1585.9375 |  996.0938 |  21343.17 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-(...)b.csv [21] |   2,637.26 us |   238.2813 |   238.2813 |  238.2813 |  10647.53 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-(...)b.csv [21] |   2,629.74 us |   238.2813 |   238.2813 |  238.2813 |  10647.59 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-(...)b.csv [21] |   1,718.96 us |  1000.0000 |   998.0469 |  998.0469 |  16269.49 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-(...)b.csv [21] |     278.23 us |     2.4414 |          - |         - |     22.03 KB |
| File_ReadAllLines_StringBuilder                                 | test-(...)b.csv [22] | 137,369.51 us | 30500.0000 | 16750.0000 | 3750.0000 | 352501.58 KB |
| File_ReadAllLines_ZString                                       | test-(...)b.csv [22] | 118,389.79 us | 16400.0000 |  8800.0000 | 2200.0000 | 249435.83 KB |
| File_ReadAllText                                                | test-(...)b.csv [22] |  42,672.01 us | 14583.3333 |  8166.6667 | 2916.6667 | 205687.49 KB |
| StreamReader_ReadLine_StringBuilder                             | test-(...)b.csv [22] |  71,198.78 us | 29875.0000 | 11500.0000 | 3250.0000 | 328932.55 KB |
| StreamReader_ReadLine_ZString                                   | test-(...)b.csv [22] |  55,135.33 us | 15000.0000 |          - |         - | 225862.11 KB |
| StreamReader_ReadToEnd                                          | test-(...)b.csv [22] |  42,615.17 us | 14583.3333 |  8166.6667 | 2916.6667 | 205686.44 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-(...)b.csv [22] |  49,649.76 us | 27363.6364 | 10727.2727 | 3090.9091 | 308595.57 KB |
| StreamReader_ReadBlock_ZString                                  | test-(...)b.csv [22] |  17,096.74 us | 12687.5000 |   156.2500 |   93.7500 | 103241.84 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-(...)b.csv [22] |  49,380.03 us | 27363.6364 | 10727.2727 | 3090.9091 | 308595.95 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-(...)b.csv [22] |  17,178.41 us | 12687.5000 |   156.2500 |   93.7500 | 103241.84 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-(...)b.csv [22] |  44,286.76 us | 14583.3333 |  8166.6667 | 2916.6667 | 205695.09 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-(...)b.csv [22] |  31,880.95 us |   125.0000 |   125.0000 |  125.0000 | 102612.18 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-(...)b.csv [22] |  31,836.24 us |   125.0000 |   125.0000 |  125.0000 | 102612.24 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-(...)b.csv [22] |  16,482.67 us |   968.7500 |   968.7500 |  968.7500 | 130957.51 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-(...)b.csv [22] |   4,349.28 us |    78.1250 |          - |         - |    664.33 KB |


### 20250317

| Method                                                          | file              | Mean       | Gen0       | Gen1       | Gen2      | Allocated    |
|---------------------------------------------------------------- |------------------ |-----------:|-----------:|-----------:|----------:|-------------:|
| File_ReadAllLines_StringBuilder                                 | test-data/192.txt |  21.525 ms |   343.7500 |   343.7500 |  343.7500 | 116039.02 KB |
| File_ReadAllLines_ZString                                       | test-data/192.txt |  17.572 ms |   343.7500 |   343.7500 |  343.7500 |  77351.79 KB |
| File_ReadAllText                                                | test-data/192.txt |  15.056 ms |  5781.2500 |  3281.2500 | 1343.7500 |   77534.1 KB |
| StreamReader_ReadLine_StringBuilder                             | test-data/192.txt |  21.682 ms |   343.7500 |   343.7500 |  343.7500 |  116038.9 KB |
| StreamReader_ReadLine_ZString                                   | test-data/192.txt |  18.083 ms |   343.7500 |   343.7500 |  343.7500 |  77351.67 KB |
| StreamReader_ReadToEnd                                          | test-data/192.txt |  15.168 ms |  5781.2500 |  3281.2500 | 1343.7500 |  77534.07 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-data/192.txt |  18.781 ms | 10500.0000 |  4125.0000 | 1968.7500 | 116327.22 KB |
| StreamReader_ReadBlock_ZString                                  | test-data/192.txt |   6.248 ms |  4750.0000 |    31.2500 |   31.2500 |   38925.2 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-data/192.txt |  19.228 ms | 10500.0000 |  4125.0000 | 1968.7500 | 116327.48 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-data/192.txt |   6.283 ms |  4750.0000 |    31.2500 |   31.2500 |   38925.2 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-data/192.txt |  15.731 ms |  5750.0000 |  3250.0000 | 1343.7500 |  77542.02 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-data/192.txt |  12.200 ms |   171.8750 |   171.8750 |  171.8750 |  38688.11 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-data/192.txt |  12.489 ms |   171.8750 |   171.8750 |  171.8750 |  38688.17 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-data/192.txt |   7.358 ms |  2492.1875 |  2492.1875 | 2492.1875 |  65422.55 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-data/192.txt |   1.394 ms |    13.6719 |          - |         - |    111.83 KB |
| File_ReadAllLines_StringBuilder                                 | test-data/258.txt | 190.508 ms | 27333.3333 | 16000.0000 | 4666.6667 | 319746.23 KB |
| File_ReadAllLines_ZString                                       | test-data/258.txt | 144.995 ms | 15500.0000 |  8250.0000 | 2000.0000 | 241207.64 KB |
| File_ReadAllText                                                | test-data/258.txt |  31.303 ms | 11062.5000 |  6062.5000 | 1812.5000 | 163223.98 KB |
| StreamReader_ReadLine_StringBuilder                             | test-data/258.txt |  63.402 ms | 26500.0000 | 10750.0000 | 3625.0000 | 273940.47 KB |
| StreamReader_ReadLine_ZString                                   | test-data/258.txt |  50.247 ms | 14333.3333 |          - |         - | 195410.81 KB |
| StreamReader_ReadToEnd                                          | test-data/258.txt |  31.473 ms | 10937.5000 |  5937.5000 | 1750.0000 | 163223.18 KB |
| StreamReader_ReadBlock_StringBuilder                            | test-data/258.txt |  40.885 ms | 22000.0000 |  8923.0769 | 2923.0769 | 244893.46 KB |
| StreamReader_ReadBlock_ZString                                  | test-data/258.txt |  13.760 ms | 10031.2500 |    93.7500 |   62.5000 |  81933.61 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                  | test-data/258.txt |  39.993 ms | 22000.0000 |  8923.0769 | 2923.0769 | 244893.62 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                        | test-data/258.txt |  13.564 ms | 10000.0000 |    93.7500 |   78.1250 |  81933.48 KB |
| StreamReader_ReadBlock_Span_StringBuilder                       | test-data/258.txt |  32.608 ms | 11062.5000 |  6062.5000 | 1750.0000 | 163231.51 KB |
| StreamReader_ReadBlock_Span_ZString                             | test-data/258.txt |  25.884 ms |   125.0000 |   125.0000 |  125.0000 |  81434.21 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString         | test-data/258.txt |  26.807 ms |   125.0000 |   125.0000 |  125.0000 |  81434.27 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString           | test-data/258.txt |  14.719 ms |   984.3750 |   984.3750 |  984.3750 |  130957.5 KB |
| StreamReader_FileStream_RecyclableMemoryStream_ReadLine_ZString | test-data/258.txt |   3.427 ms |    50.7813 |          - |         - |    428.88 KB |



