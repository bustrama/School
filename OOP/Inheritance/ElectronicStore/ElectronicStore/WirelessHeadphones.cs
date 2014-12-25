using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicStore
{
    class WirelessHeadphones : Product
    {
        protected double reseptionRange;

        public WirelessHeadphones()
            : base()
        {
            this.reseptionRange = 0;
        }

        public WirelessHeadphones(string brand, string model, float price, int amount, double reseption):base(brand, model, price, amount)
        {
            this.reseptionRange = reseption;
        }
    }
}
