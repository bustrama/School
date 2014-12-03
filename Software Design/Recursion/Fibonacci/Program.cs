using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(num));
        }

        public static int fibonacci(int num)
        {
            if (num == 1 || num == 2)
                return 1;
            else
                return fibonacci(num - 1) + fibonacci(num - 2);
        }
    }
}
