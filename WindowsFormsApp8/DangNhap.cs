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
           

            string cn = "";
            if (radioButton1.Checked == true)
            {
                cn = "BV";
            }
            else if (radioButton2.Checked == true)
            {
                cn = "QL";
            }
            chonCN chonCN = new chonCN(cn);
            DialogResult result = MessageBox.Show("Dang nhap thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            chonCN.ShowDialog();


        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox3.Text = "BV";
            }
            else if (radioButton2.Checked == true)
            {
                textBox3.Text = "QL";
            }
        }
    }
}
