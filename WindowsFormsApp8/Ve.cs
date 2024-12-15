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
    public partial class Ve : Form
    {

        private string tenphong;
        private string tenPhim;
        private string date;
        private string tenghe;
        public Ve()
        {
            InitializeComponent();

        }
        public Ve(string tenphong, string tenPhim, string date, string tenghe)
        {
            InitializeComponent();
            this.tenphong = tenphong;
            this.tenPhim = tenPhim;
            this.date = date;
            this.tenghe = tenghe;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnlVe.Visible = false;
            QR qr = new QR(lblPhong.Text, lblTenPhim.Text, lblDate.Text,lblTenghe.Text);
            qr.MdiParent = this;
            qr.Show();
        }

        private void Ve_Load(object sender, EventArgs e)
        {
            lblPhong.Text = tenphong;
            lblTenPhim.Text=tenPhim;
            lblDate.Text=date;
            lblTenghe.Text=tenghe;
        }
    }
}
