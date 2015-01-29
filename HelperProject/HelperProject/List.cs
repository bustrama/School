using System;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace HelperProject
{
    class List
    {
        /// רשימה
        /// 
        //טענת כניסה: הפעולה מקבלת רשימה של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה "אמת" אם המספר נמצא ברשימה, אחרת מחזירה "שקר"
        // סיבוכיות זמן ריצה: O(n)
        public static bool IsExistList(List<int> l, int n)
        {
            Node<int> pos = l.GetFirst();
            while (pos != null)
            {
                if (pos.GetInfo() == n)
                    return true;
                pos = pos.GetNext();
            }
            return false;
        }
        // טענת כניסה: הפעולה מקבלת רשימה של מספרים שלמים
        // טענת כניסה: הפעולה מחזירה את סכום כל איברי הרשימה
        // סיבוכיות זמן ריצה: O(n)
        public static int SumList(List<int> l)
        {
            int sum = 0;
            Node<int> pos = l.GetFirst();
            while (pos != null)
            {
                sum += pos.GetInfo();
                pos = pos.GetNext();
            }
            return sum;
        }
        // טענת כניסה: הפעולה מקבלת רשימה של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את אורך הרשימה - מספר החוליות בה
        // סיבוכיות זמן ריצה: O(n)
        public static int LengthList(List<int> l)
        {
            int length = 0;
            Node<int> pos = l.GetFirst();
            while (pos != null)
            {
                length++;
                pos = pos.GetNext();
            }
            return length;
        }
        // טענת כניסה: הפעולה מקבלת רשימה ממוינת של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מכניסה באופן ממוין את המספר לרשימה
        // סיבוכיות זמן ריצה: O(n)
        public static void InsertSorted(List<int> l, int n)
        {
            Node<int> pos = l.GetFirst();
            Node<int> before = null;
            while (pos != null && n > pos.GetInfo())
            {
                before = pos;
                pos = pos.GetNext();
            }
            l.Insert(before, n);
        }

        //מקבלת רשימה
        //מחזירה את אורך הרשימה
        public static int Size(List<int> l)
        {
            Node<int> pos = l.GetFirst();
            int mone = 0;
            while (pos != null)
            {
                mone++;
                pos = pos.GetNext();
            }
            return mone;
        }

        //מקבלת רשימה
        //מחזירה את סכום איברי הרשימה
        public static int Sum(List<int> l)
        {
            Node<int> pos = l.GetFirst();
            int sum = 0;
            while (pos != null)
            {
                sum += pos.GetInfo();
                pos = pos.GetNext();
            }
            return sum;
        }

        //מקבלת רשימה
        //מחזירה את הערך הגדול ביותר
        public static int Max(List<int> l)
        {
            Node<int> pos = l.GetFirst();
            int max = int.MinValue;
            while (pos != null)
            {
                if (pos.GetInfo() > max)
                {
                    max = pos.GetInfo();
                }
                pos = pos.GetNext();
            }
            return max;
        }

        //מקבלת רשימה ומספר
        //מחזירה אמת אם המספר נמצא ברשימה ושקר אחרת
        public static bool IsIn(List<int> l, int n)
        {
            Node<int> pos = l.GetFirst();

            while (pos != null)
            {
                if (n == pos.GetInfo())
                {
                    return true;
                }
                pos = pos.GetNext();
            }
            return false;
        }

        //מקבלת רשימה של מספרים שלמים
        //מחזירה את הרשימה ללא מספרים שליליים
        public static List<int> PositiveList(List<int> l)
        {
            Node<int> pos = l.GetFirst();
            while (pos != null)
            {
                if (pos.GetInfo() < 0)
                {
                    pos = l.Remove(pos);
                }
                else
                {
                    pos = pos.GetNext();
                }
            }
            return l;
        }
        //מקבלת 2 רשימות ממוינות
        //מחזירה איחוד ממוין של 2 הרשימות
        public static List<int> Merge(List<int> l1, List<int> l2)
        {
            List<int> newList = new List<int>();
            Node<int> pos = null;
            Node<int> pos1 = l1.GetFirst();
            Node<int> pos2 = l2.GetFirst();
            while (pos1 != null && pos2 != null)
            {
                if (pos1.GetInfo() <= pos2.GetInfo())
                {
                    pos = newList.Insert(pos, pos1.GetInfo());
                    pos1 = pos1.GetNext();
                }
                else
                {
                    pos = newList.Insert(pos, pos2.GetInfo());
                    pos2 = pos2.GetNext();
                }
            }
            if (pos1 == null)
            {
                while (pos2 != null)
                {
                    pos = newList.Insert(pos, pos2.GetInfo());
                    pos2 = pos1.GetNext();
                }
            }
            else
            {
                while (pos1 != null)
                {
                    pos = newList.Insert(pos, pos1.GetInfo());
                    pos1 = pos1.GetNext();
                }
            }
            return newList;
        }

        ///////תרגיל

        //מקבלת מספר ורשימה
        //מחזירה את מרחק המספר מהקצוות או -1 אם הוא לא נמצא
        public static int Distance(List<int> l, int num)
        {
            if (!IsIn(l, num))
                return -1;
            else
            {
                Node<int> pos = l.GetFirst();
                int right = 0;
                int left = 0;
                while (pos.GetInfo() != num)
                {
                    left += pos.GetInfo();
                    pos = pos.GetNext();
                }
                pos = pos.GetNext();
                while (pos != null)
                {
                    right += pos.GetInfo();
                    pos = pos.GetNext();
                }
                if (left <= right)
                    return left;
                return right;
            }
        }

        //////////תרגיל

        //מקבלת רשימה ומספר
        //מחזירה את שכיחות המספר ברשימה
        public static int MoneNumInList(List<int> l, int num)
        {
            Node<int> pos = l.GetFirst();
            int mone = 0;
            while (pos != null)
            {
                if (pos.GetInfo() == num)
                {
                    mone++;
                }
                pos = pos.GetNext();
            }
            return mone;
        }
        //מקבלת רשימה
        //מחזירה את המספר השכיח ביותר
        public static int MaxTimesNum(List<int> l)
        {
            int maxmone = 0;
            int max = l.GetFirst().GetInfo();
            Node<int> pos = l.GetFirst();
            while (pos != null)
            {
                if (MoneNumInList(l, pos.GetInfo()) > maxmone)
                {
                    maxmone = MoneNumInList(l, pos.GetInfo());
                    max = pos.GetInfo();
                }
                pos = pos.GetNext();
            }
            return max;
        }
        //מקבלת רשימה
        //מחזירה רשימה מועתקת
        public static List<int> Copy(List<int> l)
        {
            Node<int> pos = l.GetFirst();
            List<int> newList = new List<int>();
            Node<int> newpos = null;
            while (pos != null)
            {
                newpos = newList.Insert(newpos, pos.GetInfo());
                pos = pos.GetNext();
            }
            return newList;
        }
        //מקבלת רשימה ומספר
        //מוחקת את המספר מהרשימה
        public static void DeleteNum(List<int> l, int num)
        {
            Node<int> pos = l.GetFirst();
            while (pos != null)
            {
                if (pos.GetInfo() == num)
                    pos = l.Remove(pos);
                else
                {
                    pos = pos.GetNext();
                }
            }
        }
        //מקבלת רשימת מספרים
        //מחזירה רשימה חדשה המכילה את המספרים לפי שכיחותם
        public static List<int> MainAction(List<int> l)
        {
            List<int> copied = Copy(l);
            List<int> newList = new List<int>();
            Node<int> pos = null;
            while (!copied.IsEmpty())
            {
                pos = newList.Insert(pos, MaxTimesNum(copied));
                DeleteNum(copied, MaxTimesNum(copied));
            }
            return newList;
        }
    }
}
