namespace GUI
{
    partial class ChiTietDocGia
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lbtTenDocGia = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblLoaiDocGia = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.btn_HanhDongDocGia = new System.Windows.Forms.Button();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.tbMaDocGia = new System.Windows.Forms.TextBox();
            this.tbMaTK = new System.Windows.Forms.TextBox();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(341, 50);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(443, 51);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÊM ĐỘC GIẢ MỚI";
            // 
            // lbtTenDocGia
            // 
            this.lbtTenDocGia.AutoSize = true;
            this.lbtTenDocGia.Location = new System.Drawing.Point(73, 283);
            this.lbtTenDocGia.Name = "lbtTenDocGia";
            this.lbtTenDocGia.Size = new System.Drawing.Size(49, 25);
            this.lbtTenDocGia.TabIndex = 1;
            this.lbtTenDocGia.Text = "Tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(73, 382);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(108, 25);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(73, 481);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(73, 566);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(138, 25);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(599, 276);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(107, 25);
            this.lblTaiKhoan.TabIndex = 5;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(599, 375);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(101, 25);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblLoaiDocGia
            // 
            this.lblLoaiDocGia.AutoSize = true;
            this.lblLoaiDocGia.Location = new System.Drawing.Point(599, 474);
            this.lblLoaiDocGia.Name = "lblLoaiDocGia";
            this.lblLoaiDocGia.Size = new System.Drawing.Size(129, 25);
            this.lblLoaiDocGia.TabIndex = 7;
            this.lblLoaiDocGia.Text = "Loại độc giả";
            this.lblLoaiDocGia.Click += new System.EventHandler(this.lblLoaiDocGia_Click);
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(256, 277);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(262, 31);
            this.tbTen.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(251, 475);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(267, 31);
            this.tbEmail.TabIndex = 9;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(262, 563);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(256, 31);
            this.tbSDT.TabIndex = 10;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(795, 270);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(204, 31);
            this.tbTaiKhoan.TabIndex = 11;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(795, 369);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(204, 31);
            this.tbMatKhau.TabIndex = 12;
            this.tbMatKhau.TextChanged += new System.EventHandler(this.tbMatKhau_TextChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(259, 369);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(258, 31);
            this.dtpNgaySinh.TabIndex = 13;
            this.dtpNgaySinh.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // cbbLoaiDocGia
            // 
            this.cbbLoaiDocGia.FormattingEnabled = true;
            this.cbbLoaiDocGia.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbbLoaiDocGia.Items.AddRange(new object[] {
            "LDG001",
            "LDG002"});
            this.cbbLoaiDocGia.Location = new System.Drawing.Point(791, 473);
            this.cbbLoaiDocGia.Name = "cbbLoaiDocGia";
            this.cbbLoaiDocGia.Size = new System.Drawing.Size(207, 33);
            this.cbbLoaiDocGia.TabIndex = 14;
            // 
            // btn_HanhDongDocGia
            // 
            this.btn_HanhDongDocGia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_HanhDongDocGia.Location = new System.Drawing.Point(566, 566);
            this.btn_HanhDongDocGia.Name = "btn_HanhDongDocGia";
            this.btn_HanhDongDocGia.Size = new System.Drawing.Size(252, 76);
            this.btn_HanhDongDocGia.TabIndex = 15;
            this.btn_HanhDongDocGia.Text = "Thêm độc giả";
            this.btn_HanhDongDocGia.UseVisualStyleBackColor = false;
            this.btn_HanhDongDocGia.Click += new System.EventHandler(this.btn_HanhDongDocGia_Click);
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(73, 181);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(118, 25);
            this.lblMaDocGia.TabIndex = 16;
            this.lblMaDocGia.Text = "Mã độc giả";
            // 
            // tbMaDocGia
            // 
            this.tbMaDocGia.Location = new System.Drawing.Point(251, 175);
            this.tbMaDocGia.Name = "tbMaDocGia";
            this.tbMaDocGia.Size = new System.Drawing.Size(265, 31);
            this.tbMaDocGia.TabIndex = 17;
            // 
            // tbMaTK
            // 
            this.tbMaTK.Location = new System.Drawing.Point(795, 175);
            this.tbMaTK.Name = "tbMaTK";
            this.tbMaTK.Size = new System.Drawing.Size(204, 31);
            this.tbMaTK.TabIndex = 18;
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Location = new System.Drawing.Point(596, 176);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(146, 25);
            this.lblMaTK.TabIndex = 19;
            this.lblMaTK.Text = "Mã Tài Khoản";
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(835, 563);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(252, 76);
            this.btnThemTaiKhoan.TabIndex = 20;
            this.btnThemTaiKhoan.Text = "Thêm tài khoản";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // ChiTietDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 703);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.lblMaTK);
            this.Controls.Add(this.tbMaTK);
            this.Controls.Add(this.tbMaDocGia);
            this.Controls.Add(this.lblMaDocGia);
            this.Controls.Add(this.btn_HanhDongDocGia);
            this.Controls.Add(this.cbbLoaiDocGia);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.lblLoaiDocGia);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lbtTenDocGia);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "ChiTietDocGia";
            this.Text = "ChiTietDocGia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lbtTenDocGia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblLoaiDocGia;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        protected System.Windows.Forms.ComboBox cbbLoaiDocGia;
        private System.Windows.Forms.Button btn_HanhDongDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.TextBox tbMaDocGia;
        private System.Windows.Forms.TextBox tbMaTK;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Button btnThemTaiKhoan;
    }
}