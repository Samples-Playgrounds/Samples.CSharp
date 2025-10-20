namespace Core.Data.Formatters.Text.XML.YAXLib;

public partial class
                                        Formatter
{
    public static
        string
                                        Serialize<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        global::YAXLib.YAXSerializer serializer = new (typeof(T));
        /*
        StringWriter sw = new ();
        global::System.Xml.XmlWriter xw = global::System.Xml.XmlWriter.Create(sw);
        serializer.Serialize(t, xw);
        xw.Flush();
        result = sw.ToString();
        */
        result = serializer.Serialize(t);
        
        return result;
    }
    
    public static
        T
                                        Deserialize<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        global::YAXLib.YAXSerializer deserializer = new (typeof(T));
        t = (T) deserializer.Deserialize(xml);
        
        return t;
    }
}