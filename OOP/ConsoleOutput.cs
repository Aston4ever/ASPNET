namespace OOP;

public class ConsoleOutput
{
    public static void ConsoleSayHello(string firstName)
    {
        Console.WriteLine("Hello, World!");
        int dayTime = DateTime.Now.Hour;

        if (dayTime < 12)
        {
            Console.WriteLine($"Good morning, {firstName}");
        } else if (dayTime < 18)
        {
            Console.WriteLine($"Good afternoon, {firstName}");
        }
        else
        {
            Console.WriteLine($"Good evening, {firstName}");
        }
    }
}