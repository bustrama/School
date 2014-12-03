using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            ReversedString(str);

            Console.ReadLine();
        }

        public static void ReversedString(string str)
        {
            if (str.Length > 0)
            {
                char ch = str[0];
                ReversedString(str.Remove(0,1));
                Console.Write(ch);
            }
        }
    }
}
