using System;
using System.Collections.Generic;
using System.Text;

namespace whereNumBull
{
    class Program
    {
        public static bool WhereNumArr(int[] arr, int n, int num)
        {
            if (n == 1)
            {
                if (num == arr[0])
                    return true;
                else
                    return false;
            }
            else
            {
                if (num == arr[n - 1])
                    return true;
                else
                    return WhereNumArr(arr, n - 1, num);

            }
        }

        public static bool WhereNumArr(int[] arr, int num)
        {
            int x = arr.Length;
            return WhereNumArr(arr, x, num);
        }

        static void Main(string[] args)
        {
            int[] arr ={ 5, 6, 7, 2, 15 };
            int num = 6;
            Console.WriteLine(WhereNumArr(arr, num));
        }
    }
}
