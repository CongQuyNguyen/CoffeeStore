using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DoAnCuoiKy
{
    public partial class frmManager : Form
    {

        public frmManager()
        {
            InitializeComponent();
        }

        private string connect = @"Data Source = NGUYENCONGQUYY\SQLEXPRESS;Initial Catalog=CoffeeStore;Integrated Security=True";
        private Manager manager;

        private void frmManager_Load(object sender, EventArgs e)
        {
            LoadDataCoffee();
            LoadDataStaff();
            SetFontAndColors();
        }

        // Reset lại thông tin 2 bảng
        private void lblRefest_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            LoadDataCoffee();
            LoadDataStaff();
        }

        // Đẩy dữ liệu từ database lên bảng item
        private void LoadDataCoffee()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connect);
                string querry = "SELECT * FROM Coffee";
                DataTable table = new DataTable();
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    table.Clear();
                    adapter.Fill(table);

                    connection.Close();
                }

                dataGridView1.DataSource = table;
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Lỗi truy vấn!\n" + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            dataGridView1.ClearSelection();
        }

        // Đẩy dữ liệu từ database lên bảng staff
        private void LoadDataStaff()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connect);
                string querry = "SELECT * FROM Barista";
                DataTable table = new DataTable();
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    table.Clear();
                    adapter.Fill(table);

                    connection.Close();
                }

                dataGridView2.DataSource = table;
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Lỗi truy vấn!\n" + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            dataGridView2.ClearSelection();
        }
        #region
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        // Chỉnh font cho 2 bảng
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.SeaGreen;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;

            this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView2.DefaultCellStyle.BackColor = Color.SeaGreen;
            this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
        }

        // Sự kiện click vào bảng sản phẩm
        private void dtgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtCoffeeName.Text = Convert.ToString(row.Cells["Name"].Value);
            txtPrice.Text = Convert.ToString(row.Cells["Price"].Value);
            txtQuantity.Text = Convert.ToString(row.Cells["Quantity"].Value);
        }

        // Sự kiện click vào bảng nhân viên
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
            txtNamePerson.Text = Convert.ToString(row.Cells["Name"].Value);

            string temp = Convert.ToString(row.Cells["Birthday"].Value);
            var parts = temp.Split(' ');
            txtBirthday.Text = parts[0];

            txtAddress.Text = Convert.ToString(row.Cells["Address"].Value);
            txtPhone.Text = Convert.ToString(row.Cells["Phone"].Value);
        }

        // Tìm kiếm loại bảng loại coffee
        private DataTable findCoffee(string s)
        {
            string query = $"SELECT * FROM Coffee WHERE {"Name"} LIKE '%" + s + "%'";
            SqlConnection connection = new SqlConnection(connect);
            DataTable table = new DataTable();
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                table.Clear();
                adapter.Fill(table);

                connection.Close();
            }
            return table;
        }

        // Xử lý combobox chọn loại coffee
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem.ToString() == "Tea")
            {
                DataTable dt = findCoffee("Tea");
                dataGridView1.DataSource = dt;
            }
            else if (cbCategory.SelectedItem.ToString() == "Soda")
            {
                DataTable dt = findCoffee("Soda");
                dataGridView1.DataSource = dt;
            }
            else if (cbCategory.SelectedItem.ToString() == "Juice")
            {
                DataTable dt = findCoffee("Juice");
                dataGridView1.DataSource = dt;
            }
            else if (cbCategory.SelectedItem.ToString() == "Smoothie")
            {
                DataTable dt = findCoffee("Smoothie");
                dataGridView1.DataSource = dt;
            }
            else if (cbCategory.SelectedItem.ToString() == "Coffee")
            {
                DataTable dt = findCoffee("Coffee");
                dataGridView1.DataSource = dt;
            }
            else if (cbCategory.SelectedItem.ToString() == "Cacao")
            {
                DataTable dt = findCoffee("Cacao");
                dataGridView1.DataSource = dt;
            }
            dataGridView1.ClearSelection();
        }

        // Thêm một món uống bất kỳ vào danh sách menu của quán
        private void AddCoffee()
        {
            string name = txtCoffeeName.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            manager = new Manager(connect);
            manager.AddItem(name, quantity, price);

            // Load lại data
            LoadDataCoffee();
        }

        // Xóa một món uống bất kỳ trong danh sách menu của quán
        private void DeleteCoffee()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int coffeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CoffeeId"].Value);
                manager = new Manager(connect);
                manager.DeleteItem(coffeeId);

                // Xóa dòng từ DataGridView
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            }
        }

        // Chỉnh sửa thông tin của một món uống trong danh sách
        private void ChangeCoffee()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int coffeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CoffeeId"].Value);
                string name = txtCoffeeName.Text;
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double price = Convert.ToDouble(txtPrice.Text);

                manager = new Manager(connect);
                manager.UpdateItem(coffeeId, name, quantity, price);

                // Cập nhật DataGridView
                // Cập nhật dòng được chọn trong DataGridView với các giá trị mới
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells["Name"].Value = name;
                row.Cells["Quantity"].Value = quantity;
                row.Cells["Price"].Value = price;
            }
        }

        // Thêm một nhân viên mới vào danh sách
        private void AddStaff()
        {
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string name = txtNamePerson.Text;
            string address = txtAddress.Text;
            DateTime birthday = Convert.ToDateTime(txtBirthday.Text);

            Manager manager = new Manager(connect);
            manager.AddBarista(phone, email, name, address, birthday);

            // Load lại data
            LoadDataStaff();
        }

        // Xóa một nhân viên trong danh sách
        private void DeleteStaff()
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                int baristaId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["BaristaId"].Value);

                manager = new Manager(connect);
                manager.DeleteBarista(baristaId);

                // Xóa hàng trong danh sách
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
        }

        // Sửa thông tin một nhân viên trong danh sách
        private void ChangeStaff()
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                int baristaId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["BaristaId"].Value);
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                string name = txtNamePerson.Text;
                string address = txtAddress.Text;
                DateTime birthday = Convert.ToDateTime(txtBirthday.Text);

                manager = new Manager(connect);
                manager.ChangeBarista(baristaId, phone, email, name, address, birthday);

                // Cập nhật thông tin trên các dòng
                dataGridView2.SelectedRows[0].Cells["Phone"].Value = phone;
                dataGridView2.SelectedRows[0].Cells["Email"].Value = email;
                dataGridView2.SelectedRows[0].Cells["Name"].Value = name;
                dataGridView2.SelectedRows[0].Cells["Address"].Value = address;
                dataGridView2.SelectedRows[0].Cells["Birthday"].Value = birthday;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // AddCoffee();
            AddStaff();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // DeleteCoffee();
            DeleteStaff();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // ChangeCoffee();
            ChangeStaff();
        }
    }
}
