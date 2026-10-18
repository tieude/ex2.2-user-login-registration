namespace GiaoDien_3Form
{
    partial class FormChinh
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
            lblXinChao = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblLanDangNhap = new Label();
            btnDangXuat = new Button();
            SuspendLayout();
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 14F);
            lblXinChao.Location = new Point(56, 27);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(289, 32);
            lblXinChao.TabIndex = 0;
            lblXinChao.Text = "\"Xin chào, Nguyễn Văn A\"";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F);
            lblTenDangNhap.Location = new Point(56, 105);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(255, 28);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập: nguyenvana";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(56, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(212, 28);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: a@example.com";
            // 
            // lblLanDangNhap
            // 
            lblLanDangNhap.AutoSize = true;
            lblLanDangNhap.Font = new Font("Segoe UI", 12F);
            lblLanDangNhap.Location = new Point(56, 237);
            lblLanDangNhap.Name = "lblLanDangNhap";
            lblLanDangNhap.Size = new Size(408, 28);
            lblLanDangNhap.TabIndex = 3;
            lblLanDangNhap.Text = "Lần đăng nhập gần nhất: \\n21/09/2026 09:15";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 14F);
            btnDangXuat.Location = new Point(593, 317);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(164, 43);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangXuat);
            Controls.Add(lblLanDangNhap);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblXinChao);
            Name = "FormChinh";
            Text = "FormChinh";
            Load += FormChinh_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblXinChao;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblLanDangNhap;
        private Button btnDangXuat;
    }
}