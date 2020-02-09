using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Students s = Students.Senior;

            Console.WriteLine($"The value selected is {Enum.Format(typeof(Students), s, "g")}");
            Console.WriteLine($"The value of {s} is {Enum.Format(typeof(Students), s, "d")}");
            Console.WriteLine($"The hex value of {s} is{Enum.Format(typeof(Students), s, "x")}");
            

            Console.WriteLine($"The value at index 1 is {(Enum.GetName(typeof(Students), 1))}.");
            

            Console.ReadLine();
        }

        enum Students
        {
            Freshmen,
            Sophomore,
            Junior,
            Senior
        };

    }
}
