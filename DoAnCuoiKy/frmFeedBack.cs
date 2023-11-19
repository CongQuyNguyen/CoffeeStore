using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class frmFeedBack : Form
    {
        Customer customer = new Customer();
        public frmFeedBack()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtCmt.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            string output = customer.FeedBack(txtCmt.Text);


            MessageBox.Show(output + "\nCompleted...See you again", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
