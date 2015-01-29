using System;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace HelperProject
{
    class Queue
    {
        /// תור
        /// 
        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה תור חדש, שאיבריו זהים בערכם ובסדרם לאיברי התור שהתקבל 
        // סיבוכיות זמן ריצה: O(n)
        public static Queue<int> CloneQueue(Queue<int> q)
        {
            Queue<int> newQ = new Queue<int>();
            Queue<int> tmp = new Queue<int>();
            while (!q.IsEmpty())
            {
                newQ.Insert(q.Head());
                tmp.Insert(q.Remove());
            }
            while (!tmp.IsEmpty())
                q.Insert(tmp.Remove());
            return newQ;
        }
        // טענת כניסה: הפעולה מקבלת מחסנית של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה "אמת" אם המספר קיים בתור, אחרת מחזירה "שקר"
        // סיבוכיות זמן ריצה: O(n)
        public static bool IsExistQueue(Queue<int> q, int n)
        {
            Queue<int> qCopy = CloneQueue(q); //!
            while (!qCopy.IsEmpty())
                if (qCopy.Remove() == n)
                    return true;
            return false;
        }
        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום איברי התור
        // סיבוכיות זמן ריצה: O(n)
        public static int SumQueue(Queue<int> q)
        {
            int sum = 0;
            Queue<int> qCopy = CloneQueue(q); //!
            while (!qCopy.IsEmpty())
                sum += qCopy.Remove();
            return sum;
        }
        // טענת כניסה: הפעולה מקבלת תור של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את אורך התור - מספר האיברים בו
        // סיבוכיות זמן ריצה: O(n)
        public static int LengthQueue(Queue<int> q)
        {
            int length = 0;
            Queue<int> qCopy = CloneQueue(q); //!
            while (!qCopy.IsEmpty())
            {
                length++;
                qCopy.Remove();
            }
            return length;
        }

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
            while (q.Head() != -999)
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
                if (IsIn(arr[i], num))
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
                if (q.Head() == sifra)
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
    }
}
