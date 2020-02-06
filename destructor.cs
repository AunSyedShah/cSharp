using System;

public class destructor
{
	public destructor() //constructor
	{
		Console.WriteLine("Constructor was called");
	}
	~destructor() //destructor
    {
		Console.WriteLine("Destructor was called");
    }
	public static void Main(string []ar)
    {
		destructor obj = new destructor();
		Console.WriteLine("We are in the main method");
		Console.WriteLine("We are at the end of the main");
	}//destructor is called automatically
}
