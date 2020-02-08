using System;

public class convert
{
	public static void Main(string [] ar)
	{
		char [] ba = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
		char[] c = new char[1000];
		int n, b,i=0;
		Console.WriteLine("Enter a number");
		n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter base to be converted in");
		b = Convert.ToInt32(Console.ReadLine());
		while(n>0)
        {
			c[i++] = ba[n%b];
			n /= b;
        }
		while(--i>=0)
        {
			Console.Write($"{c[i]}");
        }
	}
}
