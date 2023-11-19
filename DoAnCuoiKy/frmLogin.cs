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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblGuest_Click(object sender, EventArgs e)
        {
            frmGuest guest = new frmGuest();
            guest.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == Start.KhoiTao.userName && txtPassword.Text == Start.KhoiTao.userMk)
            {
                MessageBox.Show("Logged in successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmManager manager = new frmManager();
                manager.ShowDialog();
                Close();
            }
            else
            {
                if(txtUser.Text != Start.KhoiTao.userName)
                {
                    MessageBox.Show("Invalid login name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                }
                else if(txtUser.Text != Start.KhoiTao.userName)
                {
                    MessageBox.Show("Invalid password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                }
            } 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
