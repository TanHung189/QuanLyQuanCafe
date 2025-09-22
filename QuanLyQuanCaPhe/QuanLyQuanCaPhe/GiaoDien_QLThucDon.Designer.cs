namespace QuanLyQuanCaPhe
{
    partial class GiaoDien_QLThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien_QLThucDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ThucDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimThucDon = new System.Windows.Forms.TextBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenThucDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaThucDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_ThucDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 248);
            this.panel1.TabIndex = 0;
            // 
            // dgv_ThucDon
            // 
            this.dgv_ThucDon.AllowUserToAddRows = false;
            this.dgv_ThucDon.AllowUserToDeleteRows = false;
            this.dgv_ThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThucDon.Location = new System.Drawing.Point(0, 0);
            this.dgv_ThucDon.Name = "dgv_ThucDon";
            this.dgv_ThucDon.ReadOnly = true;
            this.dgv_ThucDon.Size = new System.Drawing.Size(790, 248);
            this.dgv_ThucDon.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cboDanhMuc);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTenThucDon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMaThucDon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 189);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTimThucDon);
            this.groupBox1.Location = new System.Drawing.Point(17, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 52);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Thực Đơn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhập tên thực đơn:";
            // 
            // txtTimThucDon
            // 
            this.txtTimThucDon.Location = new System.Drawing.Point(166, 15);
            this.txtTimThucDon.Multiline = true;
            this.txtTimThucDon.Name = "txtTimThucDon";
            this.txtTimThucDon.Size = new System.Drawing.Size(134, 25);
            this.txtTimThucDon.TabIndex = 0;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboDanhMuc.Location = new System.Drawing.Point(386, 64);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(112, 24);
            this.cboDanhMuc.TabIndex = 3;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(386, 111);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(112, 22);
            this.txtGia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Danh Mục";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(132, 157);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 22);
            this.txtSoLuong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng";
            // 
            // txtTenThucDon
            // 
            this.txtTenThucDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTenThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThucDon.Location = new System.Drawing.Point(132, 111);
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(121, 22);
            this.txtTenThucDon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Thực Đơn";
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMaThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThucDon.Location = new System.Drawing.Point(132, 64);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(121, 22);
            this.txtMaThucDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thực Đơn";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(664, 140);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 37);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(664, 85);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 37);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(664, 29);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 37);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(539, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 37);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(539, 86);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(539, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 37);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm thực đơn";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // GiaoDien_QLThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaoDien_QLThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực đơn";
            this.Load += new System.EventHandler(this.GiaoDien_QLThucDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ThucDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;

        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThucDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.TextBox txtTenThucDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimThucDon;
    }
}