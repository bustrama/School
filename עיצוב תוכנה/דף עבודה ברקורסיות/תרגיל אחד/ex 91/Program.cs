using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_91
{
    class Program
    {
        public static int Number(int a,int d)
        {
            if (a / 10 == 0)
            {
                if (a == d)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (a % 10 == d)
                {
                    return 1 + Number(a / 10, d);
                }
                else
                {
                    return 0 + Number(a / 10, d);
                }
            }
        public static bool Numbers(int a, int b)
        {
            if (a / 10==0)
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (a % 10 == b % 10)
                {
                    return Numbers(a / 10, b / 10);
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

//if (a / 10 == 0)
//            {
//                if (a == d)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                if (a % 10 == d)
//                {
//                    return true;
//                }
//                else
//                {
//                    return Numbers(a / 10, d);
//                }
//            }
        
