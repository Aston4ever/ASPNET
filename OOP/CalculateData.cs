namespace OOP;

public static class CalculateData //Если использовать static для всего класса то можно будет создавать только методы статик
{
    public static double GetDouble(double x, double y)
    {
        Console.WriteLine("Calculating data");
        
        double output = x + y;
        return output;
    }
}