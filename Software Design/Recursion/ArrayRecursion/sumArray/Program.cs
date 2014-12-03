using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7,8,9 };
            Console.WriteLine(sumArray(arr));
        }

        public static int sumArray(int[] arr, int size)
        {
            if (size > 1)
            {
                return arr[size - 1] + sumArray(arr, size - 1);
            }
            else 
            {
                return arr[size - 1];
            }

        }

        public static int sumArray(int[] arr)
        {
            int size = arr.Length;
            //פעולת מעטפת
            return sumArray(arr, size);
        }
    }
}
