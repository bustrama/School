using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubes
{
    class Cylinder:Cube
    {
        public Cylinder(int radius, int height) : base(radius, height)
        {
            this.a = radius;
            this.height = height;
        }

        public override double basisArea()
        {
            return this.a * this.a * Math.PI;
        }

        public override double volume()
        {
            return this.basisArea() * this.height;
        }
    }
}
