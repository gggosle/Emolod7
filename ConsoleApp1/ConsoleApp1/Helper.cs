namespace HomeWork;

static class Helper
{ 
    public static int GetVal()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public static string GetString()
    {
        
        Console.WriteLine("Your name: ");
        return Console.ReadLine();
    }

}