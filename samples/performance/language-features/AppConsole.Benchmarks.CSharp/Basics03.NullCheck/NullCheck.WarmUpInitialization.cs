namespace Basics03.NullChecks;

public partial class
                                        NullCheck
{
    protected const int N_10      = 10;
    protected const int N_100     = 100;
    protected const int N_1000    = 1_000;
    protected const int N_10000   = 10_000;

    protected readonly int[] data_10;
    protected readonly int[] data_100;
    protected readonly int[] data_1000;
    protected readonly int[] data_10000;

    public
                                        NullCheck
                                        (
                                        )
    {
        data_10         = new int[N_10];
        data_100        = new int[N_100];
        data_1000       = new int[N_1000];
        data_10000      = new int[N_10000];

        Random randNum = new Random();

        data_10 = Enumerable
                        .Repeat(0, N_10)
                        .Select(i => randNum.Next(-10, 10))
                        .ToArray();

        return;
    }
}
