# Benchmrks for `MemoryStream`

*   https://github.com/microsoft/Microsoft.IO.RecyclableMemoryStream

*   https://stackoverflow.com/questions/75003773/json-serialize-error-via-recyclablememorystream

*   https://www.infoworld.com/article/2261281/how-to-use-recyclablememorystream-in-net-core.html

*   https://medium.com/@matias.paulo84/recyclablememorystream-vs-memorystream-c4aa341324a9

*   https://github.com/matipaulo/Demos

## Results

### 20250104

| Method                                                                      | file                 | Mean      | Gen0     | Gen1     | Gen2     | Allocated  |
|---------------------------------------------------------------------------- |--------------------- |----------:|---------:|---------:|---------:|-----------:|
| File_csv_to_MemoryStream                                                    | files/email50.csv    |  23.63 us |   1.0986 |        - |        - |    9.02 KB |
| File_csv_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream     | files/email50.csv    |  23.93 us |   0.6104 |   0.3052 |        - |    5.05 KB |
| File_jpeg_01_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream | files(...).jpeg [48] |  36.98 us |   0.1221 |   0.0610 |        - |  106.67 KB |
| File_jpeg_01_to_MemoryStream                                                | files(...).jpeg [48] |  37.79 us |  33.3252 |  33.3252 |  33.3252 |  106.66 KB |
| File_jpeg_02_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream | files(...).jpeg [48] |  43.26 us |   0.1221 |   0.0610 |        - |  159.85 KB |
| File_jpeg_02_to_MemoryStream                                                | files(...).jpeg [48] |  43.85 us |  49.9878 |  49.9878 |  49.9878 |  159.83 KB |
| File_jpg_01_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream  | files(...)n.jpg [22] |  83.36 us |        - |        - |        - |     707 KB |
| File_zip_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream     | files/17818489.zip   |  97.86 us |        - |        - |        - |  874.58 KB |
| File_jpg_01_to_MemoryStream                                                 | files(...)n.jpg [22] | 100.55 us | 199.9512 | 199.9512 | 199.9512 |  707.13 KB |
| File_doc_02_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream  | files(...)3.doc [50] | 106.61 us |        - |        - |        - |  956.94 KB |
| File_zip_to_MemoryStream                                                    | files/17818489.zip   | 113.56 us | 249.8779 | 249.8779 | 249.8779 |  874.74 KB |
| File_doc_02_to_MemoryStream                                                 | files(...)3.doc [50] | 125.85 us | 249.7559 | 249.7559 | 249.7559 |  957.09 KB |
| File_doc_01_to_MemoryStream                                                 | files(...)3.doc [42] | 655.68 us | 275.3906 | 275.3906 | 275.3906 |  7075.5 KB |
| File_doc_01_to_static_RecyclableMemoryStreamManager_RecyclableMemoryStream  | files(...)3.doc [42] | 725.77 us |        - |        - |        - | 7074.09 KB |

