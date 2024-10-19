using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Quanlyview
{
    public partial class Quanly : Form
    {
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
            return lstEmp; // Load data (can be updated later with actual data retrieval logic)
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
                emp.Id = int.Parse(tbId.Text);
                emp.Name = tbName.Text;
                emp.Gender = ckGender.Checked;
                emp.Address = tbAddress.Text;
                emp.Maduan = tbMaduan.Text;
                emp.Maphongban = cbMaphongban.Text;
                emp.ImagePath = employeeImagePath;
                emp.BirthDate = dateTimePicker1.Value.Date;

                RefreshBindings();
                ClearInputFields();
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
    }
}
