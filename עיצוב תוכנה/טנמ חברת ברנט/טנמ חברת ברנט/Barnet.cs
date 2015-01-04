using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace טנמ_חברת_ברנט
{
    class Barnet
    {
        private Emda[] arr;

        public Barnet()
        {
            this.arr = new Emda[15];
            for (int i = 0; i < this.arr.Length; i++)
            {
                arr[i] = new Emda();
            }
        }

        public Emda[] GetArr()
        {
            return this.arr;
        }

        public int EmptyQ()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i].GetMone() == 0)
                    return i;
            }
            return -1;
        }

        public int EmptyEmda()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i].GetStatus())
                    return i;
            }
            return -1;
        }

        public int ShortQ()
        {
            int shortest = 0;
            int count = 0;
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i].GetMone() > count)
                {
                    shortest = i;
                    count = this.arr[i].GetMone();
                }
            }
            return shortest;
        }

        public void Insert(Caller c, int i)
        {
            this.arr[i].InsertCaller(c);
            //if (this.EmptyEmda() != -1)
            //{
            //    this.arr[this.EmptyEmda()].SetStatus(false);
            //}
            //else
            //{
            //    if (this.EmptyQ() != -1)
            //    {
            //        this.arr[this.EmptyQ()].InsertCaller(c);
            //    }
            //    else
            //    {
            //        this.arr[this.ShortQ()].InsertCaller(c);                    
            //    }
            //}
        }

        public void Remove(Caller c, int i)
        {
            this.arr[i].RemoveCaller(c);
        }
    }
}
