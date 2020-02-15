using System;

namespace GeometricProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------Geometric Progression--------------------------------");
            Console.WriteLine();

            GeometricProgression(1, 2, 8);
            GeometricProgression(5, 2, 9);

            Console.ReadLine();
        }

        private static void GeometricProgression(double a, double r, double t)
        {
        // a is the first term, r is the common ratio, t is the no of terms
            double g;
            Console.Write($"Geometric Progression for {a} :\t");
                
            for(int i = 1; i <= t; i++)
            {
                g = a * (Math.Pow(r, i-1));
                Console.Write($"{g}\t");
            }
            Console.WriteLine();
        }

    }
}
