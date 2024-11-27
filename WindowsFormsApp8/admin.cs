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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            pnlDoanhThu.Visible = false;
            pnlKhachHang.Visible = false;
            pnlNhanVien.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pnlDoanhThu.Visible = true;
            pnlKhachHang.Visible = false;
            pnlNhanVien.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pnlNhanVien.Visible = true;
            pnlDoanhThu.Visible = false;
            pnlKhachHang.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pnlKhachHang.Visible = true;
            pnlNhanVien.Visible = false;
            pnlDoanhThu.Visible = false;
        }




    }
}
