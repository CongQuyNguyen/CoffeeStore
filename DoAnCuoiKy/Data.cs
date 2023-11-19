using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DoAnCuoiKy
{
    internal class Data
    {
        public void Connect(string s)
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection(s);
                con.Open();
                MessageBox.Show("Connection successful...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Disconnect(string s)
        {
            SqlConnection con;
            con = new SqlConnection(s);
            con.Close();
            con.Dispose();
            con = null;
        }
    }
}
