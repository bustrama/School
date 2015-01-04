using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_07
{
    class Program
    {
        public static void BetweenAB(int a, int b)
        {
            if (a == b - 2)
            {
                Console.WriteLine(b - 1);
            }
            else
            {
                Console.WriteLine(a + 1);
                BetweenAB(a + 1, b);
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            BetweenAB(a, b);
        }
    }
}
