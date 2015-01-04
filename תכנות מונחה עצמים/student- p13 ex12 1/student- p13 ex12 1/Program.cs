using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace student__p13_ex12_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Date bday = new Date();
            Student s1 = new Student("yuval", "ya1", trend.tecnologic, bday ,100, 4, 100, 5, 60, 3);
            Console.WriteLine();
            s1.Show();

            //Student s2 = new Student("ron", "alef2", trend.academic);
            //s2.Show();

            Student s3 = new Student("Rotem ash","ya1",trend.tecnologic,new Date(5,11,1997),100,5,84,5,89,3);
            Console.WriteLine(s1.IsOlder(s3)+" is older");
            Console.WriteLine();
            s3.Show();

            //Student s1 = new Student();
            //s1.SetstudentName("yuval");
            //s1.SetstudentClass("YudAlef1");
            //s1.StudentTrend=trend.tecnologic;
            //s1.SetmathMark(60);
            //s1.SetmathGroup(4);
            //s1.SetenglishMark(60);
            //s1.SetenglishGroup(5);
            //s1.SethisMark(60);
            //s1.SethisGroup(5);
            //Console.WriteLine(s1.AvgCalc(25, 50)); 
            //s1.Show();
            

            //student s2 = new student();
            //s2.SetstudentName("noga");
            //s2.SetstudentClass("YudAlef1");
            //s2.StudentTrend = trend.academic;
            //s2.SetmathMark(50);
            //s2.SetmathGroup(3);
            //s2.SetenglishMark(30);
            //s2.SetenglishGroup(3);
            //s2.SethisMark(-80);
            //s2.SethisGroup(5);
            //s2.Show();

            //student s3 = new student();
            //s3.SetstudentName("Or Shimshoni");
            //s3.SetstudentClass("YudAlef1");
            //s3.StudentTrend = trend.tecnologic;
            //s3.SetmathMark(30);
            //s3.SetmathGroup(5);
            //s3.SetenglishMark(80);
            //s3.SetenglishGroup(5);
            //s3.SethisMark(69);
            //s3.SethisGroup(3);
            //s3.Show();
        }
    }
}
