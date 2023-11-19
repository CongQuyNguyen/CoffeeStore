using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Staff : Person
    {
        private double factorSalary;

        public double FactorSalary { get => factorSalary; set => factorSalary = value; }

        public Staff(string identity, string name, DateTime birthDay, string address, double factorSalary) 
            : base(identity, name, birthDay, address)
        {
            this.factorSalary = factorSalary;
        }

        public override string PrintInfo()
        {
            return base.PrintInfo();
        }
    }
}
