using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPoint
{
    class Line
    {
        //datamembers
        private Point start;
        private Point end;

        //בנאים
        public Line()
        {
            this.start= new Point();
            this.end = new Point();
        }
        public Line(int x1, int y1,int x2, int y2)
        {
            this.start = new Point(x1, y1);
            this.end = new Point(x2, y2);
        }
        public Line(Point p1, Point p2)
        {
            this.start = p1;
            this.end = p2;
        }

        //Gets&&Sets
        public Point GetStart()
        {
            return this.start;
        }
        public void SetStart(Point value)
        {
            this.start = value;             
        }
        
        public Point GetEnd()
        {
            return this.end;
        }
        public void SetEnd(Point value)
        {
            this.end = value;
        }
        
        //properties
        public Point Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }
        public Point End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }

        //פעולות
        public double Length()
        {
            double lengthx = start.Px - end.Px;
            double lengthy = start.Py - end.Py;
            double length = Math.Pow(lengthx, 2) + Math.Pow(lengthy, 2);
            return Math.Sqrt(length);
        }

        public void Show()
        {
            Console.WriteLine("Start point:{0} ", start.toString());
            Console.WriteLine("End point:{0} ", end.toString()); 
            Console.WriteLine("The line length: {0} ",Length());
            Console.WriteLine();


        }
    }
}
