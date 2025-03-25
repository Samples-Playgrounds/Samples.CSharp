namespace Holisticware.Library.Snippets.Strings.HolisticWare;

public partial class
                                        ContainerForMethods
{
    public
                                        ContainerForMethods
                                        (
                                        )
    {
        this.InstanceMethodDoubleImplementation = InstanceMethodDouble;
        
        return;
    }

    public
        int
                                        InstanceMethodDouble
                                        (
                                            int arg
                                        )
    {
        return arg * 2;
    }

    public
        Task<int>
                                        InstanceMethodDoubleAsync
                                        (
                                            int arg
                                        )
    {
        return Task.FromResult<int>(arg * 2);
    }

    public virtual
        int
                                        InstanceMethodVirtualDouble
                                        (
                                            int arg
                                        )
    {
        return arg * 2;
    }

    public virtual
        Task<int>
                                        InstanceMethodVirtualDoubleAsync
                                        (
                                            int arg
                                        )
    {
        return Task.FromResult<int>(arg * 2);
    }
    
    public
        Func<int, int>
                                        InstanceMethodDoubleImplementation;
    
}