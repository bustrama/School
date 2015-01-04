using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_02
{
    class Program
    {
        public static void Numbers(int num)
        {
            if (num == 1)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num);
                Numbers(num - 1);

            }
        }
        static void Main(string[] args)
        {
            Numbers(10);
        }
    }
}
