using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.XML;

//Summary summary = BenchmarkRunner.Run<Benchmarks_XML>();

Benchmarks_XML bm = new();

/*
*/
string content = string.Empty;

content = bm.Test_11_System_Xml_Serialization_Serialize_with_MemoryStream_Iris();
content = bm.Test_11_System_Xml_Serialization_Serialize_with_RecyclableMemoryStream_Iris();

return;
