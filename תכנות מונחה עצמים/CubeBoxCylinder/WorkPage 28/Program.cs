using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkPage_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube c = new Cube(6, 8);
            Console.WriteLine(c.Surface());
            Console.WriteLine(c.Volume());

            Console.WriteLine();

            Box b = new Box(2, 3, 5);
            Console.WriteLine(b.Surface());
            Console.WriteLine(b.Volume());

            Console.WriteLine();

            Cylinder cy = new Cylinder(4, 7);
            Console.WriteLine(cy.Surface());
            Console.WriteLine(cy.Volume());
        }
    }
}
