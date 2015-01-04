using System;
using System.Collections.Generic;
using System.Text;

namespace WhereNum
{
    class Program
    {
        public static int WhereNumArr(int[] arr, int n, int num)
        {
            if (n==1)
            {
                if (num == arr[0])
                    return 0;
                else
                    return -1; 
               
            }                
            else
            {
                if (num == arr[n - 1])
                    return n - 1;
                else
                    return WhereNumArr(arr, n - 1, num);
                
            }
        }

        public static int WhereNumArr(int[] arr, int num)
        {
            int x = arr.Length;
            return WhereNumArr(arr, x, num);
        }

        static void Main(string[] args)
        {
            int[] arr ={ 5, 6, 7, 2, 15 };
            int num = 79;
            Console.WriteLine(WhereNumArr(arr, num)); 
        }
    }
}
