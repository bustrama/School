using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10to1
{
    class Program
    {
        static void Main(string[] args)
        {
            tenToOne(10);
        }

        public static void tenToOne(int num)
        {
            if (num > 0)
            {
                Console.Write(num + ", ");
                num--;
                tenToOne(num);
            }
            else
                Console.WriteLine("");
        }
    }
}
