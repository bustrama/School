using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_01
{
    class Program
    {
        public static void Numbers(int num)
        {
            if (num == 10)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num);
                Numbers(num + 1);
            }
        }
        static void Main(string[] args)
        {
            Numbers(1);



        }
    }
}
