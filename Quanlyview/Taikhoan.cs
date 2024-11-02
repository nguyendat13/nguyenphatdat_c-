using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlyview
{
    public partial class Taikhoan : Form
    {
        private string connectionString = @"Data Source=LAPTOP-QBKMQRNF\SQLEXPRESS01;Initial Catalog=Employee;User ID=sa;Password=1234;Encrypt=False;";
        private string username;

        public Taikhoan(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Kiểm tra tính hợp lệ của tên người dùng
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Tên người dùng không hợp lệ."); // Hiển thị thông báo lỗi
                return; // Ngưng thực hiện phương thức nếu tên người dùng không hợp lệ
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT Username, Password, Role FROM Users WHERE Username = @Username"; // Lấy Username, Password và Role
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@Username", username); // Truyền giá trị vào tham số

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblUsername.Text = reader["Username"].ToString();
                        // Hiển thị mật khẩu
                        tbPassword.Text = reader["Password"].ToString(); // Giả sử bạn có tbPassword để hiển thị mật khẩu
                        tbPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu khi hiển thị

                        // Hiển thị vai trò nếu cần
                        string role = reader["Role"].ToString();
                        lblRole.Text = role; // Giả sử bạn có lblRole để hiển thị vai trò
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng với tên: " + username);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void btQuayVe_Click(object sender, EventArgs e)
        {
            Quanly quanly = new Quanly();
            quanly.Show();
            this.Close();
        }

        private void Taikhoan_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        // Uncomment and implement password change logic if needed
        // private void btDoiMatKhau_Click(object sender, EventArgs e)
        // {
        //     // Logic to change password
        // }
    }
}
