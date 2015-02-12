using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubes
{
    class Box:Cube
    {
        protected int b;

        public Box(int width, int length, int height):base(width, height)
        {
            this.a = width;
            this.b = length;
            this.height = height;
        }

        public override double basisArea()
        {
            return this.b * this.a;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Length: " + b;
        }
    }
}
