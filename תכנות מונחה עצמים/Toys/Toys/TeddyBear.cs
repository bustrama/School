using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toys
{
    class TeddyBear:Toy
    {
        private bool isBig;
        private string color;

        public TeddyBear(string name, double price, bool isbig, string c)
            : base(name, price)
        {
            this.isBig = isbig;
            this.color = c;
        }

        public override double ComputePrice()
        {
            if (this.isBig)
                return this.basePrice + 30;
            return this.basePrice + 15;
        }

        //public override void ChangeBasePrice(double precent)
        //{
        //    this.basePrice += this.basePrice * precent / 100;
        //}

        public override string toString()
        {
            return this.color+ " TeddyBear " + this.name + ": the price is " + this.ComputePrice();
        }
    }
}
