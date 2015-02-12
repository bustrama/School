using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube c = new Cube(5, 6);
            Box b = new Box(5, 6, 7);
            Cylinder cyl = new Cylinder(5, 6);
            double cubeVolume = c.volume();
            double boxVolume = b.volume();
            double cylVolume = cyl.volume();

            Console.WriteLine("\n Cube Volume: {0} \n Box Volume: {1} \n Cylinder Volume: {2}", cubeVolume, boxVolume, cylVolume);
            Console.ReadKey();
        }
    }
}
