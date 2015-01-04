using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex34_P48
{
    class Salary
    {
        public Salary()
        {
        }

        public static double CalcSalary(ISalary obj)
        {
            double bruto = obj.CalcBruto();
            return bruto - CalcIncomeTax(bruto) - CalcSocialInsuranceTax(bruto);
        }

        private static double CalcIncomeTax(double bruto)
        {
            return bruto * 0.3;
        }

        private static double CalcSocialInsuranceTax(double bruto)
        {
            return bruto * 0.1;
        }
    }
}
