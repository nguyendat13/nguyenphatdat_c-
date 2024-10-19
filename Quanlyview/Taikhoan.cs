using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyview
{
    public partial class Taikhoan : Form
    {
        public Taikhoan()
        {
            InitializeComponent();
        }

        private void btQuayVe_Click(object sender, EventArgs e)
        {
            Quanly quanly = new Quanly();
            quanly.Show();
            this.Close();
        }
    }
}
