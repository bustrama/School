using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkPage_28
{
    class Cube
    {
        protected double a;
        protected double h;

        public Cube(double a1, double h1)
        {
            this.a = a1;
            this.h = h1;
        }

        public virtual double Surface()
        {
            return this.a * this.a;
        }

        public double Volume()
        {
            return this.h * this.Surface();
        }
    }
}
