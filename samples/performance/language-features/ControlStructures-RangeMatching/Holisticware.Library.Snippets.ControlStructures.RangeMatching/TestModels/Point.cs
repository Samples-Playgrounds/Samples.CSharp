namespace TestModels;

public partial class
                                        Point
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct#user-defined-types
    public
        void
                                        Deconstruct
                                        (
                                            out int x,
                                            out int y
                                        )
    {
        x  = X;
        y = Y; 
    }

    public
        int
                                        X
    {
        get;
        set;
    }
    
    public
        int
                                        Y
    {
        get;
        set;
    }
}