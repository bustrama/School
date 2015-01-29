using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class UsefulMethods
    {
        /* הערות:
        * מחלקת עזר זו כוללת פעולות עזר על רשימה, מחסנית, תור ועץ בינארי
        * לכל פעולה כתובות מעליה (כהערות) טענת הכניסה, טענת היציאה וסיבוכיות זמן הריצה של הפעולה
        * הערה עם סימן קריאה משמעה פעולה חיצונית שקיימת במחלקת עזר זו - יש לכתוב את הפעולה החיצונית!
        * רוב הפעולות מקבלות טיפוס נתונים מסוג מספר שלם, אך יכולות לעבוד עם כל טיפוס אחר
        * © כל הזכויות שמורות לערן - Saurik
        * לבקשות, הערות והצעות: http://www.fxp.co.il/showthread.php?t=14343465
        * בהצלחה בבחינות! 
        */


        ///
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
        
        
        ///
        
        ///
        /// עץ בינארי
        /// 
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה עץ חדש, זהה בדיוק בצמתיו ובמיקומים שלהם לעץ שהתקבל
        // סיבוכיות זמן ריצה: O(n)
        public static BinTreeNode<int> CloneTree(BinTreeNode<int> bt)
        {
            if (bt == null)
                return null;
            BinTreeNode<int> left = CloneTree(bt.GetLeft());
            BinTreeNode<int> right = CloneTree(bt.GetRight());
            return new BinTreeNode<int>(left, bt.GetInfo(), right); //להחליף ימין ושמאל לקבלת עץ מראה
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה "אמת" אם המספר שהתקבל נמצא בעץ, אחרת מחזירה "שקר"
        // סיבוכיות זמן ריצה: O(n)
        public static bool IsExistTree(BinTreeNode<int> bt, int n)
        {
            if (bt == null)
                return false;
            return (bt.GetInfo() == n || IsExistTree(bt.GetLeft(), n) || IsExistTree(bt.GetRight(), n));
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום ערכי כל הצמתים בעץ
        // סיבוכיות זמן ריצה: O(n)
        public static int SumTree(BinTreeNode<int> bt)
        {
            if (bt == null)
                return 0;
            return bt.GetInfo() + SumTree(bt.GetLeft()) + SumTree(bt.GetRight());
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה "אמת" אם העץ הוא עלה, אחרת מחזירה "שקר"
        // סיבוכיות זמן ריצה: O(1)
        public static bool IsLeaf(BinTreeNode<int> bt)
        {
            return (bt.GetLeft() == null && bt.GetRight() == null);
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את ערכי הצמתים בעץ לפי סדר תחילי - שורש, שמאל, ימין
        // סיבוכיות זמן ריצה: O(n)
        public static void PrintPreOrder(BinTreeNode<int> bt)
        {
            if (bt != null)
            {
                Console.WriteLine(bt.GetInfo());
                PrintPreOrder(bt.GetLeft());
                PrintPreOrder(bt.GetRight());
            }
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את ערכי הצמתים בעץ לפי סדר תוכי - שמאל, שורש, ימין
        // סיבוכיות זמן ריצה: O(n)
        public static void PrintInOrder(BinTreeNode<int> bt)
        {
            if (bt != null)
            {
                PrintInOrder(bt.GetLeft());
                Console.WriteLine(bt.GetInfo());
                PrintInOrder(bt.GetRight());
            }
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את ערכי הצמתים בעץ לפי סדר סופי - שמאל, ימין, שורש
        // סיבוכיות זמן ריצה: O(n)
        public static void PrintPostOrder(BinTreeNode<int> bt)
        {
            if (bt != null)
            {
                PrintPostOrder(bt.GetLeft());
                PrintPostOrder(bt.GetRight());
                Console.WriteLine(bt.GetInfo());
            }
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את ערכי הצמתים בעץ לפי הרמה שלהם - כל צמתי העץ ברמה כלשהי יודפסו אחד אחרי השני
        // סיבוכיות זמן ריצה: O(n)
        public static void PrintByLevels(BinTreeNode<int> bt)
        {
            Queue<BinTreeNode<int>> q = new Queue<BinTreeNode<int>>();
            q.Insert(bt);
            while (!q.IsEmpty())
            {
                BinTreeNode<int> current = q.Remove();
                Console.WriteLine(current.GetInfo());
                if (current.GetLeft() != null)
                    q.Insert(current.GetLeft());
                if (current.GetRight() != null)
                    q.Insert(current.GetRight());
            }
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את מספר הצמתים בעץ
        // סיבוכיות זמן ריצה: O(n)
        public static int CountNodes(BinTreeNode<int> bt)
        {
            if (bt == null)
                return 0;
            return 1 + CountNodes(bt.GetLeft()) + CountNodes(bt.GetRight());
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את מספר העלים בעץ
        // סיבוכיות זמן ריצה: O(n)
        public static int CountLeaves(BinTreeNode<int> bt)
        {
            if (bt == null)
                return 0;
            if (IsLeaf(bt)) //!
                return 1;
            return CountLeaves(bt.GetLeft()) + CountLeaves(bt.GetRight());
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את גובה העץ
        // סיבוכיות זמן ריצה: O(n)
        public static int Height(BinTreeNode<int> bt)
        {
            if (IsLeaf(bt)) //!
                return 0;
            int right = 0, left = 0;
            if (bt.GetLeft() != null)
                left = Height(bt.GetLeft());
            if (bt.GetRight() != null)
                right = Height(bt.GetRight());
            return 1 + Math.Max(right, left);
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את הערך הגבוה ביותר בעץ
        // סיבוכיות זמן ריצה: O(n)
        public static int MaxValue(BinTreeNode<int> bt)
        {
            if (IsLeaf(bt)) //!
                return bt.GetInfo();
            int maxLeft = MaxValue(bt.GetLeft());
            int maxRight = MaxValue(bt.GetRight());
            return Math.Max(bt.GetInfo(), Math.Max(maxLeft, maxRight));
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי "בן" ואת הצומת העליון ביותר בעץ כלשהו בו נמצא "בן" - "שורש"
        // טענת יציאה: הפעולה מחזירה את האב של העץ "בן". אם אביו לא נמצא בעץ "שורש" - יוחזר ערך ריק
        // סיבוכיות זמן ריצה: O(n)
        public static BinTreeNode<int> GetFather(BinTreeNode<int> source, BinTreeNode<int> son)
        {
            if (source == null)
                return null;
            if (source.GetLeft() == son || source.GetRight() == son)
                return source;
            BinTreeNode<int> left = GetFather(source.GetLeft(), son);
            if (left != null)
                return left;
            return GetFather(source.GetRight(), son);
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר שלם
        // טענת יציאה: הפעולה מחזירה את מספר הצמתים בהם מופיע הערך שהתקבל
        // סיבוכיות זמן ריצה: O(n)
        public static int HowMany(BinTreeNode<int> bt, int n)
        {
            if (bt == null)
                return 0;
            if (bt.GetInfo() == n)
                return 1 + HowMany(bt.GetLeft(), n) + HowMany(bt.GetRight(), n);
            return HowMany(bt.GetLeft(), n) + HowMany(bt.GetRight(), n);
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים ומספר שלם המייצג רמה בעץ
        // טענת יציאה: הפעולה מחזירה את מספר הצמתים ברמה שהתקבלה
        // סיבוכיות זמן ריצה: O(n)
        public static int NodesInLevel(BinTreeNode<int> bt, int level)
        {
            if (bt == null)
                return 0;
            if (level == 0)
                return 1;
            return NodesInLevel(bt.GetLeft(), level - 1) + NodesInLevel(bt.GetRight(), level - 1);
        }
        // טענת כניסה: הפעולה מקבלת עץ בינארי של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה "אמת" אם העץ הוא עץ חיפוש בינארי, אחרת מחזירה "שקר"
        // סיבוכיות זמן ריצה: O(n)
        public static bool IsBST(BinTreeNode<int> bt)
        {
            if (bt == null)
                return true;
            if (bt.GetLeft() != null && bt.GetLeft().GetInfo() >= bt.GetInfo())
                return false;
            if (bt.GetRight() != null && bt.GetRight().GetInfo() < bt.GetInfo())
                return false;
            return IsBST(bt.GetLeft()) && IsBST(bt.GetRight());
        }
    }
}
