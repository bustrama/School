using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_81
{
    class Program
    {
        public static bool Numbers(int a, int b)
        {
            if (a / 10 == 0 || b / 10 == 0)
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (a % 10 == b % 10)
                {
                    return Numbers(a / 10, b / 10);
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(678,9678));

        }
    }
}
