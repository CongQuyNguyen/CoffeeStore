using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Barista : Staff
    {

        public Barista(string identity, string name, DateTime birthDay, string address, double factorSalary)
            : base(identity, name, birthDay, address, factorSalary)
        {

        }

        public string PrepareCoffee(Coffee coffee, int quantity)
        {
            return "Preparing...\n"
                + "Name: " + coffee.ToString() + "\n"
                + "Quantity: " + quantity + "\n\n"; 
        }

        public string PrepareCoffee(Coffee coffee, int quantity, string action)
        {
            return "Preparing...\n"
                + "Name: " + coffee.ToString() + "\n"
                + "Quantity: " + quantity + "\n"
                + "Action: " + action + "\n\n";
        }

        public override string PrintInfo()
        {
            return "BARISTA\n"
                + base.PrintInfo();
        }
    }
}
