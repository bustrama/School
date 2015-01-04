using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_08
{
    class Program
    {
        public static int Numbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n+ Numbers(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(10));
        }
    }
}
