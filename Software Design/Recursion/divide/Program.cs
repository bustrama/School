using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(divide(num, num2));

            Console.ReadLine();
        }

        public static int divide(int a, int b)
        {
            if (a < b)
                return 0;
            else
                return (1 + divide(a - b, b));
        }
    }
}
