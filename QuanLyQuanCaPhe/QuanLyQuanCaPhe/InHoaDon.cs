using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLyQuanCaPhe
{
    public partial class InHoaDon : Form
    {
        private DataTable reportData;
        private decimal tongTien;
        public InHoaDon(DataTable dt, decimal tongTien)
        {
            InitializeComponent();

            this.reportData = dt;
            this.tongTien = tongTien;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // Tạo DataSet tạm để đổ dữ liệu
                DataSet ds = new DataSet();
                ds.Tables.Add(reportData);

                // Đường dẫn hoặc EmbeddedResource file RDLC của bạn
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaPhe.rp_InHoaDon.rdlc";

                // Thêm nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource("Dataset_InHoaDon", ds.Tables["report"]);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Truyền tham số tổng tiền vào báo cáo
                ReportParameter rpTongTien = new ReportParameter("TongTien", tongTien.ToString("N0"));
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rpTongTien });

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
