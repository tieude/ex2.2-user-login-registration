using System;
using System.Collections.Generic;
using System.ComponentModel;  
using System.Data;
using System.Drawing;
using System.Linq;    
using System.Text; 
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Microsoft.Data.SqlClient;

namespace GiaoDien_3Form
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Xóa hết các thông báo lỗi cũ trước khi kiểm tra lại
            lblLoi_HoTen.Text = "";
            lblLoi_TenDangNhap.Text = "";
            lblLoi_EmailSDT.Text = "";
            lblLoi_MatKhau.Text = "";
            lblLoi_XacNhanMatKhau.Text = "";

            // 2. KIỂM TRA TÍNH HỢP LỆ (Rỗng, độ dài, định dạng)
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Length < 2)
            {
                lblLoi_HoTen.Text = "Họ tên không được trống và phải >= 2 ký tự.";
                txtHoTen.Focus(); 
                return;
            }

            if (!Regex.IsMatch(txtTenDangNhap.Text, @"^[a-zA-Z0-9_.-]{3,16}$"))
            {
                lblLoi_TenDangNhap.Text = "Tên đăng nhập 3-16 ký tự, không chứa ký tự đặc biệt.";
                txtTenDangNhap.Focus();
                return;
            }

            string emailRegex = @"^[a-zA-Z0-9_%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(?:\.[a-zA-Z]{2,})*$"; // Kiểm tra email hợp lệ (ví dụ: .com.vn)
            string phoneRegex = @"^(03|05|07|08|09)[0-9]{8}$"; // Kiểm tra số điện thoại hợp lệ (10 số, bắt đầu bằng 03, 05, 07, 08, 09)
            if (!Regex.IsMatch(txtEmailSDT.Text, emailRegex) && !Regex.IsMatch(txtEmailSDT.Text, phoneRegex))
            {
                lblLoi_EmailSDT.Text = "Email hoặc Số điện thoại không đúng định dạng.";
                txtEmailSDT.Focus();
                return;
            }

            // Kiểm tra mật khẩu mạnh: ít nhất 8 ký tự, có chữ hoa, chữ thường, số và ký tự đặc biệt
            if (!Regex.IsMatch(txtMatKhau.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,64}$"))
            {
                lblLoi_MatKhau.Text = "Mật khẩu yếu (Cần 8-64 ký tự, có Hoa, thường, số, đặc biệt).";
                txtMatKhau.Focus();
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                lblLoi_XacNhanMatKhau.Text = "Mật khẩu không khớp.";
                txtXacNhanMatKhau.Focus();
                return;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
