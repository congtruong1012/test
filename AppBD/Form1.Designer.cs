namespace AppBD
{
    partial class frmAppBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppBD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dtpNgayLay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnLayMa = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.txtGioLay = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dtgvThongTin = new System.Windows.Forms.DataGridView();
            this.txtTimTheoTen = new System.Windows.Forms.TextBox();
            this.dtpTimTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.nbTimTheoGio = new System.Windows.Forms.NumericUpDown();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.btnTimTheoGio = new System.Windows.Forms.Button();
            this.btnTimTheoNgay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTimTheoGio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Lượng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(381, 11);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 20);
            this.txtGhiChu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giờ Lấy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Lấy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(569, 50);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(338, 94);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(452, 94);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(569, 94);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(221, 94);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 17;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(81, 7);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(215, 20);
            this.txtTenKH.TabIndex = 0;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(247, 49);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(49, 20);
            this.txtSL.TabIndex = 4;
            // 
            // dtpNgayLay
            // 
            this.dtpNgayLay.CustomFormat = "dd/MM/yyy";
            this.dtpNgayLay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLay.Location = new System.Drawing.Point(569, 12);
            this.dtpNgayLay.Name = "dtpNgayLay";
            this.dtpNgayLay.Size = new System.Drawing.Size(170, 20);
            this.dtpNgayLay.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "MaKH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(81, 49);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(101, 20);
            this.txtMaKH.TabIndex = 22;
            // 
            // btnLayMa
            // 
            this.btnLayMa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLayMa.Location = new System.Drawing.Point(12, 94);
            this.btnLayMa.Name = "btnLayMa";
            this.btnLayMa.Size = new System.Drawing.Size(72, 23);
            this.btnLayMa.TabIndex = 23;
            this.btnLayMa.Text = "Lấy Mã";
            this.btnLayMa.UseVisualStyleBackColor = false;
            this.btnLayMa.Click += new System.EventHandler(this.BtnLayMa_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(107, 94);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(75, 23);
            this.btnDatLai.TabIndex = 24;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.BtnDatLai_Click);
            // 
            // txtGioLay
            // 
            this.txtGioLay.Location = new System.Drawing.Point(381, 52);
            this.txtGioLay.Name = "txtGioLay";
            this.txtGioLay.Size = new System.Drawing.Size(80, 20);
            this.txtGioLay.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(685, 94);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // dtgvThongTin
            // 
            this.dtgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTin.Location = new System.Drawing.Point(8, 188);
            this.dtgvThongTin.Name = "dtgvThongTin";
            this.dtgvThongTin.Size = new System.Drawing.Size(869, 270);
            this.dtgvThongTin.TabIndex = 27;
            this.dtgvThongTin.SelectionChanged += new System.EventHandler(this.DtgvThongTin_SelectionChanged);
            // 
            // txtTimTheoTen
            // 
            this.txtTimTheoTen.Location = new System.Drawing.Point(26, 150);
            this.txtTimTheoTen.Name = "txtTimTheoTen";
            this.txtTimTheoTen.Size = new System.Drawing.Size(215, 20);
            this.txtTimTheoTen.TabIndex = 28;
            // 
            // dtpTimTheoNgay
            // 
            this.dtpTimTheoNgay.CustomFormat = "dd/MM/yyy";
            this.dtpTimTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimTheoNgay.Location = new System.Drawing.Point(590, 150);
            this.dtpTimTheoNgay.Name = "dtpTimTheoNgay";
            this.dtpTimTheoNgay.Size = new System.Drawing.Size(170, 20);
            this.dtpTimTheoNgay.TabIndex = 29;
            // 
            // nbTimTheoGio
            // 
            this.nbTimTheoGio.Location = new System.Drawing.Point(361, 150);
            this.nbTimTheoGio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nbTimTheoGio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbTimTheoGio.Name = "nbTimTheoGio";
            this.nbTimTheoGio.Size = new System.Drawing.Size(120, 20);
            this.nbTimTheoGio.TabIndex = 30;
            this.nbTimTheoGio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Location = new System.Drawing.Point(260, 150);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(75, 23);
            this.btnTimTheoTen.TabIndex = 31;
            this.btnTimTheoTen.Text = "Tìm theo tên";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.BtnTimTheoTen_Click);
            // 
            // btnTimTheoGio
            // 
            this.btnTimTheoGio.Location = new System.Drawing.Point(496, 150);
            this.btnTimTheoGio.Name = "btnTimTheoGio";
            this.btnTimTheoGio.Size = new System.Drawing.Size(75, 23);
            this.btnTimTheoGio.TabIndex = 32;
            this.btnTimTheoGio.Text = "Tìm theo giờ";
            this.btnTimTheoGio.UseVisualStyleBackColor = true;
            this.btnTimTheoGio.Click += new System.EventHandler(this.BtnTimTheoGio_Click);
            // 
            // btnTimTheoNgay
            // 
            this.btnTimTheoNgay.Location = new System.Drawing.Point(778, 148);
            this.btnTimTheoNgay.Name = "btnTimTheoNgay";
            this.btnTimTheoNgay.Size = new System.Drawing.Size(87, 23);
            this.btnTimTheoNgay.TabIndex = 33;
            this.btnTimTheoNgay.Text = "Tìm theo ngày";
            this.btnTimTheoNgay.UseVisualStyleBackColor = true;
            this.btnTimTheoNgay.Click += new System.EventHandler(this.BtnTimTheoNgay_Click);
            // 
            // frmAppBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.btnTimTheoNgay);
            this.Controls.Add(this.btnTimTheoGio);
            this.Controls.Add(this.btnTimTheoTen);
            this.Controls.Add(this.nbTimTheoGio);
            this.Controls.Add(this.dtpTimTheoNgay);
            this.Controls.Add(this.txtTimTheoTen);
            this.Controls.Add(this.dtgvThongTin);
            this.Controls.Add(this.txtGioLay);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnLayMa);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayLay);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppBD";
            this.Text = "AppBD";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTimTheoGio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DateTimePicker dtpNgayLay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnLayMa;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.TextBox txtGioLay;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dtgvThongTin;
        private System.Windows.Forms.TextBox txtTimTheoTen;
        private System.Windows.Forms.DateTimePicker dtpTimTheoNgay;
        private System.Windows.Forms.NumericUpDown nbTimTheoGio;
        private System.Windows.Forms.Button btnTimTheoTen;
        private System.Windows.Forms.Button btnTimTheoGio;
        private System.Windows.Forms.Button btnTimTheoNgay;
    }
}

