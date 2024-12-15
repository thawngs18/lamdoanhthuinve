﻿using System;
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

namespace WindowsFormsApp8
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\SQLEXPRESS;Database=rapphim;Trusted_Connection=True;";
        private void Seller_Load(object sender, EventArgs e)
        {
            // Câu truy vấn SQL để lấy dữ liệu từ cột
            string query = "SELECT TenPhim FROM Phim";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Đổ dữ liệu vào ComboBox
                comboBox1.DisplayMember = "TenPhim"; // Cột hiển thị
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = dataTable;
            }

            query = "SElECT TenMH FROM LoaiManHinh";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Đổ dữ liệu vào ComboBox
                comboBox2.DisplayMember = "TenMH"; // Cột hiển thị
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = dataTable;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenP = comboBox1.Text;
            string tenMH = comboBox2.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    String query = "SELECT l.id,p.TenPhim,h.TenMH,l.ThoiGianChieu,p.ThoiLuong,c.SoChoNgoi,TenPhong FROM LichChieu l,LoaiManHinh h,Phim p,DinhDangPhim d,PhongChieu c where l.idDinhDang = d.id and d.idPhim = p.id and d.idLoaiManHinh = h.id and l.idPhong = c.id and p.TenPhim = @tenphim and h.TenMH = @tenMH";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@tenphim", tenP);
                        cmd.Parameters.AddWithValue("@tenMH", tenMH);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu vào DataGridView
                        dtgLichChieuP.DataSource = dataTable;
                    }
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
            if (dtgLichChieuP.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dtgLichChieuP.SelectedRows[0];
                idlc = row.Cells["id"].Value?.ToString();
                tenphim = row.Cells["TenPhim"].Value?.ToString();
                tenmh = row.Cells["TenMH"].Value?.ToString();
                time = row.Cells["ThoiGianChieu"].Value?.ToString();
                tenphong = row.Cells["TenPhong"].Value?.ToString();


            }
                
        }
        private void button2_Click(object sender, EventArgs e)
        {           
                    BanVe bv = new BanVe(idlc,tenphong,tenphim,tenmh,time);
                    bv.Show();       
        }


    }
}
