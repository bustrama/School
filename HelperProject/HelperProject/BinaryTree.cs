using System;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace HelperProject
{
    class BinaryTree
    {
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

        //מקבלת עץ בינארי
        //מדפיסה את העץ בצורה תוכית
        public static void InOrderPrint(BinTreeNode<int> t)
        {
            if (t != null)
            {
                InOrderPrint(t.GetLeft());
                Console.Write(t.GetInfo() + " ");
                InOrderPrint(t.GetRight());
            }
        }
        //מקבלת עץ בינארי
        //מדפיסה את העץ בצורה תחילית
        public static void PreOrderPrint(BinTreeNode<int> t)
        {
            if (t != null)
            {
                Console.Write(t.GetInfo() + " ");
                PreOrderPrint(t.GetLeft());
                PreOrderPrint(t.GetRight());
            }
        }
        //מקבלת עץ בינארי
        //מדפיסה את העץ בצורה סופית
        public static void PostOrderPrint(BinTreeNode<int> t)
        {
            if (t != null)
            {
                PostOrderPrint(t.GetLeft());
                PostOrderPrint(t.GetRight());
                Console.Write(t.GetInfo() + " ");
            }
        }
        //מקבלת עץ בינארי
        //מדפיסה את העץ בצורת רמות
        public static void LevelOrderPrint(BinTreeNode<int> t)
        {
            Queue<BinTreeNode<int>> q = new Queue<BinTreeNode<int>>();
            q.Insert(t);
            while (!q.IsEmpty())
            {
                BinTreeNode<int> temp = q.Remove();
                Console.Write(temp.GetInfo() + " ");
                if (temp.GetLeft() != null)
                    q.Insert(temp.GetLeft());

                if (temp.GetRight() != null)
                    q.Insert(temp.GetRight());
            }
        }

        //מקבלת עץ
        //מחזירה את מספר הצמתים
        public static int MoneTsomet(BinTreeNode<int> t)
        {
            int mone = 1;
            if (t == null)
            {
                return 0;
            }
            else
            {
                mone += MoneTsomet(t.GetLeft()) + MoneTsomet(t.GetRight());
            }
            return mone;
        }

        //מקבלת עץ
        //מחזירה את סכום ערכי הצמתים
        public static int SumTsomet(BinTreeNode<int> t)
        {
            if (t == null)
            {
                return 0;
            }
            else
            {
                return t.GetInfo() + SumTsomet(t.GetLeft()) + SumTsomet(t.GetRight());
            }
        }

        //מקבלת עץ
        //מחזירה את סכום הבנים הימניים
        public static int SumRight(BinTreeNode<int> t)
        {
            if (t == null)
            {
                return 0;
            }
            else
            {
                if (t.GetRight() != null)
                    return t.GetInfo() + SumRight(t.GetRight()) + SumRight(t.GetLeft());
                else
                    return SumRight(t.GetRight()) + SumRight(t.GetLeft());
            }
        }
        //מקבלת עץ בינארי
        //מדפיסה את הצמתים שיש להם 2 בנים וערכם גדול מאחד מהם
        public static void BigFatherTwoSuns(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && t.GetRight() != null)
                {
                    if (t.GetInfo() > t.GetLeft().GetInfo() || t.GetInfo() > t.GetRight().GetInfo())
                    {
                        Console.WriteLine(t.ToString());
                        //Console.WriteLine(t.GetInfo());
                    }
                }
                BigFatherTwoSuns(t.GetLeft());
                BigFatherTwoSuns(t.GetRight());
            }
        }
        //מקבלת עץ בינארי
        //תדפיס את כל הצמתים שערכם נמוך מערך אביהם
        //מדפיסה בסדר סופי: postOrder
        public static void SunLowerThanFather(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null)
                {
                    if (t.GetLeft().GetInfo() < t.GetInfo())
                        Console.Write(t.GetLeft().GetInfo() + " ");
                    SunLowerThanFather(t.GetLeft()); ;
                }
                if (t.GetRight() != null)
                {
                    if (t.GetRight().GetInfo() < t.GetInfo())
                        Console.Write(t.GetRight().GetInfo() + " ");
                    SunLowerThanFather(t.GetRight());
                }
            }
        }
        //מקבלת עץ בינארי
        //מחזירה אמת אם הוא עץ עלה
        public static bool IfLeaf(BinTreeNode<int> t)
        {
            if (t != null)
            {
                //if (t.GetLeft() == null && t.GetRight() == null)
                //    return true;
                //return false;
                return t.GetLeft() == null && t.GetRight() == null;
            }
            return false;
        }
        //מקבלת עץ בינארי
        //מחזירה את סכום ערכי עליו
        public static int SumLeafs(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (IfLeaf(t))
                    return t.GetInfo();
                else
                    return SumLeafs(t.GetLeft()) + SumLeafs(t.GetRight());
            }
            return 0;
        }
        //מקבלת עץ בינארי
        //מחזירה את כמות הבנים היחידים
        public static int MoneLonly(BinTreeNode<int> t)
        {
            if (t == null)
                return 0;
            else
            {
                if ((t.GetRight() != null && t.GetLeft() == null) || (t.GetLeft() != null && t.GetRight() == null))
                    return 1 + MoneLonly(t.GetLeft()) + MoneLonly(t.GetRight());
                return MoneLonly(t.GetLeft()) + MoneLonly(t.GetRight());
            }
        }
        //מקבל עץ בינארי
        //מחזיר את כמות הצמתים שערכם זוגי
        public static int MoneTsometZugi(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetInfo() % 2 == 0)
                    return 1 + MoneTsometZugi(t.GetLeft()) + MoneTsometZugi(t.GetRight());
                return MoneTsometZugi(t.GetLeft()) + MoneTsometZugi(t.GetRight());
            }
            return 0;
        }
        //מקבל עץ בינארי ומספר
        //מחזירה את כמות הצמתים שערכם כשל המספר
        public static int MoneNumInTree(BinTreeNode<int> t, int n)
        {
            if (t != null)
            {
                if (t.GetInfo() == n)
                    return 1 + MoneNumInTree(t.GetLeft(), n) + MoneNumInTree(t.GetRight(), n);
                return MoneNumInTree(t.GetLeft(), n) + MoneNumInTree(t.GetRight(), n);
            }
            return 0;
        }
        //מקבלת עץ 
        //מחזירה את כמות הסבים בעץ
        public static int MoneGrandpas(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if ((IfLeaf(t.GetLeft()) == false && t.GetLeft() != null) || (IfLeaf(t.GetRight()) == false && t.GetRight() != null))
                    return 1 + MoneGrandpas(t.GetLeft()) + MoneGrandpas(t.GetRight());
                return MoneGrandpas(t.GetLeft()) + MoneGrandpas(t.GetRight());
            }
            return 0;
        }
        //מקבלת עץ
        //מחזירה את כמות הבנים היחידים שערכם אי זוגי
        public static int SumLonlyIzugi(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetRight() != null && t.GetLeft() == null)
                {
                    if (t.GetRight().GetInfo() % 2 != 0)
                        return t.GetRight().GetInfo() + SumLonlyIzugi(t.GetLeft()) + SumLonlyIzugi(t.GetRight());
                    return SumLonlyIzugi(t.GetLeft()) + SumLonlyIzugi(t.GetRight());
                }
                else
                {
                    if (t.GetLeft() != null && t.GetRight() == null)
                        if (t.GetLeft().GetInfo() % 2 != 0)
                            return t.GetLeft().GetInfo() + SumLonlyIzugi(t.GetLeft()) + SumLonlyIzugi(t.GetRight());
                    return SumLonlyIzugi(t.GetLeft()) + SumLonlyIzugi(t.GetRight());
                }
            }
            return 0;
        }
        //מקבל עץ
        //מחזירה את כמות הצמתים בעלי 2 בנים שערכם זהה
        public static int MoneTwoSunsEqualInfo(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && t.GetRight() != null)
                {
                    if (t.GetLeft().GetInfo() == t.GetRight().GetInfo())
                        return 1 + MoneTwoSunsEqualInfo(t.GetLeft()) + MoneTwoSunsEqualInfo(t.GetRight());
                    return MoneTwoSunsEqualInfo(t.GetLeft()) + MoneTwoSunsEqualInfo(t.GetRight());
                }
            }
            return 0;
        }
        //מקבלת עץ בינארי
        //מחזירה את הצמתים שיש שגדולים לפחות מאחד מבניהם
        public static int SmallFatherOneSuns(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && t.GetLeft().GetInfo() > t.GetInfo())
                {
                    return 1 + SmallFatherOneSuns(t.GetLeft()) + SmallFatherOneSuns(t.GetRight());
                }
                else
                {
                    if (t.GetRight() != null && t.GetRight().GetInfo() > t.GetInfo())
                    {
                        return 1 + SmallFatherOneSuns(t.GetLeft()) + SmallFatherOneSuns(t.GetRight());
                    }
                }
                return SmallFatherOneSuns(t.GetLeft()) + SmallFatherOneSuns(t.GetRight());
            }
            return 0;
        }
        //מקבלת עץ בינארי
        //מחזירה את כמות הצמתים שערכם גבוה מערך אביהם
        public static int SunHigherThanFather(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && t.GetLeft().GetInfo() > t.GetInfo())
                {
                    if (t.GetRight() != null && t.GetRight().GetInfo() > t.GetInfo())
                        return 2 + SunHigherThanFather(t.GetLeft()) + SunHigherThanFather(t.GetRight());
                    return 1 + SunHigherThanFather(t.GetLeft());
                }
                else
                {
                    if (t.GetRight() != null && t.GetRight().GetInfo() > t.GetInfo())
                    {
                        return 1 + SunHigherThanFather(t.GetLeft()) + SunHigherThanFather(t.GetRight());
                    }
                }
                return SunHigherThanFather(t.GetLeft()) + SunHigherThanFather(t.GetRight());
            }
            return 0;
        }

        //ex 23
        public static bool IfAllIzugi(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetInfo() % 2 == 0)
                    return false;
                return IfAllIzugi(t.GetLeft()) && IfAllIzugi(t.GetRight());
            }
            return true;
        }
        //ex 24
        public static bool IfAllBrothersSame(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && t.GetRight() != null)
                {
                    if (t.GetLeft().GetInfo() != t.GetRight().GetInfo())
                        return false;
                }
                return IfAllBrothersSame(t.GetRight()) && IfAllBrothersSame(t.GetRight());
            }
            return true;
        }
        //ex 25
        public static bool IfLeafLikeFather(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (IfLeaf(t.GetLeft()))
                {
                    if (t.GetInfo() != t.GetLeft().GetInfo())
                        return false;
                }
                if (IfLeaf(t.GetRight()))
                {
                    if (t.GetInfo() != t.GetLeft().GetInfo())
                        return false;
                }
                return IfLeafLikeFather(t.GetRight()) && IfLeafLikeFather(t.GetRight());
            }
            return true;
        }
        //ex 26
        public static bool If8NotExsist(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetInfo() == 8)
                    return false;
                return If8NotExsist(t.GetLeft()) && If8NotExsist(t.GetRight());
            }
            return true;
        }
        //ex 27
        public static bool IfAre2DifferentSons(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetRight() != null && t.GetLeft() != null)
                {
                    if (t.GetLeft().GetInfo() == t.GetRight().GetInfo())
                        return false;
                }
                return IfAre2DifferentSons(t.GetLeft()) || IfAre2DifferentSons(t.GetRight());
            }
            return true;
        }
        //ex 28
        public static bool LeftBigRightSmall(BinTreeNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && t.GetRight() != null)
                {
                    if (t.GetLeft().GetInfo() <= t.GetInfo() || t.GetRight().GetInfo() >= t.GetInfo())
                        return false;
                }
                return LeftBigRightSmall(t.GetLeft()) && LeftBigRightSmall(t.GetRight());
            }
            return true;
        }

        //מקבלת עץ תווים
        //מחזירה אמת אם הוא עץ עלה
        public static bool IfLeaf(BinTreeNode<char> t)
        {
            if (t != null)
            {
                //if (t.GetLeft() == null && t.GetRight() == null)
                //    return true;
                //return false;
                return t.GetLeft() == null && t.GetRight() == null;
            }
            return false;
        }

        //מקבלת עץ ביטוי
        //מחזירה את ערכו כפעולת חשבון
        public static int ExpretionTreeValue(BinTreeNode<char> t)
        {
            if (!IfLeaf(t))
            {
                switch (t.GetInfo())
                {
                    case '+': return ExpretionTreeValue(t.GetLeft()) + ExpretionTreeValue(t.GetRight());
                        break;
                    case '-': return ExpretionTreeValue(t.GetLeft()) - ExpretionTreeValue(t.GetRight());
                        break;
                    case '*': return ExpretionTreeValue(t.GetLeft()) * ExpretionTreeValue(t.GetRight()); 
                        break;
                    case '/': return ExpretionTreeValue(t.GetLeft()) / ExpretionTreeValue(t.GetRight()); 
                        break;
                    default: break;
                }
            }
            return t.GetInfo() - 48;
        }

        /////////////////////////////////////////////////////////////עץ חיפוש
        //מקבלת עץ חיפוש
        //מדפיסה אותו בסדר עולה
        public static void UpOrderPrint(BinTreeNode<int> t)
        {
            if (t != null)
            {
                UpOrderPrint(t.GetLeft());
                Console.Write(t.GetInfo() + " ");
                UpOrderPrint(t.GetRight());
            }
        }

        //מקבלת עץ חיפוש
        //מדפיסה אותו בסדר יורד
        public static void DownOrderPrint(BinTreeNode<int> t)
        {
            if (t != null)
            {
                DownOrderPrint(t.GetRight());
                Console.Write(t.GetInfo() + " ");
                DownOrderPrint(t.GetLeft());
            }
        }

        //מקבלת עץ חיפוש ומספר
        //מחזירה מצביע למיקום
        //רקורסייה
        public static BinTreeNode<int> Position(BinTreeNode<int> t, int num)
        {
            //if (t != null)
            //{
            if (t.GetInfo() != num)
            {
                if (t.GetInfo() < num)
                    return Position(t.GetRight(), num);
                return Position(t.GetLeft(), num);
            }
            return t;
            //}
            //return t;
        }

        //מקבלת עץ חיפוש ומספר
        //מחזירה מצביע למיקום
        //While
        public static BinTreeNode<int> Position2(BinTreeNode<int> t, int num)
        {
            BinTreeNode<int> temp = t;
            while (temp.GetInfo() != num)
            {
                if (t.GetInfo() < num)
                    temp = t.GetRight();
                temp = t.GetLeft();
            }
            return temp;
        }

        //מקבלת עץ חיפוש
        //מחזירה את האיבר המינימלי בעץ
        //רקורסיה
        public static BinTreeNode<int> Minimaly(BinTreeNode<int> t)
        {
            if (t.GetLeft() != null)
                return Minimaly(t.GetLeft());
            return t;
        }

        //מקבלת עץ חיפוש
        //מחזירה את האיבר המינימלי בעץ
        //While
        public static BinTreeNode<int> Minimaly2(BinTreeNode<int> t)
        {
            BinTreeNode<int> tree = t;
            while (tree.GetLeft() != null)
            {
                tree = tree.GetLeft();
            }
            return tree;
        }

        //מקבלת עץ חיפוש
        //מחזירה את האיבר מקסימלי בעץ
        //רקורסיה
        public static BinTreeNode<int> Maximaly(BinTreeNode<int> t)
        {
            if (t.GetRight() != null)
                return Maximaly(t.GetRight());
            return t;
        }

        //מקבלת עץ חיפוש
        //מחזירה את האיבר מקסימלי בעץ
        //While
        public static BinTreeNode<int> Maximaly2(BinTreeNode<int> t)
        {
            BinTreeNode<int> tree = t;
            while (tree.GetRight() != null)
            {
                tree = tree.GetRight();
            }
            return tree;
        }

    }
}
