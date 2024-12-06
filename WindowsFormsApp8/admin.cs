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
        string connectionString = "Server=.\\SQLEXPRESS;Database=rapphim;Trusted_Connection=True;";

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

        private void btnXemKh_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM KhachHang";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvKH.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void btnThemKh_Click(object sender, EventArgs e)
        {
            {
                string idnv = txtMaKh.Text;
                string tennv = txtHoTenKH.Text;
                string ns = txtNsKH.Text;
                string dc = txtDiaChiKH.Text;
                string sdt = txtSDTKH.Text;
                int cmnd = int.Parse(txtCMNDKH.Text);
                int dtl =  int.Parse(nmupdownKH.Value.ToString());
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO KhachHang(id,HoTen,NgaySinh,DiaChi,SDT,CMND,DiemTichLuy) VALUES (@id,@Name,@ns,@Address,@Phone,@cmnd,@dtl)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", tennv);
                            cmd.Parameters.AddWithValue("@Phone", sdt);
                            cmd.Parameters.AddWithValue("@Address", dc);
                            cmd.Parameters.AddWithValue("@id", idnv);
                            cmd.Parameters.AddWithValue("@cmnd", cmnd);
                            cmd.Parameters.AddWithValue("@ns", ns);
                            cmd.Parameters.AddWithValue("@dtl",dtl);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm khach hang thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm khach hang that bai.");
                            }
                        }
                        btnXemKh.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

        }

        private void btnXoaKh_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {

                var id = dgvKH.SelectedRows[0].Cells["id"].Value;

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khach hang này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM KhachHang WHERE id = @idkh";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@idkh", id);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa khach hang thanh cong!");
                                    btnXemKh.PerformClick(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Xóa khach hang that bai ");
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
                MessageBox.Show("Vui lòng chọn một khach hang để xóa.");
            }

        }

        private void btnSuaKh_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvKH.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có ID hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string idkh = txtMaKh.Text;
                string tenkh = txtHoTenKH.Text;
                string ns = txtNsKH.Text;
                string dc = txtDiaChiKH.Text;
                string sdt = txtSDTKH.Text;
                int cmnd = int.Parse(txtCMNDKH.Text);
                int dtl = int.Parse(nmupdownKH.Value.ToString());


                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE KhachHang SET HoTen = @Name,NgaySinh = @ns,DiaChi = @Address,SDT = @Phone,CMND = @cmnd,DiemTichLuy = @dtl WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", tenkh);
                            cmd.Parameters.AddWithValue("@Phone", sdt);
                            cmd.Parameters.AddWithValue("@Address", dc);
                            cmd.Parameters.AddWithValue("@id", idkh);
                            cmd.Parameters.AddWithValue("@cmnd", cmnd);
                            cmd.Parameters.AddWithValue("@ns", ns);
                            cmd.Parameters.AddWithValue("@dtl",dtl);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                btnXemKh.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy khach hang để cập nhật.");
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

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvKH.SelectedRows[0];
                txtMaKh.Text = row.Cells["id"].Value?.ToString();
                txtHoTenKH.Text = row.Cells["HoTen"].Value?.ToString();
                txtNsKH.Text = row.Cells["NgaySinh"].Value?.ToString();
                txtDiaChiKH.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDTKH.Text = row.Cells["SDT"].Value?.ToString();
                txtCMNDKH.Text = row.Cells["CMND"].Value?.ToString();
                var value = row.Cells["DiemTichLuy"].Value;
                if (value != null && decimal.TryParse(value.ToString(), out decimal diemTichLuy))
                {
                    nmupdownKH.Value = diemTichLuy; // Gán giá trị vào NumericUpDown
                }
                else
                {
                    nmupdownKH.Value = nmupdownKH.Minimum; // Gán giá trị mặc định nếu không hợp lệ
                }
            }

        }

        //Loai man hinh
        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM LoaiManHinh";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvLMH.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            {
                string idMH = textBox4.Text;
                string tenMH = textBox13.Text;


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO LoaiManHinh(id,TenMH) VALUES (@id,@Name)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id",idMH);
                            cmd.Parameters.AddWithValue("@Name",tenMH);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm loai man hinh thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm loai man hinh that bai.");
                            }
                        }
                        button6.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dgvLMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLMH.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvLMH.SelectedRows[0];
                textBox4.Text = row.Cells["id"].Value?.ToString();
                textBox13.Text = row.Cells["TenMH"].Value?.ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (dgvLMH.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvLMH.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có ID hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string id = textBox4.Text;
                string tenMH = textBox13.Text;



                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE LoaiManHinh SET TenMH = @Name WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.Parameters.AddWithValue("@Name", tenMH);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                button6.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy loai man hinh để cập nhật.");
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

        private void button26_Click(object sender, EventArgs e)
        {
            if (dgvLMH.SelectedRows.Count > 0)
            {

                var id = dgvLMH.SelectedRows[0].Cells["id"].Value;

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khach hang này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM LoaiManHinh WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa loai man hinh thanh cong!");
                                    button6.PerformClick(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Xóa loai man hinh that bai ");
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
                MessageBox.Show("Vui lòng chọn một loai man hinh để xóa.");
            }

        }

  //phong chieu


        private void btnThemPC_Click(object sender, EventArgs e)
        {
            {
                string idPC = txtMaPc.Text;
                string tenPC = txtTenPC.Text;
                string idMh = txtMHPC.Text;
                int scn = int.Parse(txtChoNgoiPC.Text);
                int tt = int.Parse(txtTinhTrangPc.Text);
                int shghe = int.Parse(txtHangGhePC.Text);
                int sghemothang = int.Parse(txtGheMoiHangPC.Text);


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO PhongChieu(id, TenPhong, idManHinh, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang) VALUES (@id,@Name,@idmh,@scn,@tt,@shghe,@sogh1hang)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", idPC);
                            cmd.Parameters.AddWithValue("@Name", tenPC);
                            cmd.Parameters.AddWithValue("@idmh", idMh);
                            cmd.Parameters.AddWithValue("@scn", scn);
                            cmd.Parameters.AddWithValue("@tt", tt);
                            cmd.Parameters.AddWithValue("@shghe", shghe);
                            cmd.Parameters.AddWithValue("@sogh1hang",sghemothang );

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm phong chieu thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm phong chieu that bai.");
                            }
                        }
                        btnXemPC.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnXemPC_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM PhongChieu";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvPC.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaPC_Click(object sender, EventArgs e)
        {

            if (dgvPC.SelectedRows.Count > 0)
            {

                var id = dgvPC.SelectedRows[0].Cells["id"].Value;

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khach hang này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM PhongChieu WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa phong chieu thanh cong!");
                                    btnXemPC.PerformClick(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Xóa phong chieu that bai ");
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
                MessageBox.Show("Vui lòng chọn một phong chieu để xóa.");
            }

        }


        private void btnSuaPC_Click(object sender, EventArgs e)
        {
            if (dgvPC.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvPC.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có ID hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string idPC = txtMaPc.Text;
                string tenPC = txtTenPC.Text;
                string idMh = txtMHPC.Text;
                int scn = int.Parse(txtChoNgoiPC.Text);
                int tt = int.Parse(txtTinhTrangPc.Text);
                int shghe = int.Parse(txtHangGhePC.Text);
                int sghemothang = int.Parse(txtGheMoiHangPC.Text);



                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE PhongChieu SET TenPhong = @Name,  idManHinh = @idmh, SoChoNgoi = @scn, TinhTrang = @tt, SoHangGhe = @shghe, SoGheMotHang = @sogh1hang WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idPC);
                            cmd.Parameters.AddWithValue("@Name", tenPC);
                            cmd.Parameters.AddWithValue("@idmh", idMh);
                            cmd.Parameters.AddWithValue("@scn", scn);
                            cmd.Parameters.AddWithValue("@tt", tt);
                            cmd.Parameters.AddWithValue("@shghe", shghe);
                            cmd.Parameters.AddWithValue("@sogh1hang", sghemothang);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                btnXemPC.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy phong chieu để cập nhật.");
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

        private void dgvPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPC.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvPC.SelectedRows[0];
                txtMaPc.Text = row.Cells["id"].Value?.ToString();
                txtTenPC.Text = row.Cells["TenPhong"].Value?.ToString();
                txtMHPC.Text = row.Cells["idManHinh"].Value?.ToString();
                txtChoNgoiPC.Text = row.Cells["SoChoNgoi"].Value?.ToString();
                txtTinhTrangPc.Text = row.Cells["TinhTrang"].Value?.ToString();
                txtHangGhePC.Text = row.Cells["SoHangGhe"].Value?.ToString();
                txtGheMoiHangPC.Text = row.Cells["SoGheMotHang"].Value?.ToString();

            }
        }
    }
   
}
