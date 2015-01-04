using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_71
{
    class Program
    {
      public static bool Numbers(int a,int d)
        {
            if (a / 10 == 0)
            {
                if (a == d)
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
                if (a % 10 == d)
                {
                    return true;
                }
                else
                {
                    return Numbers(a / 10, d);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Numbers(345,8));
        }
    }
}
