using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPerson
{
    class SalesMan:Worker
    {
        protected float bonus { get; set; }

        public SalesMan(string first, string last, int age, string id, string num, string dpt, float sal, float hours, float bonus)
            : base(first, last, age, id, num, dpt, sal, hours)
        {
            this.bonus = bonus;
        }

        public void SetSalesMan(string first, string last, int age, string id, string num, string dpt, float sal, float hours, float bonus)
        {
            base.SetWorker(first, last, age, id, num, dpt, sal, hours);
            this.bonus = bonus;
        }

        public void SetSalesManSalary(float sal, float hours, float bonus)
        {
            base.SetWorkerSalary(sal, hours);
            this.bonus = bonus;
        }

        public new float CalcSalary()
        {
            return base.CalcSalary() + this.bonus;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Bonus: " + this.bonus;
        }
    }
}
