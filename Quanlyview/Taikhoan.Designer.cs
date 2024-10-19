namespace Quanlyview
{
    partial class Taikhoan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btQuayVe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(41, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(41, 116);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(133, 155);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đổi mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 5;
            // 
            // btQuayVe
            // 
            btQuayVe.Location = new Point(12, 9);
            btQuayVe.Name = "btQuayVe";
            btQuayVe.Size = new Size(59, 28);
            btQuayVe.TabIndex = 6;
            btQuayVe.Text = "Quay về";
            btQuayVe.UseVisualStyleBackColor = true;
            btQuayVe.Click += btQuayVe_Click;
            // 
            // Taikhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 232);
            Controls.Add(btQuayVe);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Taikhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taikhoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btQuayVe;
    }
}