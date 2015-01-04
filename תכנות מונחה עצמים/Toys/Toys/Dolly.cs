using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toys
{
    class Dolly:Toy
    {
        private int accerrories;
        private double accPrice;
        public Dolly(string name, double price, int acc, double accp)
            : base(name, price)
        {
            this.accerrories = acc;
            this.accPrice = accp;
        }

        public override double ComputePrice()
        {
            return this.accerrories * this.accPrice + this.basePrice;
        }

        //public override void ChangeBasePrice(double precent)
        //{
        //    this.basePrice += this.basePrice * precent / 100;
        //}

        public override string toString()
        {
            return "Dolly " + this.name + ": the price is " + this.ComputePrice();
        }
    }
}
