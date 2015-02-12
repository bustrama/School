using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubes
{
    class Cube
    {
        protected int a;
        protected int height;

        public Cube(int a, int height)
        {
            this.a = a;
            this.height = height;
        }

        public virtual double basisArea()
        {
            return this.a * this.a;
        }

        public virtual double volume()
        {
            return this.basisArea() * this.height;
        }

        public override string ToString()
        {
            return "\n Basis: " + this.a + "\n Height: "+ this.height;
        }
    }
}
