using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace תור
{
    class Program
    {
        //מקבלת תור
        //מחזירה את מספר האיברים בו
        public static int Size(Queue<int> q)
        {
            int mone = 0;
            q.Insert(-999);
            while (q.Head() != -999)
            {
                mone++;
                q.Insert(q.Remove());
            }
            q.Remove();
            return mone;
        }

        //מקבלת תור
        //מחזירה את המערך הפוך
        public static void Hafuch(Queue<int> q)
        {
            Stack<int> st = new Stack<int>();
            while (!q.IsEmpty())
            {
                st.Push(q.Remove());
            }
            while (!st.IsEmpty())
            {
                q.Insert(st.Pop());
            }
        }

        //פעולה המקבלת תור ומספר
        //מחזירה אמת אם המספר קיים בתור ושקר אחרת
        public static bool IsIn(Queue<int> q, int n)
        {
            bool check = false;
            q.Insert(-9999);
            while (q.Head() != -9999)
            {
                if (q.Head() == n)
                    check = true;
                q.Insert(q.Remove());
            }
            q.Remove();
            return check;
        }

        //מקבלת תור עם כפילויות
        //מוחקת את הכפילויות
        public static void NoRepeatings(Queue<int> q)
        {
            Queue<int> tempq = new Queue<int>();
            while (!q.IsEmpty())
            {
                if (!IsIn(tempq, q.Head()))
                {
                    tempq.Insert(q.Head());
                }
                q.Remove();
            }
            while (!tempq.IsEmpty())
            {
                q.Insert(tempq.Remove());
            }
        }

        //מקבלת תור
        //מחזירה שרשרת חוליות של כל האיברים הזוגיים בתור
        //הנחה: יש זוגי אחד לפחות בתור
        public static Node<int> Zugiim(Queue<int> q)
        {
           while (q.Head() % 2 != 0)
           {
               q.Insert(q.Remove());
           }
           Node<int> chain = new Node<int>(q.Head());
           q.Insert(-999);
           q.Insert(q.Remove());
           while(q.Head()!=-999)
           {
               if (q.Head() % 2 == 0)
               {
                   Node<int> temp = new Node<int>(q.Head(), chain);
                   chain = temp;
               }
               q.Insert(q.Remove());
           }
           q.Remove();
           return chain;           
        }

        //מקבלת שרשרת חוליות
        //מדפיסה את השרשרת
        public static void PrintNode(Node<int> in1)
        {
            while (in1 != null)
            {
                Console.Write(in1.ToString() + " -> ");
                in1 = in1.GetNext();
            }
            Console.WriteLine("null");
        }

        //מקבלת מערך של תורים ומספר
        //מדפיסה את האינדקסים במערך שהמספר מופיע בהם
        public static void PrintIndex(Queue<int>[] arr, int num)
        {
            string st = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if(IsIn(arr[i],num))
                {
                    st += i + ", ";
                }
            }
            Console.WriteLine(st);
        }

        //
        //
        public static void HowManySifra(Queue<int> q, int sifra)
        {
            int mone = 0;
            q.Insert(-999);
            while (q.Head() != -999)
            {
                if (q.Head()==sifra)
                {
                    mone++;
                }
                q.Insert(q.Remove());
            }
            q.Remove();
            Console.WriteLine(sifra + ": " + mone);
        }
        public static void HowManyTimes(Queue<int> q)
        {
            for (int i = 0; i <= 9; i++)
            {
                HowManySifra(q, i);
            }
        }



        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(9);
            q.Insert(7);
            q.Insert(9);
            q.Insert(8);
            q.Insert(10);

            Queue<int>q1=new Queue<int>();
            q1.Insert(5);
            q1.Insert(4);
            q1.Insert(7);
            q1.Insert(3);
            q1.Insert(6);

            Queue<int>q2=new Queue<int>();
            q2.Insert(4);
            q2.Insert(12);
            q2.Insert(22);
            q2.Insert(26);
            q2.Insert(1);

            Queue<int> q3 = new Queue<int>();
            q3.Insert(1);
            q3.Insert(2);
            q3.Insert(4);
            q3.Insert(5);
            q3.Insert(6);
            q3.Insert(8);
            q3.Insert(9);
            q3.Insert(0);
            q3.Insert(5);

            Queue<int>[]arr=new Queue<int>[3];
            arr[0] = q;
            arr[1] = q1;
            arr[2] = q2;



            //Console.WriteLine(q2.ToString());

            //Console.WriteLine();
            //Console.WriteLine(Size(q));

            //Console.WriteLine();
            //Hafuch(q);
            //Console.WriteLine(q.ToString());

            //Console.WriteLine();
            //Console.WriteLine(IsIn(q,2));

            //Console.WriteLine();
            //NoRepeatings(q);
            //Console.WriteLine(q.ToString());

            //Console.WriteLine();            
            //PrintNode(Zugiim(q2));

            //Console.WriteLine();
            //PrintIndex(arr, 7);

            HowManyTimes(q3);
        }
    }
}
