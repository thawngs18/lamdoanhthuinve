using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
        private decimal GiamGia = 0;
        private decimal thanhtoan = 0;
        public static string GetAsciiString(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int number in numbers)
            {
                sb.Append((char)number);
            }

            return sb.ToString();
        }

        public BanVe ( bool rs)
        {
            InitializeComponent();
            bool result = rs;
            if (!rs)
            {
                uncheck();
            }
        }

        public BanVe() {
            InitializeComponent();
        }
       
   
        public void uncheck()
        {
            chkTV.Checked = false;

        }

        private void DangNhapTV_CancelClicked(object sender, EventArgs e)
        {
            uncheck(); // Gọi phương thức uncheck
        }

        public BanVe( string idphong, string tenphim, string tenMh, string time)
        {
            InitializeComponent();
            lblipphong.Text = idphong;
            lbltenphim.Text = tenphim;
            lblTenMh.Text = tenMh;
            lbltgchieu.Text = time;
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
        private Dictionary<int, List<int>> gheDaChon = new Dictionary<int, List<int>>();
        private bool KiemTraGheBiBoGiua()
        {
            foreach (var kvp in gheDaChon)
            {
                List<int> gheDaChonTrongHang = kvp.Value;

                // Nếu danh sách ghế trong hàng rỗng hoặc chỉ có một ghế, không cần kiểm tra
                if (gheDaChonTrongHang.Count <= 1)
                    continue;

                // Sắp xếp danh sách theo tọa độ X
                gheDaChonTrongHang.Sort();

                // Duyệt qua danh sách ghế để kiểm tra khoảng trống
                for (int i = 0; i < gheDaChonTrongHang.Count - 1; i++)
                {
                    // Kiểm tra khoảng cách giữa hai ghế liên tiếp
                    if (gheDaChonTrongHang[i + 1] - gheDaChonTrongHang[i] > 30)
                    {
                        // Phát hiện ghế bị bỏ giữa trong một nhóm liên tiếp
                        return true;
                    }
                }
            }

            // Không có ghế bị bỏ giữa trong bất kỳ hàng nào
            return false;
        }
        private bool KiemTraGheCot1DaChon(int yPosition)
        {
            // Duyệt qua các ghế đã chọn trong panel2 để tìm ghế ở cột 1 cùng hàng
            foreach (Control control in panel2.Controls)
            {
                if (control is Button btn && btn.Location.Y == yPosition)
                {
                    // Kiểm tra nếu ghế ở cột 1 (vị trí x = 11) đã được chọn (màu đỏ)
                    if (btn.Location.X == 11 && btn.BackColor == Color.Red)
                    {
                        return true;  // Nếu ghế ở cột 1 đã chọn
                    }
                }
            }
            return false;  // Không có ghế ở cột 1 đã chọn
        }
        private void CapNhatGheDaChon(Button b)
        {
            int yPosition = b.Location.Y; // Hàng của ghế
            int xPosition = b.Location.X; // Tọa độ X của ghế

            if (!gheDaChon.ContainsKey(yPosition))
            {
                gheDaChon[yPosition] = new List<int>();
            }

            if (b.BackColor == Color.Red) // Ghế được chọn
            {
                if (!gheDaChon[yPosition].Contains(xPosition))
                {
                    gheDaChon[yPosition].Add(xPosition);
                }
            }
            else // Ghế bị bỏ chọn
            {
                if (gheDaChon[yPosition].Contains(xPosition))
                {
                    gheDaChon[yPosition].Remove(xPosition);
                }

                // Nếu không còn ghế nào trong hàng được chọn, xóa hàng khỏi danh sách
                if (gheDaChon[yPosition].Count == 0)
                {
                    gheDaChon.Remove(yPosition);
                }
            }
        }
        private bool KiemTraGheCungHang(int yPosition)
        {
            if (gheDaChon.ContainsKey(yPosition))
            {
                // Kiểm tra nếu có ghế ở cột 1 (X = 11) trong danh sách các ghế đã chọn trong cùng hàng
                if (gheDaChon[yPosition].Contains(11))
                {
                    return true;  // Ghế ở cột 1 đã được chọn
                }
            }
            return false;
        }
        private bool HasEmptySeatBetween(Button selectedSeat)
        {
            if (gheDaChon.ContainsKey(selectedSeat.Location.Y))
            {
                List<int> selectedSeatsInRow = gheDaChon[selectedSeat.Location.Y];

                int leftSeat = Math.Min(selectedSeat.Location.X, selectedSeatsInRow[0]);
                int rightSeat = Math.Max(selectedSeat.Location.X, selectedSeatsInRow[0]);

                // Kiểm tra có ghế trống giữa không
                for (int x = leftSeat + 30; x < rightSeat; x += 30) // Giả sử kích thước ghế là 30px
                {
                    if (IsSeatEmpty(x, selectedSeat.Location.Y))
                    {
                        return true;  // Có ghế trống giữa
                    }
                }
            }
            return false;
        }
        private bool IsSeatEmpty(int x, int y)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is Button btn && btn.Location.X == x && btn.Location.Y == y && btn.BackColor == Color.White)
                {
                    return true;  // Ghế trống
                }
            }
            return false; // Không có ghế trống
        }


        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            // Kiểm tra xem người dùng đã chọn loại vé chưa
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
                CapNhatGheDaChon(b);
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
                CapNhatGheDaChon(b);
            }

            // Tính lại tổng tiền sau khi thay đổi trạng thái ghế
            TinhThanhTien();

            // Cập nhật giảm giá và tổng thanh toán
            TinhGiamGia();
            TinhTT();

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
            thanhtoan = tongTien;

            // Hiển thị tổng tiền vào TextBox "Thanh Tiền"
            txtThanhTien.Text = tongTien.ToString("C");
            textBox2.Text = thanhtoan.ToString("C");

        }
        private void TinhGiamGia()
        {
            // Kiểm tra xem khách hàng có phải là khách hàng thân thiết hay không
            if (chkTV.Checked)
            {
                GiamGia = tongTien * 10 / 100;  // Giảm giá 10% nếu là khách hàng thân thiết
            }
            else
            {
                GiamGia = 0;  // Không giảm giá nếu không phải khách hàng thân thiết
            }

            // Hiển thị giảm giá vào TextBox
            textBox1.Text = GiamGia.ToString("C");

        }
        private void TinhTT()
        {
            // Chỉ trừ giảm giá nếu khách hàng thân thiết
            if (chkTV.Checked)
            {
                thanhtoan = tongTien - GiamGia;  // Giảm giá nếu khách hàng thân thiết
            }
            else
            {
                thanhtoan = tongTien;  // Không giảm giá nếu không phải khách hàng thân thiết
            }

            // Hiển thị tổng thanh toán vào TextBox
            textBox2.Text = thanhtoan.ToString("C");

        }

        private void radNguoiLon_CheckedChanged(object sender, EventArgs e)
        {
            TinhGiaVe();
            TinhThanhTien();
            TinhTT();
        }

        private void radSV_CheckedChanged(object sender, EventArgs e)
        {
            TinhGiaVe();
            TinhThanhTien();
            TinhTT();
        }

        private void radTreEm_CheckedChanged(object sender, EventArgs e)
        {
            TinhGiaVe();
            TinhThanhTien();
            TinhTT();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra số lượng ghế đã chọn
            int soLuongGheDaChon = gheDaChon.Values.Sum(list => list.Count);
            if (soLuongGheDaChon == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu có ghế bị bỏ giữa
            if (KiemTraGheBiBoGiua())
            {
                MessageBox.Show("Không thể thanh toán vì có ghế bị bỏ giữa trong một nhóm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ghế cột 2 mà không chọn cột 1
            foreach (var kvp in gheDaChon)
            {
                int yPosition = kvp.Key; // Lấy hàng hiện tại
                List<int> gheTrongHang = kvp.Value; // Danh sách các ghế đã chọn trong hàng

                // Kiểm tra nếu ghế ở cột 2 (X = 41) được chọn mà không chọn ghế ở cột 1 (X = 11)
                if (gheTrongHang.Contains(41) && !gheTrongHang.Contains(11)) // 41 là tọa độ X của ghế cột 2, 11 là tọa độ X của ghế cột 1
                {
                    MessageBox.Show("Bạn phải chọn ghế ở cột 1 trước khi chọn ghế ở cột 2!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Xác nhận thanh toán
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán?", "Thông Báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đổi màu ghế đã chọn thành màu xám
                foreach (Control control in panel1.Controls)
                {
                    if (control is Button btn && btn.BackColor == Color.Red)
                    {
                        btn.BackColor = Color.Gray; // Đổi màu ghế đã chọn thành màu xám
                    }
                }

                // Reset lại số lượng vé đã chọn
                soLuongNguoiLon = 0;
                soLuongSV = 0;
                soLuongTreEm = 0;

                // Reset lại tổng tiền
                tongTien = 0;
                thanhtoan = 0;
                GiamGia = 0;
                txtThanhTien.Clear();  // Xóa hiển thị tổng tiền
                textBox1.Clear();
                textBox2.Clear();

                // Reset lại các radio button (nếu cần thiết)
                radNguoiLon.Checked = false;
                radSV.Checked = false;
                radTreEm.Checked = false;
                chkTV.Checked = false;
            }

        }

        public void SetLabelData(string data)
        {
            lblHienTTin.Text = data;  // Giả sử bạn có một Label với tên label1
        }
        private void taikhoan_CancelClicked(object sender, EventArgs e)
        {
            uncheck(); // Gọi phương thức uncheck
        }
        private void chkTV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTV.Checked)
            {
                DangNhapTV tk = new DangNhapTV();
                tk.CancelClicked += taikhoan_CancelClicked; // Đăng ký sự kiện
                tk.Show();
            }
            // Nếu checkbox khách hàng thân thiết được chọn
            if (chkTV.Checked)
            {
                TinhGiamGia();  // Tính giảm giá
                TinhTT();        // Cập nhật tổng thanh toán
            }
            else
            {
                // Nếu checkbox khách hàng thân thiết không được chọn, reset giảm giá
                textBox1.Text = string.Empty;  // Xóa giảm giá
                textBox2.Text = tongTien.ToString("C");  // Cập nhật lại tổng thanh toán mà không có giảm giá
            }


        }

    }
}
