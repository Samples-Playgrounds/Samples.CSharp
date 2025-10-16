using ExtendedXmlSerializer.ExtensionModel.Xml;

namespace Core.Data.Formatters.Text.XML.ExtendedXmlSerializer;

/// <summary>
/// 
/// </summary>
/// https://extendedxmlserializer.readthedocs.io/en/latest/get-started/index.html#serialization
public partial class
                                        Formatter
{
    private static readonly 
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager
                                        = new ();

    public static
        global::ExtendedXmlSerializer.IExtendedXmlSerializer 
                                        Cache
                                        = new global::ExtendedXmlSerializer
                                                                    .Configuration
                                                                    .ConfigurationContainer()
                                                                    .Create();

    public static
        string
                                        SerializeNaive<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        global::ExtendedXmlSerializer.IExtendedXmlSerializer 
                                        serializer
                                        = new global::ExtendedXmlSerializer
                                                                    .Configuration
                                                                    .ConfigurationContainer()
                                                                    .Create();
        return result;
    }

    public static
        string
                                        SerializeCachedMemoryStream<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        global::ExtendedXmlSerializer.IExtendedXmlSerializer serializer;
        serializer = Cache;
        
        using (MemoryStream ms     = new ())
        using (global::System.Xml.XmlWriter w = global::System.Xml.XmlWriter.Create(ms))
        {
            serializer.Serialize(w, t);
            w.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            result = new StreamReader(ms).ReadToEnd();
        }

        return result;
    }
    
    public static
        string
                                        SerializeCachedRecyclableMemoryStream<T>
                                        (
                                            T t
                                        )
    {
        string? result = default(string);
        
        global::ExtendedXmlSerializer.IExtendedXmlSerializer serializer;
        serializer = Cache;
        
        using (Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        using (global::System.Xml.XmlWriter w = global::System.Xml.XmlWriter.Create(ms))
        {
            serializer.Serialize(w, t);
            w.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            result = new StreamReader(ms).ReadToEnd();
        }

        return result;
    }
    
    public static
        T
                                        DeserializeNaiveMemoryStream<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        global::ExtendedXmlSerializer.IExtendedXmlSerializer 
                                        serializer
                                        = new global::ExtendedXmlSerializer
                                                                    .Configuration
                                                                    .ConfigurationContainer()
                                                                    .Create();

        using (MemoryStream ms = new (global::System.Text.Encoding.UTF8.GetBytes(xml)))
        using (global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(ms))
        {
            t = (T)serializer.Deserialize(reader);
        }
        return t;
    }
    
    public static
        T
                                        DeserializeNaiveRecyclableMemoryStream<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        global::ExtendedXmlSerializer.IExtendedXmlSerializer 
                                        serializer
                                        = new global::ExtendedXmlSerializer
                                                                    .Configuration
                                                                    .ConfigurationContainer()
                                                                    .Create();

        using (Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        using (global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(ms))
        {
            t = (T)serializer.Deserialize(reader);
        }
        return t;
    }
    
    public static
        T?
                                        DeserializeCachedMemoryStream<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        global::ExtendedXmlSerializer.IExtendedXmlSerializer serializer;
        
        serializer = Cache;

        using (MemoryStream ms = new (global::System.Text.Encoding.UTF8.GetBytes(xml)))
        using (global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(ms))
        {
            t = (T) serializer.Deserialize(reader);
        }

        return t;
    }

    public static
        T?
                                        DeserializeCachedRecyclableMemoryStream<T>
                                        (
                                            string xml
                                        )
    {
        T? t = default(T);
        
        global::ExtendedXmlSerializer.IExtendedXmlSerializer serializer;
        
        serializer = Cache;

        using (Microsoft.IO.RecyclableMemoryStream ms = manager.GetStream())
        using (global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(ms))
        {
            t = (T) serializer.Deserialize(reader);
        }

        return t;
    }

}