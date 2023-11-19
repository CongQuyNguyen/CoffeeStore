using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Inventory
    {
        private Coffee coffee;

        private int quantity;

        public Inventory(Coffee coffee, int quantity)
        {
            this.Coffee = coffee;
            this.Quantity = quantity;
        }

        public Inventory()
        {
            
        }

        public Coffee Coffee { get => coffee; set => coffee = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public void Load()
        {

        }
    }
}
