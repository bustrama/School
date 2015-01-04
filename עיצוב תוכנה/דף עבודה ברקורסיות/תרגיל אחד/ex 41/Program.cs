using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_41
{
    class Program
    {
        public static int Numbers(int a)
        {
            if (a/10==0)
            {
                return 1;
            }
            else
            {
                return 1 + Numbers(a / 10);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(123456789));
        }
    }
}
