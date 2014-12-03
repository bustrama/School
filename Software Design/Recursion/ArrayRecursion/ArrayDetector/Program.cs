using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7 };
            Console.WriteLine(arr.ToString());
            Console.WriteLine(sortedArray(arr));
        }

        public static bool sortedArray(int[] arr)
        {
            int size = arr.Length-1;

            return sortedArray(arr, size);
        }

        public static bool sortedArray(int[] arr, int size)
        {
            if (size > 1)
            {
                if (arr[size] > arr[size - 1])
                    return sortedArray(arr, size - 1);
                else
                    return false;
            }
            else
                return true;
        }
    }
}
