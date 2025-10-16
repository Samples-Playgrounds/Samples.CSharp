namespace Core.Data.Formatters.Text.XML.ServiceStack.Text;

/// <summary>
/// 
/// </summary>
/*
                                        where T 
                                        :
                                        global::StackXML.IXmlSerializable,
                                        new()
*/
public partial class
                                        Formatter
{
    public static
        string
                                        SerializeNaive<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        result = global::ServiceStack.Text.XmlSerializer.SerializeToString(t);
        
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
        
        t = global::ServiceStack.Text.XmlSerializer.DeserializeFromString<T>(xml);

        return t;
    }
    
}