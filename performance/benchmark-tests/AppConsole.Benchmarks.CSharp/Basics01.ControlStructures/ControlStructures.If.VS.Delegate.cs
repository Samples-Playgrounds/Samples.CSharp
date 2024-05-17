namespace Basics01.ControlStructures;

public partial class
                                        ControlStructures_IfEnabled_VS_Delegate
{
    bool
                                        enabled = true;

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        void
                                        DoWork_IfEnabled_true
                                        (
                                        )
    {
        enabled = true;

        for(int i=1; i<=1000; i++)
        {
            if (enabled)
            {
                DoWork();
            }
        }

        return;
    }
    
    [BenchmarkDotNet.Attributes.Benchmark]
    public
        void
                                        DoWork_IfEnabled_false
                                        (
                                        )
    {
        enabled = false;

        for(int i=1; i<=1000; i++)
        {
            if (enabled)
            {
                DoWork();
            }
        }

        return;
    }

    Action              
                                        DoWorkDelegate;



    [BenchmarkDotNet.Attributes.Benchmark]
    public
        void
                                        DoWork_Delegate
                                        (
                                        )
    {
        DoWorkDelegate = DoWork;

        for(int i=1; i<=1000; i++)
        {
            DoWorkDelegate();
        }

        return;
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        void
                                        DoWork_Delegate_null
                                        (
                                        )
    {
        DoWorkDelegate = null;
        
        for(int i=1; i<=1000; i++)
        {
            DoWorkDelegate();
        }

        return;
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        void
                                        DoWork_Delegate_NoOp
                                        (
                                        )
    {
        DoWorkDelegate = DoWorkNoOp;
        
        for(int i=1; i<=1000; i++)
        {
            DoWorkDelegate();
        }

        return;
    }

    private
        void
                                        DoWorkNoOp
                                        (
                                        )
    {
        return;
    }

    private
        void
                                        DoWork
                                        (
                                        )
    {
        Console.WriteLine("DoWork");

        return;
    }

}
