using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveNode
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> chain = new Node<int>(3, new Node<int>(3, new Node<int>(7, new Node<int>(4, new Node<int>(3)))));
            Console.WriteLine(Node<int>.removeNode(chain, 3));
            Console.ReadKey();
        }
    }
}
