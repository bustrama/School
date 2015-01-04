using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace טנמ_חברת_ברנט
{
    class Emda
    {
        private Queue<Caller> q;
        private bool status;
        private int mone;

        public Emda()
        {
            this.q = new Queue<Caller>();
            this.status = true;
            this.mone = 0;
        }

        //public bool IsEmpty()
        //{
        //    if (this.q.IsEmpty())
        //        return true;
        //    return false;
        //}

        public int GetMone()
        {
            return this.mone;
        }

        public void SetMone(int value)
        {
            this.mone = value;
        }

        public bool GetStatus()
        {
            return this.status;
        }

        public void SetStatus(bool value)
        {
            this.status = value;
        }

        //public Queue<Caller> GetQ()
        //{
        //    return this.q;
        //}

        public void InsertCaller(Caller c)
        {
            this.q.Insert(c);
            this.mone++;
        }

        public void RemoveCaller(Caller c)
        {
            this.q.Remove();
            this.mone--;
        }
    }
}
