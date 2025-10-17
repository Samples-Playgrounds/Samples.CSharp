using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Holisticware.Library.Snippets.Models;

using Holisticware.Library.Snippets.XML;
using Holisticware.Library.Snippets.JSON;

//Summary summary_w = BenchmarkRunner.Run<Benchmarks_XML_Weather>();
//Summary summary_i = BenchmarkRunner.Run<Benchmarks_XML_Iris>();

Summary summary_xml_person = BenchmarkRunner.Run<Benchmarks_XML_Person>();
Summary summary_json_person = BenchmarkRunner.Run<Benchmarks_JSON_Person>();


string root = "../../../../Holisticware.Library.Snippets.XML/Data/";
string file;

Benchmarks_XML_Person bm_xml = new();
Benchmarks_JSON_Person bm_json = new();

string content = string.Empty;
Person? person = null;

content = bm_xml.Test_02_System_Runtime_Serialization_DataContractSerializer_01_SerializeCached();
person = bm_xml.Test_02_System_Runtime_Serialization_DataContractSerializer_02_DeserializeNaive();

content = bm_json.Test_01_System_Text_Json_01_Serialize();
content = bm_json.Test_02_Newtonsoft_JSON_NET_01_Serialize_People();
person = bm_json.Test_01_System_Text_Json_02_Deserialize();

/*
//Console.WriteLine(summary_w);();


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
