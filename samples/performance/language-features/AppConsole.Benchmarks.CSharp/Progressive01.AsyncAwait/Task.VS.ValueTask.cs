namespace AppConsole.Benchmarks.CSharp;

public partial class
                                        Task_VS_ValueTask
{
    public async
        Task<int>
                                        GetValueAsTaskAsync
                                        (
                                        )
    {
        return 1 + 1;
    }
    
    public async
        Task<int>
                                        GetValueAsValueTaskAsync
                                        (
                                        )
    {
        return 1 + 1;
    }
}