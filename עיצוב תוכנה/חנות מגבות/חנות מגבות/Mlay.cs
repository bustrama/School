using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace חנות_מגבות
{
    class Mlay
    {
        private Stack<Mish> stack;

        public Mlay()
        {
            stack = new Stack<Mish>();
        }

        public Stack<Mish> GetStack()
        {
            return this.stack;
        }
        


        public void Add(int p, int s)
        {
            Mish m = new Mish(p, s);
            stack.Push(m);
        }

        public int XXX(int s)
        {
            int sum=0;
            while (s > 0)
            {
                if (s >= stack.Top().GetSum())
                {
                    sum += stack.Top().GetSum() * stack.Top().GetPrice();
                    s -= stack.Top().GetSum();
                    stack.Pop();
                }
                else
                {                    
                    sum += s * stack.Top().GetPrice();
                    stack.Top().SetSum(stack.Top().GetSum() - s);
                    s = 0;
                }
            }
            return sum;
        }








    }
}
