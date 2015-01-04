using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11
{
    class Program
    {
        public static int Numbers(int a, int b)
        {
            if (a - b < b)
            {
                return 1;
            }
            else
            {
                return 1 + Numbers(a - b, b);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(60, 5));

        }
    }
}
