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
            Person[] arr = new Person[5];
            arr[0] = new Employee("g", "h", 9, 8, 7, "good");
            arr[1] = new Worker("aa", "aa", 1, 2, 3, "bad", 678, 9);
            arr[2] = new SalesMan("aa", "aa", 5, 4, 3, "nice", 678, 9, 1000);
            arr[3]=new Person("", "", 7,9);
            arr[4] = new Person("yuval", "geva", 7, 0909);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
                Console.WriteLine("-------------------------------");
            }

        }
    }
}
