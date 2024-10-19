namespace Quanlyview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbTaiKhoan = new TextBox();
            tbMatKhau = new TextBox();
            btDangNhap = new Button();
            btThoat = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // tbTaiKhoan
            // 
            tbTaiKhoan.Location = new Point(88, 24);
            tbTaiKhoan.Name = "tbTaiKhoan";
            tbTaiKhoan.Size = new Size(137, 23);
            tbTaiKhoan.TabIndex = 2;
            tbTaiKhoan.TextChanged += tbTaiKhoan_TextChanged;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(88, 72);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(137, 23);
            tbMatKhau.TabIndex = 3;
            tbMatKhau.UseSystemPasswordChar = true;
            tbMatKhau.TextChanged += tbMatKhau_TextChanged;
            // 
            // btDangNhap
            // 
            btDangNhap.Location = new Point(12, 136);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(99, 33);
            btDangNhap.TabIndex = 4;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.UseVisualStyleBackColor = true;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(126, 136);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(99, 33);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(88, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 192);
            Controls.Add(checkBox1);
            Controls.Add(btThoat);
            Controls.Add(btDangNhap);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTaiKhoan;
        private TextBox tbMatKhau;
        private Button btDangNhap;
        private Button btThoat;
        private CheckBox checkBox1;
    }
}
