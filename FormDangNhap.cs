using Microsoft.Data.SqlClient; // Để kết nối SQL Server
using System.Text.RegularExpressions; // Regex để kiểm tra định dạng chuỗi

namespace GiaoDien_3Form
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private async void btnDangNhap_Click(object sender, EventArgs e) // async để không bị treo UI khi chờ kết nối CSDL
        {
            // Hàm kiểm tra rỗng, nếu rỗng thì hiện thông báo lỗi và return luôn
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return;
            }

            // Kiểm tra định dạng username, nếu không đúng thì hiện thông báo lỗi và return luôn
            if (!Regex.IsMatch(txtTenDangNhap.Text, @"^[a-zA-Z0-9_.-]{3,16}$"))
            {
                lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng."; 
                return;
            }
            
        }
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy fDangKy = new FormDangKy();
            fDangKy.ShowDialog(); // Mở form đăng ký dưới dạng modal,
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát Ứng dụng
        }
    }
}
