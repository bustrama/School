using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace Towl_Store
{
    class Stock
    {
        public Stack<Shipment> stack { get; private set;}

        public Stock()
        {
            stack = new Stack<Shipment>();
        }

        public void Add(int p, int s)
        {
            Shipment m = new Shipment(p, s);
            stack.Push(m);
        }

        public int XXX(int s)
        {
            int sum=0;
            while (s > 0)
            {
                if (s >= stack.Top().sum)
                {
                    sum += stack.Top().sum * stack.Top().price;
                    s -= stack.Top().sum;
                    stack.Pop();
                }
                else
                {                    
                    sum += s * stack.Top().price;
                    stack.Top().sum = stack.Top().sum - s;
                    s = 0;
                }
            }
            return sum;
        }








    }
}
