using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPoint
{
    class Circle
    {
        //datamembers
        private Point center;
        private int radius;

        //בנאים
        public Circle()
        {
            this.center = new Point();
            //this.center=null;
            this.radius = 0;
        }
        public Circle(Point p1, int l1)
        {
            this.center = p1;
            //this.p1=new Point(p1);
            this.radius = l1;
        }

        //Gets&Sets
        public Point GetCenter()
        {
            return this.center;
        }
        public void SetCenter(Point value)
        {
            this.center = value;
        }

        public int GetRadius()
        {
            return this.radius;
        }
        public void SetRadius(int value)
        {
            if (value <= 1)
                this.radius = 1;
            else
                this.radius = value;
        }

        //properties
        public Point Center
        {
            get { return this.center; }
            set { this.center = value; }
        }
        public int Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 1)
                    this.radius = 1;
                else
                    this.radius = value;
            }
        }

        //פעולות
        private double Pcircle()
        {
            return Math.PI * 2 * this.radius;
        }
        private double Scircle()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public void Show()
        {
            Console.WriteLine("Center point:{0} ", center.toString());
            Console.WriteLine("The radius length: {0} ", this.radius);
            Console.WriteLine("Pcircle: {0}", Pcircle());
            Console.WriteLine("Scircle: {0}", Scircle());
            Console.WriteLine();
        }
    }
}
