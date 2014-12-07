using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntNode_1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = rand.Next(2, 100);

            IntNode chain = new IntNode(1);
            IntNode t = chain;

            for (int i = 2; i < n; i++)
            {
                t.next = new IntNode(i);
                t = t.next;
            }

            Console.WriteLine(IntNode.printIntNode(chain));

            Console.ReadKey();
        }
    }
}
