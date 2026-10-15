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
        private string username; // Biến lưu trữ tên đăng nhập được truyền vào
        public FormChinh(string tenDangNhap)
        {
            InitializeComponent();
            this.username = tenDangNhap;
        }

        private async void FormChinh_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
