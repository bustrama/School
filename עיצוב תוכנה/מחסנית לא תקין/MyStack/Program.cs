using System;
//using System.Collections.Generic;
using System.Text;
using Unit4.CollectionsLib;

namespace MyStack
{
    class Program
    {
        //����� ������
        //������ �� ���� ������� �������
        public static int PrintNum(Stack<int> s1)
        {
            int mone = 0;
            Stack<int> s2=new Stack<int>();
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
        //����� ������
        //������ �� ������ �������
        public static int PrintLast(Stack<int> s1)
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
        //���� ������
        //���� �� ��� ������ �������
        public static void Hafuch(Stack<int> s1)
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
        //������ �� �������
        //������ ������ �� ����� ��������
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
        //���� ������� �� ������ �����
        //���� ������� ���� ��������
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


        static void Main(string[] args)
        {
            
            //����� 16 ���� 248
            Stack<int> s1 =new Stack<int>();
            for (int i = 1; i <= 4; i++)
            {
                s1.Push(i);
            }
            Stack<int> s2 =new Stack<int>();
            for (int i = 1; i <= 3; i++)
            {
                s2.Push(i);
            }
            Stack<int> s3 =new Stack<int>();
            for (int i = 1; i <= 2; i++)
            {
                s3.Push(i);
            }
            Stack<int>[] stacks={s1,s2,s3};
            Console.WriteLine(GetTopsSum(stacks));
        }
    }
}
