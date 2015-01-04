using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;


namespace מחסנית
{
    class Program
    {
        //מקבלת מחסנית
        //מחזירה את מספר האיברים במחסנית
        public static int NumOfObjects(Stack<int> s1)
        {
            int mone = 0;
            Stack<int> s2 = new Stack<int>();
            while (!s1.IsEmpty())
            {
                s2.Push(s1.Pop());
                mone++;
            }
            while (!s2.IsEmpty())
            {
                s1.Push(s2.Pop());
            }
            return mone;
        }
        //מקבלת מחסנית
        //מחזירה את האחרון במחסנית
        public static int LastObject(Stack<int> s1)
        {
            Stack<int> s2 = new Stack<int>();
            while (!s1.IsEmpty())
            {
                s2.Push(s1.Pop());
            }
            int num = s2.Top();
            while (!s2.IsEmpty())
            {
                s1.Push(s2.Pop());
            }
            return num;
        }
        //מקבל מחסנית
        //הופך את סדר האיברי המחסנית
        public static void Oposite(Stack<int> s1)
        {
            Stack<int> s2 = new Stack<int>();
            Stack<int> s3 = new Stack<int>();
            while (!s1.IsEmpty())
            {
                s2.Push(s1.Pop());
            }

            while (!s2.IsEmpty())
            {
                s3.Push(s2.Pop());
            }
            while (!s3.IsEmpty())
            {
                s1.Push(s3.Pop());
            }
        }
        //תרגיל 13 עמוד 246
        //מחסנית של מחרוזות
        //מחזירה מחסנית של אורכי המחרוזות
        public static Stack<int> GetStringsLength(Stack<string> s1)
        {
            Stack<int> s2 = new Stack<int>();
            Stack<string> s3 = new Stack<string>();
            while (!s1.IsEmpty())
            {
                s3.Push(s1.Pop());
            }
            while (!s3.IsEmpty())
            {
                s1.Push(s3.Pop());
                s2.Push(s1.Top().Length);
            }
            return s2;
        }
        //תרגיל 16 עמוד 247
        //מערך מחסניות של מספרים שלמים
        //סכום האיברים ברשי המחסניות
        public static int GetTopsSum(Stack<int>[] stacks)
        {
            int sum = 0;
            for (int i = 0; i < stacks.Length; i++)
            {
                if (!stacks[i].IsEmpty())
                    sum += stacks[i].Top();
            }
            return sum;
        }
        //מחסנית מלאה ומספר
        //מחזיר את המספר במקום של המספר
        public static int PlaceN(int n, Stack<int> st)
        {
            Stack<int> st1 = new Stack<int>();
            for (int i = 1; i < n; i++)
            {
                st1.Push(st.Pop());
            }
            int x = st.Top();
            while (!st1.IsEmpty())
                st.Push(st1.Pop());
            return x;

        }
        //מקבלת מחסנית ומספר 
        //מחזירה נכון אם המספר במחסנית 
        public static bool IsIn(int num, Stack<int> st)
        {
            bool b = false;
            Stack<int> st1 = new Stack<int>();
            while (!st.IsEmpty())
            {
                if (st.Top() == num)
                    b = true;
                st1.Push(st.Pop());
            }
            while (!st1.IsEmpty())
            {
                st.Push(st1.Pop());
            }
            return b;
        }
        //מחסנית
        //מחסנית חדשה בלי כפילויות
        public static Stack<int> NoRepeating(Stack<int> st)
        {
            Stack<int> tempst = new Stack<int>();
            Stack<int> newst = new Stack<int>();
            while (!st.IsEmpty())
            {
                if (!IsIn(st.Top(), tempst))
                {
                    tempst.Push(st.Top());
                    newst.Push(st.Pop());                    
                }
                else
                {
                    tempst.Push(st.Pop());
                }
            }
            while (!tempst.IsEmpty())
            {
                st.Push(tempst.Pop());
            }
            return newst;
        }
        //
        //
        public static void DeleteRepeating(Stack<int> st)
        {
            Stack<int> tempst = new Stack<int>();
            //Stack<int> newst = new Stack<int>();
            while (!st.IsEmpty())
            {
                if (!IsIn(st.Top(), tempst))
                {
                    tempst.Push(st.Pop());
                    //newst.Push(st.Pop());
                }
                else
                {
                    st.Pop();
                }
            }
            while (!tempst.IsEmpty())
            {
                st.Push(tempst.Pop());
            }
        }

        static void Main(string[] args)
        {
            ////שימוש בפעולות
            //Stack<int> stack = new Stack<int>();
            //for (int i = 1; i <= 150; i*=2)
            //{
            //    stack.Push(i);
            //}

            //Console.WriteLine(stack.ToString());

            //Console.WriteLine(NumOfObjects(stack));

            //Console.WriteLine(LastObject(stack));

            //Oposite(stack);
            //Console.WriteLine(stack.ToString());
            //Console.WriteLine();
            //Console.WriteLine();

            Stack<int> x = new Stack<int>();
            for (int i = 4; i >= 1; i--)
            {
                x.Push(i);
                x.Push(7);
            }
            x.Push(4);
            Console.WriteLine(x.ToString());
            //Console.WriteLine(PlaceN(2, x));
            //Console.WriteLine(x.ToString());
            //Console.WriteLine(IsIn(7,x));
            //Console.WriteLine(x.ToString());
            //Console.WriteLine("new stack "+NoRepeating(x).ToString());
            //Console.WriteLine(x.ToString());
            DeleteRepeating(x);
            Console.WriteLine("new stack"+x.ToString());
            ////תרגיל 13 עמוד 246
            //Stack<string> stack2 = new Stack<string>();
            //stack2.Push("name");
            //stack2.Push("my");
            //stack2.Push("is");
            //stack2.Push("Geva");
            //stack2.Push("Yuval");
            //Console.WriteLine(stack2.ToString());
            //Console.WriteLine(GetStringsLength(stack2).ToString());
            //Console.WriteLine();
            //Console.WriteLine();


            ////תרגיל 16 עמוד 248
            //Stack<int> s1 = new Stack<int>();
            //for (int i = 1; i <= 4; i++)
            //{
            //    s1.Push(i);
            //}
            //Stack<int> s2 = new Stack<int>();
            //for (int i = 1; i <= 3; i++)
            //{
            //    s2.Push(i);
            //}
            //Stack<int> s3 = new Stack<int>();
            //for (int i = 1; i <= 2; i++)
            //{
            //    s3.Push(i);
            //}
            //Stack<int>[] stacks = { s1, s2, s3 };
            //Console.WriteLine(GetTopsSum(stacks));


        }
    }
}
