using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace Ex34_P48
{
    class Student:Person
    {
        private List<int> Grades;
        public Student()
            : base()
        {
            this.Grades = new List<int>();
        }

        public Student(string first, string last, int id, List<int> grades)
            : base(first, last, id)
        {
            this.Grades = grades;
        }

        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
                this.Grades.Insert(null, grade);
        }

        public double CalcAvg()
        {
            int sum = 0;
            int mone = 0;
            Node<int> pos=Grades.GetFirst();
            while (pos != null)
            {
                mone++;
                sum += pos.GetInfo();
                pos = pos.GetNext();
            }
            return sum / mone;
        }

        public int FailuresNum()
        {
            int mone = 0;
            Node<int> pos = this.Grades.GetFirst();
            while (pos != null)
            {
                if (pos.GetInfo() <= 55)   //ציון נכשל
                    mone++;
                pos = pos.GetNext();
            }
            return mone;
        }

        protected override string Details()
        {
            return "\nGrades: "+this.Grades.ToString() + "\nAvarge: " + CalcAvg() + "\nFailures:" + FailuresNum();
        }
    }
}
