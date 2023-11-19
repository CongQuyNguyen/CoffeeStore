using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Customer : Person
    {
        public Customer(string identity, string name, DateTime birthDay, string address) 
            : base(identity, name, birthDay, address)
        {

        }

        public Customer() 
            : base()
        { }

        public string OrderCoffee(Coffee coffee, int quantity)
        {
            return "Ordering...\n"
                + "Name: " + coffee.ToString() + "\n"
                + "Quantity: " + quantity + "\n\n"
                + "Action: " + " Empty" + "\n"
                + "Total: " + (coffee.Price * quantity) + "$\n\n";
        }

        public string OrderCoffee(Coffee coffee, int quantity, string action)
        {
            return "Ordering...\n"
                + "Name: " + coffee.ToString() + "\n"
                + "Quantity: " + quantity + "\n"
                + "Action: " + action + "\n"
                + "Total: " + (coffee.Price * quantity) + "$\n\n";
        }

        public double PayCoffee(double total, double payAmount)
        {
            return payAmount - total;
        }

        public string FeedBack(string fb)
        {
            return "Thank for your feedback";
        }

        public override string PrintInfo()
        {
            return "CUSTOMER\n"
                + base.PrintInfo();
        }
    }
}
