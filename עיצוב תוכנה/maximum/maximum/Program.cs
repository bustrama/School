using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maximum
{
    class Program
    {
        public static int Maximali(int[] arr, int n)
        {
            int max;
            if (n == 1)
            {
                return arr[0];
            }
            else
            {
                if (arr[n - 1] > max)
                {
                    max = arr[n - 1];
                }
                    return Maximali(arr, n - 1);
                
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            Console.WriteLine(Maximali(arr, arr.Length));
        }
    }
}
