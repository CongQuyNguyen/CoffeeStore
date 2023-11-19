using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Serve : Staff
    {

        public Serve(string identity, string name, DateTime birthDay, string address, double factorSalary) 
            : base(identity, name, birthDay, address, factorSalary)
        {

        }

        public string ServeCoffee(Coffee coffee, int quantity)
        {
            return "";
        }

        public override string PrintInfo()
        {
            return "SERVE\n"
                + base.PrintInfo();
        }
    }
}
