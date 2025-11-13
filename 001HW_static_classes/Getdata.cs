using System.Globalization;

namespace _001HW_static_classes;

public class Getdata
{
    public static double GetDouble()
    {
        Console.WriteLine("Enter double:");
        string inputText = Console.ReadLine();
        bool isDouble = double.TryParse(inputText, out double output);

        if (isDouble)
        {
            Console.WriteLine("number saved");
        }
        else
        {
            Console.WriteLine("Try again");
        }
        return output;
    }
}