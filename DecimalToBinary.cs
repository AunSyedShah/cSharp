using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalToBinary(20);
            DecimalToBinary(16);
            DecimalToBinary(32);
            Console.ReadLine();
        }

        public static void DecimalToBinary(int a)
        {
            int x = a;
            int[] n = new int[8];
            for (int i = 0; a > 0; i++)
            {
                n[i] = a % 2;
                a = a / 2;
            }
            
            Array.Reverse(n);
            Console.WriteLine($"The binary equivalent of {x} is: ");
            
            for (int j = 0; j < n.Length; j++)
                Console.Write(n[j]);
                
            Console.WriteLine();
            
        }
    }
}
