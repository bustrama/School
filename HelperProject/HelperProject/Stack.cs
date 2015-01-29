using System;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace HelperProject
{
    class Stack
    {
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

        ///
        /// מחסנית
        ///
        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה מחסנית חדשה, שאיבריה זהים בערכם ובסדרם לאיברי המחסנית שהתקבלה
        // סיבוכיות זמן ריצה: O(n)
        public static Stack<int> CloneStack(Stack<int> s)
        {
            Stack<int> newS = new Stack<int>();
            Stack<int> tmp = new Stack<int>();
            while (!s.IsEmpty())
                tmp.Push(s.Pop());
            while (!tmp.IsEmpty())
            {
                newS.Push(tmp.Top());
                s.Push(tmp.Pop());
            }
            return newS;
        }

        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה מחסנית חדשה, שאיבריה מסודרים בסדר הפוך ביחס לאיברי המחסנית שהתקבלה
        // סיבוכיות זמן ריצה: O(n)
        public static Stack<int> FlipStack(Stack<int> s)
        {
            Stack<int> newS = new Stack<int>();
            Stack<int> tmp = CloneStack(s); //!
            while (!tmp.IsEmpty())
                newS.Push(tmp.Pop());
            return tmp;
        }
        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים ומספר שלם
        // טענת יציאה: המחסנית מחזירה "אמת" אם המספר נמצא במחסנית, אחרת מחזירה "שקר"
        // סיבוכיות זמן ריצה: O(n)
        public static bool IsExistStack(Stack<int> s, int n)
        {
            Stack<int> sCopy = CloneStack(s); //!
            while (!sCopy.IsEmpty())
                if (sCopy.Pop() == n)
                    return true;
            return false;
        }
        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה "אמת" אם המספר נמצא במחסנית, אחרת מחזירה "שקר"
        // הערה: הפעולה רקורסיבית, ועדיין שומרת על סדר המחסנית שהתקבלה
        // סיבוכיות זמן ריצה: O(n)
        public static bool IsExistStackRec(Stack<int> s, int n)
        {
            if (s.IsEmpty())
                return false;
            int x = s.Pop();
            bool exists = (x == n || IsExistStackRec(s, n));
            s.Push(x); //לאחר הקריאה הרקורסיבית, האיבר שנשלף נדחף בחזרה אל תוך המחסנית
            return exists;
        }
        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום איברי המחסנית
        // סיבוכיות זמן ריצה: O(n)
        public static int SumStack(Stack<int> s)
        {
            int sum = 0;
            Stack<int> sCopy = CloneStack(s); //!
            while (!sCopy.IsEmpty())
                sum += sCopy.Pop();
            return sum;
        }
        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את אורך המחסנית - מספר האיברים בה
        // סיבוכיות זמן ריצה: O(n)
        public static int LengthStack(Stack<int> s)
        {
            int length = 0;
            Stack<int> sCopy = CloneStack(s); //!
            while (!sCopy.IsEmpty())
            {
                length++;
                sCopy.Pop();
            }
            return length;
        }
    }
}
