using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(module(num, num2));

            Console.ReadLine();
        }

        public static int module(int a, int b)
        {
            if (a < b)
                return b;
            else
                return module(a-b, b);
        }
    }
}
