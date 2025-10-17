namespace Core.Data.Formatters.Text.JSON.Serde.NET;

public partial class
                                        Formatter
{
    public static
        string?
                                        Serialize<T>
                                        (
                                            T t
                                        )
                                        where T 
                                        :
                                        global::Serde.ISerializeProvider<T>
    {
        string? result = default(string);
        
        result = global::Serde.Json.JsonSerializer.Serialize(t);

        return result;
    }

    /*
    public static
        T?
                                        Deserialize<T>
                                        (
                                            string json
                                        )
                                        where T 
                                        :
                                        global::Serde.ISerializeProvider<T>
    {
        T? t = default(T);
        
        t = global::Serde.Json.JsonSerializer.Deserialize<T>(json);

        return t;
    }
    */
}