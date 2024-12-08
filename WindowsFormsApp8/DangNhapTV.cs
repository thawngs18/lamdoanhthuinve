using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp8
{
    public partial class DangNhapTV : Form
    {
        public DangNhapTV()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\SQLEXPRESS;Database=rapphim;Trusted_Connection=True;";
        public event EventHandler CancelClicked;
        public event EventHandler OKClicked;

     
        private void btnThoat_Click(object sender, EventArgs e)
        {
            bool rs = false;
            BanVe frm = new BanVe (rs);
            CancelClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string makh = txtTKTV.Text.Trim();
            

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(makh))
            {
                MessageBox.Show("Vui lòng nhập ma khach hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuỗi truy vấn SQL để xác thực người dùng (không cần IsActive)
            string query = @"SELECT HoTen FROM KhachHang WHERE id = @makh" ;

            // Kết nối với cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@makh", makh);
                        

                        // Thực thi câu lệnh SQL và lấy kết quả
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // Nếu có kết quả, người dùng hợp lệ
                            reader.Read();
                            string hoTen = reader["HoTen"].ToString();
                        
                            MessageBox.Show($"Xin chào KHTV : {hoTen}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Mở form tiếp theo hoặc thực hiện hành động khác
                            // Ví dụ: mở form BanVe hoặc hành động khác
                            this.Close();
                            // Ẩn form đăng nhập
                        }
                        else
                        {
                            MessageBox.Show("Khong tim thay ma khach hang thanh vien", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
