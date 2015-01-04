using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace טנמ_בנושא_תור
{
    class DoubleLine
    {
        private Queue<int> fastQ;
        private Queue<int> slowQ;
        private int countFast;

        public DoubleLine()
        {
            this.fastQ = new Queue<int>();
            this.slowQ = new Queue<int>();
            this.countFast = 0;
        }

        public void Add(int num, int act)
        {
            if (act == 0)
            {
                this.fastQ.Insert(num);
            }
            else
            {
                this.slowQ.Insert(num);
            }
        }

        public void Remove()
        {
            if (this.countFast < 5)
            {
                this.fastQ.Remove();
                countFast++;
            }
            else
            {
                this.slowQ.Remove();
                this.countFast++;
            }
        }
    }
}
