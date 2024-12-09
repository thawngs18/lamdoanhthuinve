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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlTypes;



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
            
            Panel[] panels = {flp_admin,ftp_DL, panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }
           
            flp_admin.Visible = true;
            panel1.Visible = true;
            System.Windows.Forms.Button[] buttons = {button7,button16,button17,button15,button13,button14,button24,button28,button29,button30,button31,button32};
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button16.BackColor = Color.Red;
            
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Nhan Vien";
            Panel[] panels = {  flp_admin, ftp_DL, panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }
            pnlNV.Visible = true;
            System.Windows.Forms.Button[] buttons = { button7, button16, button17, button15, button13, button14, button24, button28, button29, button30, button31, button32 };
            foreach (var button in buttons)
                button.BackColor = SystemColors.Control;
            button13.BackColor = Color.Red;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = "Khach Hang";
            Panel[] p = {  flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlKH.Visible = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Doanh Thu";
            Panel[] p = {  flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            pnlDoanhThu.Visible = true;
           
            loadCBPhim();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Du Lieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            ftp_DL.Visible = true;
            button17.BackColor = Color.Red;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Text = "Loai Man Hinh";
            Panel[] p = {flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLoaiManHinh.Visible = true;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Text = "Phong Chieu";
            Panel[] p = {  flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhongChieu.Visible = true;
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Text = "The Loai";
            Panel[] p = {  flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlTheLoai.Visible = true;
           

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Text = "Phim";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlPhim.Visible = true;
            
            LoadTheLoaiToCheckedListBox();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Text = "Dinh Dang";
            Panel[] p = {  flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlDinhDang.Visible = true;
            
            LoadComboBoxData();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Text = "Lich Chieu";
            Panel[] p = {  flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            pnlLichChieu.Visible = true;
            
            LoadData();
            LoadPhongChieuData();

        }
        //dg code
        private void button16_Click(object sender, EventArgs e)
        {
            Panel[] panels = {flp_admin, ftp_DL, panel2, pnlKH, pnlDinhDang, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlTheLoai, pnlPhongChieu };
            foreach (var pan in panels)
            {
                pan.Visible = false;
            }

            flp_admin.Visible = true;
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button16.PerformClick();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            this.Text = "Du Lieu";
            Panel[] p = { flp_admin, panel2, ftp_DL, pnlDinhDang, pnlKH, pnlDoanhThu, pnlLichChieu, pnlLoaiManHinh, pnlNV, pnlPhim, pnlPhongChieu, pnlTheLoai };
            foreach (var panel in p)
            { panel.Visible = false; }
            panel2.Visible = true;
            ftp_DL.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button17.PerformClick();
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
        // Thể Loại
        private void btnXemTL_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM TheLoai";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvTL.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            {
                string idTL = txtMaTheLoai.Text;
                string tenTL = txtTenTheLoai.Text;
                string idMT = txtMoTaTL.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO TheLoai(id, TenTheLoai , MoTa) VALUES (@id,@Name,@comment)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", idTL);
                            cmd.Parameters.AddWithValue("@Name", tenTL);
                            cmd.Parameters.AddWithValue("@comment", idMT);
                            
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm the loai thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm the loai that bai.");
                            }
                        }
                        btnXemTL.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (dgvTL.SelectedRows.Count > 0)
            {

                var id = dgvTL.SelectedRows[0].Cells["id"].Value;

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa the loai này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM TheLoai WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa the loai thanh cong!");
                                    btnXemTL.PerformClick(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Xóa the loai that bai ");
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
                MessageBox.Show("Vui lòng chọn một the loai để xóa.");
            }
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTL.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvTL.SelectedRows[0];
                txtMaTheLoai.Text = row.Cells["id"].Value?.ToString();
                txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString();
                txtMoTaTL.Text = row.Cells["MoTa"].Value?.ToString();              
            }
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            if (dgvTL.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvTL.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có ID hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string idTL = txtMaTheLoai.Text;
                string tenTL = txtTenTheLoai.Text;
                string idMT = txtMoTaTL.Text;




                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE TheLoai SET TenTheLoai = @Name, MoTa = @comment WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idTL);
                            cmd.Parameters.AddWithValue("@Name", tenTL);
                            cmd.Parameters.AddWithValue("@comment", idMT);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                btnXemTL.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy the loai để cập nhật.");
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
        //Phim

        private void LoadTheLoaiToCheckedListBox()
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString)) ;

            // Truy vấn lấy tên thể loại
            string query = "SELECT id,TenTheLoai FROM TheLoai";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Xóa danh sách cũ trước khi thêm mới
                    clbTheLoaiP.Items.Clear();

                    // Thêm từng tên thể loại vào CheckedListBox
                    while (reader.Read())
                    {
                        clbTheLoaiP.Items.Add(new ListItem
                        {
                            Id = reader["id"].ToString(),
                            Name = reader["TenTheLoai"].ToString()
                        }
                        );

                    }

                    reader.Close();
                    clbTheLoaiP.DisplayMember = "TenTheLoai"; // Hiển thị tên thể loại
                    clbTheLoaiP.ValueMember = "id";    // Lưu id ẩn trong ListItem
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnXemP_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM Phim";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvP.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            if (dgvP.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvP.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có phim hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string idP = txtMaPhimP.Text;
                string tenP = txtTenPhimP.Text;
                string MT = txtMoTaP.Text;
                float thoiluong = float.Parse(txtThoiLuongP.Text);
                DateTime ngaykc = dtpKCP.Value.Date;
                DateTime ngaykt = dtpKTP.Value.Date;
                string sannxuat = txtSanXuatP.Text;
                string daodien = txtDaoDienP.Text;
                int namsx = int.Parse(txtNamSXP.Text);




                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Phim SET TenPhim = @Name, MoTa = @comment, ThoiLuong = @TL, NgayKhoiChieu = @NKC, NgayKetThuc = @NKT, SanXuat = @SX, DaoDien = @DD, NamSX = @namsx  WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idP);
                            cmd.Parameters.AddWithValue("@Name", tenP);
                            cmd.Parameters.AddWithValue("@comment", MT);
                            cmd.Parameters.AddWithValue("@TL", thoiluong);
                            cmd.Parameters.AddWithValue("@NKC", ngaykc);
                            cmd.Parameters.AddWithValue("@NKT", ngaykt);
                            cmd.Parameters.AddWithValue("@SX", sannxuat);
                            cmd.Parameters.AddWithValue("@DD", daodien);
                            cmd.Parameters.AddWithValue("@namsx", namsx);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                btnXemP.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy phim để cập nhật.");
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

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvP.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvP.SelectedRows[0];
                txtTenPhimP.Text = row.Cells["TenPhim"].Value?.ToString();
                txtMoTaP.Text = row.Cells["MoTa"].Value?.ToString();
                txtSanXuatP.Text = row.Cells["SanXuat"].Value?.ToString();
                txtThoiLuongP.Text = row.Cells["ThoiLuong"].Value?.ToString();
                txtMaPhimP.Text = row.Cells["id"].Value?.ToString();
                txtDaoDienP.Text = row.Cells["DaoDien"].Value?.ToString();
                dtpKCP.Text = row.Cells["NgayKhoiChieu"].Value?.ToString();
                dtpKTP.Text = row.Cells["NgayKetThuc"].Value?.ToString();
                txtNamSXP.Text = row.Cells["NamSX"].Value?.ToString();            
            }
        }
        private List<string> GetCheckedTheLoaiIds()
        {
            List<string> checkedIds = new List<string>();

            foreach (var item in clbTheLoaiP.CheckedItems)
            {
                if (item is ListItem listItem)
                {
                    checkedIds.Add(listItem.Id);
                }
            }

            return checkedIds;
        }

        private void AddPhanLoaiPhim(string maPhim, List<string> theLoaiIds)
        {
            string query = "INSERT INTO PhanLoaiPhim (idPhim, idTheLoai) VALUES (@idPhim, @idTheLoai)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    foreach (string theLoaiId in theLoaiIds)
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idPhim", maPhim);
                            command.Parameters.AddWithValue("@idTheLoai", theLoaiId);

                            command.ExecuteNonQuery();
                        }
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            {
                string idP = txtMaPhimP.Text;
                string tenP = txtTenPhimP.Text;
                string MT = txtMoTaP.Text;
                float thoiluong = float.Parse(txtThoiLuongP.Text);
                DateTime ngaykc = dtpKCP.Value.Date;
                DateTime ngaykt = dtpKTP.Value.Date;
                string sannxuat = txtSanXuatP.Text;
                string daodien = txtDaoDienP.Text;
                int namsx = int.Parse(txtNamSXP.Text);
                

                List<string> theLoaiIds = GetCheckedTheLoaiIds();


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Phim(id,TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, SanXuat, DaoDien, NamSX) VALUES (@id,@Name,@comment,@TL,@NKC,@NKT,@SX,@DD,@namsx)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", idP);
                            cmd.Parameters.AddWithValue("@Name", tenP);
                            cmd.Parameters.AddWithValue("@comment", MT);
                            cmd.Parameters.AddWithValue("@TL", thoiluong);
                            cmd.Parameters.AddWithValue("@NKC", ngaykc);
                            cmd.Parameters.AddWithValue("@NKT", ngaykt);
                            cmd.Parameters.AddWithValue("@SX", sannxuat);
                            cmd.Parameters.AddWithValue("@DD", daodien);
                            cmd.Parameters.AddWithValue("@namsx", namsx);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm phim thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm phim that bai.");
                            }
                        }
                        btnXemP.PerformClick();
                        AddPhanLoaiPhim(idP, theLoaiIds);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            if (dgvP.SelectedRows.Count > 0)
            {

                var id = dgvP.SelectedRows[0].Cells["id"].Value;

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Phim WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa phim thanh cong!");
                                    btnXemP.PerformClick(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Xóa phim that bai ");
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
                MessageBox.Show("Vui lòng chọn một phim để xóa.");
            }
    }
        //Dinh Dang
        private void btnXemDD_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM DinhDangPhim";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvDD.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void btnThemDD_Click(object sender, EventArgs e)
        {
            {
                string idMaDD = txtMaDD.Text;
                string idPhimDD = cmbMaPhimDD.Text;
                string idManHinhDD = cmbMaManHinhDD.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO DinhDangPhim(id, idPhim, idLoaiManHinh) VALUES (@id,@N,@comment)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", idMaDD);
                            cmd.Parameters.AddWithValue("@N", idPhimDD);
                            cmd.Parameters.AddWithValue("@comment", idManHinhDD);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm the loai thanh cong!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm the loai that bai.");
                            }
                        }
                        btnXemDD.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

        }



        private void LoadComboBoxData()
        {
              cmbMaManHinhDD.Items.Clear(); 
            cmbMaPhimDD.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load maPhim
                SqlCommand cmdPhim = new SqlCommand("SELECT id, TenPhim FROM Phim", connection);
                SqlDataReader readerPhim = cmdPhim.ExecuteReader();
                while (readerPhim.Read())
                {
                    cmbMaPhimDD.Items.Add(new ComboBoxItem
                    {
                        Id = readerPhim["id"].ToString(),
                        Name = readerPhim["TenPhim"].ToString()
                    });
                }
                readerPhim.Close();

                // Load maMH
                SqlCommand cmdMH = new SqlCommand("SELECT id, TenMH FROM LoaiManHinh", connection);
                SqlDataReader readerMH = cmdMH.ExecuteReader();
                while (readerMH.Read())
                {
                    cmbMaManHinhDD.Items.Add(new ComboBoxItem
                    {
                        Id = readerMH["id"].ToString(),
                        Name = readerMH["TenMH"].ToString()
                    });
                }
                readerMH.Close();
            }
        }

        private void cmbMaPhimDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaPhimDD.SelectedItem != null)
            {
                var selectedItem = (dynamic)cmbMaPhimDD.SelectedItem;
                txtTenPhimDD.Text = selectedItem.Name;
            }
        }

        private void cmbMaManHinhDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaManHinhDD.SelectedItem != null)
            {
                var selectedItem = (dynamic)cmbMaManHinhDD.SelectedItem;
                txtTenManHinhDD.Text = selectedItem.Name;
            }
        }

        private void dgvDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDD.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var row = dgvDD.SelectedRows[0];
                txtMaDD.Text = row.Cells["id"].Value?.ToString();
                cmbMaPhimDD.Text = row.Cells["idPhim"].Value?.ToString();
                cmbMaManHinhDD.Text = row.Cells["idLoaiManHinh"].Value?.ToString();
            }
        }

        private void btnSuaDD_Click(object sender, EventArgs e)
        {
            if (dgvDD.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvDD.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có ma dinh dang hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string idMaDD = txtMaDD.Text;
                string idPhimDD = cmbMaPhimDD.Text;
                string idManHinhDD = cmbMaManHinhDD.Text;




                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE DinhDangPhim SET  idPhim=@N, idLoaiManHinh=@comment WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idMaDD);
                            cmd.Parameters.AddWithValue("@N", idPhimDD);
                            cmd.Parameters.AddWithValue("@comment", idManHinhDD);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                btnXemDD.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dinh dang để cập nhật.");
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

        private void btnXoaDD_Click(object sender, EventArgs e)
        {
            if (dgvDD.SelectedRows.Count > 0)
            {

                var id = dgvDD.SelectedRows[0].Cells["id"].Value;

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dinh dang này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM DinhDangPhim WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa dinh dang thanh cong!");
                                    btnXemDD.PerformClick(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Xóa dinh dang that bai ");
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
                MessageBox.Show("Vui lòng chọn một the loai để xóa.");
            }
        }
        //Lich Chieu
        private void btnXemLC_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn
                    string query = "SELECT * FROM LichChieu";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvLC.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        //load data dinhdangtronglichchieu
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Lấy dữ liệu từ bảng DinhDangPhim kết hợp với Phim và LoaiManHinh
                    string query = @"
                    SELECT dp.id, p.TenPhim, lm.TenMH
                    FROM DinhDangPhim dp
                    JOIN Phim p ON dp.idPhim = p.id
                    JOIN LoaiManHinh lm ON dp.idLoaiManHinh = lm.id";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán DataSource cho ComboBox
                    cmbMaDDLC.DataSource = dt;
                    cmbMaDDLC.DisplayMember = "id"; // Hiển thị TênPhim
                    cmbMaDDLC.ValueMember = "id"; // Giá trị của ComboBox là id (DinhDangPhim.id)

                    // Optional: Hiển thị thêm thông tin về màn hình 2D/3D/IMax
                    cmbMaDDLC.SelectedIndexChanged += cmbMaDDLC_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
     
        private void cmbMaDDLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaDDLC.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cmbMaDDLC.SelectedItem;
                string tenPhim = rowView["TenPhim"].ToString();
                string tenMH = rowView["TenMH"].ToString();

                // Hiển thị tên phim và loại màn hình vào các TextBox
                txtPhimLC.Text = tenPhim;
                txtManHinhLC.Text = tenMH;
            }
        }
        private void LoadPhongChieuData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Lấy dữ liệu từ bảng PhongChieu
                    string query = "SELECT id, TenPhong FROM PhongChieu"; // Giả sử bảng PhongChieu có cột id và TenPhong
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán DataSource cho ComboBox
                    cmbPhongChieuLC.DataSource = dt;
                    cmbPhongChieuLC.DisplayMember = "TenPhong"; // Hiển thị TênPhòng
                    cmbPhongChieuLC.ValueMember = "id"; // Giá trị của ComboBox là id (PhongChieu.id)

                    // Optional: Hiển thị thêm thông tin khi chọn phòng chiếu
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    

        private void btnThemLC_Click(object sender, EventArgs e)
        {
            {
                string idMaLC = txtMaLC.Text;
                string idMaDDLC = cmbMaDDLC.Text;
                string idPhongChieuLC = cmbPhongChieuLC.SelectedValue.ToString();
                DateTime ngaylc = dtpNgayLC.Value.Date;
                DateTime ngaygio = dtpGioLC.Value; // Assuming you want both date and time
                DateTime thoiGianChieu = new DateTime(ngaylc.Year, ngaylc.Month, ngaylc.Day, ngaygio.Hour, ngaygio.Minute, 0);
                int Giave = int.Parse(txtGiaVeLC.Text);
                int TT = int.Parse(textTTLC.Text);

                // Combine date and time into one DateTime
              

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO LichChieu(id, ThoiGianChieu, idPhong, idDinhDang, GiaVe, TrangThai) " +
                            "VALUES (@id,@date,@idPhong,@idDinhDang,@Giave,@TT)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", idMaLC);
                            cmd.Parameters.AddWithValue("@idDinhDang", idMaDDLC); // Corrected
                            cmd.Parameters.AddWithValue("@idPhong", idPhongChieuLC); // Corrected
                            cmd.Parameters.AddWithValue("@date", thoiGianChieu); // Use combined DateTime
                            cmd.Parameters.AddWithValue("@TT", TT);
                            cmd.Parameters.AddWithValue("@Giave", Giave);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm lịch chiếu thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Thêm lịch chiếu thất bại.");
                            }
                        }
                        btnXemLC.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoaLC_Click(object sender, EventArgs e)
        {
            if (dgvLC.SelectedRows.Count > 0)
            {

                var id = dgvLC.SelectedRows[0].Cells["id"].Value;

                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lich chieu này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM LichChieu WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa dinh dang thanh cong!");
                                    btnXemLC.PerformClick(); // Tải lại danh sách sau khi xóa
                                }
                                else
                                {
                                    MessageBox.Show("Xóa dinh dang that bai ");
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
        }

        private void btnSuaLC_Click(object sender, EventArgs e)
        {
            if (dgvLC.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy ID từ hàng được chọn
                var cellValue = dgvLC.SelectedRows[0].Cells["id"].Value;

                if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("Không có ma dinh dang hợp lệ trong hàng được chọn.");
                    return;
                }


                // Lấy thông tin mới từ TextBox
                string idMaLC = txtMaLC.Text;
                string idMaDDLC = cmbMaDDLC.Text;
                string idPhongChieuLC = cmbPhongChieuLC.SelectedValue.ToString();
                DateTime ngaylc = dtpNgayLC.Value.Date;
                DateTime ngaygio = dtpGioLC.Value; // Assuming you want both date and time
                DateTime thoiGianChieu = new DateTime(ngaylc.Year, ngaylc.Month, ngaylc.Day, ngaygio.Hour, ngaygio.Minute, 0);
                int Giave = int.Parse(txtGiaVeLC.Text);
                int TT = int.Parse(textTTLC.Text);




                // Chuẩn bị câu lệnh SQL UPDATE

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE LichChieu SET   ThoiGianChieu = @date, idPhong=@idPhong, idDinhDang=@idDinhDang, GiaVe=@Giave ,TrangThai =@TT  WHERE id = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idMaLC);
                            cmd.Parameters.AddWithValue("@idDinhDang", idMaDDLC); // Corrected
                            cmd.Parameters.AddWithValue("@idPhong", idPhongChieuLC); // Corrected
                            cmd.Parameters.AddWithValue("@date", thoiGianChieu); // Use combined DateTime
                            cmd.Parameters.AddWithValue("@TT", TT);
                            cmd.Parameters.AddWithValue("@Giave", Giave);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!");
                                btnXemLC.PerformClick(); // Tải lại danh sách sau khi cập nhật
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy Lich Chieu để cập nhật.");
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

        private void dgvLC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLC.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
               // id, ThoiGianChieu, idPhong, idDinhDang, GiaVe, TrangThai
                var row = dgvLC.SelectedRows[0];
                txtMaLC.Text = row.Cells["id"].Value?.ToString();
                DateTime thoiGianChieu = (DateTime)row.Cells["ThoiGianChieu"].Value;
                dtpNgayLC.Value = thoiGianChieu;
                dtpGioLC.Value = thoiGianChieu;
                cmbPhongChieuLC.SelectedValue = row.Cells["idPhong"].Value?.ToString();
                txtGiaVeLC.Text = row.Cells["GiaVe"].Value?.ToString();
                textTTLC.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }
        public void loadCBPhim()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Lấy dữ liệu từ bảng PhongChieu
                    string query = "SELECT id, TenPhim FROM Phim"; // Giả sử bảng PhongChieu có cột id và TenPhong
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán DataSource cho ComboBox
                    cmbChonPhim.DataSource = dt;
                    cmbChonPhim.DisplayMember = "TenPhim"; // Hiển thị TênPhòng
                    cmbChonPhim.ValueMember = "id"; // Giá trị của ComboBox là id (PhongChieu.id)

                    // Optional: Hiển thị thêm thông tin khi chọn phòng chiếu

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
   

