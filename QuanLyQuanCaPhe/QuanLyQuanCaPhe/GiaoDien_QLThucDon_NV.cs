using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_QLThucDon_NV : Form
    {
        public GiaoDien_QLThucDon_NV()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        MyDataTable dataTable = new MyDataTable();  
        private void GiaoDien_QLThucDon_NV_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void LayDuLieu()
        {
            List<ThucDon_DTO> lsttd = ThucDon_BUS.LayThucDon();
            dgv_ThucDon.DataSource = lsttd;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemAnh_Click(object sender, EventArgs e)
        {

            panel_XemAnh.Visible = true;
            btnXemAnh.Visible = false;
            panel_XemAnh.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cà Phê Đen", "Thực Đơn");
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {

            panel_XemAnh.Visible = false;
            btnXemAnh.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cà Phê Nâu(H/I) | 30000 Vnd", "Thực Đơn");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cà Phê Cốt Dừa | 55000 vnd", "Thực Đơn");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cà Phê Bạc Xỉu | 39000 vnd", "Thực Đơn");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cà Phê Hạt Dẻ | 59000 vnd", "Thực Đơn");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hồng Trà Trân Châu | 30000 vnd", "Thực Đơn");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trà Thạch Đào | 30000 vnd", "Thực Đơn");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nước Ép Cam Tươi | 30000 vnd", "Thực Đơn");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trà Kiwi Nha Đam  | 55000 vnd", "Thực Đơn");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trà Thanh Long | 55000 vnd", "Thực Đơn");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nước Chanh Leo  | 35000 vnd", "Thực Đơn");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nước Dừa Tươi | 35000 vnd", "Thực Đơn");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nước Ép Dưa Hấu | 55000 vnd", "Thực Đơn");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mojito | 55000 vnd", "Thực Đơn");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mojito (đặc biệt) | 65000 vnd", "Thực Đơn");
        }
    }
}
