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

            while (str != null)
            {
                if (str.IndexOf(' ') > 0)
                {
                    t.next = new Node<string>(str.Substring(0, str.IndexOf(' ')));
                    t = t.next;
                    str = str.Remove(0, str.IndexOf(' ') + 1);
                }
                else
                {
                    t.next = new Node<string>(str.Substring(0, str.Length));
                    t = t.next;
                    str = null;
                }
            }

            Console.WriteLine(Node<string>.printIntNode(stringNode));

            Console.ReadLine();
        }
    }
}
