using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringToNode
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Node<string> stringNode = new Node<string>(str.Substring(0, str.IndexOf(' ')));
            str = str.Remove(0, str.IndexOf(' ') +1);
            Node<string> t = stringNode;

            for (int i = 0; i < str.Length; i++)
            {
                if(str.IndexOf(' ') > 0)
                    t.next = new Node<string>(str.Substring(0, str.IndexOf(' ')));
                else
                    t.next = new Node<string>(str.Substring(0, str.Length));
                t = t.next;
                str = str.Remove(0, str.IndexOf(' ') + 1);
            }

            Console.WriteLine(Node<string>.printIntNode(stringNode));

            Console.ReadLine();
        }
    }
}
