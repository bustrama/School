using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIntNode
{
    class Program
    {
        //מקבלת שרשרת חוליות
        //מדפיסה את חוליות השרשרת
        public static void Print(IntNode in1)
        {
            while (in1 != null)
            {
                Console.Write(in1.ToString() + " -> ");
                in1 = in1.GetNext();
            }
            Console.WriteLine("null");
        }
        //מקבלת שרשרת חוליות
        //מחזירה את סכום החוליות
        public static int Schum(IntNode chain)
        {
            int sum = 0;
            while (chain != null)
            {
                sum += chain.GetInfo();
                chain = chain.GetNext(); 
            }
            return sum;
        }
        //מקבלת שרשרת חוליות
        //מחזירה את האיבר המקסימלי
        public static int Maximum(IntNode chain)
        {
            int temp = chain.GetInfo();
            chain = chain.GetNext();
            
            while (chain != null)
            {
                if (chain.GetInfo() > temp)
               
                    temp = chain.GetInfo();                  
                
                chain = chain.GetNext();
            }
            return temp;
        }
        //מקבלת שרשרת חוליות
        //מוחקת את החוליה השניה בשרשרת
        public static void LessSecond(IntNode chain)
        {
            IntNode temp = chain.GetNext();
            chain.SetNext(temp.GetNext());
            temp.SetNext (null);          
        }
        //מקבלת שרשרת חוליות ומספר שלם
        //מחזירה את השרשרת בלי החוליה שערכה כשל המספר
        //לא עובד
        public static void LessNum(IntNode chain, int num)
        {
            IntNode pos = chain;
            if (pos.GetInfo() == num)
                chain = chain.GetNext();
            while (pos != null)
            {
                if (pos.GetNext().GetInfo() == num)
                {
                    IntNode temp = pos.GetNext();
                    pos.SetNext(temp.GetNext());
                    temp.SetNext(null);
                }
                pos = pos.GetNext();
            }
            if (pos.GetInfo() == num)
            {
                IntNode pos1 = chain;
                while (pos1.GetNext() != pos)
                    pos1 = pos1.GetNext();
                IntNode temp = pos1.GetNext();
                pos1.SetNext(temp.GetNext());
                temp.SetNext(null);
            }                    
        }
        //מקבלת שרשרת חוליות ומספר שלם
        //מחזירה האם המספר מצויי בשרשרת
        public static bool IfExist(IntNode chain1, int num1)
        {
            while (chain1!=null)
            {
                if (chain1.GetInfo() == num1)
                    return true;
                chain1 = chain1.GetNext();
            }
            return false;
        }
        //מקבלת שרשרת חוליות
        //מחזירה את השרשרת ללא חזרות
        public static IntNode DeleteRepeating(IntNode chain)
        {
            IntNode temp = new IntNode(chain.GetInfo());
            IntNode pos = chain.GetNext();
            IntNode pos1 = temp;

            while (pos != null)
            {
                if (IfExist(temp, pos.GetInfo()) == false)
                {
                    IntNode temp2 = new IntNode(pos.GetInfo());
                    pos1.SetNext(temp2);
                    pos1 = pos1.GetNext();
                }
                pos = pos.GetNext();
            }
            return temp;
        }
        //מקבלת שרשרת חוליות
        //מחזירה שרשרת חדשה בלי חזרות
        public static IntNode NoRepeating(IntNode chain)
        {
            IntNode chain2 = new IntNode(chain.GetInfo(),null);
            chain = chain.GetNext();
           
            while (chain != null)
            {
                if (IfExist(chain2, chain.GetInfo()) == false)
                { 
                    IntNode temp = new IntNode(chain.GetInfo(),chain2);
                    chain2=temp;
                }
                chain = chain.GetNext();
               
            }
            return chain2;
        }
        //מקבלת שרשרת ומספר בתחום השרשרת
        //מחזיר את השרשרת בלי החוליה במקום הזה
        public static void LessNth(IntNode chain, int n)
        {
            IntNode pos = chain;
            for (int i = 1; i < n - 1; i++)
            {
                pos = pos.GetNext();
            }
            IntNode temp = pos.GetNext();
            pos.SetNext(pos.GetNext());
            temp.SetNext(null);

        }
        //מקבלת שרשרת בסדר עולה ומספר
        //מחזיר את השרשרת כשהמספר במקום
        public static void PutIn(IntNode chain, int num)
        {
            IntNode temp = new IntNode(num);
            IntNode pos = chain;
            while (pos.GetNext() != null)
            {
                pos = pos.GetNext();
            }
            if (num > pos.GetInfo())
            {
                pos.SetNext(temp);
            }
            else
            {
                pos = chain;
                while (pos.GetNext().GetInfo() < num)
                {
                    pos = pos.GetNext();
                }
                temp.SetNext(pos.GetNext());
                pos.SetNext(temp);
            }
        }
        //מקבלת שרשרת חוליות
        //מדפיסה את השרשרת ההפוכה
        public static void Hafuch(IntNode chain)
        {
            IntNode p = chain;
            IntNode newchain = new IntNode(p.GetInfo());
            p = p.GetNext();
            while (p != null)
            {
                IntNode temp = new IntNode(p.GetInfo());
                temp.SetNext(newchain);
                newchain = temp;
                p = p.GetNext();
            }
            Print(newchain);
        }
        static void Main(string[] args)
        {
            
            //ex 1 p. 215
            
            //א
            //IntNode chain1 = new IntNode(7, new IntNode(21, new IntNode(4)));
            //Print(chain1);


            //ב
            //Random n = new Random();
            //int num = n.Next(2, 101);
            //IntNode chain2 = new IntNode(num);
            //for (int i = num; i >= 1; i--)
            //{
            //    IntNode chain3 = new IntNode(i, chain2);
            //    chain2 = chain3;
            //}
            //Print(chain2);


            //שימוש בפעולות
            //IntNode in1 = new IntNode(1, new IntNode(7, new IntNode(9, new IntNode(9))));
            IntNode in2 = new IntNode(1, new IntNode(3, new IntNode(5, null)));
            //Print(in1);
            //Console.WriteLine(Schum(in1));
            //Console.WriteLine(Maximum(in1));
            //LessSecond(in2);
            //Print(in2);
            //LessNth(in2,3);
            //Print(in2);
            //PutIn(in2, 1);
            Print(in2);
            Hafuch(in2);

            //IntNode in1 = new IntNode(5, new IntNode(5, new IntNode(4, new IntNode(4, new IntNode(3, new IntNode(4, new IntNode(5, null)))))));
            //Print(in1);
            //Console.WriteLine();
            //Print(DeleteRepeating(in1));
            //Print(NoRepeating(in1));

        }
    }
}
