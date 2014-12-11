using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPerson
{
    class Employee:Person
    {
        protected string employeeNum { get; set; }
        protected string department { get; set; }

        public Employee(string first, string last, int age, string id, string num, string department)
            : base(first, last, age, id)
        {
            this.employeeNum = num;
            this.department = department;
        }

        public void SetEmployee(string first, string last, int age, string id, string department, string employeeNum)
        {
            base.SetPerson(first, last, age, id);
            this.employeeNum=employeeNum;
            this.department=department;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Emplyee Num: " + this.employeeNum + "\n Department: " + this.department;
        }
    }
}
