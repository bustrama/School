using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkPage_28
{
    class Cylinder:Cube
    {


        public Cylinder(double a1, double h1)
            : base(a1, h1)
        {
        }

        public override double Surface()
        {
            return Math.Sqrt(base.Surface()) * Math.PI * 2;
        }
    }
}
