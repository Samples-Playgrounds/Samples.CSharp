namespace Core.Data.Formatters.Text.JSON.SpanJSON;

public partial class
                                        Formatter
{
    public static
        string?
                                        SerializeNaive<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        result = global::SpanJson.JsonSerializer.Generic.Utf16.Serialize(t);

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
        
        result = global::SpanJson.JsonSerializer.Generic.Utf16.Serialize(t);

        return result;
    }
    
    public static
        T?
                                        DeserializeNaive<T>
                                        (
                                            string json
                                        )
    {
        T? t = default(T);
        
        t = global::SpanJson.JsonSerializer.Generic.Utf16.Deserialize<T>(json);

        return t;
    }
    
    public static
        T?
                                        DeserializeCached<T>
                                        (
                                            string json
                                        )
    {
        T? t = default(T);
        
        t = global::SpanJson.JsonSerializer.Generic.Utf16.Deserialize<T>(json);

        return t;
    }


}