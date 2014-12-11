using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace school
{
    class Worker:Person
    {
        protected float salary { get; set; }
        protected float hours { get; set; }

        public Worker(string first, string last, int age, string id, string num, string department, float salary, float hours):
            base(first, last, age, id)
        {
            this.salary = salary;
            this.hours = hours;
        }

        public void SetWorker(string first, string last, int age, string id, string num, string dpt, float salary, float hours)
        {
            base.SetPerson(first, last, age, id);
            this.salary = salary;
            this.hours = hours;
        }

        public void SetWorkerSalary(float salary, float hour)
        {
            this.salary = salary;
            this.hours = hour;
        }
        
        public float CalcSalary()
        {
            return this.salary * this.hours;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Salary: " + this.salary + "\n Hour: " + this.hours;
        }
    }
}
