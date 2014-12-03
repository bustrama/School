using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sidra
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            ReversedSidra(num);

            Console.ReadLine();
        }

        public static void sidra(int num)
        {
            if (num == 6)
            {
                Console.Write(num);
            }
            else if (num < 7)
            {
                Console.Write(num);
                sidra(num + 1);
            }
            else
            {

            }
        }

        public static void sidra(int num, int max)
        {
            if (num == max)
            {
                Console.Write(num);
            }
            else if (num < (max+1))
            {
                Console.Write(num + " ");
                sidra(num + 1, max);
            }
            else
            {
                Console.WriteLine("It's above the Max");
            }
        }

        public static void ReversedSidra(int num)
        {
            if (num == 6)
            {
                Console.Write(num);
            }
            else
            {
                ReversedSidra(num + 1);
                Console.Write(num + " ");
            }
        }

        public static void ReversedSidra(int num, int max)
        {
            if (num == max)
            {
                Console.Write(num + " ");
            }
            else if (num > (max - 1))
            {
                Console.Write(num + " ");
                ReversedSidra(num - 1, max);
            }
            else
            {
                Console.WriteLine("It's below the Max");
            }
        }
    }
}
