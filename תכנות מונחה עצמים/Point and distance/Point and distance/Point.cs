using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hhfjki
{
    class Point
    {
        //public int x;
        //public int y;
        private int x;
        private int y;

        public int GetX()
        {
            return this.x;
        }
        public void SetX(int value)
        {
            this.x = value;
        }

        public int GetY()
        {
            return this.y;
        }
        public void SetY(int value)
        {
            this.y = value;
        }

        

        public string toString()
        {
            return "x=" + this.x + " ,y=" + this.y;
        }
    }
}
