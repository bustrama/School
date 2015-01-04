using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_03
{
    class Program
    {
        public static void Numbers(int num)
        {
            if (num%10 == 5)
            {
                Console.WriteLine(num % 10);
                Console.WriteLine('*');
                Console.WriteLine(num % 10);
                Numbers(num / 10);
            }
            else
            {
                Console.WriteLine(num % 10);
                Numbers(num % 10 + 1 + num * 10);

            }
        }
        static void Main(string[] args)
        {
            Numbers(1);
        }
    }
}
