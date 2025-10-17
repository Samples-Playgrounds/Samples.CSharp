namespace Core.Data.Formatters.Text.XML.System.Runtime.Serialization.DataContractSerializer;

/// <summary>
///
/// Sensitive to
///     XML namespaces
///     Attributes - opt in serializer (must be told what needs to be serialized)
///         
/// </summary>
public partial class
                                        Formatter
{
    public static
        Dictionary
        <
            Type,
            global::System.Runtime.Serialization.DataContractSerializer
        >
                                        Cache
                                        = new ();
    
    
    [
        Obsolete
        (
            """
            Use this only for quick tests. Non cached version is performance killer and source of memory leaks!!!
            """
        )
    ]   
    public static
        string
                                        SerializeNaive<T>
                                        (
                                            T t
                                        )
    {
        string? result;
        
        global::System.Runtime.Serialization.DataContractSerializer serializer = new(typeof(T));
        
        using global::System.IO.StringWriter sw = new ();
        using global::System.Xml.XmlWriter writer = global::System.Xml.XmlWriter.Create(sw);
        serializer.WriteObject(writer, t);
        writer.Flush();
        result = sw.ToString();
        
        return result;
    }
    
    public static
        string
                                        SerializeCached<T>
                                        (
                                            T t
                                        )
    {
        string? result;
        
        global::System.Runtime.Serialization.DataContractSerializer serializer = Cache[typeof(T)];
        
        using global::System.IO.StringWriter sw = new ();
        using global::System.Xml.XmlWriter writer = global::System.Xml.XmlWriter.Create(sw);
        serializer.WriteObject(writer, t);
        writer.Flush();
        result = sw.ToString();
        
        return result;
    }
    
    public static
        T
                                        DeserializeNaive<T>
                                        (
                                            string xml
                                        )
    {
        T? result = default(T);
        
        Type type = typeof(T);
        global::System.Runtime.Serialization.DataContractSerializer serializer = new
                                                                                    (
                                                                                        type,
                                                                                        type.Name,
                                                                                        ""
                                                                                    );
        using (global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(new StringReader(xml)))
        {
            result = (T)serializer.ReadObject(reader);
        }
        
        return result;
    }
    
    public static
        T?
                                        DeserializeCached<T>
                                        (
                                            string xml
                                        )
    {
        T? result = default(T);
        
        global::System.Runtime.Serialization.DataContractSerializer serializer = Cache[typeof(T)];
        using (global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(new StringReader(xml)))
        {
            T? t = (T)serializer?.ReadObject(reader);
        }
        
        return result;
    }


}