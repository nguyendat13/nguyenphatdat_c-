using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;

namespace Quanlyview
{
    public partial class Quanly : Form
    {
        private string strCon = @"Data Source=LAPTOP-QBKMQRNF\SQLEXPRESS01;Initial Catalog=Employee;User ID=sa;Password=1234;Encrypt=False;";
        private SqlConnection sqlCon; // Khai báo SqlConnection


        public List<Employee> lstEmp = new List<Employee>();
        private BindingSource bs = new BindingSource();
        public bool isThoat = true;
        public event EventHandler DangXuat;

        private string employeeImagePath = string.Empty; // Store the image path

        public Quanly()
        {
            InitializeComponent();
            SetupImageList();
            InitializeDateTimePicker();
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();
            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs;
            SetupDataGridView();
        }

        private void InitializeDateTimePicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        public List<Employee> GetData()
        {
            List<Employee> employees = new List<Employee>();

            using (sqlCon = new SqlConnection(strCon)) // Sử dụng từ khóa using để quản lý tài nguyên
            {
                sqlCon.Open(); // Mở kết nối

                // Câu truy vấn để lấy dữ liệu
                string query = "SELECT Id, Name, BirthDate, Gender, Address, Maduan, Maphongban, ImagePath FROM Employee";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon)) // Tạo SqlCommand
                {
                    using (SqlDataReader reader = cmd.ExecuteReader()) // Sử dụng using cho SqlDataReader
                    {
                        while (reader.Read()) // Đọc dữ liệu
                        {
                            Employee emp = new Employee
                            {
                                Id = reader.GetInt32(0), // Mã
                                Name = reader.GetString(1), // Tên
                                BirthDate = reader.GetDateTime(2), // Ngày sinh
                                Gender = reader.GetBoolean(3), // Giới tính
                                Address = reader.GetString(4), // Địa chỉ
                                Maduan = reader.GetString(5), // Mã dự án
                                Maphongban = reader.GetString(6), // Mã phòng ban
                                ImagePath = reader.IsDBNull(7) ? null : reader.GetString(7) // Ảnh
                            };
                            employees.Add(emp); // Thêm vào danh sách
                        }
                    }
                }
            }
            return employees; // Trả về danh sách nhân viên
        }
        private void AddEmployee(Employee newEmp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "INSERT INTO Employees (Id, Name, BirthDate, Gender, Address, Maduan, Maphongban, ImagePath) VALUES (@Id, @Name, @BirthDate, @Gender, @Address, @Maduan, @Maphongban, @ImagePath)";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", newEmp.Id);
                    cmd.Parameters.AddWithValue("@Name", newEmp.Name);
                    cmd.Parameters.AddWithValue("@BirthDate", newEmp.BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", newEmp.Gender);
                    cmd.Parameters.AddWithValue("@Address", newEmp.Address);
                    cmd.Parameters.AddWithValue("@Maduan", newEmp.Maduan);
                    cmd.Parameters.AddWithValue("@Maphongban", newEmp.Maphongban);
                    cmd.Parameters.AddWithValue("@ImagePath", newEmp.ImagePath);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void UpdateEmployee(Employee emp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "UPDATE Employees SET Name=@Name, BirthDate=@BirthDate, Gender=@Gender, Address=@Address, Maduan=@Maduan, Maphongban=@Maphongban, ImagePath=@ImagePath WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", emp.Id);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                    cmd.Parameters.AddWithValue("@Address", emp.Address);
                    cmd.Parameters.AddWithValue("@Maduan", emp.Maduan);
                    cmd.Parameters.AddWithValue("@Maphongban", emp.Maphongban);
                    cmd.Parameters.AddWithValue("@ImagePath", emp.ImagePath);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void DeleteEmployee(int empId)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "DELETE FROM Employees WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", empId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SetupDataGridView()
        {
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.Columns[0].HeaderText = "Mã";
            dgvEmployee.Columns[1].HeaderText = "Tên";
            dgvEmployee.Columns[2].HeaderText = "Ngày Sinh";
            dgvEmployee.Columns[3].HeaderText = "Giới Tính";
            dgvEmployee.Columns[4].HeaderText = "Địa Chỉ";
            dgvEmployee.Columns[5].HeaderText = "Mã Dự Án";
            dgvEmployee.Columns[6].HeaderText = "Mã Phòng Ban";
            dgvEmployee.Columns[7].HeaderText = "Ảnh";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat?.Invoke(this, EventArgs.Empty);
        }

        private void Quanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) Application.Exit();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tbId.Text, out int newId))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
                    return;
                }

                if (lstEmp.Any(emp => emp.Id == newId))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                var newEmp = new Employee
                {
                    Id = newId,
                    Name = tbName.Text,
                    Gender = ckGender.Checked,
                    Address = tbAddress.Text,
                    Maduan = tbMaduan.Text,
                    Maphongban = cbMaphongban.Text,
                    ImagePath = employeeImagePath,
                    BirthDate = dateTimePicker1.Value.Date
                };

                lstEmp.Add(newEmp);
                RefreshBindings();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            var idx = dgvEmployee.CurrentRow.Index;
            var emp = lstEmp[idx];

            try
            {
                int newId = int.Parse(tbId.Text);

                // Kiểm tra xem ID mới đã tồn tại trong danh sách nhưng không phải của nhân viên hiện tại
                if (lstEmp.Any(e => e.Id == newId && e != emp))
                {
                    MessageBox.Show("Lỗi: ID này đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                // Cập nhật thông tin nhân viên
                emp.Id = newId;
                emp.Name = tbName.Text;
                emp.Gender = ckGender.Checked;
                emp.Address = tbAddress.Text;
                emp.Maduan = tbMaduan.Text;
                emp.Maphongban = cbMaphongban.Text;
                emp.ImagePath = employeeImagePath;
                emp.BirthDate = dateTimePicker1.Value.Date;

                RefreshBindings(); // Cập nhật dữ liệu hiển thị trên DataGridView
                ClearInputFields(); // Xóa các ô nhập liệu
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            lstEmp.RemoveAt(idx);

            RefreshBindings();
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= lstEmp.Count) return;

            var emp = lstEmp[e.RowIndex];

            tbId.Text = emp.Id.ToString();
            tbName.Text = emp.Name;
            ckGender.Checked = emp.Gender;
            tbAddress.Text = emp.Address;
            tbMaduan.Text = emp.Maduan;
            cbMaphongban.Text = emp.Maphongban;
            if (emp.BirthDate != null && emp.BirthDate >= dateTimePicker1.MinDate && emp.BirthDate <= dateTimePicker1.MaxDate)
            {
                dateTimePicker1.Value = emp.BirthDate;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now; // Default to current date
            }


            if (File.Exists(emp.ImagePath))
            {
                pbEmployeeImage.Image = Image.FromFile(emp.ImagePath);
            }
            else
            {
                pbEmployeeImage.Image = null;
            }
        }

        private void RefreshBindings()
        {
            bs.DataSource = lstEmp.ToList();
            bs.ResetBindings(false);
            dgvEmployee.ClearSelection(); // Optional: Clear selection for better UX
        }

        private void ClearInputFields()
        {
            tbId.Clear();
            tbName.Clear();
            tbAddress.Clear();
            tbMaduan.Clear();
            cbMaphongban.Text = "";
            ckGender.Checked = false;
            pbEmployeeImage.Image = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void SetupImageList()
        {
            var imageList = new ImageList { ImageSize = new Size(24, 24) };

            try
            {
                imageList.Images.Add(Image.FromFile("Images/add.png"));
                imageList.Images.Add(Image.FromFile("Images/edit.png"));
                imageList.Images.Add(Image.FromFile("Images/delete.png"));
                imageList.Images.Add(Image.FromFile("Images/logout.png"));
                imageList.Images.Add(Image.FromFile("Images/exit.png"));

                btAddNew.ImageList = imageList; btAddNew.ImageIndex = 0;
                btEdit.ImageList = imageList; btEdit.ImageIndex = 1;
                btDelete.ImageList = imageList; btDelete.ImageIndex = 2;
                btDangXuat.ImageList = imageList; btDangXuat.ImageIndex = 3;
                btThoat.ImageList = imageList; btThoat.ImageIndex = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}");
            }
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    employeeImagePath = ofd.FileName;
                    pbEmployeeImage.Image = Image.FromFile(employeeImagePath);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtTimKiem.Text.ToLower();
            bs.DataSource = lstEmp.Where(emp => emp.Name.ToLower().Contains(searchValue) ||
                                                emp.Id.ToString().Contains(searchValue)).ToList();
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSapXep.SelectedItem?.ToString() == "Tên")
            {
                bs.DataSource = lstEmp.OrderBy(emp => emp.Name).ToList();
            }
            else if (cbSapXep.SelectedItem?.ToString() == "Mã")
            {
                bs.DataSource = lstEmp.OrderBy(emp => emp.Id).ToList();
            }
        }

        private void lTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Taikhoan taikhoan = new Taikhoan();
            taikhoan.Show();
            this.Hide();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
