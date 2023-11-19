using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmManager());

        /*Coffee coffee = new Coffee("Trung Nguyên", 3.5);
        Barista baris = new Barista("0001", "Nguyễn Công Quý", new DateTime(2004, 11, 20), "VietNam", 3.14);
        Customer customer = new Customer("0001", "Nguyễn Công Quý", new DateTime(2004, 11, 20), "VietNam");

        // MessageBox.Show(baris.PrintInfo(), "Thông báo", MessageBoxButtons.OK);

        MessageBox.Show(customer.OrderCoffee(coffee, 2), "Thông báo", MessageBoxButtons.OK);
        MessageBox.Show(baris.PrepareCoffee(coffee, 2), "Thông báo", MessageBoxButtons.OK);*/
        }
    }
}
