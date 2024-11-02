 using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlyview
{
    public partial class Form1 : Form
    {
        //string tentaikhoan = "admin";
        //string matkhau = "123";

        private string connectionString = @"Data Source=LAPTOP-QBKMQRNF\SQLEXPRESS01;Initial Catalog=Employee;User ID=sa;Password=1234;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(tbTaiKhoan.Text, tbMatKhau.Text))
            {
                Quanly f = new Quanly();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
                tbTaiKhoan.Text = "";
                tbMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Error");
                tbTaiKhoan.Focus();
            }

        }

        private void F_DangXuat(object? sender, EventArgs e)
        {
            var quanlyForm = sender as Quanly;
            if (quanlyForm != null)
            {
                quanlyForm.Close(); // Đóng form Quanly
            }
            this.Show(); // Hiển thị lại Form1 (màn hình đăng nhập)
        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(1) FROM [User] WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Username", tentaikhoan);
                        cmd.Parameters.AddWithValue("@Password", matkhau);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi kết nối cơ sở dữ liệu: {ex.Message}");
                    return false;
                }
            }
        }
        //bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        //{
        //    if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { 
                   tbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar=true;
            }
        }
    }
}
