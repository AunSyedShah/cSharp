using System;

public class triangularnumber
{
	public static void Main(string [] ar)
	{
		int s = 0, t = 0,n;
		Console.WriteLine("Enter a number");
		n = Convert.ToInt32(Console.ReadLine());
		for(int j=1;j<=n; j++)
        {
			t += j;
			s += t;
        }
		Console.WriteLine($"The sum of first {n} triangular number is {s}");
	}
}
