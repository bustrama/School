using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_61
{
    class Program
    {
        public static int Numbers(int a,int d)
        {
            if (a / 10 == 0)
            {
                if (a == d)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (a % 10 == d)
                {
                    return 1 + Numbers(a / 10, d);
                }
                else
                {
                    return 0 + Numbers(a / 10, d);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(121,1));
        }
    }
}
