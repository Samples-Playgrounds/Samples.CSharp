namespace Holisticware.Library.Snippets.Models;

[Serializable] 
[global::System.Runtime.Serialization.DataContract]
public partial class 
                                        Person
{
    [global::System.Runtime.Serialization.DataMember]
    public partial
        string
                                        Name
    {
        get => field;
        set => field = value;
    }
    
    [global::System.Runtime.Serialization.DataMember]
    public partial
        int
                                        Age
    {
        get => field;
        set => field = value;
    }
    
    [global::System.Runtime.Serialization.DataMember]
    public partial
        string
                                        City
    {
        get => field;
        set => field = value;
    }
}