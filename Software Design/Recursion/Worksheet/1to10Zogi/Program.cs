using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1to100Zogi
{
    class Program
    {
        static void Main(string[] args)
        {
            oneToHundredZogi(1);

            Console.ReadLine();
        }

        public static void oneToHundredZogi(int num)
        {
            if (num < 101 && num % 2 == 0)
            {
                Console.Write(num + ", ");
                num++;
                oneToHundredZogi(num);
            }
            else if (num % 2 != 0)
            {
                num++;
                oneToHundredZogi(num);
            }
            else
                Console.WriteLine("");
        }


    }
}
