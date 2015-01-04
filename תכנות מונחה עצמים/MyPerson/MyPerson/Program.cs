using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex24_P26
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Person p = new Person("y", "g", 16, 22222);
        //    Console.WriteLine(p.toString());
        //    p.SetPerson("yy", "gg", 16, 222223);
        //    Console.WriteLine(p.toString());

            //Employee em = new Employee();
            //em.SetEmployee("y", "g", 16, 22222, 69, "good One");
            //Console.WriteLine(em.toString());

            //Worker w = new Worker();
            //w.SetWorker("y", "g", 16, 22222, 69, "good One", 9, 8);
            //Console.WriteLine(w.toString());
            //Console.WriteLine("\n");
            //w.SetWorkerSalary(10, 15);
            //Console.WriteLine(w.toString());


            SalesMan s = new SalesMan();
            s.SetSalesMan("y", "g", 16, 22222, 69, "good One", 9, 8, 100);
            Console.WriteLine(s.toString());
            Console.WriteLine("\n");
            s.SetSalesManSalary(0, 0, 200);
            Console.WriteLine(s.toString());

        }
    }
}
