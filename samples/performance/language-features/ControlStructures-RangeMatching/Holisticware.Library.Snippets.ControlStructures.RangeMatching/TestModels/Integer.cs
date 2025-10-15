namespace TestModels;


/// <summary>
/// Hypotetical class for test
/// </summary>
/*
Interesting sample

https://stackoverflow.com/questions/56676260/c-sharp-8-switch-expression-with-multiple-cases-with-same-result
https://stackoverflow.com/questions/43080505/how-to-switch-on-system-type
https://stackoverflow.com/questions/1554689/evaluate-expressions-in-switch-statements-in-c-sharp
https://antondevtips.com/blog/how-to-write-elegant-code-with-csharp-switch-expressions
https://www.reddit.com/r/dotnet/comments/1ddamyl/how_to_write_elegant_code_with_c_switch/
*/
public partial class
                                        Integer
{
    private int
        integer;

    public
        Integer
        (
            int integer
        )
    {
        this.integer = integer;
    }

    public static implicit operator
        int
                                        (
                                            Integer i
                                        )
        => i.integer;

    public
        bool
                                        Is1
    {
        get
        {
            if (this.integer == 1)
            {
                return true;
            }

            return false;
        }
    }

    public
        bool
                                        Is2
    {
        get
        {
            if (this.integer == 2)
            {
                return true;
            }

            return false;
        }
    }
    
    public
        bool
                                        Is3
    {
        get
        {
            if (this.integer == 3)
            {
                return true;
            }

            return false;
        }
    }
    
}