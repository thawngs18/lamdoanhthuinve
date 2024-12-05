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
    public partial class chonCN : Form
    {
        public chonCN(string cn)
        {
            InitializeComponent();
            label3.Text = cn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LichChieu form1 = new LichChieu();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin ad  = new admin();
            ad.ShowDialog();
        }

        private void chonCN_Load(object sender, EventArgs e)
        {
            if(label3.Text == "BV")
            {
                button1.Enabled = false;
            }
        }
    }
}
