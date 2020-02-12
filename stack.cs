using System;

public class recwork
{
	void stack(int n)
    {
		Console.WriteLine(n);
		if(n>0)
			stack(n-1);
		Console.WriteLine(n); // this line is stacked and executed after n=0 
    }
	public static void Main(string [] args)
	{
		recwork obj = new recwork();
		obj.stack(10);
	}
}
