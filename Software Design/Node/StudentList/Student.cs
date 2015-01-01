using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StudentList
{
    class Student
    {
        private string Name { get; set; }
        private string cellPhone { get; set; }

        public Student()
        {
            this.Name = null;
            this.cellPhone = null;
        }

        public Student(string name, string cell)
        {
            this.Name = name;
            this.cellPhone = cell;
        }

        public override string ToString()
        {
            return "< " + this.Name + " > < " + this.cellPhone + " > ";
        }
    }
}
