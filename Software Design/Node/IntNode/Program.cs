using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntNode
{
    class Program
    {
        static void Main(string[] args)
        {
            IntNode n = new IntNode(7, new IntNode(21, new IntNode(4)));

            Console.WriteLine(n.printIntNode(n));
        }

        
    }
}
