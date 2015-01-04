using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointsArray//////
{
    class Point
    {
        //datamembers
        private int x;
        private int y;

        //בנאים
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x1, int y1)
        {
            this.x = x1;
            this.y = y1;
        }

        public Point(Point p1)
        {
            this.x = p1.GetX();
            this.y = p1.GetY();
        }


        //Get&Set
        public int GetX()
        {
            return this.x;
        }
        public void SetX(int value)
        {
            if (value <= 0)
            {
                this.x = 0;
            }
            else
            {
                this.x = value;
            }
        }

        public int GetY()
        {
            return this.y;
        }
        public void SetY(int value)
        {
            if (value <= 0)
            {
                this.y = 0;
            }
            else
            {
                this.y = value;
            }
        }

        //properties
        public int Px
        {
            get
            {
                return this.x;
            }
            set
            {
                if(value<=0)
                {
                    this.x=0;
                }
                else
                {
                    this.x=value;
                }
            }
                    
        }
        public int Py
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value <= 0)
                {
                    this.y = 0;
                }
                else
                {
                    this.y = value;
                }
            }

        }
        
        

        public string toString()
        {
            return "x=" + this.x + " ,y=" + this.y;
        }
    }
}
