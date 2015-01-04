using System;
//using System.Collections.Generic;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;

namespace Ex34_P48
{
    class Trainer:Student,ISalary
    {
        private double mSalPerHour;
        private double mHours;

        public Trainer()
        {
        }

        public Trainer(string fname, string lname, int id, List<int> grades, double sal, double hour)
            : base(fname, lname, id, grades)
        {
            this.mSalPerHour = sal;
            this.mHours = hour;
        }

        public double SalaryPerHour
        {
            get { return this.mSalPerHour; }
            set { this.mSalPerHour = value; }
        }

        public double Hours
        {
            get { return this.mHours; }
            set { this.mHours = value; }
        }

        protected override string Details()
        {
            return base.Details() + "\nSalary= " + Salary.CalcSalary(this);
        }

        public double CalcBruto()
        {
            return this.mSalPerHour * this.mHours;
        }
    }
}
