namespace QuanLyQuanCaPhe
{
    partial class GiaoDien_BcThucDon
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
            this.thucDonTableAdapter1 = new QuanLyQuanCaPhe.QuanLyQuanCaPhe_THDataSetTableAdapters.ThucDonTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyQuanCaPhe_THDataSet = new QuanLyQuanCaPhe.QuanLyQuanCaPhe_THDataSet();
            this.thucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKChiTietHoMonAn71D1E811BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPhe_THDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.thucDonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKChiTietHoMonAn71D1E811BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // thucDonTableAdapter1
            // 
            this.thucDonTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thucDonBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaPhe.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(789, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyQuanCaPhe_THDataSet
            // 
            this.quanLyQuanCaPhe_THDataSet.DataSetName = "QuanLyQuanCaPhe_THDataSet";
            this.quanLyQuanCaPhe_THDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thucDonBindingSource
            // 
            this.thucDonBindingSource.DataMember = "ThucDon";
            this.thucDonBindingSource.DataSource = this.quanLyQuanCaPhe_THDataSet;
            // 
            // fKChiTietHoMonAn71D1E811BindingSource
            // 
            this.fKChiTietHoMonAn71D1E811BindingSource.DataMember = "FK__ChiTietHo__MonAn__71D1E811";
            this.fKChiTietHoMonAn71D1E811BindingSource.DataSource = this.thucDonBindingSource;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // thucDonBindingSource1
            // 
            this.thucDonBindingSource1.DataMember = "ThucDon";
            this.thucDonBindingSource1.DataSource = this.quanLyQuanCaPhe_THDataSet;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.quanLyQuanCaPhe_THDataSet;
            // 
            // GiaoDien_BcThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 398);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GiaoDien_BcThucDon";
            this.Text = "GiaoDien_BcThucDon";
            this.Load += new System.EventHandler(this.GiaoDien_BcThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKChiTietHoMonAn71D1E811BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyQuanCaPhe_THDataSetTableAdapters.ThucDonTableAdapter thucDonTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource thucDonBindingSource;
        private QuanLyQuanCaPhe_THDataSet quanLyQuanCaPhe_THDataSet;
        private System.Windows.Forms.BindingSource fKChiTietHoMonAn71D1E811BindingSource;
        private QuanLyQuanCaPhe_THDataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource thucDonBindingSource1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
    }
}