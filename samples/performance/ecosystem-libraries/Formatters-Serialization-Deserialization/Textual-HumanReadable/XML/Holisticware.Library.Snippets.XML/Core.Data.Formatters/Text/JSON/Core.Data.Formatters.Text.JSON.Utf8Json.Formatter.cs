namespace Core.Data.Formatters.Text.JSON.Utf8Json;

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
        
        byte[] bytes = global::Utf8Json.JsonSerializer.Serialize(t);
    
        result = global::System.Text.Encoding.UTF8.GetString(bytes);
        
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
        
        t = global::Utf8Json.JsonSerializer.Deserialize<T>(json);

        return t;
    }

}