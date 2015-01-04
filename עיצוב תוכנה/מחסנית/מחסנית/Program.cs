using System;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;


namespace מחסנית
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int count(Stack<int> T)
        {
            int counter = 0;
            Stack<int> temp = new Stack<int>();
            while (!T.IsEmpty())
            {
                temp.Push(T.Pop());
                counter++;
            }
            while (!temp.IsEmpty())
            {
                T.Push(temp.Pop());
            }
            return counter;
        }

        //מחזירה את האחרון במחסנית
        public static int LastObject(Stack<int> T)
        {
            Stack<int> temp = new Stack<int>();
            while (!T.IsEmpty())
            {
                temp.Push(T.Pop());
            }
            int num = temp.Top();
            while (!temp.IsEmpty())
            {
                T.Push(temp.Pop());
            }
            return num;
        }

        //הופך את סדר האיברי המחסנית
        public static void Oposite(Stack<int> T)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> s3 = new Stack<int>();
            while (!T.IsEmpty())
            {
                temp.Push(T.Pop());
            }

            while (!temp.IsEmpty())
            {
                s3.Push(temp.Pop());
            }
            while (!s3.IsEmpty())
            {
                T.Push(s3.Pop());
            }
        }

        //מחזירה מחסנית של אורכי המחרוזות
        public static Stack<int> GetStringsLength(Stack<string> T)
        {
            Stack<int> temp = new Stack<int>();
            Stack<string> s3 = new Stack<string>();
            while (!T.IsEmpty())
            {
                s3.Push(T.Pop());
            }
            while (!s3.IsEmpty())
            {
                T.Push(s3.Pop());
                temp.Push(T.Top().Length);
            }
            return temp;
        }

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

        
    }
}
