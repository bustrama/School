using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace StudentList
{
    class StudentList
    {
        private Node<Student> first;

        public StudentList()
        {

        }

        public void Add(Student st)
        {
            if (first.GetInfo() == null)
                first.SetInfo(st);
            else
                first.SetNext(new Node<Student>(st));
        }


    }
}
