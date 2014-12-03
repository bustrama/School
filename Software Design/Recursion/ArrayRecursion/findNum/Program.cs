using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace findNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4};
            Console.WriteLine(findNum(arr, 1, 4));
        }

        public static int findNum(int[] arr, int size, int numToFind)
        {
            if(size > 0)
            {
                if (arr[size-1] == numToFind)
                {
                    return size-1;
                }
                else
                    return findNum(arr, size - 1, numToFind);
            }
            else
            {
                return -1;
            }
        }
    }
}
