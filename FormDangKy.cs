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
            var (salt, bam) = MatKhau.Tao(txtMatKhau.Text);
            string chuoiKetNoi= @"Server=localhost; Database=QuanLyNguoiDung; Trusted_Connection=True; TrustServerCertificate=True;";
            string sql = "INSERT INTO Users (TenDangNhap,MatKhauBam,Salt,HoTen,Email,SoDienThoai) VALUES (@ten,@bam,@salt,@hoten,@email,@sdt)";
            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý.....";
            
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    using (SqlCommand lenh = new SqlCommand(sql, conn))
                    {
                        lenh.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = txtTenDangNhap.Text;
                        lenh.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = bam;
                        lenh.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
                        lenh.Parameters.Add("@hoten", SqlDbType.NVarChar, 50).Value = txtHoTen.Text;
                        lenh.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = emailDbValue;
                        lenh.Parameters.Add("@sdt", SqlDbType.NVarChar, 20).Value = phoneDbValue;
                        await conn.OpenAsync();
                        await lenh.ExecuteNonQueryAsync();
                        MessageBox.Show("Đăng ký thành công!", "Thông báo");
                        this.Close();
                    }
            
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    lblLoi_TenDangNhap.Text = "Tên đăng nhập này đã có người dùng.";
                    txtTenDangNhap.Focus();
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                }
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng ký";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
