namespace QuanLyQuanCaPhe
{
    partial class GiaoDien_BanHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien_BanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dataGridView_BanHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Ban = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.nurSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboThucDon = new System.Windows.Forms.ComboBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.Timer_BanHang = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BanHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTongSoLuong);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.dataGridView_BanHang);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 479);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoLuong.ForeColor = System.Drawing.Color.Red;
            this.txtTongSoLuong.Location = new System.Drawing.Point(184, 385);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.ReadOnly = true;
            this.txtTongSoLuong.Size = new System.Drawing.Size(148, 29);
            this.txtTongSoLuong.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(184, 420);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(148, 29);
            this.txtTongTien.TabIndex = 2;
            // 
            // dataGridView_BanHang
            // 
            this.dataGridView_BanHang.AllowUserToAddRows = false;
            this.dataGridView_BanHang.AllowUserToDeleteRows = false;
            this.dataGridView_BanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BanHang.Location = new System.Drawing.Point(0, 76);
            this.dataGridView_BanHang.Name = "dataGridView_BanHang";
            this.dataGridView_BanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BanHang.Size = new System.Drawing.Size(425, 285);
            this.dataGridView_BanHang.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblChucVu);
            this.panel2.Controls.Add(this.lblTenNV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 67);
            this.panel2.TabIndex = 0;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(9, 44);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(50, 13);
            this.lblChucVu.TabIndex = 6;
            this.lblChucVu.Text = "Tên NV :";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.ForeColor = System.Drawing.Color.White;
            this.lblTenNV.Location = new System.Drawing.Point(65, 44);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(35, 13);
            this.lblTenNV.TabIndex = 6;
            this.lblTenNV.Text = "label7";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(141, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "LH COFFEE";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Navy;
            this.lblTime.Location = new System.Drawing.Point(284, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(133, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "1/12/2024 14:16:43";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.btnHuyBan);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.flowLayoutPanel_Ban);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(426, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 479);
            this.panel3.TabIndex = 1;
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.BackColor = System.Drawing.Color.Chocolate;
            this.btnHuyBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBan.ForeColor = System.Drawing.Color.White;
            this.btnHuyBan.Location = new System.Drawing.Point(138, 402);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(97, 44);
            this.btnHuyBan.TabIndex = 5;
            this.btnHuyBan.Text = "Hủy Bàn";
            this.btnHuyBan.UseVisualStyleBackColor = false;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Chocolate;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(416, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 47);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Chocolate;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(255, 402);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(97, 44);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // flowLayoutPanel_Ban
            // 
            this.flowLayoutPanel_Ban.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Ban.Location = new System.Drawing.Point(3, 76);
            this.flowLayoutPanel_Ban.Name = "flowLayoutPanel_Ban";
            this.flowLayoutPanel_Ban.Size = new System.Drawing.Size(519, 285);
            this.flowLayoutPanel_Ban.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.nurSoLuong);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cboThucDon);
            this.panel4.Controls.Add(this.cboDanhMuc);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 67);
            this.panel4.TabIndex = 0;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Location = new System.Drawing.Point(408, 7);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(102, 47);
            this.btnThemMon.TabIndex = 4;
            this.btnThemMon.Text = "Thêm thực đơn";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // nurSoLuong
            // 
            this.nurSoLuong.Location = new System.Drawing.Point(290, 22);
            this.nurSoLuong.Name = "nurSoLuong";
            this.nurSoLuong.Size = new System.Drawing.Size(92, 20);
            this.nurSoLuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thực đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục";
            // 
            // cboThucDon
            // 
            this.cboThucDon.FormattingEnabled = true;
            this.cboThucDon.Location = new System.Drawing.Point(93, 40);
            this.cboThucDon.Name = "cboThucDon";
            this.cboThucDon.Size = new System.Drawing.Size(121, 21);
            this.cboThucDon.TabIndex = 2;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(93, 6);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(121, 21);
            this.cboDanhMuc.TabIndex = 1;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // Timer_BanHang
            // 
            this.Timer_BanHang.Tick += new System.EventHandler(this.Timer_BanHang_Tick);
            // 
            // GiaoDien_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 479);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaoDien_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.GiaoDien_BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BanHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboThucDon;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown nurSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer Timer_BanHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Ban;
        private System.Windows.Forms.Button btnHuyBan;
        public System.Windows.Forms.DataGridView dataGridView_BanHang;
    }
}