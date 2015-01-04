using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace Ex34_P48
{
    class Teacher:Person, ISalary
    {
        private double mBaseSalary;
        private double mTeachingHours;

        public Teacher() { }
        public Teacher(string fname, string lname, int id, double sal, int hour)
            : base(fname, lname, id)
        {
            this.mBaseSalary = sal;
            this.mTeachingHours = hour;
        }

        protected override string Details()
        {
            return "Base Salary=" + this.mBaseSalary + "\nHours=" + this.mTeachingHours + "\nSalary=" + Salary.CalcSalary(this);
        }

        public double BaseSalary
        {
            get { return this.mBaseSalary; }
            set { this.mBaseSalary = value; }
        }

        public double TeachingHours
        {
            get { return this.mTeachingHours; }
            set { this.mTeachingHours = value; }
        }

        public double CalcBruto()
        {
            if (this.mTeachingHours > 80)
            {
                double extra_hour = this.mTeachingHours - 80;
                double extra_payment_per_hour = this.mBaseSalary / 80 * 1.5;
                return this.mBaseSalary + extra_hour * extra_payment_per_hour;
            }
            return this.mBaseSalary;
        }


    }
}
