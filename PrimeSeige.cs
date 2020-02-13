using System;
using System.Collections;
using System.Collections.Generic;
public class PrimeSeige
	{
		public static void Main(string[] ar)
		{
			int n;
			bool flg;
			Console.WriteLine("Enter a number");
			n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"The first {n} prime nummbers are ->");
			ArrayList prime = new ArrayList();
			int i = 2;
		    if(n>0)
			prime.Add(i);
		    n -= 1;
		    i = 3;
			while (n > 0)
			{
				flg = true;
				foreach (var j in prime)
				{
					if (i % Convert.ToInt32(j) == 0)
						flg = false;
				}
				if (flg == true)
				{
					prime.Add(i);
					n--;
				}
				i+=2;
			}
			foreach(var j in prime)
			Console.WriteLine(j);
		}
	}
