namespace Core.Data.Formatters.Text.JSON.System.Text.Json;

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
        
        result = global::System.Text.Json.JsonSerializer.Serialize(t);
        
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
        
        t = global::System.Text.Json.JsonSerializer.Deserialize<T>(json);

        return t;
    }
}