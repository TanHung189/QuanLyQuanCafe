namespace QuanLyQuanCaPhe
{
    partial class GiaoDien_BcNhanVien
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyQuanCaPhe_THDataSet = new QuanLyQuanCaPhe.QuanLyQuanCaPhe_THDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPhe_THDataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaPhe.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(953, 405);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyQuanCaPhe_THDataSet
            // 
            this.quanLyQuanCaPhe_THDataSet.DataSetName = "QuanLyQuanCaPhe_THDataSet";
            this.quanLyQuanCaPhe_THDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyQuanCaPhe_THDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // GiaoDien_BcNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 415);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GiaoDien_BcNhanVien";
            this.Text = "GiaoDien_BcNhanVien";
            this.Load += new System.EventHandler(this.GiaoDien_BcNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyQuanCaPhe_THDataSet quanLyQuanCaPhe_THDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyQuanCaPhe_THDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}