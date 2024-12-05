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

        private void button8_Click(object sender, EventArgs e)
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

        private void pnlDinhDang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {   
            string customerID = textBox2.Text;
            string customerName = textBox3.Text;
            string phone = textBox6.Text;
            int cmnd = int.Parse(textBox7.Text);
            string address = textBox5.Text;
            int dtl = 0;
            DateTime ns = dateTimePicker3.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO KhachHang(id,HoTen,SDT,CMND,DiaChi,NgaySinh,DiemTichLuy) VALUES (@id,@Name,@Phone,@cmnd,@DC,@ns,@dtl)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", customerName);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@DC", address);
                        cmd.Parameters.AddWithValue("@id", customerID);
                        cmd.Parameters.AddWithValue("@cmnd", cmnd);
                        cmd.Parameters.AddWithValue("@ns", ns);
                        cmd.Parameters.AddWithValue("@dtl", dtl);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm khách hàng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng thất bại.");
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
