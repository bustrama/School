using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WierdSidra
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            wierdSidra(num);

            Console.ReadLine();
        }

        public static void wierdSidra(int num)
        {
            if (num == 7)
            {
                Console.Write(num + " ");
            }
            else
            {
                Console.Write(num + " ");
                wierdSidra(num + 1);
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
