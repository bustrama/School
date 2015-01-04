using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_04
{
    class Program
    {
        public static void Numbers(int num)
        {
            if (num == 100)
            {
                Console.WriteLine(num);
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    Numbers(num + 2);
                }
                else
                {
                    num += 1;
                    Console.WriteLine(num);
                    Numbers(num + 2);
                }
            }
        }
        static void Main(string[] args)
        {
            Numbers(1);
        }
    }
}
