using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_31
{
    class Program
    {
        public static int Numbers(int a, int b)
        {
            if (a<b)
            {
                return a;
            }
            else
            {
                return Numbers(a-b, b);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(198,7));
        }
    }
}
