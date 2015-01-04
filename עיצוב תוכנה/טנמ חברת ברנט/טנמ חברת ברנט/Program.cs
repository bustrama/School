using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace טנמ_חברת_ברנט
{
    class Program
    {
        public static void Natev_Caller(Caller c)
        {
            Barnet b= new Barnet();
            Emda[] a = b.GetArr();
            if (b.EmptyEmda() != -1)
            {                
                a[b.EmptyEmda()].SetStatus(false);
            }
            else
            {
                if (b.EmptyQ() != -1)
                {
                    a[b.EmptyQ()].InsertCaller(c);
                }
                else
                {
                    a[b.ShortQ()].InsertCaller(c);
                }
            }
        }




        static void Main(string[] args)
        {
        }
    }
}
