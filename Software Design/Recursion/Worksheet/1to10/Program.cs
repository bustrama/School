using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            oneToTen(1);
        }

        public static void oneToTen(int num)
        {
            if(num < 11)
            {
                Console.Write(num +", ");
                num++;
                oneToTen(num);
            }
            else
                Console.WriteLine("");
        }
    }
}
