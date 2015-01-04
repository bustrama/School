using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_51
{
    class Program
    {
        public static int Numbers(int a)
        {
            if (a / 10 == 0)
            {
                return a;
            }
            else
            {
                return a % 10 + Numbers(a / 10);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(1234));
        }
    }
}
