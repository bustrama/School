using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int Pow(int a, int b)
        {
            if (b == 0)
                return 1;
            else if (b == 1)
                return a;
            else
                return a * Pow(a, b - 1);
        }
    }
}
