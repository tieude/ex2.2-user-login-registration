namespace GiaoDien_3Form
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            txtEmailSDT = new TextBox();
            txtHoTen = new TextBox();
            lblLoi_HoTen = new Label();
            lblLoi_TenDangNhap = new Label();
            lblLoi_MatKhau = new Label();
            lblLoi_XacNhanMatKhau = new Label();
            lblLoi_EmailSDT = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 14F);
            txtTenDangNhap.Location = new Point(360, 110);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(218, 39);
            txtTenDangNhap.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(127, 110);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(127, 182);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(127, 252);
            label4.Name = "label4";
            label4.Size = new Size(224, 32);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(127, 325);
            label5.Name = "label5";
            label5.Size = new Size(127, 32);
            label5.TabIndex = 4;
            label5.Text = "Email/SDT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(127, 42);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 5;
            label1.Text = "Họ và tên:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 14F);
            txtMatKhau.Location = new Point(360, 182);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(218, 39);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 14F);
            txtXacNhanMatKhau.Location = new Point(360, 252);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(218, 39);
            txtXacNhanMatKhau.TabIndex = 7;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // txtEmailSDT
            // 
            txtEmailSDT.Font = new Font("Segoe UI", 14F);
            txtEmailSDT.Location = new Point(360, 325);
            txtEmailSDT.Name = "txtEmailSDT";
            txtEmailSDT.Size = new Size(218, 39);
            txtEmailSDT.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 14F);
            txtHoTen.Location = new Point(360, 42);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(218, 39);
            txtHoTen.TabIndex = 9;
            // 
            // lblLoi_HoTen
            // 
            lblLoi_HoTen.AutoSize = true;
            lblLoi_HoTen.Location = new Point(360, 77);
            lblLoi_HoTen.Name = "lblLoi_HoTen";
            lblLoi_HoTen.Size = new Size(0, 20);
            lblLoi_HoTen.TabIndex = 10;
            lblLoi_HoTen.Click += label6_Click;
            // 
            // lblLoi_TenDangNhap
            // 
            lblLoi_TenDangNhap.AutoSize = true;
            lblLoi_TenDangNhap.Location = new Point(360, 159);
            lblLoi_TenDangNhap.Name = "lblLoi_TenDangNhap";
            lblLoi_TenDangNhap.Size = new Size(0, 20);
            lblLoi_TenDangNhap.TabIndex = 11;
            // 
            // lblLoi_MatKhau
            // 
            lblLoi_MatKhau.AutoSize = true;
            lblLoi_MatKhau.Location = new Point(360, 224);
            lblLoi_MatKhau.Name = "lblLoi_MatKhau";
            lblLoi_MatKhau.Size = new Size(0, 20);
            lblLoi_MatKhau.TabIndex = 12;
            // 
            // lblLoi_XacNhanMatKhau
            // 
            lblLoi_XacNhanMatKhau.AutoSize = true;
            lblLoi_XacNhanMatKhau.Location = new Point(360, 302);
            lblLoi_XacNhanMatKhau.Name = "lblLoi_XacNhanMatKhau";
            lblLoi_XacNhanMatKhau.Size = new Size(0, 20);
            lblLoi_XacNhanMatKhau.TabIndex = 13;
            // 
            // lblLoi_EmailSDT
            // 
            lblLoi_EmailSDT.AutoSize = true;
            lblLoi_EmailSDT.Location = new Point(360, 376);
            lblLoi_EmailSDT.Name = "lblLoi_EmailSDT";
            lblLoi_EmailSDT.Size = new Size(0, 20);
            lblLoi_EmailSDT.TabIndex = 14;
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 14F);
            btnDangKy.Location = new Point(201, 410);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(150, 40);
            btnDangKy.TabIndex = 15;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 14F);
            btnHuy.Location = new Point(473, 410);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 40);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(lblLoi_EmailSDT);
            Controls.Add(lblLoi_XacNhanMatKhau);
            Controls.Add(lblLoi_MatKhau);
            Controls.Add(lblLoi_TenDangNhap);
            Controls.Add(lblLoi_HoTen);
            Controls.Add(txtHoTen);
            Controls.Add(txtEmailSDT);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenDangNhap);
            Name = "FormDangKy";
            Text = "FormDangKy";
            Load += FormDangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtEmailSDT;
        private TextBox txtHoTen;
        private Label lblLoi_HoTen;
        private Label lblLoi_TenDangNhap;
        private Label lblLoi_MatKhau;
        private Label lblLoi_XacNhanMatKhau;
        private Label lblLoi_EmailSDT;
        private Button btnDangKy;
        private Button btnHuy;
    }
}