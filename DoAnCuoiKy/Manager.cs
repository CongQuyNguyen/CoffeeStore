using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{

    public class Manager : Person
    {
        private double factorySalary;

        private List<Inventory> inventories;

        private List<Staff> staffList;
        public Manager()
            : base()
        {
        }

        // Thiết lập chuỗi kết nối với database
        private string connectionString;

        public Manager(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public Manager(string identity, string name, DateTime birthDay, string address, double factorySalary)
            : base()
        {
            this.factorySalary = factorySalary;
            this.inventories = new List<Inventory>();
            this.staffList = new List<Staff>();
        }

        public double FactorySalary { get => factorySalary; set => factorySalary = value; }
        public List<Inventory> Inventories { get => inventories; set => inventories = value; }
        public List<Staff> StaffList { get => staffList; set => staffList = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        // Xóa một mặt hàng bất kỳ khỏi danh sách menu quán
        public void DeleteItem(int coffeeId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Coffee WHERE CoffeeId = @id", connection);
                command.Parameters.AddWithValue("@id", coffeeId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Thêm một mặt hàng bất kỳ vào danh sách menu quán
        public void AddItem(string name, int quantity, double price)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Coffee(Name, Quantity, Price) VALUES(@name, @quantity, @price)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Thay đổi thông tin của một món uống trên danh sách
        public void UpdateItem(int coffeeId, string name, int quantity, double price)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE Coffee SET Name = @name, Quantity = @quantity, Price = @price WHERE CoffeeId = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@id", coffeeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Thêm một nhân viên vào danh sách
        public void AddBarista(string phone, string email, string name, string address, DateTime birthday)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Barista(Phone, Email, Name, Address, Birthday) VALUES(@phone, @email, @name, @address, @birthday)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@birthday", birthday);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Xóa một nhân viên khỏi danh sách
        public void DeleteBarista(int baristaId)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Barista WHERE BaristaId = @baristaId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(@"baristaId", baristaId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Cập nhật thông tin của nhân viên
        public void ChangeBarista(int baristaId, string phone, string email, string name, string address, DateTime birthday)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Barista SET Phone = @phone, Email = @email, Name = @name, Address = @address, Birthday = @birthday WHERE BaristaId = @baristaId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue(@"email", email);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@birthday", birthday);
                    command.Parameters.AddWithValue("@baristaId", baristaId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
