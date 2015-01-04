using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] arr = new Point[10];            
            Random rnd=new Random();
            Point p1 = new Point(rnd.Next(0, 10), rnd.Next(0, 10));
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Point(p1);
                Console.WriteLine(arr[i].toString());
            }
            //arr[5].Px = 90;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i].toString());
            //}

        }
    }
}
