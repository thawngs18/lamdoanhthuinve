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
    public partial class LichChieu : Form
    {
        public LichChieu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BanVe form = new BanVe();   
            form.ShowDialog();
        }
    }
}
