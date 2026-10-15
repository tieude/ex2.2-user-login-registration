namespace GiaoDien_3Form
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            lblLoi = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lnkDangKy = new LinkLabel();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(83, 79);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(83, 153);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            label2.Click += label2_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 14F);
            txtTenDangNhap.Location = new Point(319, 83);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(211, 39);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 14F);
            txtMatKhau.Location = new Point(319, 153);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(211, 39);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblLoi
            // 
            lblLoi.AutoSize = true;
            lblLoi.ForeColor = Color.Red;
            lblLoi.Location = new Point(319, 205);
            lblLoi.Name = "lblLoi";
            lblLoi.Size = new Size(0, 20);
            lblLoi.TabIndex = 5;
            lblLoi.Click += label3_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 12F);
            btnDangNhap.Location = new Point(199, 282);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(137, 43);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(451, 282);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 43);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lnkDangKy
            // 
            lnkDangKy.AutoSize = true;
            lnkDangKy.LinkColor = Color.Red;
            lnkDangKy.Location = new Point(280, 349);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(236, 20);
            lnkDangKy.TabIndex = 8;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "\"Bạn chưa có tài khoản? Đăng Ký\".";
            lnkDangKy.LinkClicked += lnkDangKy_LinkClicked;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkDangKy);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(lblLoi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangNhap";
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label lblLoi;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel lnkDangKy;
    }
}
