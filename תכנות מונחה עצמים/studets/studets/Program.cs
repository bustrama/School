using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace studets
{
    class Program
    {
        static void Main(string[] args)
        {
            student Yuval = new student();
            Yuval.setFN("Yuval");
            Yuval.setLN("Geva");
            Yuval.setID("208490185");
            Yuval.setCR("YudAlef1");
            Console.WriteLine(Yuval.GetFN());
            Console.WriteLine(Yuval.GetLN());
            Console.WriteLine(Yuval.GetID());
            Console.WriteLine(Yuval.GetCR());

        }
    }
}
