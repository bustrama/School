using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SidraFalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            sidraDoubleFalindrom(num);

            Console.ReadLine();
        }

        public static void sidraFalindrom(int num)
        {
            if (num == 4)
            {
                Console.Write(num + " ");
            } else {
                Console.Write(num + " ");
                sidraFalindrom(num + 1);
                Console.Write(num + " ");
            }
        }

        public static void sidraDoubleFalindrom(int num)
        {
            if (num == 4)
            {
                Console.Write(num + " " + num + " ");
            }
            else
            {
                Console.Write(num + " " + num + " ");
                sidraDoubleFalindrom(num + 1);
                Console.Write(num + " " + num + " ");
            }
        }
    }
}
