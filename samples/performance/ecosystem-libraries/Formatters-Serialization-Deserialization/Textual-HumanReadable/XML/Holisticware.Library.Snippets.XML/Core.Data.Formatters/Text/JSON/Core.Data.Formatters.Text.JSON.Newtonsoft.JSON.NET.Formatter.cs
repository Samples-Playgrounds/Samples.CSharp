namespace Core.Data.Formatters.Text.JSON.Newtonsoft.JSON.NET;

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
        
        result = global::Newtonsoft.Json.JsonConvert.SerializeObject(t);

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
        
        t = global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);

        return t;
    }
    
}