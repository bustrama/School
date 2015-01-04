using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex24_P26
{
    class Employee:Person
    {
        private int num;
        private string department;

        public Employee()
        {
        }
        public Employee(string firstname, string lastname, int age, int id, int num, string department)
            : base(firstname, lastname, age, id)
        {
            this.num = num;
            this.department = department;
        }

        public string GetDepartment()
        {
            return this.department;
        }
        public void SetDepartment(string value)
        {
            this.department = value;
        }
        public int GetNum()
        {
            return this.num;
        }
        public void SetNum(int value)
        {
            this.num = value;
        }

        public void SetEmployee(string firstname, string lastname, int age, int id, int num, string department)
        {
            this.SetPerson(firstname, lastname, age, id);
            this.num = num;
            this.department = department;
        }

        //public string PrintEmployee()
        //{            
        //    return this.PrintPerson() + ", employee num is " + this.num + ", department is " + this.department; 
        //}

        //public new string toString()
        //{
        //    return base.toString()+", employee num is " + this.num + ", department is " + this.department;
        //}
        public override string toString()
        {
            return base.toString() + ", employee num is " + this.num + ", department is " + this.department;
        }
    }
}
