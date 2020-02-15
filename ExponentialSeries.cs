using System;
namespace ExponentialSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Exponential Series--------------------");
            
            ExSeries(3, 5);
            ExSeries(4, 3);
            ExSeries(7, 3);
            
            Console.ReadLine();
        }

        public static void ExSeries(double n,double x)
        {
            Console.WriteLine();
            Console.Write($"Series of e^{n} = ");
            double w;
            // n is the power of e
            // x is the number of terms up to which the values of the series is to be found
            for(int i = 0; i <= x; i++)
            {
                w = Math.Pow(n,i) / factorial(i);
                Console.Write($"{w} + ");
            }
            Console.WriteLine();
        }
        
        public static int factorial(int a)
        {
            if (a == 0 || a == 1)
                return 1;
            else
                return a * factorial(a - 1);
        }  
    }
}
