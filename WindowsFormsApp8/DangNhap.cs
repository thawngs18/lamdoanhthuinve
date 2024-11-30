using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chonCN chonCN = new chonCN();
            DialogResult result = MessageBox.Show("Dang nhap thanh cong","Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            chonCN.ShowDialog();
            
        }
    }
}
