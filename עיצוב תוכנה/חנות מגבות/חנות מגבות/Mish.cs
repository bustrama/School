using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace חנות_מגבות
{
    class Mish
    {
        private int price;
        private int sum;

        public Mish()
        {

        }
        public Mish(int p, int s)
        {
            this.price = p;
            this.sum = s;
        }

        public int GetPrice()
        {
            return this.price;
        }
        public void SetPrice(int value)
        {
            this.price = value;
        }
        public int GetSum()
        {
            return this.sum;
        }
        public void SetSum(int value)
        {
            this.sum = value;
        }
    }
}
