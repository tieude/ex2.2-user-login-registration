using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_3Form
{
    public partial class FormChinh : Form
    {
        public FormChinh(string tenDangNhap)
        {
        }

        private async void FormChinh_Load(object sender, EventArgs e)
        {
            string chuoiKetNoi = @"Server=localhost\SQLEXPRESS; Database=QuanLyNguoiDung; Trusted_Connection=True; TrustServerCertificate=True;";
            string sql = "SELECT HoTen, TenDangNhap, Email, LanDangNhapCuoi FROM Users WHERE TenDangNhap = @ten";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@ten", System.Data.SqlDbType.NVarChar, 20).Value = this.username;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                lblXinChao.Text = "Xin chào, " + reader["HoTen"].ToString();
                                lblTenDangNhap.Text = "Tên đăng nhập: " + reader["TenDangNhap"].ToString();
                                lblEmail.Text = "Email: " + reader["Email"].ToString();

                                if (reader["LanDangNhapCuoi"] != DBNull.Value)
                                {
                                    DateTime lanCuoi = Convert.ToDateTime(reader["LanDangNhapCuoi"]);
                                    lblLanDangNhap.Text = "Lần đăng nhập gần nhất:\n" + lanCuoi.ToString("dd/MM/yyyy HH:mm");
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           
        }
    }
}
