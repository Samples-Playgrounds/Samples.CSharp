using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.XML;

//Summary summary_w = BenchmarkRunner.Run<Benchmarks_XML_Weather>();
//Summary summary_i = BenchmarkRunner.Run<Benchmarks_XML_Iris>();

Benchmarks_XML_Weather bm = new();

string content = string.Empty;

/*
*/

content = bm.Test_11_Serialize_01_System_Runtime_Serialization_Serialize_with_MemoryStream();
content = bm.Test_12_Serialize_01_System_Xml_Serialization_Serialize_with_MemoryStream();

bm.Test_21_Deserialize_02_System_Runtime_Serialization_with_RecyclableMemoryStream();

return;
