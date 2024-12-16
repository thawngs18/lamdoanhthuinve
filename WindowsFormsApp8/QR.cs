using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace WindowsFormsApp8
{
    public partial class QR : Form
    {
        private string tenphong;
        private string tenPhim;
        private string date;
        private string tenghe;
        private List<string> danhSachGhe;

        public QR()
        {
            InitializeComponent();
          
           
        }
        public QR(string tenphong, string tenPhim, string date, string tenghe)
        {
            this.tenphong = tenphong;
            this.tenPhim = tenPhim;
            this.date = date;
            this.tenghe = tenghe;
            this.danhSachGhe = danhSachGhe ?? new List<string>();
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
           
        }

        private void QR_Load(object sender, EventArgs e)
        {
            qr();
        }
        public void qr()
        {
            if (danhSachGhe == null)
            {
                danhSachGhe = new List<string>();
            }
            string danhSachGheStr = string.Join(", ", danhSachGhe);
            string qrConten = string.Format(
    "========= Ve Xem Phim ========= \n" +
    " {0,-24} : {1,-32}\n" +
    " {2,-13} : {3,-34}\n" +
    " {4,-16} : {5,-30}\n" +
    " {6,-16} : {7,-30}\n" +
    "==============================",
    "Phim", tenPhim, "Thoi Gian Chieu", date, "Phong Chieu", tenphong, "So ghe", tenghe);
            if (danhSachGhe.Count > 0)
            {
                qrConten += "\n" + "Danh Sach Ghe: " + danhSachGheStr;
            }
            using (QRCodeGenerator qr = new QRCodeGenerator())
            {
                QRCodeData data = qr.CreateQrCode(qrConten, QRCodeGenerator.ECCLevel.Q);
                using (QRCode code = new QRCode(data))
                {
                    Bitmap qrimg = code.GetGraphic(2, Color.Red, Color.White, true);
                    pictureBox1.Image = qrimg;
                }
            }
        }


    }
}
