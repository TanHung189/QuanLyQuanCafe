namespace QuanLyQuanCaPhe
{
    partial class GiaoDien_BcTaiKhoan
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
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QuanLyQuanCaPhe.QuanLyQuanCaPhe_THDataSetTableAdapters.TaiKhoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.taiKhoanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaPhe.Report3.rdlc";
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
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.quanLyQuanCaPhe_THDataSet;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // GiaoDien_BcTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 398);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GiaoDien_BcTaiKhoan";
            this.Text = "GiaoDien_BcTaiKhoan";
            this.Load += new System.EventHandler(this.GiaoDien_BcTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPhe_THDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyQuanCaPhe_THDataSet quanLyQuanCaPhe_THDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QuanLyQuanCaPhe_THDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
    }
}