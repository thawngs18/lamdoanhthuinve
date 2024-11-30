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
    

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Text = "Doanh Thu";
            Panel[] p = {  panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlDoanhThu.Visible = true;

        }

    

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Text = "Khach Hang";
            Panel[] p = {  panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlKhachHang.Visible = true;

        }

        private void admin_Load(object sender, EventArgs e)
        {
            Panel[] p = {  panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Nhan Vien";
            Panel[] p = { panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }

            pnlNhanVien.Visible = true;

        }


        private void button18_Click(object sender, EventArgs e)
        {
            Panel[] p = {panel2,pnlDinhDang, pnlKhachHang,pnlDoanhThu,pnlLichChieu,pnlLoaiManHinh,pnlNhanVien,pnlPhim,pnlPhongChieu,pnlTheLoai};
            foreach (var panel in p)
                { panel.Visible = false; }
           
            panel2.Visible = true;
            pnlLoaiManHinh.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Du Lieu";
            Panel[] p = { panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
          
            panel2.Visible = true;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Panel[] p = {  panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
         
            panel2.Visible = true;
            pnlPhongChieu.Visible = true;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Panel[] p = {  panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
          
            panel2.Visible = true;
            pnlTheLoai.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Panel[] p = {  panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
          
            panel2.Visible = true;
            pnlPhim.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Panel[] p = {  panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
        
            panel2.Visible = true;
            pnlDinhDang.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Panel[] p = { panel2, pnlDinhDang, pnlKhachHang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNhanVien, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }

            panel2.Visible = true;
            pnlLichChieu.Visible = true;
        }
    }
}
