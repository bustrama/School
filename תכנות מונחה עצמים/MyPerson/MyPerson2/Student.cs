using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPerson2
{
    public enum trend { academic, tecnologic }
    class Student:Person
    {
        //datamembers
        private string studentClass;
        private trend studentTrend;
        private double mathMark;
        private int mathGroup;
        private double englishMark;
        private int englishGroup;
        private double hisMark;
        private int hisGroup;
        
        
        //משתנה סטטי
        public static int counter;
       
        //בנאים סטטיים
        static Student()
        {
            counter = 0;
        }

        //בנאים
        public Student()
        {
            this.firstname = null;
            this.lastname = null;
            this.studentClass = null;
            this.studentTrend = trend.academic;
            this.birthday = null;
            this.mathMark = 0;
            this.MathGroup = 3;
            this.englishMark = 0;
            this.englishGroup = 3;
            this.hisMark = 0;
            this.hisGroup = 3;

            counter++;
        }

        public Student(string fname, string lname, Date date, int id, string sclass, trend strend, Date sbirthday, double mathmark, int mathgroup, double englishmark, int englishgroup, double hismark, int hisgroup)
            : base(fname, lname, date, id)
        {
            this.studentClass = sclass;
            this.studentTrend = strend;
            this.birthday = sbirthday;

            if (mathmark < 0)
                mathmark = -mathmark;
            if (mathmark > 100)
                mathmark = 100;
            this.mathMark = mathmark;

            if (mathgroup != 4 && mathgroup != 5)
                this.mathGroup = 3;
            else
                this.mathGroup = mathgroup;


            if (englishmark < 0)
                englishmark = -englishmark;
            if (englishmark > 100)
                englishmark = 100;
            this.englishMark = englishmark;

            if (englishgroup != 4 && englishgroup != 5)
                this.englishGroup = 3;
            else
                this.englishGroup = englishgroup;


            if (hismark < 0)
                hismark = -hismark;
            if (hismark > 100)
                hismark = 100;
            this.hisMark = hismark;

            if (hisgroup != 4 && hisgroup != 5)
                this.hisGroup = 3;
            else
                this.hisGroup = hisgroup;

            counter++;
        }

        //public Student(string sname, string sclass, trend strend)
        //{
        //    this.studentName = sname;
        //    this.studentClass = sclass;
        //    this.studentTrend = strend;
        //    this.birthday = null;
        //    this.mathMark = 0;
        //    this.MathGroup = 3;
        //    this.englishMark = 0;
        //    this.englishGroup = 3;
        //    this.hisMark = 0;
        //    this.hisGroup = 3;

        //    counter++;
        //}

        //Get&Set
        //public void SetstudentName(string value)
        //{
        //    this.studentName = value;
        //}
        //public string GetstudentName()
        //{
        //    return this.studentName;
        //}

        public void SetstudentClass(string value)
        {
            this.studentClass = value;
        }
        public string GetstudentClass()
        {
            return this.studentClass;
        }

        public void SetstudentTrend(trend value)
        {
            this.studentTrend=value ;
        }
        public trend GetstudentTrend()
        {
            return this.studentTrend;
        }

        public void SetmathMark(double value)
        {
            if (value < 0)
                value = -value;
            if (value > 100)
                value = 100;  
            this.mathMark = value;
        }
        public double GetmathMark()
        {
            return this.mathMark;
        }

        public void SetmathGroup(int value)
        {
            this.mathGroup = value;
        }
        public int GetmathGroup()
        {
            return this.mathGroup;
        }

        public void SetenglishMark(double value)
        {
            if (value < 0)
                value = -value;
            if (value > 100)
                value = 100;  
            this.englishMark = value;
        }
        public double GetenglishMark()
        {
            return this.englishMark;
        }

        public void SetenglishGroup(int value)
        {
            this.englishGroup = value;
        }
        public int GetenglishGroup()
        {
            return this.englishGroup;
        }

        public void SethisMark(double value)
        {
            if (value < 0)
                value = -value;
            if (value > 100)
                value = 100;
            this.hisMark = value;
        }
        public double GethisMark()
        {
            return this.hisMark;
        }

        public void SethisGroup(int value)
        {
            this.hisGroup = value;
        }
        public int GethisGroup()
        {
            return this.hisGroup;
        }

        //properties

        //public string StudentName
        //{
        //    get { return this.studentName; }
        //    set { this.studentName = value; }
        //}

        public string StudentClass
        {
            get { return this.studentClass; }
            set { this.studentClass = value; }
        }

        public trend StudentTrend
        {
            get { return this.studentTrend; }
            set { this.studentTrend = value; }
        }

        public double MathMark
        {
            get 
            {
                return this.mathMark; 
            }
            set 
            {
                this.mathMark = value;
                if (value < 0)
                    value = -value;
                if (value > 100)
                    value = 100;                
            }
        }

        public int MathGroup
        {
            get { return this.mathGroup; }
            set { this.mathGroup = value; }
        }

        public double EnglishMark
        {
            get { return this.englishMark; }
            set
            {
                this.englishMark = value;
                if (value < 0)
                    value = -value;
                if (value > 100)
                    value = 100;
            }
        }

        public int EnglishGroup
        {
            get { return this.englishGroup; }
            set { this.englishGroup = value; }
        }

        public double HisMark
        {
            get { return this.hisMark; }
            set
            {
                this.hisMark = value;
                if (value < 0)
                    value = -value;
                if (value > 100)
                    value = 100; 
            }
        }

        public int HisGroup
        {
            get { return this.hisGroup; }
            set { this.hisGroup = value; }
        }


        //AvgCalc1
        private double AvgCalc()
        {
            double math = mathMark, english = englishMark, his = hisMark, avg;
            switch (mathGroup)
            {
                case 5: math *= 1.2; break;
                case 4: math *= 1.1; break;
            }

            switch (englishGroup)
            {
                case 5: english *= 1.2; break;
                case 4: english *= 1.1; break;
            }

            switch (hisGroup)
            {
                case 5: his *= 1.2; break;
                case 4: his *= 1.1; break;
            }
            avg = (math + english + his) / 3;
            if (avg > 100)
                return 100;
            else
                return avg;
        }

        ////AvgCalc2
        public double AvgCalc(double b4, double b5)
        {
            double math = mathMark, english = englishMark, his = hisMark, avg;
            switch (mathGroup)
            {
                case 5: math = math* (b5 / 100 + 1); break;
                case 4: math = math * (b4 / 100 + 1); break;
            }

            switch (englishGroup)
            {
                case 5: english *= (b5 / 100 + 1); break;
                case 4: english *= (b4 / 100 + 1); break;
            }

            switch (hisGroup)
            {
                case 5: his *= (b5 / 100 + 1); break;
                case 4: his *= (b4 / 100 + 1); break;
            }
            avg = (math + english + his) / 3;
            if (avg >= 100)
                return 100;
            return avg;
        }

        public string IsOlder(Student st1)
        {
            if (this.birthday.Before(st1.birthday))
            {
                return this.firstname;
            }
            return st1.firstname;
        }


        //Show
        public new string tostring()
        {
            return base.toString() + ", class: " + StudentClass + ", trend: " + studentTrend + ", mathMark: " + mathMark + ", mathGroup: " + mathGroup + ", englishMark: " + englishMark + ", englishGroup: " + englishGroup + ", hisMark: " + hisMark + ", hisGroup: " + hisGroup + ", student avarge: " + AvgCalc() + ", studen counter: " + Student.counter;
            //Console.WriteLine(this.toString());
            //Console.WriteLine(", class: "+StudentClass);
            //Console.WriteLine("trend: "+studentTrend);
            
            //Console.Write("birthday: ");

            //if (this.birthday != null)
            //    birthday.Print();
            //else
            //    Console.WriteLine("-");

            //Console.WriteLine("mathMark: "+mathMark+", mathGroup: "+mathGroup);
            //Console.WriteLine("englishMark: " + englishMark + ", englishGroup: " + englishGroup);
            //Console.WriteLine("hisMark: " + hisMark + ", hisGroup: " + hisGroup);
            //Console.WriteLine("student avarge: " + AvgCalc());
            //Console.WriteLine("studen counter: "+Student.counter); 
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();
            
        }
    
    
    }
}
