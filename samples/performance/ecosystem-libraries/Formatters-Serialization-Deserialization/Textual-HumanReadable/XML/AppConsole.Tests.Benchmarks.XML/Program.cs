using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.XML;
using Holisticware.Library.Snippets.XML.Models;

//Summary summary_w = BenchmarkRunner.Run<Benchmarks_XML_Weather>();
//Summary summary_i = BenchmarkRunner.Run<Benchmarks_XML_Iris>();

Summary summary_p = BenchmarkRunner.Run<Benchmarks_XML_Person>();


/*
string root = "../../../../Holisticware.Library.Snippets.XML/Data/";
string file;

Benchmarks_XML_Person bm = new();

string content = string.Empty;
Person? person = null;

person = bm.Test_02_Deserialize_02_System_Runtime_Serialization_DeserializeNaive();


content = bm.Test_11_Serialize_01_System_Runtime_Serialization_Serialize_with_MemoryStream();
string data = "weather";
file = $"{root}/{data}.system-runtime-serialization--memory-stream.xml";
Console.WriteLine($"{file}");
System.IO.File.WriteAllText(file, content);
content = bm.Test_12_Serialize_01_System_Xml_Serialization_Serialize_with_MemoryStream();
file = $"{root}/{data}.system-xml-serialization--memory-stream.xml";
Console.WriteLine($"{file}");
System.IO.File.WriteAllText(file, content);
content = bm.Test_11_Serialize_02_System_Runtime_Serialization_Serialize_with_RecyclableMemoryStream();
file = $"{root}/{data}.system-runtime-serialization--recyclable-memory-stream.xml";
Console.WriteLine($"{file}");
System.IO.File.WriteAllText(file, content);
content = bm.Test_11_Serialize_02_System_Runtime_Serialization_Serialize_with_RecyclableMemoryStream();
file = $"{root}/{data}.system-xml-serialization--recyclable-memory-stream.xml";
Console.WriteLine($"{file}");
System.IO.File.WriteAllText(file, content);
*/

return;
