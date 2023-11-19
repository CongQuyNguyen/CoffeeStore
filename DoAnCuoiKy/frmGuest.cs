using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace DoAnCuoiKy
{
    public partial class frmGuest : Form
    {
        

        public frmGuest()
        {
            InitializeComponent();
            //NpgsqlConnection connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=coffee;User Id=postgres;Password=ds");
            //connect.Open();
            //NpgsqlCommand cmd = new NpgsqlCommand();
            //cmd.Connection = connect;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT * FROM public.coffee";
            //NpgsqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows)
            //{
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    dataGridView2.DataSource = dt;
            //}
            //cmd.Dispose();
            //connect.Close();

        }

        private void frmGuest_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
        }

        private void listViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
