using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex24_P26
{
    class SalesMan:Worker
    {
        private int bonus;

        public SalesMan()
        {
        }
        public SalesMan(string firstname, string lastname, int age, int id, int num, string department, int salary, int hours,int bonus)
            : base(firstname, lastname, age, id, num, department,salary,hours)
        {
            this.bonus = bonus;
        }

        public int GetBonus()
        {
            return this.bonus;
        }
        public void SetBonus(int value)
        {
            this.bonus = value;
        }


        public void SetSalesManSalary(int sal, int h,int b)
        {
            this.SetWorkerSalary(sal, h);
            this.bonus = b;
        }
        public void SetSalesMan(string firstname, string lastname, int age, int id, int num, string department, int salary, int hours, int bonus)
        {
            this.SetWorker(firstname, lastname, age, id, num, department, salary, hours);
            this.bonus = bonus;
        }

        //public double CalcSalesManSalary()
        //{
        //    return this.CalcWorkerSalary() + this.bonus;
        //}

        public new double CalcSalary()
        {
            return base.CalcSalary() + this.bonus;
        }

        //public string PrintSalesMan()
        //{
        //    return PrintWorker() + ", bonus is " + this.bonus + ", total salary with bonus is " + CalcSalesManSalary();
        //}

        //public new string toString()
        //{
        //    return base.toString() + ", bonus is " + this.bonus + ", total salary with bonus is " + CalcSalary();
        //}
        public override string toString()
        {
            return base.toString() + ", bonus is " + this.bonus + ", total salary with bonus is " + CalcSalary();
        }
    }
}
