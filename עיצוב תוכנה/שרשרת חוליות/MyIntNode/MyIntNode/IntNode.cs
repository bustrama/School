using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIntNode
{
    class IntNode
    {
       
            private int info;
            private IntNode next;

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

            public IntNode GetNext()
            {
                return this.next;
            }

            public void SetNext(IntNode next)
            {
                this.next = next;
            }

            public int GetInfo()
            {
                return this.info;
            }

            public void SetInfo(int x)
            {
                this.info = x;
            }

            public override string ToString()
            {
                return "" + this.info;
            }
        }
    }

