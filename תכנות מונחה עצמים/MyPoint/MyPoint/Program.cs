using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Point check:
            //Point p1 = new Point();            
            //Console.WriteLine( p1.toString());
            //Point p2 = new Point(2, 4);
            //Console.WriteLine(p2.toString());
            //Point p3 = new Point();
            //p3.SetX(8);
            //p3.Py = 9;
            //Console.WriteLine(p3.toString());

            ////Line check:
            //Line gevald = new Line();
            //gevald.Show();
            //Line l2 = new Line(3, 6, 0, 2);
            //l2.Show();
            //Point p2 = new Point(2, 4);
            //gevald.Start = p2;
            //gevald.Show();

            //Circle check
            Circle c1 = new Circle();
            c1.Show();
            Point p2 = new Point(2, 4);
            c1.SetCenter(p2);
            c1.Radius = 4;
            c1.Show();
        }
    }
}
