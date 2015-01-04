using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex24_P26
{
    class Worker : Employee
    {
        private int salary;//per hour
        private int hours;//monthlt working hours

        public Worker()
        {
        }
        public Worker(string firstname, string lastname, int age, int id, int num, string department, int salary, int hours)
            : base(firstname, lastname, age, id, num, department)
        {
            this.salary = salary;
            this.hours = hours;
        }

        public int GetSalary()
        {
            return this.salary;
        }
        public void Setsalary(int value)
        {
            this.salary = value;
        }
        public int GetHours()
        {
            return this.hours;
        }
        public void Sethours(int value)
        {
            this.hours = value;
        }

        public void SetWorkerSalary(int sal, int h)
        {
            this.salary = sal;
            this.hours = h;
        }
        public void SetWorker(string firstname, string lastname, int age, int id, int num, string department, int sal, int h)
        {
            this.SetEmployee( firstname,  lastname,  age,  id,  num,  department);
            this.salary = sal;
            this.hours = h;
        }

        //public double CalcWorkerSalary()
        //{
        //    return this.hours * this.salary;
        //}

        public double CalcSalary()
        {
            return this.hours * this.salary;
        }

        //public string PrintWorker()
        //{
        //    return PrintEmployee() + ", salary per hour is " + this.salary + ", monthly working hours is " + this.hours + ", total salary is" + this.CalcWorkerSalary();
        //}

        //public new string toString()
        //{
        //    return base.toString() + ", salary per hour is " + this.salary + ", monthly working hours is " + this.hours + ", total salary is " + this.CalcSalary();
        //}
        public override string toString()
        {
            return base.toString() + ", salary per hour is " + this.salary + ", monthly working hours is " + this.hours + ", total salary is " + this.CalcSalary();
        }
    }
}
