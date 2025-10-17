namespace Core.Data.Formatters.Text.JSON.NetJSON;

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
        
        result = global::NetJSON.NetJSON.Serialize(t);

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
        
        t = global::NetJSON.NetJSON.Deserialize<T>(json);

        return t;
    }
    
}