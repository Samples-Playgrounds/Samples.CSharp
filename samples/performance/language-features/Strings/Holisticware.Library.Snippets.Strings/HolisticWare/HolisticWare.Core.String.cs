namespace Core;

public static partial class
                                        String
{
    public static 
        string
                                        ConcatWithJoin
                                        (
                                            string[] strings
                                        )
    {
        return
            string
                .Join
                    (
                        null,
                        strings
                    );
    }
    
    public static 
        string
                                        ConcatWithConcat
                                        (
                                            string[] strings
                                        )
    {
        return
            string
                .Concat
                    (
                        strings
                    );
    }
}