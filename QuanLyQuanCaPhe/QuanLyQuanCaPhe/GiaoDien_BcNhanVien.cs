using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_BcNhanVien : Form
    {
        public GiaoDien_BcNhanVien()
        {
            InitializeComponent();
        }

        private void GiaoDien_BcNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCaPhe_THDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyQuanCaPhe_THDataSet.NhanVien);
            //nhanVienBindingSource.DataSource = NhanVien_BUS.LayNhanVien();
            this.reportViewer1.RefreshReport();
        }
    }
}
