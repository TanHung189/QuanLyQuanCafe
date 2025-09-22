namespace QuanLyQuanCaPhe
{
    partial class InHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.quanLyQuanCaPheTHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCaPhe_THDataSet = new QuanLyQuanCaPhe.QuanLyQuanCaPhe_THDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyQuanCaPhe.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new QuanLyQuanCaPhe.DataSet1TableAdapters.DataTable1TableAdapter();
            this.TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucDonDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheTHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyQuanCaPheTHDataSetBindingSource
            // 
            this.quanLyQuanCaPheTHDataSetBindingSource.DataSource = this.quanLyQuanCaPhe_THDataSet;
            this.quanLyQuanCaPheTHDataSetBindingSource.Position = 0;
            // 
            // quanLyQuanCaPhe_THDataSet
            // 
            this.quanLyQuanCaPhe_THDataSet.DataSetName = "QuanLyQuanCaPhe_THDataSet";
            this.quanLyQuanCaPhe_THDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dataset_InHoaDon";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaPhe.rp_InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(512, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // TaiKhoanBindingSource
            // 
            this.TaiKhoanBindingSource.DataMember = "TaiKhoan";
            this.TaiKhoanBindingSource.DataSource = this.quanLyQuanCaPhe_THDataSet;
            // 
            // chiTietHoaDonDTOBindingSource
            // 
            this.chiTietHoaDonDTOBindingSource.DataSource = typeof(DTO.ChiTietHoaDon_DTO);
            // 
            // hoaDonDTOBindingSource
            // 
            this.hoaDonDTOBindingSource.DataSource = typeof(DTO.HoaDon_DTO);
            // 
            // thucDonDTOBindingSource
            // 
            this.thucDonDTOBindingSource.DataSource = typeof(DTO.ThucDon_DTO);
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 437);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheTHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chiTietHoaDonDTOBindingSource;
        private System.Windows.Forms.BindingSource hoaDonDTOBindingSource;
        private System.Windows.Forms.BindingSource thucDonDTOBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource quanLyQuanCaPheTHDataSetBindingSource;
        private QuanLyQuanCaPhe_THDataSet quanLyQuanCaPhe_THDataSet;
        private System.Windows.Forms.BindingSource TaiKhoanBindingSource;
    }
}