using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.XML;

Summary summary_w = BenchmarkRunner.Run<Benchmarks_XML_Weather>();
Summary summary_i = BenchmarkRunner.Run<Benchmarks_XML_Iris>();

/*
Benchmarks_XML bm = new();

   string content = string.Empty;

content = bm.Test_12_System_Xml_Serialization_Serialize_with_MemoryStream_Iris();
content = bm.Test_12_System_Xml_Serialization_Serialize_with_RecyclableMemoryStream_Iris();
*/

return;
