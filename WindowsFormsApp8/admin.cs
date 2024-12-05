using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;


namespace WindowsFormsApp8
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\SQLEXPRESS;Database=rapphim_login;Trusted_Connection=True;";

        private void admin_Load(object sender, EventArgs e)
        {
            Panel[] panels = {panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai,pnlPhongChieu };
            foreach (var pan in panels) {
                pan.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Nhan Vien";
            Panel[] panels = {panel2,pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai,pnlPhongChieu };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }
            pnlNV.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = "Khach Hang";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlKH.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Doanh Thu";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlDoanhThu.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Du Lieu";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Text = "Loai Man Hinh";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLoaiManHinh.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Text = "Phong Chieu";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhongChieu.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Text = "The Loai";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlTheLoai.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Text = "Phim";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhim.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Text = "Dinh Dang";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlDinhDang.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Text = "Lich Chieu";
            Panel[] p = { panel2, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLichChieu.Visible = true;
        }
    }
}
