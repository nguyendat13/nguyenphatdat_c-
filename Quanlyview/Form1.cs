namespace Quanlyview
{
    public partial class Form1 : Form
    {
        string tentaikhoan = "admin";
        string matkhau = "123";
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
            (sender as Quanly).isThoat = false;
            (sender as Quanly).Close();
            this.Show();

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
            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }
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
