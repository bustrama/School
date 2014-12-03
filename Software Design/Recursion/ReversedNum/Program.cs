using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReversedNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            reversedNum(num);
        }

        public static void reversedNum(int num)
        {
            if (num < 10)
                Console.WriteLine(num);
            else
            {
                Console.Write(num%10);
                reversedNum(num / 10);
            }
        }
    }
}
