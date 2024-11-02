
namespace Quanlyview
{
    partial class Quanly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btThoat = new Button();
            btDangXuat = new Button();
            dgvEmployee = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btEdit = new Button();
            btDelete = new Button();
            label5 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbMaphongban = new ComboBox();
            tbMaduan = new TextBox();
            pbEmployeeImage = new PictureBox();
            btSelectImage = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            cbSapXep = new ComboBox();
            txtTimKiem = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            btReload = new Button();
            groupBox4 = new GroupBox();
            lTaiKhoan = new LinkLabel();
            linkLabel1 = new LinkLabel();
            groupBox5 = new GroupBox();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btThoat
            // 
            btThoat.Location = new Point(60, 27);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(47, 30);
            btThoat.TabIndex = 0;
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btDangXuat
            // 
            btDangXuat.Location = new Point(6, 27);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(48, 30);
            btDangXuat.TabIndex = 1;
            btDangXuat.UseVisualStyleBackColor = true;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.BackgroundColor = Color.IndianRed;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(212, 295);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(685, 142);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 37);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 74);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh";
            // 
            // tbId
            // 
            tbId.Location = new Point(84, 29);
            tbId.Name = "tbId";
            tbId.Size = new Size(146, 23);
            tbId.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(84, 69);
            tbName.Name = "tbName";
            tbName.Size = new Size(146, 23);
            tbName.TabIndex = 8;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Checked;
            ckGender.Location = new Point(84, 141);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(52, 19);
            ckGender.TabIndex = 9;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(31, 22);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(49, 30);
            btAddNew.TabIndex = 10;
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(31, 67);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(49, 30);
            btEdit.TabIndex = 11;
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(31, 116);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(49, 30);
            btDelete.TabIndex = 12;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(434, 8);
            label5.Name = "label5";
            label5.Size = new Size(168, 28);
            label5.TabIndex = 13;
            label5.Text = "Quản lý nhân viên";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(328, 18);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(210, 23);
            tbAddress.TabIndex = 14;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 82);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 17;
            label6.Text = "Mã dự án";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 50);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 18;
            label7.Text = "Mã phòng ban";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 21);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 19;
            label8.Text = "Địa chỉ";
            // 
            // cbMaphongban
            // 
            cbMaphongban.FormattingEnabled = true;
            cbMaphongban.Items.AddRange(new object[] { "HC", "NS", "ANM", "QL" });
            cbMaphongban.Location = new Point(328, 47);
            cbMaphongban.Name = "cbMaphongban";
            cbMaphongban.Size = new Size(210, 23);
            cbMaphongban.TabIndex = 20;
            // 
            // tbMaduan
            // 
            tbMaduan.Location = new Point(328, 76);
            tbMaduan.Name = "tbMaduan";
            tbMaduan.Size = new Size(210, 23);
            tbMaduan.TabIndex = 21;
            // 
            // pbEmployeeImage
            // 
            pbEmployeeImage.Location = new Point(328, 105);
            pbEmployeeImage.Name = "pbEmployeeImage";
            pbEmployeeImage.Size = new Size(96, 108);
            pbEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmployeeImage.TabIndex = 22;
            pbEmployeeImage.TabStop = false;
            // 
            // btSelectImage
            // 
            btSelectImage.Location = new Point(430, 188);
            btSelectImage.Name = "btSelectImage";
            btSelectImage.Size = new Size(95, 25);
            btSelectImage.TabIndex = 23;
            btSelectImage.Text = "Chọn ảnh...";
            btSelectImage.UseVisualStyleBackColor = true;
            btSelectImage.Click += btSelectImage_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(84, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btSelectImage);
            groupBox1.Controls.Add(tbMaduan);
            groupBox1.Controls.Add(pbEmployeeImage);
            groupBox1.Controls.Add(cbMaphongban);
            groupBox1.Controls.Add(ckGender);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(212, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 219);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btAddNew);
            groupBox2.Controls.Add(btEdit);
            groupBox2.Controls.Add(btDelete);
            groupBox2.Location = new Point(784, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(113, 162);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 267);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 27;
            label4.Text = "Sắp xếp";
            // 
            // cbSapXep
            // 
            cbSapXep.FormattingEnabled = true;
            cbSapXep.Location = new Point(277, 264);
            cbSapXep.Name = "cbSapXep";
            cbSapXep.Size = new Size(132, 23);
            cbSapXep.TabIndex = 28;
            cbSapXep.SelectedIndexChanged += cbSapXep_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(653, 264);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(173, 23);
            txtTimKiem.TabIndex = 29;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(832, 267);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 28;
            label9.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btReload);
            groupBox3.Controls.Add(btDangXuat);
            groupBox3.Controls.Add(btThoat);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(181, 74);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tác vụ";
            // 
            // btReload
            // 
            btReload.Location = new Point(113, 27);
            btReload.Name = "btReload";
            btReload.Size = new Size(50, 30);
            btReload.TabIndex = 2;
            btReload.UseVisualStyleBackColor = true;
            btReload.Click += btReload_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lTaiKhoan);
            groupBox4.Controls.Add(linkLabel1);
            groupBox4.Location = new Point(12, 101);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(181, 118);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh mục";
            // 
            // lTaiKhoan
            // 
            lTaiKhoan.AutoSize = true;
            lTaiKhoan.LinkColor = Color.FromArgb(64, 0, 0);
            lTaiKhoan.Location = new Point(21, 48);
            lTaiKhoan.Name = "lTaiKhoan";
            lTaiKhoan.Size = new Size(101, 15);
            lTaiKhoan.TabIndex = 1;
            lTaiKhoan.TabStop = true;
            lTaiKhoan.Text = "Tài khoản quản trị";
            lTaiKhoan.LinkClicked += lTaiKhoan_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 0, 0);
            linkLabel1.Location = new Point(22, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quản lí nhân viên";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(linkLabel4);
            groupBox5.Controls.Add(linkLabel5);
            groupBox5.Location = new Point(12, 242);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(181, 118);
            groupBox5.TabIndex = 32;
            groupBox5.TabStop = false;
            groupBox5.Text = "Khác";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.FromArgb(64, 0, 0);
            linkLabel4.Location = new Point(20, 47);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(50, 15);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Trợ giúp";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.LinkColor = Color.FromArgb(64, 0, 0);
            linkLabel5.Location = new Point(21, 22);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(58, 15);
            linkLabel5.TabIndex = 2;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Giới thiệu";
            // 
            // Quanly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(920, 449);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label9);
            Controls.Add(txtTimKiem);
            Controls.Add(cbSapXep);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(dgvEmployee);
            Name = "Quanly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quanly";
            FormClosed += Quanly_FormClosed;
            Load += Quanly_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void label3_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private Button btThoat;
        private Button btDangXuat;
        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btEdit;
        private Button btDelete;
        private Label label5;
        private TextBox tbAddress;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbMaphongban;
        private TextBox tbMaduan;
        private PictureBox pbEmployeeImage;
        private Button btSelectImage;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox cbSapXep;
        private TextBox txtTimKiem;
        private Label label9;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private LinkLabel lTaiKhoan;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private Button btReload;
    }
}