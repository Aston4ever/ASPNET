namespace OOP;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, what is your name? ");
		string? name = Console.ReadLine();
		
		ConsoleOutput.ConsoleSayHello(name);
		
		
		CalculateData.GetDouble(2.32, 1.23);
		Console.ReadKey();
	}
}