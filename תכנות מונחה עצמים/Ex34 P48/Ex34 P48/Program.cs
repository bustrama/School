using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace Ex34_P48
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> g=new List<int>();
            for (int i=90;i<=100;i++)
            {
                g.Insert(null,i);
            }


            //Student s = new Student("yuval", "geva", 208490185, g);
            //s.LastName = "gevva";
            //Console.WriteLine(s.ToString());

            //Trainer t = new Trainer("yuval", "geva", 208490185, g, 30, 90);
            //Console.WriteLine(t.ToString());

            Teacher t = new Teacher("yuval", "geva", 208490185, 100, 40);
            Console.WriteLine(t.ToString());


        }
    }
}
