using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(digits(num));
        }

        public static int digits(int num)
        {
            if (num < 10)
                return 1;
            else
                return 1 + digits(num / 10);
        }
    }
}
