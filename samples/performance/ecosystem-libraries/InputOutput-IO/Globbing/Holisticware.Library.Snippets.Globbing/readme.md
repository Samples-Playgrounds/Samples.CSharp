# FileReading

Playground and benchmarking workspace for repos:

  https://github.com/HolisticWare-Libraries/HolisticWare.Core.IO

Execute benchmarks:

```shell
dotnet run \
    --configuration Release \
    --framework net9.0
    -- \
    --job short \
    --runtimes net8.0 net9.0 net10.0

```

*  Text

  *   https://code-maze.com/csharp-fastest-way-to-read-text-file/

      *   https://github.com/CodeMazeBlog/CodeMazeGuides/tree/main/files-csharp/FastestWayToReadATextFileInCsharp

    *   https://cc.davelozinski.com/c-sharp/fastest-way-to-read-text-files

      *   https://cc.davelozinski.com/c-sharp/the-fastest-way-to-read-and-process-text-files

        *   https://lemire.me/blog/2024/10/17/how-fast-can-you-parse-a-csv-file-in-c/

*   https://www.joelverhagen.com/blog/2020/12/fastest-net-csv-parsers

    *   https://github.com/joelverhagen/NCsvPerf/pulls

*   Binary

  *   https://stackoverflow.com/questions/8624071/save-and-load-memorystream-to-from-a-file

    *   https://www.reddit.com/r/csharp/comments/5sv0t1/the_absolute_fastest_way_to_read_bytes_from_a/


## Tips & Tricks

1.  ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString

2.  StreamReader_ReadBlock_ArrayPool_ZString

3.  StreamReader_FileStream_MemoryStream_ReadLine_ZString


## Results

## 20250626


```
BenchmarkDotNet v0.15.2, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
```


