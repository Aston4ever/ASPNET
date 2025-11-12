namespace ASPNET;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			mySImpleMeth2();
			mySImpleMeth();
		}
		catch (InvalidOperationException ex)
		{
			Console.WriteLine("this was intercepted with first catch");
			Console.WriteLine(ex.Message);
		}
		catch (NotImplementedException ex)
		{
			Console.WriteLine("You forgot to implement this method");
			Console.WriteLine(ex.Message);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

		Console.ReadLine();
	}

	public static void mySImpleMeth()
	{
		throw new InvalidOperationException("This method is not working properly");
	}

	public static void mySImpleMeth2()
	{
		throw new NotImplementedException("This method is not implemented");
	}
}