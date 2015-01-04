using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_92
{
    class Program
    {
        public static int Numbers(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Numbers(n - 1) + Numbers(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(7));
        }
    }
}
