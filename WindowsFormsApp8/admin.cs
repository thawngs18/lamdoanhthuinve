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
            Panel[] panels = { panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Nhan Vien";
            Panel[] panels = { panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu };
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

        private void btnXemNV_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM NhanVien";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvNV.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            {
                string idnv = txtMaNV.Text;
                string tennv = txtHoTenNV.Text;
                string ns = txtDateNV.Text;
                string dc = txtDCNV.Text;
                string sdt = txtSDTNV.Text;
                int cmnd = int.Parse(txtCCCDNV.Text);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO NhanVien(id,HoTen,NgaySinh,DiaChi,SDT,CMND) VALUES (@id,@Name,@ns,@Address,@Phone,@cmnd)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name",tennv);
                            cmd.Parameters.AddWithValue("@Phone",sdt);
                            cmd.Parameters.AddWithValue("@Address",dc);
                            cmd.Parameters.AddWithValue("@id",idnv);
                            cmd.Parameters.AddWithValue("@cmnd", cmnd);
                            cmd.Parameters.AddWithValue("@ns", ns);
                            
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm Nhan Vien thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm Nhan Vien that bai.");
                            }
                        }
                        btnXemNV.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
      
                if (dgvNV.SelectedRows.Count > 0)
                {
                    
                    var id = dgvNV.SelectedRows[0].Cells["id"].Value;

                    // Xác nhận trước khi xóa
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhan vien này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            try
                            {
                                conn.Open();
                                string query = "DELETE FROM NhanVien WHERE id = @idnv";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@idnv", id);

                                    int rowsAffected = cmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Xóa nhan vien thanh cong!");
                                        btnXemNV.PerformClick(); // Tải lại danh sách sau khi xóa
                                    }
                                    else
                                    {
                                        MessageBox.Show("Xóa nhan vien  that bai ");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhan vien để xóa.");
                }

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvNV.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có ID hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string idnv = txtMaNV.Text;
                string tennv = txtHoTenNV.Text;
                string ns = txtDateNV.Text;
                string dc = txtDCNV.Text;
                string sdt = txtSDTNV.Text;
                int cmnd = int.Parse(txtCCCDNV.Text);

                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE NhanVien SET HoTen = @Name,NgaySinh = @ns,DiaChi = @Address,SDT = @Phone,CMND = @cmnd WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", tennv);
                            cmd.Parameters.AddWithValue("@Phone", sdt);
                            cmd.Parameters.AddWithValue("@Address", dc);
                            cmd.Parameters.AddWithValue("@id", idnv);
                            cmd.Parameters.AddWithValue("@cmnd", cmnd);
                            cmd.Parameters.AddWithValue("@ns", ns);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                btnXemNV.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.");
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvNV.SelectedRows[0];
                txtMaNV.Text = row.Cells["id"].Value?.ToString();
                txtHoTenNV.Text = row.Cells["HoTen"].Value?.ToString();
                txtDateNV.Text = row.Cells["NgaySinh"].Value?.ToString();
                txtDCNV.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDTNV.Text = row.Cells["SDT"].Value?.ToString();
                txtCCCDNV.Text = row.Cells["CMND"].Value?.ToString();
            }
        }
    }
    
}
