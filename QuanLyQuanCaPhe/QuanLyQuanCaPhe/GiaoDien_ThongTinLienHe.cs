using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_ThongTinLienHe : Form
    {
        public GiaoDien_ThongTinLienHe()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.linkedin.com/in/b%C3%B9i-%C4%91%E1%BB%97-t%E1%BA%A5n-h%C6%B0ng-634832319/";

            // Mở URL bằng trình duyệt mặc định
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Yêu cầu mở bằng trình duyệt
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "mailto:hung_dth225658@student.agu.edu.vn?subject=Hello&body=How are you?";

            // Mở URL bằng trình duyệt mặc định
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Yêu cầu mở bằng trình duyệt
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "mailto:luan_dth225690@student.agu.edu.vn?subject=Hello&body=How are you?";

            // Mở URL bằng trình duyệt mặc định
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true 
            });
        }

        private void GiaoDien_ThongTinLienHe_Load(object sender, EventArgs e)
        {

        }
    }
}
