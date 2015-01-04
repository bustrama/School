using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            TeddyBear t = new TeddyBear("Kof", 100, false, "red");
            //Console.WriteLine(t.toString());
            //t.ChangeBasePrice(9);
            //Console.WriteLine(t.toString());
            
            //Console.WriteLine();

            Dolly d = new Dolly("Songoku", 100, 2, 10);
            //Console.WriteLine(d.toString());
            //d.ChangeBasePrice(50);
            //Console.WriteLine(d.toString());

            Toy[] arr = new Toy[5];
            arr[0] = t;
            arr[1] = d;
            arr[2] = new TeddyBear("Dov", 25, false, "yellow");
            arr[3] = new Dolly("barbi", 78, 90, 8);
            arr[4] = new Dolly("George", 543, 7, 100);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i+"- "+arr[i].toString());
            }
        }
    }
}
