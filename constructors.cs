using System;

public class constructors
{
	int a;
	public constructors() //default constructor
	{
		Console.WriteLine("The default constructor was called");
		a = 100;
	}
	public constructors(int c) //parameterized constructor
	{
		Console.WriteLine("The parametized constructor was called");
		a =c;
	}
	static void Main(string[] ar)
	{
		constructors obj = new constructors();//Instantiation
		Console.WriteLine("The value of a is "+obj.a);
		constructors obj1 = new constructors(150);//Instantiation
		Console.WriteLine("The value of a is "+obj1.a);
		constructors obj2 = new constructors(200);//Instantiation
		Console.WriteLine("The value of a is " + obj2.a+"\nPrevious value was"+obj1.a);
	}
}
