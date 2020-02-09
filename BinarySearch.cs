using System;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Binary Search---------");
            int[] a = new int[10] { 43,54,76,12,49,63,89,81,3,17};
                
            BubbleSort(a);

            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{a[i]}");

            BinarySearch(a, 76);
            BinarySearch(a, 4);
            BinarySearch(a, 12);

            Console.ReadLine();
        }

        public static void BinarySearch(int[] a, int x)
        {
            int l = 0;
            int u = a.Length - 1;
            int f = 0;
            
            while (l <= u)
            {
                int mid = (l + u) / 2;
                if (a[mid] == x)
                {
                    Console.WriteLine($"{x} is present in the array at position {mid + 1}.");
                    f = 1;
                    break;
                }
                else if (a[mid] > x)
                    u = mid - 1;
                else
                    l = mid + 1;
            }

            if (l > u && f == 0)
                Console.WriteLine($"{x} does not exists in the array.");
        }

        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            int t;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }
            }
        }
    }
}
