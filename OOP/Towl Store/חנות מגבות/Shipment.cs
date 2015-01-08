using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace Towl_Store
{
    class Shipment
    {
        public int price { get; set; }
        public int sum { get; set; }

        public Shipment()
        {

        }
        public Shipment(int p, int s)
        {
            this.price = p;
            this.sum = s;
        }
    }
}
