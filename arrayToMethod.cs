    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
     
    namespace array_parameter
    {
        class Program
        {
            static void printarray(int[] newarray)
            {
                int i, sum = 0;
                Console.Write("\n\nYou entered:\t");
                for (i = 0; i < 4; i++)
                {
                    Console.Write("{0}\t", newarray[i]);
                    sum = sum + newarray[i];
                }
                Console.Write("\n\nAnd sum of all value is:\t{0}", sum);
                Console.ReadLine();
            }
            static void Main(string[] args)
            {
                int[] arr = new int[4];
                int i;
                for (i = 0; i < 4; i++)
                {
                    Console.Write("Enter number:\t");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                // passing array as argument
                Program.printarray(arr);
            }
        }
    }