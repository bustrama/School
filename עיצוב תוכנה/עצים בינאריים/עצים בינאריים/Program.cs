
using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace עצים_בינאריים
{
    class Program
    {
        //מקבלת עץ בינארי
        //מדפיסה את העץ בצורה תוכית
        public static void InOrderPrint(BinTreeNode<int> t)
        {
            if (t != null)
            {
                InOrderPrint(t.GetLeft());
                Console.Write(t.GetInfo()+" ");
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
                Console.Write(temp.GetInfo()+" ");
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
                        Console.Write(t.GetLeft().GetInfo()+" ");
                    SunLowerThanFather(t.GetLeft()); ;                    
                }
                if (t.GetRight() != null)
                {
                    if (t.GetRight().GetInfo() < t.GetInfo())
                        Console.Write(t.GetRight().GetInfo()+" ");
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
                if (t.GetInfo()%2==0)
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


        ////////////////////////////////////////////////// עץ ביטויי

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
                    case '+': return ExpretionTreeValue(t.GetLeft()) + ExpretionTreeValue(t.GetRight()); break;
                    case '-': return ExpretionTreeValue(t.GetLeft()) - ExpretionTreeValue(t.GetRight()); break;
                    case '*': return ExpretionTreeValue(t.GetLeft()) * ExpretionTreeValue(t.GetRight()); break;
                    case '/': return ExpretionTreeValue(t.GetLeft()) / ExpretionTreeValue(t.GetRight()); break;
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

        static void Main(string[] args)
        {
            ////עץ בינארי
            //BinTreeNode<int> tl = new BinTreeNode<int>(new BinTreeNode<int>(7), 9, new BinTreeNode<int>(8));
            //BinTreeNode<int> tr = new BinTreeNode<int>(null, 5, new BinTreeNode<int>(4));
            //BinTreeNode<int> t = new BinTreeNode<int>(3);
            //t.SetLeft(tl);
            //t.SetRight(tr);
            //Console.Write("InOrderPrint: ");
            //InOrderPrint(t);
            //Console.WriteLine();
            //Console.Write("PreOrderPrint: ");
            //PreOrderPrint(t);
            //Console.WriteLine();
            //Console.Write("PostOrderPrint: ");
            //PostOrderPrint(t);
            //Console.WriteLine();
            //Console.WriteLine("mone= " + MoneTsomet(t));
            //Console.WriteLine("sum= " + SumTsomet(t));
            //Console.WriteLine("sum right= " + SumRight(t));
            //Console.WriteLine("BigFatherTwoSuns: ");
            //BigFatherTwoSuns(t);
            //Console.WriteLine("SunLowerThanFather: ");
            //SunLowerThanFather(t);
            //Console.WriteLine();
            //Console.WriteLine("IfLeaf: "+IfLeaf(t));
            //Console.WriteLine("SumLeaf: " + SumLeafs(t));

            //BinTreeNode<int> pos1 = new BinTreeNode<int>(new BinTreeNode<int>(1), 8, null);
            //BinTreeNode<int> pos2 = new BinTreeNode<int>(pos1, 5, new BinTreeNode<int>(8));
            //BinTreeNode<int> pos3 = new BinTreeNode<int>(new BinTreeNode<int>(5), 3, new BinTreeNode<int>(2));
            //BinTreeNode<int> t = new BinTreeNode<int>(pos2, 10, pos3);
            //Console.Write("InOrderPrint: ");
            //InOrderPrint(t);
            //Console.WriteLine();
            //Console.Write("PreOrderPrint: ");
            //PreOrderPrint(t);
            //Console.WriteLine();
            //Console.Write("PostOrderPrint: ");
            //PostOrderPrint(t);
            //Console.WriteLine();
            //Console.Write("LevelOrderPrint:" );
            //LevelOrderPrint(t);
            //Console.WriteLine();

            //Console.WriteLine("MoneLonly " + MoneLonly(t));
            //Console.WriteLine("MoneTsometZugi: " + MoneTsometZugi(t));
            //Console.WriteLine("MoneNumInTree: " + MoneNumInTree(t, 8));
            //Console.WriteLine("MoneGrandpas: " + MoneGrandpas(t));
            //Console.WriteLine("SumLonlyIzugi: " + SumLonlyIzugi(t));
            //Console.WriteLine("MoneTwoSunsEqualInfo: " + MoneTwoSunsEqualInfo(t));
            //Console.WriteLine("SmallFatherOneSuns: " + SmallFatherOneSuns(t));
            //Console.WriteLine("SunHigherThanFather: " + SunHigherThanFather(t));
            //Console.WriteLine("IfAllIzugi: " + IfAllIzugi(t));
            //Console.WriteLine("IfAllBrothersSame: " + IfAllBrothersSame(t));
            ////BinTreeNode<int> t1 = new BinTreeNode<int>(new BinTreeNode<int>(9), 8, new BinTreeNode<int>(7));
            //Console.WriteLine("IfLeafLikeFather: " + IfLeafLikeFather(t));
            //Console.WriteLine("If8NotExsist: " + If8NotExsist(t));
            //Console.WriteLine("IfAre2DifferentSons: " + IfAre2DifferentSons(t));
            ////Console.WriteLine("LeftBigRightSmall: " + LeftBigRightSmall(t));
            //BinTreeNode<int> tree = new BinTreeNode<int>(new BinTreeNode<int>(new BinTreeNode<int>(7), 9, new BinTreeNode<int>(8)), 3, new BinTreeNode<int>(null, 5, new BinTreeNode<int>(4)));
            //InOrderPrint(tree);



            ////////עץ ביטויי
            //BinTreeNode<char> t = new BinTreeNode<char>(new BinTreeNode<char>(new BinTreeNode<char>('3'), '*', new BinTreeNode<char>('4')), '+', new BinTreeNode<char>('2'));
            //Console.WriteLine(ExpretionTreeValue(t));



            //////עץ חיפוש
            BinTreeNode<int> t = new BinTreeNode<int>(new BinTreeNode<int>(new BinTreeNode<int>(1), 2, new BinTreeNode<int>(3)), 5, new BinTreeNode<int>(new BinTreeNode<int>(5), 7, null));
            Console.Write("UpOrderPrint: ");
            UpOrderPrint(t);
            Console.WriteLine();
            Console.Write("DownOrderPrint: ");
            DownOrderPrint(t);
            Console.WriteLine();
            Console.Write("Position: ");
            UpOrderPrint(Position(t, 2));
            Console.WriteLine();
            Console.Write("Position2: ");
            UpOrderPrint(Position2(t, 2));
            Console.WriteLine();
            Console.Write("Minimaly: ");
            UpOrderPrint(Minimaly(t));
            Console.WriteLine();
            Console.Write("Minimaly2: ");
            UpOrderPrint(Minimaly2(t));
            Console.WriteLine();
            Console.Write("Maximaly: ");
            UpOrderPrint(Maximaly(t));
            Console.WriteLine();
            Console.Write("Maximaly2: ");
            UpOrderPrint(Maximaly2(t));
            Console.WriteLine();

        }
    }
}

