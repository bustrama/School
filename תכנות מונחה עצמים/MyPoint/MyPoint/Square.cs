using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPoint
{
    class Square
    {
        //datamembers
        private Line line;

        //בנאים
        public Square()
        {
            this.line = new Line();
        }
        public Square(Line l1)
        {
            this.line = l1;
        }

        //get&set
        public Line GetTsela()
        {
            return this.line;
        }
        public void SetTsela(Line value)
        {
            this.line = value;
        }

        //פעולות
        private double Psquare()
        {
            return 4*this.line.Length();
        }
        private double Ssquare()
        {
            return Math.Pow(this.line.Length(), 2);
        }

        public void Show()
        {
            Console.WriteLine("The tsela length: {0} ", this.line.Length());
            Console.WriteLine("Psquare: {0}", Psquare());
            Console.WriteLine("Ssquare: {0}", Ssquare());
            Console.WriteLine();

    }
}
