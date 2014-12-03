using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ifExists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 22, 5, 4, 98, 36, 14, 52, 87 };
            int numToFind = int.Parse(Console.ReadLine());
            Console.WriteLine(ifExists(arr, numToFind));
        }

        public static bool ifExists(int[] arr, int numToFind)
        {
            return ifExists(arr, arr.Length, numToFind);
        }

        public static bool ifExists(int[] arr, int size, int numToFind)
        {
            if (size > 0)
            {
                if (numToFind == arr[size - 1])
                    return true;
                else
                    return ifExists(arr, size - 1, numToFind);
            }
            else
            {
                return false;
            }
        }
    }
}
