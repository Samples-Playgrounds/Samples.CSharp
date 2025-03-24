namespace Holisticware.Library.Snippets.Strings.HolisticWare;

public partial class
                                        ContainerForMethods
{
    public static int StaticMethodDouble(int arg) { return arg * 2; }

    public static Task<int> StaticMethodDoubleAsync(int arg) { return Task.FromResult<int>(arg * 2); }

    public int InstanceMethodDouble(int arg) { return arg * 2; }

    public Task<int> InstanceMethodDoubleAsync(int arg) { return Task.FromResult<int>(arg * 2); }

    public virtual int VirtualMethodDouble(int arg) { return arg * 2; }

    public virtual Task<int> VirtualAsyncMethodDouble(int arg) { return Task.FromResult<int>(arg * 2); }
    
}