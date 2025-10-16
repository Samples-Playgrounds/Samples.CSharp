namespace Core.Data.Formatters.Text.XML.NetBike;

public partial class
                                        Formatter
{
    protected static 
        global::NetBike.Xml.XmlSerializer
                                        serializer 
                                        = 
                                        new();

    public static
        string
                                        SerializeNaive<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        global::NetBike.Xml.XmlSerializer serializer = new();

        using (global::System.IO.StringWriter writer = new())
        {
            serializer.Serialize(writer, t);
            result = writer.ToString();
        }

        return result;
    }

    public static
        string
                                        SerializeCached<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        using (global::System.IO.StringWriter writer = new())
        {
            serializer.Serialize(writer, t);
            result = writer.ToString();
        }

        return result;
    }
    
    public static
        T
                                        DeserializeNaive<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        global::NetBike.Xml.XmlSerializer serializer = new ();

        using (global::System.IO.StringReader reader = new (xml))
        {
            t = serializer.Deserialize<T>(reader);
        }

        return t;
    }
    
    public static
        T?
                                        DeserializeCached<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        using (global::System.IO.StringReader reader = new (xml))
        {
            t = serializer.Deserialize<T>(reader);
        }

        return t;
    }


}