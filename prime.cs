using System;

namespace ConsoleApp1
{
    class Program
    {
    
        public static bool PrimeCheck(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        
        public static void Main()
        {
            
            Console.WriteLine("To check a number is prime or not :");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Input a number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (PrimeCheck(a))
                Console.WriteLine($"{a} is a prime number");
            else
                Console.WriteLine($"{a} is not a prime number");
            Console.ReadLine();
        }
    }
}
