using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toys
{
    abstract class Toy
    {
        protected string name;
        protected double basePrice;

        public Toy(string name, double price)
        {
            this.name = name;
            this.basePrice = price;
        }

        public abstract double ComputePrice();

        public void ChangeBasePrice(double precent)
        {
            this.basePrice += this.basePrice * precent / 100;
        }

        public abstract string toString();
    }
}
