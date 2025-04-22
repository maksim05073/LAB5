namespace LB52;

public class genPerson
{
    public static Random rnd=new Random();

    private static string[]
        ArrayName = { "", "", "", "", "", "", "" };

    private static string[]
        Surname = { "", "", "", "", "", "" };

    public static DateTime GenDate()
    {
        return new DateTime(rnd.Next(1980, 2007), rnd.Next(1, 12), rnd.Next(1, 28));
    }
    public static 
    
}