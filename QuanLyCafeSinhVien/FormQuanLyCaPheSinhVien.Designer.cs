namespace QuanLyCafeSinhVien
{
    partial class FormQuanLyCaPheSinhVien
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
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoKhachHang = new System.Windows.Forms.TextBox();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.grpNuocUong = new System.Windows.Forms.GroupBox();
            this.grpThucAn = new System.Windows.Forms.GroupBox();
            this.radCafeDen = new System.Windows.Forms.RadioButton();
            this.radCafeDa = new System.Windows.Forms.RadioButton();
            this.radCafeSua = new System.Windows.Forms.RadioButton();
            this.radCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.radCafeKem = new System.Windows.Forms.RadioButton();
            this.chkBanhMyTrung = new System.Windows.Forms.CheckBox();
            this.chkBanhMyCa = new System.Windows.Forms.CheckBox();
            this.chkMyTomTrung = new System.Windows.Forms.CheckBox();
            this.chkMyXaoBo = new System.Windows.Forms.CheckBox();
            this.chkMyCay = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongKhach = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoKhachDaThanhToan = new System.Windows.Forms.Label();
            this.lblTienDaThanhToan = new System.Windows.Forms.Label();
            this.grpNuocUong.SuspendLayout();
            this.grpThucAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblTieuDe.Location = new System.Drawing.Point(327, 22);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(378, 51);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CAFE SINH VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(52, 110);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(184, 25);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoKhachHang.Location = new System.Drawing.Point(51, 164);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(171, 25);
            this.lblSoKhachHang.TabIndex = 2;
            this.lblSoKhachHang.Text = "Số Khách Hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(262, 110);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(494, 22);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // txtSoKhachHang
            // 
            this.txtSoKhachHang.Location = new System.Drawing.Point(262, 164);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.Size = new System.Drawing.Size(494, 22);
            this.txtSoKhachHang.TabIndex = 4;
            this.txtSoKhachHang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSoKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoKhachHang_KeyPress);
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinhVien.Location = new System.Drawing.Point(634, 206);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(122, 26);
            this.chkSinhVien.TabIndex = 5;
            this.chkSinhVien.Text = "Sinh Viên ?";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // grpNuocUong
            // 
            this.grpNuocUong.Controls.Add(this.radCafeKem);
            this.grpNuocUong.Controls.Add(this.radCafeSuaDa);
            this.grpNuocUong.Controls.Add(this.radCafeSua);
            this.grpNuocUong.Controls.Add(this.radCafeDa);
            this.grpNuocUong.Controls.Add(this.radCafeDen);
            this.grpNuocUong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuocUong.Location = new System.Drawing.Point(57, 243);
            this.grpNuocUong.Name = "grpNuocUong";
            this.grpNuocUong.Size = new System.Drawing.Size(351, 283);
            this.grpNuocUong.TabIndex = 6;
            this.grpNuocUong.TabStop = false;
            this.grpNuocUong.Text = "Nước uống";
            // 
            // grpThucAn
            // 
            this.grpThucAn.Controls.Add(this.chkMyCay);
            this.grpThucAn.Controls.Add(this.chkMyXaoBo);
            this.grpThucAn.Controls.Add(this.chkMyTomTrung);
            this.grpThucAn.Controls.Add(this.chkBanhMyCa);
            this.grpThucAn.Controls.Add(this.chkBanhMyTrung);
            this.grpThucAn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThucAn.Location = new System.Drawing.Point(577, 243);
            this.grpThucAn.Name = "grpThucAn";
            this.grpThucAn.Size = new System.Drawing.Size(351, 283);
            this.grpThucAn.TabIndex = 7;
            this.grpThucAn.TabStop = false;
            this.grpThucAn.Text = "Thức ăn";
            // 
            // radCafeDen
            // 
            this.radCafeDen.AutoSize = true;
            this.radCafeDen.Location = new System.Drawing.Point(16, 42);
            this.radCafeDen.Name = "radCafeDen";
            this.radCafeDen.Size = new System.Drawing.Size(95, 24);
            this.radCafeDen.TabIndex = 0;
            this.radCafeDen.TabStop = true;
            this.radCafeDen.Text = "Cafe đen";
            this.radCafeDen.UseVisualStyleBackColor = true;
            // 
            // radCafeDa
            // 
            this.radCafeDa.AutoSize = true;
            this.radCafeDa.Location = new System.Drawing.Point(16, 123);
            this.radCafeDa.Name = "radCafeDa";
            this.radCafeDa.Size = new System.Drawing.Size(86, 24);
            this.radCafeDa.TabIndex = 1;
            this.radCafeDa.TabStop = true;
            this.radCafeDa.Text = "Cafe đá";
            this.radCafeDa.UseVisualStyleBackColor = true;
            // 
            // radCafeSua
            // 
            this.radCafeSua.AutoSize = true;
            this.radCafeSua.Location = new System.Drawing.Point(16, 204);
            this.radCafeSua.Name = "radCafeSua";
            this.radCafeSua.Size = new System.Drawing.Size(94, 24);
            this.radCafeSua.TabIndex = 2;
            this.radCafeSua.TabStop = true;
            this.radCafeSua.Text = "Cafe sữa";
            this.radCafeSua.UseVisualStyleBackColor = true;
            // 
            // radCafeSuaDa
            // 
            this.radCafeSuaDa.AutoSize = true;
            this.radCafeSuaDa.Location = new System.Drawing.Point(205, 42);
            this.radCafeSuaDa.Name = "radCafeSuaDa";
            this.radCafeSuaDa.Size = new System.Drawing.Size(116, 24);
            this.radCafeSuaDa.TabIndex = 3;
            this.radCafeSuaDa.TabStop = true;
            this.radCafeSuaDa.Text = "Cafe sữa đá";
            this.radCafeSuaDa.UseVisualStyleBackColor = true;
            // 
            // radCafeKem
            // 
            this.radCafeKem.AutoSize = true;
            this.radCafeKem.Location = new System.Drawing.Point(205, 123);
            this.radCafeKem.Name = "radCafeKem";
            this.radCafeKem.Size = new System.Drawing.Size(100, 24);
            this.radCafeKem.TabIndex = 4;
            this.radCafeKem.TabStop = true;
            this.radCafeKem.Text = "Cafe kem";
            this.radCafeKem.UseVisualStyleBackColor = true;
            // 
            // chkBanhMyTrung
            // 
            this.chkBanhMyTrung.AutoSize = true;
            this.chkBanhMyTrung.Location = new System.Drawing.Point(17, 42);
            this.chkBanhMyTrung.Name = "chkBanhMyTrung";
            this.chkBanhMyTrung.Size = new System.Drawing.Size(140, 24);
            this.chkBanhMyTrung.TabIndex = 0;
            this.chkBanhMyTrung.Text = "Bánh mỳ trứng";
            this.chkBanhMyTrung.UseVisualStyleBackColor = true;
            // 
            // chkBanhMyCa
            // 
            this.chkBanhMyCa.AutoSize = true;
            this.chkBanhMyCa.Location = new System.Drawing.Point(17, 123);
            this.chkBanhMyCa.Name = "chkBanhMyCa";
            this.chkBanhMyCa.Size = new System.Drawing.Size(118, 24);
            this.chkBanhMyCa.TabIndex = 1;
            this.chkBanhMyCa.Text = "Bánh mỳ cá";
            this.chkBanhMyCa.UseVisualStyleBackColor = true;
            // 
            // chkMyTomTrung
            // 
            this.chkMyTomTrung.AutoSize = true;
            this.chkMyTomTrung.Location = new System.Drawing.Point(17, 205);
            this.chkMyTomTrung.Name = "chkMyTomTrung";
            this.chkMyTomTrung.Size = new System.Drawing.Size(132, 24);
            this.chkMyTomTrung.TabIndex = 2;
            this.chkMyTomTrung.Text = "Mỳ tôm trứng";
            this.chkMyTomTrung.UseVisualStyleBackColor = true;
            // 
            // chkMyXaoBo
            // 
            this.chkMyXaoBo.AutoSize = true;
            this.chkMyXaoBo.Location = new System.Drawing.Point(215, 42);
            this.chkMyXaoBo.Name = "chkMyXaoBo";
            this.chkMyXaoBo.Size = new System.Drawing.Size(109, 24);
            this.chkMyXaoBo.TabIndex = 3;
            this.chkMyXaoBo.Text = "Mỳ xào bò";
            this.chkMyXaoBo.UseVisualStyleBackColor = true;
            // 
            // chkMyCay
            // 
            this.chkMyCay.AutoSize = true;
            this.chkMyCay.Location = new System.Drawing.Point(215, 123);
            this.chkMyCay.Name = "chkMyCay";
            this.chkMyCay.Size = new System.Drawing.Size(86, 24);
            this.chkMyCay.TabIndex = 4;
            this.chkMyCay.Text = "Mỳ cay";
            this.chkMyCay.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(317, 558);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(108, 53);
            this.btnTinhTien.TabIndex = 8;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(484, 558);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(108, 53);
            this.btnNhapLai.TabIndex = 9;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(648, 558);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(108, 53);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(820, 558);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 53);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongKhach
            // 
            this.lblTongKhach.AutoSize = true;
            this.lblTongKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongKhach.Location = new System.Drawing.Point(52, 638);
            this.lblTongKhach.Name = "lblTongKhach";
            this.lblTongKhach.Size = new System.Drawing.Size(198, 25);
            this.lblTongKhach.TabIndex = 12;
            this.lblTongKhach.Text = "Tổng Khách Hàng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(52, 686);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(242, 25);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "Tổng Tiền Thanh Toán";
            // 
            // lblSoKhachDaThanhToan
            // 
            this.lblSoKhachDaThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoKhachDaThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoKhachDaThanhToan.Location = new System.Drawing.Point(333, 638);
            this.lblSoKhachDaThanhToan.Name = "lblSoKhachDaThanhToan";
            this.lblSoKhachDaThanhToan.Size = new System.Drawing.Size(328, 26);
            this.lblSoKhachDaThanhToan.TabIndex = 14;
            this.lblSoKhachDaThanhToan.Text = "0";
            this.lblSoKhachDaThanhToan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSoKhachDaThanhToan.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTienDaThanhToan
            // 
            this.lblTienDaThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTienDaThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDaThanhToan.Location = new System.Drawing.Point(333, 686);
            this.lblTienDaThanhToan.Name = "lblTienDaThanhToan";
            this.lblTienDaThanhToan.Size = new System.Drawing.Size(328, 26);
            this.lblTienDaThanhToan.TabIndex = 15;
            this.lblTienDaThanhToan.Text = "0 VNĐ";
            this.lblTienDaThanhToan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 761);
            this.Controls.Add(this.lblTienDaThanhToan);
            this.Controls.Add(this.lblSoKhachDaThanhToan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTongKhach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grpThucAn);
            this.Controls.Add(this.grpNuocUong);
            this.Controls.Add(this.chkSinhVien);
            this.Controls.Add(this.txtSoKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblSoKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANH TOÁN CAFE SINH VIÊN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNuocUong.ResumeLayout(false);
            this.grpNuocUong.PerformLayout();
            this.grpThucAn.ResumeLayout(false);
            this.grpThucAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoKhachHang;
        private System.Windows.Forms.CheckBox chkSinhVien;
        private System.Windows.Forms.GroupBox grpNuocUong;
        private System.Windows.Forms.GroupBox grpThucAn;
        private System.Windows.Forms.RadioButton radCafeKem;
        private System.Windows.Forms.RadioButton radCafeSuaDa;
        private System.Windows.Forms.RadioButton radCafeSua;
        private System.Windows.Forms.RadioButton radCafeDa;
        private System.Windows.Forms.RadioButton radCafeDen;
        private System.Windows.Forms.CheckBox chkMyCay;
        private System.Windows.Forms.CheckBox chkMyXaoBo;
        private System.Windows.Forms.CheckBox chkMyTomTrung;
        private System.Windows.Forms.CheckBox chkBanhMyCa;
        private System.Windows.Forms.CheckBox chkBanhMyTrung;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongKhach;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoKhachDaThanhToan;
        private System.Windows.Forms.Label lblTienDaThanhToan;
    }
}

