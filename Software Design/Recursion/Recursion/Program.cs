using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(multiply(2, 3));
        }

        public static int multiply(int n1, int n2)
        {
            if (n2 == 1)
                return n1;
            else
                return multiply(n1, n2 - 1) + n1;
        }
    }
}
