using System;

namespace sortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = new int[] {23,12,43,76,4,21,86,55};
            BubbleSort(r);
            Console.ReadLine();
        }

        public static void BubbleSort(int[] a)
        {
            int n = a.Length;
            int t;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }                      
                }
            }

            Display(a);
        }

        
        public static void Display(int[] s)
        {
            Console.WriteLine("Sorted Array: ");
            for (int k = 0; k < s.Length; k++)
                Console.Write($"{s[k]} ");
        }
    }
}
