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

namespace WindowsFormsApp8
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.\\SQLEXPRESS;Database=rapphim;Trusted_Connection=True;";
        private void button1_Click(object sender, EventArgs e)
        {         

            string cn = "";
            if (radioButton1.Checked == true)
            {
                cn = "BV";
            }
            else if (radioButton2.Checked == true)
            {
                cn = "QL";
            }
            
            string username = textBox4.Text.Trim();
            string password = textBox1.Text.Trim();
            

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuỗi truy vấn SQL dựa trên vai trò
            string query = string.Empty;
            if (cn == "QL")
            {
                query = @"SELECT HoTen FROM Managers m,NhanVien n WHERE m.id=n.id and ManagerId = @Username AND Password = @Password AND IsActive = 1";
            }
            else if (cn == "BV")
            {
                query = @"SELECT HoTen FROM TicketSellers s,NhanVien n WHERE s.id=n.id and SellerId = @Username AND Password = @Password AND IsActive = 1";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối với cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số để tránh SQL Injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Thực thi truy vấn
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string fullName = result.ToString();
                            MessageBox.Show($"Đăng nhập thành công! Chào mừng {fullName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (cn == "QL")
                            {
                                chonCN frm = new chonCN(cn,fullName);
                                frm.ShowDialog();
                            }
                            else
                            {
                                chonCN frm = new chonCN(cn,fullName);
                                frm.ShowDialog();
                             
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        

        private void DangNhap_Load(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox3.Text = "BV";
            }
            else if (radioButton2.Checked == true)
            {
                textBox3.Text = "QL";
            }
        }
    }
}
