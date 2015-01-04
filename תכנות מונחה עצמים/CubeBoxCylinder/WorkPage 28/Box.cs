using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkPage_28
{
    class Box:Cube
    {
        private double b;

        public Box(double a1, double b1, double h1)
            : base(a1, h1)
        {
            this.b = b1;
        }

        public override double Surface()
        {
            return Math.Sqrt(base.Surface()) * b;
        }
    }
}
