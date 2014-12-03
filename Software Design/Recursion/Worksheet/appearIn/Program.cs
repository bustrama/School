using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appearIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            Console.WriteLine(boolAppearIn(n, digit));

            Console.ReadLine();
        }

        public static int appearIn(int n, int digit)
        {
            if (n < 10)
            {
                if (n == digit)
                    return 1;
                else
                    return 0;
            }
            else
            {
                if (n % 10 == digit)
                {
                    return 1 + appearIn(n / 10, digit);
                }
                else
                    return appearIn(n / 10, digit);
            }
        }

        public static bool boolAppearIn(int n, int digit)
        {
            if (n < 10)
            {
                if (n == digit)
                    return true;
                else
                    return false;
            }
            else
            {
                if (n % 10 == digit)
                {
                    return true;
                }
                else
                    return boolAppearIn(n / 10, digit);
            }
        }
    }
}
