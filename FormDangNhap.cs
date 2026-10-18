using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

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


        private async void btnDangNhap_Click(object sender, EventArgs e)
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
            // Kiểm tra rỗng 
             string KetNoi = @"Server=localhost; Database=QuanLyNguoiDung; Trusted_Connection=True; TrustServerCertificate=True;";
             string sql = "SELECT Salt, MatKhauBam FROM Users WHERE TenDangNhap = @ten";
             string sqlUpdate = "UPDATE Users SET LanDangNhapCuoi = SYSDATETIME() WHERE TenDangNhap = @ten";
            
             btnDangNhap.Enabled = false;
             btnDangNhap.Text = "Đang xử lý...";
            
             try
             {
                 string saltLuu = "";
                 string bamLuu = "";
            
                 bool TimThay = false;
                 using (SqlConnection conn = new SqlConnection(KetNoi))
                 {
                     using (SqlCommand cmd = new SqlCommand(sql, conn))
                     {
                         cmd.Parameters.Add("@ten", System.Data.SqlDbType.NVarChar, 20).Value = txtTenDangNhap.Text;
            
                         await conn.OpenAsync();
                         using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                         {
                             if (reader.Read())
                             {
                                 saltLuu = reader["Salt"]?.ToString() ?? "";
                                 bamLuu = reader["MatKhauBam"]?.ToString() ?? "";
                                 TimThay = true;
                             }
                         }
                                 // Gọi hàm kiểm tra băm mật khẩu 
                                 if (TimThay&&MatKhau.KiemTra(txtMatKhau.Text, saltLuu, bamLuu))
                                 {
                                     //cập nhật lần cuối đăng nhập
                                     using (SqlCommand updatTime = new SqlCommand(sqlUpdate, conn))
                                     {
                                         updatTime.Parameters.Add("@ten", System.Data.SqlDbType.NVarChar, 20).Value = txtTenDangNhap.Text;
                                         await updatTime.ExecuteNonQueryAsync();
                                     }
                                     // Đăng nhập thành công, mở Form Chính 
                                     FormChinh fChinh = new FormChinh(txtTenDangNhap.Text);
                                     this.Hide();
                                     fChinh.ShowDialog();
                                     // Sau khi form chính đóng, hiện lại form đăng nhập và xóa mật khẩu cũ
                                     this.Show();
                                     txtMatKhau.Clear();
                                     return;
                                 }
                             
                     }
                 }
                 lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                 txtMatKhau.Clear(); // Xóa ô mật khẩu khi sai 
             }
             catch (SqlException ex)
             {
                 MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
             }
             finally
             {
                 btnDangNhap.Enabled = true;
                 btnDangNhap.Text = "Đăng nhập";
             }
        }
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                FormDangKy fDangKy = new FormDangKy();
                fDangKy.ShowDialog(); // Mở form đăng ký
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                Application.Exit(); // Thoát Ứng dụng
        }
    }
}
