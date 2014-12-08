using System;
using System.Collections.Generic;
using System.Linq;

namespace StringToNode
{
    class Node<T>
    {
        public T info { get; set; }
        public Node<T> next { get; set; }

        public Node(T value)
        {
            this.info = value;
            this.next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.info = value;
            this.next = next;
        }

        public static string printIntNode(Node<T> chain)
        {
            string chainString = null;
            if (chain.next == null)
                chainString += chain.ToString();
            else
            {
                chainString += chain.info + " --> ";
                chainString += printIntNode(chain.next);
            }
            return chainString;
        }

        public override string ToString()
        {
            return "" + this.info.ToString();
        }
    }
}
