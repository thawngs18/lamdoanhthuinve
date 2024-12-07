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

    public partial class BanVe : Form
    {

        private decimal giaVe = 0;
        private int soLuongNguoiLon = 0;
        private int soLuongSV = 0;
        private int soLuongTreEm = 0;
        private decimal giaVeNguoiLon = 100000;  // Giá vé người lớn
        private decimal giaVeSV = 75000;         // Giá vé sinh viên
        private decimal giaVeTreEm = 50000;     // Giá vé trẻ em
        private decimal tongTien = 0;
        public static string GetAsciiString(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int number in numbers)
            {
                sb.Append((char)number);
            }

            return sb.ToString();
        }
        public BanVe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoitaosoghe(11, 15);
            khoitaoday(11, 1);
        }

        private void khoitaoday(int v1, int v2)
        {
            int x, y = 16, kc = 30, d=65;
            for (int i = 0; i < v1; i++)
            {
                x = 11;   
                for (int j = 0; j < v2; j++)
                {
                    Label lblDay = new Label();
                    lblDay.Location = new System.Drawing.Point(x, y);
                    lblDay.Size = new System.Drawing.Size(30, 23);
                    lblDay.Text = ((char)d).ToString();
                    lblDay.BackColor = Color.Black;
                    lblDay.TextAlign = ContentAlignment.MiddleCenter;
                    lblDay.ForeColor = Color.White;
                    panel2.Controls.Add(lblDay);
                    x += kc;
                }
                y += kc;
                d++;
            }
        
        }

        private void khoitaosoghe(int v1, int v2)
        {
            int x, y = 16,kc = 30,d;
            for (int i = 0; i < v1; i++) {
                x = 11; 
                d = 1;
                


                for (int j = 0; j < v2; j++)
                {
                    Button btnGhe = new Button();
                    btnGhe.Location = new System.Drawing.Point(x, y);
                    btnGhe.Size = new System.Drawing.Size(30, 23);
                    btnGhe.Text = d++.ToString();
                    btnGhe.BackColor = Color.White;
                    btnGhe.TextAlign = ContentAlignment.MiddleCenter;
                    panel1.Controls.Add(btnGhe);
                    btnGhe.Click += BtnGhe_Click;
                    x += kc;                  
                }
                y += kc;
            } 
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (!radNguoiLon.Checked && !radSV.Checked && !radTreEm.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại vé trước khi chọn ghế!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trạng thái ghế
            if (b.BackColor == Color.Gray)
            {
                MessageBox.Show("Ghế đã đặt");
            }
            else if (b.BackColor == Color.White)
            {
                // Trước khi thay đổi trạng thái ghế, tính lại tổng tiền
                if (radNguoiLon.Checked)
                {
                    soLuongNguoiLon++;
                }
                else if (radSV.Checked)
                {
                    soLuongSV++;
                }
                else if (radTreEm.Checked)
                {
                    soLuongTreEm++;
                }


                b.BackColor = Color.Red;

                // Tính lại tổng tiền sau khi chọn ghế
                TinhThanhTien();
            }
            else if (b.BackColor == Color.Red)
            {
                // Trước khi thay đổi trạng thái ghế, tính lại tổng tiền
                if (radNguoiLon.Checked)
                {
                    soLuongNguoiLon--;
                }
                else if (radSV.Checked)
                {
                    soLuongSV--;
                }
                else if (radTreEm.Checked)
                {
                    soLuongTreEm--;
                }


                b.BackColor = Color.White;

                // Tính lại tổng tiền sau khi bỏ chọn ghế
                TinhThanhTien();
            }
        }

        private void TinhGiaVe()
        {
            decimal giaVe = 0;

            // Kiểm tra loại vé đã chọn và gán giá tiền tương ứng
            if (radNguoiLon.Checked)
            {
                giaVe = 100000;
            }
            else if (radSV.Checked)
            {
                giaVe = 75000;
            }
            else if (radTreEm.Checked)
            {
                giaVe = 50000;
            }

            // Cập nhật giá vé vào TextBox "Giá Tiền"
            txtGiaVe.Text = giaVe.ToString();  // Format thành tiền tệ

            // Tính số lượng ghế đã chọn
            int soLuongGhe = 0;
            foreach (Control control in panel2.Controls)
            {
                if (control is Button btn && btn.BackColor == Color.Red) // Kiểm tra ghế đã được chọn
                {
                    soLuongGhe++;
                }
            }

        }
        private void TinhThanhTien()
        {

            tongTien = 0;
            decimal tongTienNguoiLon = soLuongNguoiLon * giaVeNguoiLon;
            decimal tongTienSV = soLuongSV * giaVeSV;
            decimal tongTienTreEm = soLuongTreEm * giaVeTreEm;

            // Tính tổng tiền chung
            tongTien = tongTienNguoiLon + tongTienSV + tongTienTreEm;


            // Hiển thị tổng tiền vào TextBox "Thanh Tiền"
            txtThanhTien.Text = tongTien.ToString("C");

        }

        private void radNguoiLon_CheckedChanged(object sender, EventArgs e)
        {
            TinhGiaVe();
            TinhThanhTien();
        }

        private void radSV_CheckedChanged(object sender, EventArgs e)
        {
            TinhGiaVe();
            TinhThanhTien();
        }

        private void radTreEm_CheckedChanged(object sender, EventArgs e)
        {
            TinhGiaVe();
            TinhThanhTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán?", "Thông Báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Thông báo thanh toán thành công
                MessageBox.Show("Thanh toán thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đổi màu ghế đã chọn thành màu xám (hoặc bạn có thể chọn màu khác để đánh dấu ghế đã thanh toán)
                foreach (Control control in panel2.Controls)
                {
                    if (control is Button btn && btn.BackColor == Color.Red)
                    {
                        btn.BackColor = Color.Gray;  // Đổi màu ghế đã chọn thành màu xám (hoặc màu khác nếu muốn)
                    }
                }

                // Reset lại số lượng vé đã chọn
                soLuongNguoiLon = 0;
                soLuongSV = 0;
                soLuongTreEm = 0;

                // Reset lại tổng tiền
                tongTien = 0;
                txtThanhTien.Clear();  // Xóa hiển thị tổng tiền

                // Reset lại các radio button (nếu cần thiết)
                radNguoiLon.Checked = false;
                radSV.Checked = false;
                radTreEm.Checked = false;
            }
        }
    }
}