| Method                                                                                                 | file_path_test_data | Mean          | Median        | Gen0       | Gen1       | Gen2      | Allocated    |
|------------------------------------------------------------------------------------------------------- |-------------------- |--------------:|--------------:|-----------:|-----------:|----------:|-------------:|
| File_ReadAllLines_StringBuilder                                                                        | td/192.txt          |  22,237.59 μs |  22,105.45 μs |   343.7500 |   343.7500 |  343.7500 | 116039.06 KB |
| File_ReadAllLines_ZString                                                                              | td/192.txt          |  19,123.30 μs |  18,583.01 μs |   343.7500 |   343.7500 |  343.7500 |  77351.84 KB |
| File_ReadAllText                                                                                       | td/192.txt          |  15,633.57 μs |  15,492.06 μs |  5750.0000 |  3250.0000 | 1359.3750 |  77533.96 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/192.txt          |  22,193.10 μs |  22,150.08 μs |   343.7500 |   343.7500 |  343.7500 | 116038.95 KB |
| StreamReader_ReadLine_ZString                                                                          | td/192.txt          |  18,217.82 μs |  18,222.90 μs |   343.7500 |   343.7500 |  343.7500 |  77351.72 KB |
| StreamReader_ReadToEnd                                                                                 | td/192.txt          |  15,163.53 μs |  15,157.92 μs |  5765.6250 |  3265.6250 | 1359.3750 |  77534.13 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/192.txt          |  18,811.61 μs |  18,867.48 μs | 10500.0000 |  4156.2500 | 1968.7500 | 116327.66 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/192.txt          |   6,119.42 μs |   6,116.44 μs |  4750.0000 |    31.2500 |   31.2500 |  38925.26 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/192.txt          |  18,756.89 μs |  18,733.36 μs | 10500.0000 |  4156.2500 | 1968.7500 | 116327.62 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/192.txt          |   6,105.42 μs |   6,104.70 μs |  4750.0000 |    31.2500 |   31.2500 |  38925.26 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/192.txt          |  15,663.99 μs |  15,653.85 μs |  5750.0000 |  3250.0000 | 1343.7500 |   77542.1 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/192.txt          |  12,227.39 μs |  12,204.30 μs |   171.8750 |   171.8750 |  171.8750 |  38688.17 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/192.txt          |  12,343.31 μs |  12,351.84 μs |   171.8750 |   171.8750 |  171.8750 |  38688.23 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString                                                  | td/192.txt          |   7,138.03 μs |   7,149.98 μs |  2492.1875 |  2492.1875 | 2492.1875 |  65422.62 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect | td/192.txt          |   1,381.61 μs |   1,386.29 μs |    13.6719 |          - |         - |     111.9 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct   | td/192.txt          |   1,409.86 μs |   1,395.55 μs |    13.6719 |          - |         - |     111.9 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/258.txt          | 186,424.16 μs | 183,876.71 μs | 27333.3333 | 16000.0000 | 4666.6667 |  319743.7 KB |
| File_ReadAllLines_ZString                                                                              | td/258.txt          | 145,266.06 μs | 144,772.27 μs | 15500.0000 |  8250.0000 | 2000.0000 | 241207.52 KB |
| File_ReadAllText                                                                                       | td/258.txt          |  31,046.23 μs |  31,026.49 μs | 10937.5000 |  5937.5000 | 1750.0000 |  163222.6 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/258.txt          |  62,731.15 μs |  62,524.07 μs | 26555.5556 | 10777.7778 | 3666.6667 | 273939.29 KB |
| StreamReader_ReadLine_ZString                                                                          | td/258.txt          |  49,866.29 μs |  49,909.70 μs | 14300.0000 |          - |         - | 195410.88 KB |
| StreamReader_ReadToEnd                                                                                 | td/258.txt          |  31,033.31 μs |  30,872.88 μs | 10937.5000 |  5937.5000 | 1687.5000 | 163223.42 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/258.txt          |  38,877.14 μs |  38,867.94 μs | 22000.0000 |  8923.0769 | 2923.0769 | 244893.65 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/258.txt          |  13,396.93 μs |  13,374.05 μs | 10000.0000 |    93.7500 |   78.1250 |  81933.54 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/258.txt          |  39,449.52 μs |  39,085.66 μs | 22000.0000 |  8916.6667 | 2916.6667 | 244893.71 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/258.txt          |  13,669.24 μs |  13,613.34 μs | 10000.0000 |    93.7500 |   78.1250 |  81933.54 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/258.txt          |  32,478.88 μs |  32,292.72 μs | 11076.9231 |  6076.9231 | 1846.1538 |  163231.6 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/258.txt          |  26,001.76 μs |  26,087.44 μs |   125.0000 |   125.0000 |  125.0000 |  81434.25 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/258.txt          |  26,048.78 μs |  26,091.96 μs |   125.0000 |   125.0000 |  125.0000 |  81434.32 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString                                                  | td/258.txt          |  15,072.80 μs |  14,854.67 μs |   984.3750 |   984.3750 |  984.3750 | 130957.56 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect | td/258.txt          |   3,412.09 μs |   3,409.38 μs |    50.7813 |          - |         - |    428.95 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct   | td/258.txt          |   3,388.57 μs |   3,387.53 μs |    50.7813 |          - |         - |    428.95 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/509.10mb.csv     |  27,048.49 μs |  26,805.12 μs |  6656.2500 |  3656.2500 | 1968.7500 |  72509.62 KB |
| File_ReadAllLines_ZString                                                                              | td/509.10mb.csv     |  24,164.60 μs |  24,344.36 μs |  3625.0000 |  2093.7500 |  750.0000 |  51529.77 KB |
| File_ReadAllText                                                                                       | td/509.10mb.csv     |   7,847.76 μs |   7,751.79 μs |  3343.7500 |  1906.2500 |  984.3750 |  41854.97 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/509.10mb.csv     |  15,265.71 μs |  15,286.99 μs |  6656.2500 |  3109.3750 | 1750.0000 |  66947.66 KB |
| StreamReader_ReadLine_ZString                                                                          | td/509.10mb.csv     |  12,052.01 μs |  11,961.67 μs |  3343.7500 |   312.5000 |  281.2500 |  45966.62 KB |
| StreamReader_ReadToEnd                                                                                 | td/509.10mb.csv     |   7,523.42 μs |   7,519.57 μs |  3343.7500 |  1906.2500 |  984.3750 |  41854.83 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/509.10mb.csv     |  11,073.15 μs |  10,957.62 μs |  5984.3750 |  2750.0000 | 1015.6250 |  62794.71 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/509.10mb.csv     |   3,412.89 μs |   3,392.66 μs |  2570.3125 |    23.4375 |         - |  21015.56 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/509.10mb.csv     |  10,321.62 μs |  10,212.65 μs |  5984.3750 |  2750.0000 | 1015.6250 |  62794.61 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/509.10mb.csv     |   3,286.83 μs |   3,276.36 μs |  2570.3125 |    23.4375 |         - |  21015.56 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/509.10mb.csv     |   7,792.02 μs |   7,816.82 μs |  3328.1250 |  1890.6250 |  984.3750 |  41862.66 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/509.10mb.csv     |   6,440.36 μs |   6,450.68 μs |   226.5625 |   226.5625 |  226.5625 |  20887.63 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/509.10mb.csv     |   6,453.46 μs |   6,423.90 μs |   226.5625 |   226.5625 |  226.5625 |  20887.69 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString                                                  | td/509.10mb.csv     |   3,834.64 μs |   3,820.36 μs |  1984.3750 |  1980.4688 | 1980.4688 |  32654.34 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect | td/509.10mb.csv     |     599.69 μs |     596.71 μs |     4.8828 |          - |         - |     43.82 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct   | td/509.10mb.csv     |     593.55 μs |     597.31 μs |     4.8828 |          - |         - |     43.82 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/519.1mb.csv      |   2,796.10 μs |   2,797.39 μs |   996.0938 |   683.5938 |  683.5938 |   8526.06 KB |
| File_ReadAllLines_ZString                                                                              | td/519.1mb.csv      |   2,279.98 μs |   2,277.03 μs |   562.5000 |   414.0625 |  273.4375 |   6065.38 KB |
| File_ReadAllText                                                                                       | td/519.1mb.csv      |     657.56 μs |     657.45 μs |   650.3906 |   471.6797 |  347.6563 |   4913.41 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/519.1mb.csv      |   1,491.78 μs |   1,487.16 μs |   998.0469 |   660.1563 |  337.8906 |   7841.78 KB |
| StreamReader_ReadLine_ZString                                                                          | td/519.1mb.csv      |   1,317.02 μs |   1,317.49 μs |   562.5000 |   210.9375 |  203.1250 |   5381.02 KB |
| StreamReader_ReadToEnd                                                                                 | td/519.1mb.csv      |     653.54 μs |     654.99 μs |   650.3906 |   471.6797 |  347.6563 |   4913.38 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/519.1mb.csv      |   1,303.70 μs |   1,300.17 μs |   998.0469 |   648.4375 |  394.5313 |   7367.53 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/519.1mb.csv      |     418.13 μs |     414.84 μs |   302.2461 |     8.7891 |         - |   2470.38 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/519.1mb.csv      |   1,301.09 μs |   1,299.24 μs |   998.0469 |   648.4375 |  394.5313 |   7367.52 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/519.1mb.csv      |     416.62 μs |     414.30 μs |   302.2461 |     8.7891 |         - |   2470.38 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/519.1mb.csv      |     672.17 μs |     671.07 μs |   651.3672 |   475.5859 |  347.6563 |   4921.28 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/519.1mb.csv      |     625.14 μs |     624.15 μs |   207.0313 |   205.0781 |  205.0781 |   2455.73 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/519.1mb.csv      |     619.17 μs |     617.27 μs |   206.0547 |   204.1016 |  204.1016 |    2455.8 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString                                                  | td/519.1mb.csv      |     335.92 μs |     334.29 μs |   525.8789 |   523.4375 |  523.4375 |   3981.44 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect | td/519.1mb.csv      |     110.45 μs |     110.49 μs |     1.5869 |          - |         - |     13.73 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct   | td/519.1mb.csv      |     110.95 μs |     110.51 μs |     1.5869 |          - |         - |     13.73 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/530.2mb.csv      |   6,500.53 μs |   6,492.88 μs |  2156.2500 |  1492.1875 |  992.1875 |  15750.12 KB |
| File_ReadAllLines_ZString                                                                              | td/530.2mb.csv      |   5,287.96 μs |   5,268.80 μs |   976.5625 |   765.6250 |  375.0000 |  11232.89 KB |
| File_ReadAllText                                                                                       | td/530.2mb.csv      |   1,153.35 μs |   1,151.22 μs |  1109.3750 |   802.7344 |  554.6875 |   9018.21 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/530.2mb.csv      |   2,568.71 μs |   2,563.80 μs |  2121.0938 |  1472.6563 |  996.0938 |  14410.02 KB |
| StreamReader_ReadLine_ZString                                                                          | td/530.2mb.csv      |   2,536.33 μs |   2,541.78 μs |   871.0938 |   230.4688 |  210.9375 |   9892.09 KB |
| StreamReader_ReadToEnd                                                                                 | td/530.2mb.csv      |   1,167.51 μs |   1,165.67 μs |  1109.3750 |   802.7344 |  554.6875 |   9018.21 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/530.2mb.csv      |   3,243.80 μs |   3,243.04 μs |  2023.4375 |  1460.9375 |  914.0625 |  13530.94 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/530.2mb.csv      |     718.98 μs |     720.72 μs |   553.7109 |    15.6250 |         - |   4531.06 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/530.2mb.csv      |   3,367.55 μs |   3,508.35 μs |  2015.6250 |  1460.9375 |  914.0625 |  13530.94 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/530.2mb.csv      |     704.80 μs |     704.76 μs |   553.7109 |    15.6250 |         - |   4531.06 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/530.2mb.csv      |   1,191.54 μs |   1,193.31 μs |  1109.3750 |   800.7813 |  554.6875 |   9026.18 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/530.2mb.csv      |   1,264.61 μs |   1,262.77 μs |   154.2969 |   152.3438 |  152.3438 |   4503.56 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/530.2mb.csv      |   1,257.04 μs |   1,253.50 μs |   154.2969 |   152.3438 |  152.3438 |   4503.62 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString                                                  | td/530.2mb.csv      |     637.92 μs |     636.49 μs |  1006.8359 |  1004.8828 | 1004.8828 |   8077.54 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect | td/530.2mb.csv      |     159.12 μs |     158.91 μs |     1.7090 |          - |         - |     15.07 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct   | td/530.2mb.csv      |     158.02 μs |     157.85 μs |     1.7090 |          - |         - |     15.07 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/545.5mb.csv      |  13,472.17 μs |  13,416.00 μs |  3515.6250 |  1984.3750 |  984.3750 |  36900.35 KB |
| File_ReadAllLines_ZString                                                                              | td/545.5mb.csv      |  11,759.94 μs |  11,778.81 μs |  1906.2500 |  1140.6250 |  421.8750 |  26217.09 KB |
| File_ReadAllText                                                                                       | td/545.5mb.csv      |   3,401.53 μs |   3,403.34 μs |  2273.4375 |  1589.8438 |  996.0938 |   21335.4 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/545.5mb.csv      |   6,596.27 μs |   6,607.43 μs |  3500.0000 |  1773.4375 |  992.1875 |  34104.31 KB |
| StreamReader_ReadLine_ZString                                                                          | td/545.5mb.csv      |   6,094.38 μs |   6,083.49 μs |  1875.0000 |   343.7500 |  312.5000 |  23420.78 KB |
| StreamReader_ReadToEnd                                                                                 | td/545.5mb.csv      |   3,416.53 μs |   3,404.22 μs |  2289.0625 |  1601.5625 |  996.0938 |  21335.42 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/545.5mb.csv      |   5,369.25 μs |   5,381.15 μs |  3234.3750 |  1625.0000 |  992.1875 |  32003.49 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/545.5mb.csv      |   1,655.35 μs |   1,653.15 μs |  1308.5938 |    27.3438 |         - |  10712.76 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/545.5mb.csv      |   5,387.00 μs |   5,391.94 μs |  3234.3750 |  1625.0000 |  992.1875 |  32003.41 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/545.5mb.csv      |   1,646.20 μs |   1,640.27 μs |  1308.5938 |    27.3438 |         - |  10712.76 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/545.5mb.csv      |   3,340.07 μs |   3,345.03 μs |  2250.0000 |  1574.2188 |  996.0938 |  21343.23 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/545.5mb.csv      |   2,610.96 μs |   2,606.83 μs |   238.2813 |   238.2813 |  238.2813 |  10647.59 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/545.5mb.csv      |   2,649.81 μs |   2,656.39 μs |   238.2813 |   238.2813 |  238.2813 |  10647.66 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString                                                  | td/545.5mb.csv      |   1,748.47 μs |   1,748.84 μs |  1000.0000 |   998.0469 |  998.0469 |  16269.55 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect | td/545.5mb.csv      |     311.08 μs |     312.09 μs |     2.4414 |          - |         - |      22.1 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct   | td/545.5mb.csv      |     305.88 μs |     305.33 μs |     2.4414 |          - |         - |      22.1 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/558.50mb.csv     | 139,753.90 μs | 137,836.68 μs | 30750.0000 | 17000.0000 | 4000.0000 | 352504.05 KB |
| File_ReadAllLines_ZString                                                                              | td/558.50mb.csv     | 119,987.98 μs | 118,548.72 μs | 16400.0000 |  8800.0000 | 2200.0000 | 249435.73 KB |
| File_ReadAllText                                                                                       | td/558.50mb.csv     |  42,025.18 μs |  41,942.28 μs | 14583.3333 |  8166.6667 | 2916.6667 | 205687.51 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/558.50mb.csv     |  70,980.69 μs |  70,784.90 μs | 29875.0000 | 11500.0000 | 3250.0000 |  328934.4 KB |
| StreamReader_ReadLine_ZString                                                                          | td/558.50mb.csv     |  54,665.82 μs |  54,651.15 μs | 15000.0000 |          - |         - |  225862.1 KB |
| StreamReader_ReadToEnd                                                                                 | td/558.50mb.csv     |  42,245.37 μs |  42,146.03 μs | 14583.3333 |  8166.6667 | 2916.6667 | 205688.66 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/558.50mb.csv     |  48,993.09 μs |  49,219.23 μs | 27363.6364 | 10727.2727 | 3090.9091 | 308595.51 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/558.50mb.csv     |  16,987.40 μs |  16,996.86 μs | 12687.5000 |   156.2500 |   93.7500 | 103241.89 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/558.50mb.csv     |  49,187.28 μs |  49,212.51 μs | 27363.6364 | 10727.2727 | 3090.9091 |  308595.5 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/558.50mb.csv     |  17,246.70 μs |  17,188.70 μs | 12687.5000 |   156.2500 |   93.7500 | 103241.89 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/558.50mb.csv     |  43,735.60 μs |  43,691.53 μs | 14583.3333 |  8083.3333 | 2916.6667 | 205694.36 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/558.50mb.csv     |  31,460.71 μs |  31,402.90 μs |   125.0000 |   125.0000 |  125.0000 | 102612.21 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/558.50mb.csv     |  31,433.19 μs |  31,450.43 μs |   125.0000 |   125.0000 |  125.0000 | 102612.27 KB |
| StreamReader_FileStream_MemoryStream_ReadLine_ZString                                                  | td/558.50mb.csv     |  15,950.69 μs |  15,972.95 μs |   968.7500 |   968.7500 |  968.7500 | 130957.56 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_InDirect | td/558.50mb.csv     |   4,380.84 μs |   4,375.86 μs |    78.1250 |          - |         - |    664.39 KB |
| ReadAllTextWithFileUsingStreamRecyclableAndMemoryStreamAndStreamReaderAndReadBlockIntoZString_Direct   | td/558.50mb.csv     |   4,409.79 μs |   4,417.52 μs |    78.1250 |          - |         - |    664.39 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/s1/kb.1.txt      |      52.67 μs |      52.71 μs |     2.0142 |     0.0610 |         - |     16.73 KB |
| File_ReadAllLines_ZString                                                                              | td/s1/kb.1.txt      |      52.44 μs |      52.43 μs |     1.5869 |          - |         - |     13.19 KB |
| File_ReadAllText                                                                                       | td/s1/kb.1.txt      |      51.46 μs |      51.43 μs |     1.5259 |          - |         - |     12.69 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/s1/kb.1.txt      |      52.37 μs |      52.33 μs |     1.9531 |     0.0610 |         - |     16.31 KB |
| StreamReader_ReadLine_ZString                                                                          | td/s1/kb.1.txt      |      51.97 μs |      52.00 μs |     1.5259 |          - |         - |     12.77 KB |
| StreamReader_ReadToEnd                                                                                 | td/s1/kb.1.txt      |      51.17 μs |      51.30 μs |     1.5259 |          - |         - |     12.69 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/s1/kb.1.txt      |      53.71 μs |      53.90 μs |     2.7466 |     0.1221 |         - |     22.71 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/s1/kb.1.txt      |      52.41 μs |      52.49 μs |     2.2583 |     0.1221 |         - |     18.65 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/s1/kb.1.txt      |      52.37 μs |      52.37 μs |     2.7466 |     0.0610 |         - |     22.71 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/s1/kb.1.txt      |      51.96 μs |      52.01 μs |     2.2583 |     0.1221 |         - |     18.65 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/s1/kb.1.txt      |      51.68 μs |      51.95 μs |     2.5024 |     0.0610 |         - |     20.71 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/s1/kb.1.txt      |      52.00 μs |      52.06 μs |     2.2583 |     0.0610 |         - |     18.59 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/s1/kb.1.txt      |      52.21 μs |      52.20 μs |     2.2583 |          - |         - |     18.66 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/s1/kb.10.txt     |      60.48 μs |      60.47 μs |     9.5215 |     1.2207 |         - |     78.78 KB |
| File_ReadAllLines_ZString                                                                              | td/s1/kb.10.txt     |      59.44 μs |      59.54 μs |     6.4697 |     0.6104 |         - |     53.15 KB |
| File_ReadAllText                                                                                       | td/s1/kb.10.txt     |      55.69 μs |      55.67 μs |     7.3242 |     0.8545 |         - |     60.38 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/s1/kb.10.txt     |      58.60 μs |      58.67 μs |     9.1553 |          - |         - |     75.84 KB |
| StreamReader_ReadLine_ZString                                                                          | td/s1/kb.10.txt     |      58.00 μs |      57.92 μs |     6.1035 |          - |         - |      50.2 KB |
| StreamReader_ReadToEnd                                                                                 | td/s1/kb.10.txt     |      56.09 μs |      55.76 μs |     7.3242 |     0.8545 |         - |     60.38 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/s1/kb.10.txt     |      57.79 μs |      57.75 μs |    10.7422 |     0.1221 |         - |     88.06 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/s1/kb.10.txt     |      55.26 μs |      55.28 μs |     4.4556 |     0.1221 |         - |      36.5 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/s1/kb.10.txt     |      57.07 μs |      57.06 μs |    10.7422 |     0.1221 |         - |     88.06 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/s1/kb.10.txt     |      55.21 μs |      55.25 μs |     4.4556 |     0.1221 |         - |      36.5 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/s1/kb.10.txt     |      56.02 μs |      56.08 μs |     8.3008 |     0.1221 |         - |     68.26 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/s1/kb.10.txt     |      55.36 μs |      55.29 μs |     4.3945 |          - |         - |     36.35 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/s1/kb.10.txt     |      55.68 μs |      55.66 μs |     4.3945 |          - |         - |     36.42 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/s1/kb.2.txt      |      53.60 μs |      53.66 μs |     2.9907 |     0.1831 |         - |     24.44 KB |
| File_ReadAllLines_ZString                                                                              | td/s1/kb.2.txt      |      53.46 μs |      53.47 μs |     2.1362 |     0.0610 |         - |      17.7 KB |
| File_ReadAllText                                                                                       | td/s1/kb.2.txt      |      52.33 μs |      52.37 μs |     2.0142 |          - |         - |     16.76 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/s1/kb.2.txt      |      53.15 μs |      53.20 μs |     2.8687 |     0.1221 |         - |     23.67 KB |
| StreamReader_ReadLine_ZString                                                                          | td/s1/kb.2.txt      |      53.25 μs |      53.24 μs |     2.0142 |          - |         - |     16.92 KB |
| StreamReader_ReadToEnd                                                                                 | td/s1/kb.2.txt      |      52.16 μs |      52.20 μs |     2.0142 |          - |         - |     16.76 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/s1/kb.2.txt      |      53.01 μs |      52.97 μs |     3.4790 |     0.0610 |         - |     28.63 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/s1/kb.2.txt      |      52.69 μs |      52.68 μs |     2.5024 |     0.0610 |         - |     20.62 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/s1/kb.2.txt      |      53.23 μs |      53.15 μs |     3.4790 |     0.0610 |         - |     28.63 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/s1/kb.2.txt      |      52.48 μs |      52.49 μs |     2.5024 |     0.1221 |         - |     20.62 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/s1/kb.2.txt      |      52.65 μs |      52.81 μs |     2.9907 |     0.1221 |         - |     24.66 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/s1/kb.2.txt      |      52.62 μs |      52.59 μs |     2.5024 |     0.1221 |         - |     20.57 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/s1/kb.2.txt      |      52.98 μs |      53.01 μs |     2.5024 |     0.0610 |         - |     20.63 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/s1/kb.20.txt     |      66.75 μs |      66.80 μs |    16.8457 |     4.1504 |         - |    138.89 KB |
| File_ReadAllLines_ZString                                                                              | td/s1/kb.20.txt     |      65.79 μs |      65.78 μs |    11.8408 |     1.9531 |         - |     97.56 KB |
| File_ReadAllText                                                                                       | td/s1/kb.20.txt     |      58.90 μs |      58.95 μs |    11.5967 |     1.8311 |         - |      95.8 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/s1/kb.20.txt     |      65.09 μs |      65.21 μs |    16.2354 |     0.9766 |         - |    133.14 KB |
| StreamReader_ReadLine_ZString                                                                          | td/s1/kb.20.txt     |      63.69 μs |      63.72 μs |    11.2305 |     0.2441 |         - |     91.81 KB |
| StreamReader_ReadToEnd                                                                                 | td/s1/kb.20.txt     |      59.09 μs |      59.11 μs |    11.5967 |     1.8311 |         - |      95.8 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/s1/kb.20.txt     |      61.51 μs |      61.53 μs |    17.4561 |     1.7090 |         - |    143.25 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/s1/kb.20.txt     |      58.50 μs |      58.52 μs |     6.8359 |     0.1221 |         - |     56.32 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/s1/kb.20.txt     |      60.84 μs |      61.17 μs |    17.4561 |     1.5869 |         - |    143.25 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/s1/kb.20.txt     |      58.35 μs |      58.28 μs |     6.8359 |     0.1221 |         - |     56.32 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/s1/kb.20.txt     |      59.79 μs |      59.80 μs |    12.5732 |     0.2441 |         - |    103.68 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/s1/kb.20.txt     |      58.33 μs |      58.33 μs |     6.8359 |          - |         - |     56.08 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/s1/kb.20.txt     |      58.75 μs |      58.62 μs |     6.8359 |          - |         - |     56.14 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/s1/kb.5.txt      |      56.41 μs |      56.39 μs |     5.3711 |     0.4272 |         - |     43.99 KB |
| File_ReadAllLines_ZString                                                                              | td/s1/kb.5.txt      |      55.38 μs |      55.45 μs |     3.7842 |     0.2441 |         - |     30.94 KB |
| File_ReadAllText                                                                                       | td/s1/kb.5.txt      |      53.52 μs |      53.61 μs |     4.2114 |     0.1831 |         - |     34.81 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/s1/kb.5.txt      |      55.48 μs |      55.49 μs |     5.1880 |     0.1831 |         - |     42.47 KB |
| StreamReader_ReadLine_ZString                                                                          | td/s1/kb.5.txt      |      54.68 μs |      54.76 μs |     3.5400 |     0.0610 |         - |     29.41 KB |
| StreamReader_ReadToEnd                                                                                 | td/s1/kb.5.txt      |      53.53 μs |      53.51 μs |     4.2114 |     0.2441 |         - |     34.81 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/s1/kb.5.txt      |      54.85 μs |      54.79 μs |     6.4087 |     0.3052 |         - |     52.61 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/s1/kb.5.txt      |      53.75 μs |      53.75 μs |     3.2349 |     0.1221 |         - |     26.59 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/s1/kb.5.txt      |      54.24 μs |      54.18 μs |     6.4087 |     0.3052 |         - |     52.61 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/s1/kb.5.txt      |      53.39 μs |      53.28 μs |     3.2349 |     0.1221 |         - |     26.59 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/s1/kb.5.txt      |      54.31 μs |      54.32 μs |     5.1880 |     0.1831 |         - |      42.7 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/s1/kb.5.txt      |      53.69 μs |      53.72 μs |     3.2349 |     0.0610 |         - |     26.49 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/s1/kb.5.txt      |      53.57 μs |      53.67 μs |     3.2349 |          - |         - |     26.55 KB |
| File_ReadAllLines_StringBuilder                                                                        | td/s1/kb.50.txt     |     100.19 μs |     100.29 μs |    31.1279 |    31.1279 |   31.1279 |    332.86 KB |
| File_ReadAllLines_ZString                                                                              | td/s1/kb.50.txt     |      98.47 μs |      98.60 μs |    31.1279 |    31.1279 |   31.1279 |    228.75 KB |
| File_ReadAllText                                                                                       | td/s1/kb.50.txt     |      77.91 μs |      77.74 μs |    31.1279 |    31.1279 |   31.1279 |    217.79 KB |
| StreamReader_ReadLine_StringBuilder                                                                    | td/s1/kb.50.txt     |      97.66 μs |      97.70 μs |    31.1279 |    31.1279 |   31.1279 |    320.75 KB |
| StreamReader_ReadLine_ZString                                                                          | td/s1/kb.50.txt     |      96.08 μs |      96.26 μs |    31.1279 |    31.1279 |   31.1279 |    216.64 KB |
| StreamReader_ReadToEnd                                                                                 | td/s1/kb.50.txt     |      77.58 μs |      77.65 μs |    31.1279 |    31.1279 |   31.1279 |    217.79 KB |
| StreamReader_ReadBlock_StringBuilder                                                                   | td/s1/kb.50.txt     |      83.07 μs |      83.14 μs |    31.1279 |    31.1279 |   31.1279 |    324.61 KB |
| StreamReader_ReadBlock_ZString                                                                         | td/s1/kb.50.txt     |      67.23 μs |      67.67 μs |    14.1602 |     0.3662 |         - |     115.9 KB |
| StreamReader_ReadBlock_ArrayPool_StringBuilder                                                         | td/s1/kb.50.txt     |      82.86 μs |      82.78 μs |    31.1279 |    31.1279 |   31.1279 |    324.61 KB |
| StreamReader_ReadBlock_ArrayPool_ZString                                                               | td/s1/kb.50.txt     |      67.57 μs |      67.54 μs |    14.1602 |     0.3662 |         - |     115.9 KB |
| StreamReader_ReadBlock_Span_StringBuilder                                                              | td/s1/kb.50.txt     |      77.89 μs |      77.82 μs |    31.1279 |    31.1279 |   31.1279 |    225.67 KB |
| StreamReader_ReadBlock_Span_ZString                                                                    | td/s1/kb.50.txt     |      79.99 μs |      79.95 μs |    31.1279 |    31.1279 |   31.1279 |    115.29 KB |
| StreamReader_FileStream_BufferedStream_ReadLine_ZString                                                | td/s1/kb.50.txt     |      78.99 μs |      78.28 μs |    31.1279 |    31.1279 |   31.1279 |    115.35 KB |


## 202506

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



