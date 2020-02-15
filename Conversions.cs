using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------Degree and Radian Conversions-------------------------------");
            Console.WriteLine();

            DegreetoRadian(30);
            RadiantoDegree(230);

            Console.ReadLine();

        }

        public static void DegreetoRadian(double n)
        {
        // n is the value of degree to be converted to radian
            double r;
            r = Math.Round((n * Math.PI / 180),6);
            Console.WriteLine($"{n} degree is {r} radian");
            
            Console.WriteLine();
        }


        public static void RadiantoDegree(double a)
        {
        // a is the value of radian to be converted to degree
            double d;
            d = Math.Round((a * 180 / Math.PI),6);
            Console.WriteLine($"{a} radian is {d} degree");

            Console.WriteLine();
        }
    }
}
