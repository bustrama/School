using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10
{
    class Program
    {
        public static int Numbers(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            else
            {
                return a + Numbers(a, b - 1);                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(4,7));
        }
    }
}
