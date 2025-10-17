namespace Core.Data.Formatters.Text.JSON.SpanJSON;

public partial class
                                        Formatter
{
    public static
        string?
                                        Serialize<T>
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
                                        Deserialize<T>
                                        (
                                            string json
                                        )
    {
        T? t = default(T);
        
        t = global::SpanJson.JsonSerializer.Generic.Utf16.Deserialize<T>(json);

        return t;
    }

}