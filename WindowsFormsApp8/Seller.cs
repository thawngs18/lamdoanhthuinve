using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.database;

namespace WindowsFormsApp8
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            using (var context = new rapphimEntities()) // DbContext được tạo tự động
            {
                // Lấy danh sách tên phim
                var danhSachPhim = context.Phims.Select(p => new { p.id, p.TenPhim }).ToList();
                comboBox1.DisplayMember = "TenPhim";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = danhSachPhim;

                // Lấy danh sách loại màn hình
                var danhSachMH = context.LoaiManHinhs.Select(mh => new { mh.id, mh.TenMH }).ToList();
                comboBox2.DisplayMember = "TenMH";
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = danhSachMH;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenP = comboBox1.Text;
            string tenMH = comboBox2.Text;

            using (var context = new rapphimEntities())
            {
                try
                {
                    // Truy vấn dữ liệu với LINQ
                    var lichChieu = (from lc in context.LichChieux
                                     join dd in context.DinhDangPhims on lc.idDinhDang equals dd.id
                                     join phim in context.Phims on dd.idPhim equals phim.id
                                     join mh in context.LoaiManHinhs on dd.idLoaiManHinh equals mh.id
                                     join phong in context.PhongChieux on lc.idPhong equals phong.id
                                     where phim.TenPhim == tenP && mh.TenMH == tenMH
                                     select new
                                     {
                                         lc.id,
                                         phim.TenPhim,
                                         mh.TenMH,
                                         lc.ThoiGianChieu,
                                         phim.ThoiLuong,
                                         phong.SoChoNgoi,
                                         phong.TenPhong
                                     }).ToList();

                    // Gán dữ liệu vào DataGridView
                    dtgLichChieuP.DataSource = lichChieu;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        string idlc = "";
        string tenphim = "";
        string tenmh = "";
        string time = "";
        string tenphong = "";
        private void dtgLichChieuP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem hàng có hợp lệ không
            {
                var row = dtgLichChieuP.Rows[e.RowIndex];
                idlc = row.Cells["id"].Value?.ToString();
                tenphim = row.Cells["TenPhim"].Value?.ToString();
                tenmh = row.Cells["TenMH"].Value?.ToString();
                time = row.Cells["ThoiGianChieu"].Value?.ToString();
                tenphong = row.Cells["TenPhong"].Value?.ToString();
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            BanVe bv = new BanVe(idlc, tenphong, tenphim, tenmh, time);
            bv.Show();

        }


    }
}
