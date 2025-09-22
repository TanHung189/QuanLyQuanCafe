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
    public partial class DangNhap_GUI : Form
    {
        public DangNhap_GUI()
        {
            InitializeComponent();
        }

        string hoVaTen = "";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void ckHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienMK.Checked == true)
                txtMatKhau.UseSystemPasswordChar = false;//hien thi dang ki tu
            else txtMatKhau.UseSystemPasswordChar = true;//hien thi dang mat khau
        }
    }
       
}