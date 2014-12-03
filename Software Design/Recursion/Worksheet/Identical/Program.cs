using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Identical
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(sameSame(n1, n2));

            Console.ReadLine();
        }

        public static bool sameSame(int n1, int n2)
        {
            if (n1 % 10 == n2 % 10)
                if (n1 == 0 && n2 == 0)
                    return true;
                else
                    return sameSame(n1 / 10, n1 / 10);
            else
                return false;
        }

        public static bool identical(int n1, int n2)
        {

        }
    }
}
