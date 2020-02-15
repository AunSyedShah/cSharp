using System;

namespace Collatz_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------Collatz Sequence------------------------------");
            CollatzSequence(5);
            CollatzSequence(4);
            CollatzSequence(11);

            Console.ReadLine();

        }
        public static void CollatzSequence(int n)
        {
            Console.WriteLine($"Entered number : {n}");
            Console.WriteLine("Sequence: ");
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    Console.Write($"{n}\t");
                }
                else
                {
                    n = 3 * n + 1;
                    Console.Write($"{n}\t");
                }
            }

            Console.WriteLine("\n");
        }
    }
}
