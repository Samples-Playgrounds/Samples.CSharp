namespace Core.Data.Formatters.Text.XML.SharpSerializer;

public partial class
                                        Formatter
{
    private static readonly 
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager
                                        = new ();

    static
        Polenter.Serialization.SharpSerializer 
                                        serializer
                                        = new();

    public static
        string?
                                        SerializeNaive<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        Polenter.Serialization.SharpSerializer serializer = new();
        
        using (Microsoft.IO.RecyclableMemoryStream stream = manager.GetStream())
        {
            var buffer = stream.GetBuffer();
            // serializer.Serialize(t, stream);
        }
        
        return result;
    }

    public static
        string?
                                        SerializeCached<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        MemoryStream stream = new ( );

        serializer.Serialize(t, stream);
        
        return result;
    }
    
    public static
        T?
                                        DeserializeNaive<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        Polenter.Serialization.SharpSerializer serializer = new();
        t = (T?)serializer.Deserialize(xml);

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
        
        t = (T?)serializer.Deserialize(xml);

        return t;
    }


}