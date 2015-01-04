using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace טנמ_בנושא_תור
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLine line = new DoubleLine();
            bool getout=false;
            while (getout == false)
            {
                Console.WriteLine("Press 1 to enter cliente");
                Console.WriteLine("Press 2 to get servise cliente");
                Console.WriteLine("Press 3 to exit");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1: Console.Write("For slow queue press 1, and for fast queue press 0: ");
                        int act = int.Parse(Console.ReadLine());
                        Console.Write("Enter your number: ");
                        int num=int.Parse(Console.ReadLine());
                        line.Add(num, act);
                        Console.WriteLine("\n");
                        break;
                    case 2: line.Remove();
                        Console.WriteLine("\n");
                        break;
                    case 3: getout = true;
                        break;
                    defalt: Console.WriteLine("Illigle value");
                        Console.WriteLine("\n");
                        break;
                }
            }
        }
    }
}
