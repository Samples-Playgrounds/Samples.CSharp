namespace Core.Data.Formatters.Text.XML.System.Xml.Serialization.XmlSerializer;

public partial class
                                        Formatter
{
    public static
        Dictionary
        <
            Type,
            global::System.Xml.Serialization.XmlSerializer
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
        
        global::System.Xml.Serialization.XmlSerializer serializer = new(typeof(T));
        
        using global::System.IO.StringWriter writer = new ();
        serializer.Serialize(writer, t);
        result = writer.ToString();
        
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
        
        global::System.Xml.Serialization.XmlSerializer serializer = Cache[typeof(T)];
        
        using global::System.IO.StringWriter writer = new ();
        serializer.Serialize(writer, t);
        result = writer.ToString();
        
        return result;
    }
    
    public static
        T
                                        DeserializeNaive<T>
                                        (
                                            string xml
                                        )
    {
        using global::System.IO.StringReader reader = new (xml);
        global::System.Xml.Serialization.XmlSerializer serializer = new(typeof(T));

        T t = (T) serializer.Deserialize(reader);

        return t;
    }
    
    public static
        T?
                                        DeserializeCached<T>
                                        (
                                            string xml
                                        )
    {
        using global::System.IO.StringReader reader = new (xml);
        global::System.Xml.Serialization.XmlSerializer serializer = Cache[typeof(T)];

        T? t = (T) serializer?.Deserialize(reader);

        return t;
    }


}