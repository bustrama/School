using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_06
{
    class Program
    {
        public static void NumOfCh(char ch, int n)
        {
            if (n == 1)
            {
                Console.WriteLine(ch);
            }
            else
            {
                Console.WriteLine(ch);
                NumOfCh(ch, n - 1);
            }
        }
        static void Main(string[] args)
        {
            char ch = 'y';
            int n = 9;
            NumOfCh(ch, n);
        }
    }
}
