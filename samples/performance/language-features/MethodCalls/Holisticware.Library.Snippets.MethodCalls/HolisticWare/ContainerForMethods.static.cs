namespace Holisticware.Library.Snippets.Strings.HolisticWare;

public partial class
                                        ContainerForMethods
{
    public static
        int
                                        StaticMethodDouble
                                        (
                                            int arg
                                        )
    {
        return arg * 2;
    }

    public static
        Task<int>
                                        StaticMethodDoubleAsync
                                        (
                                            int arg
                                        )
    {
        return Task.FromResult<int>(arg * 2);
    }
    
    public static
        Func<int, int>
                                        StaticMethodDoubleImplementation
                                        =
                                        StaticMethodDouble;
    
}