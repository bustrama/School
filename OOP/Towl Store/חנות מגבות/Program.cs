using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace Towl_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock m = new Stock();            
            m.Add(15, 10);
            m.Add(9, 10);
            m.Add(19, 10);

            int sumoftowels =12;
            int sellPrice = 40;
            int x = sumoftowels * sellPrice - m.XXX(sumoftowels);
            Console.WriteLine("Hachnasa=" + sumoftowels * sellPrice);
            //Console.WriteLine("Tashlum=" + m.XXX(sumoftowels));
            Console.WriteLine("Revah="+x);
        }
    }
}
