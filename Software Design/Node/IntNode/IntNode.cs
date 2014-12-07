using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntNode
{
    class IntNode
    {
        public int info { get; set; }
        public IntNode next { get; set; }

        public IntNode(int x)
        {
            this.info = x;
            this.next = null;
        }

        public IntNode(int x, IntNode next)
        {
            this.info = x;
            this.next = next;
        }


        public string printIntNode(IntNode chain)
        {
            string chainString = null;
            if (chain.next == null)
                chainString += chain.ToString();
            else
            {
                chainString += chain.info + " ---> ";
                chainString += printIntNode(chain.next);
            }
            return chainString;
        }

        public override string ToString()
        {
            return "" + this.info;
        }
    }
}
