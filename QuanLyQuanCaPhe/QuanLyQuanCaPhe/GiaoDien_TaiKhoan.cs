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
    public partial class GiaoDien_TaiKhoan : Form
    {
        public GiaoDien_TaiKhoan()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        MyDataTable dataTable = new MyDataTable();
        string maTaiKhoan = "";

        private void BatTat(bool giaTri)
        {
            txtMaTaiKhoan.Enabled = false;
            txtTenHienThi.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            txtMaNhanVien.Enabled = false;
            cboQuyenHan.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayDuLieu()
        {
            List<TaiKhoan_DTO> lstnv = TaiKhoan_BUS.LayDSTaiKhoan();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lstnv;
            dgv_TaiKhoan.DataSource = bindingSource;

            List<LoaiTaiKhoan_DTO> lstLtk = LoaiTaiKhoan_BUS.LayLoaiTaiKhoan();

            cboQuyenHan.DataSource = lstLtk;
            cboQuyenHan.DisplayMember = "STenLoai";
            cboQuyenHan.ValueMember = "IMaLoaiTaiKhoan";
            cboQuyenHan.SelectedIndex = -1;

            txtMaTaiKhoan.DataBindings.Clear();
            txtTenHienThi.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();

            cboQuyenHan.DataBindings.Add("SelectedValue", bindingSource, "ILoaiTaiKhoan", true, DataSourceUpdateMode.Never);
            txtMaTaiKhoan.DataBindings.Add("Text", bindingSource, "IMaTaiKhoan", true, DataSourceUpdateMode.Never);
            txtTenHienThi.DataBindings.Add("Text", bindingSource, "STenHienThi", true, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "STenDangNhap", true, DataSourceUpdateMode.Never);
            txtMatKhau.DataBindings.Add("Text", bindingSource, "SMatKhau", true, DataSourceUpdateMode.Never);
            txtGhiChu.DataBindings.Add("Text", bindingSource, "SGhiChu", true, DataSourceUpdateMode.Never);
            txtMaNhanVien.DataBindings.Add("Text", bindingSource, "IMaNhanVien", true, DataSourceUpdateMode.Never);
        }

       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenHienThi.Text.Trim() == "")
                MessageBox.Show("Họ và tên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtTenDangNhap.Text.Trim() == "")
                MessageBox.Show("Tên đăng nhập không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtMatKhau.Text.Trim() == "")
                MessageBox.Show("Mật khẩu không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboQuyenHan.Text.Trim() == "")
                MessageBox.Show("Quyền hạn không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    TaiKhoan_DTO tk = new TaiKhoan_DTO();
                    tk.STenDangNhap = txtTenDangNhap.Text.Trim();
                    tk.STenHienThi = txtTenHienThi.Text.Trim();
                    tk.SMatKhau = txtMatKhau.Text.Trim();
                    tk.ILoaiTaiKhoan = Convert.ToInt32(cboQuyenHan.SelectedValue);
                    tk.SGhiChu = txtGhiChu.Text.Trim();
                    tk.IMaNhanVien = Convert.ToInt32(txtMaNhanVien.Text);

                
                    if (maTaiKhoan == "")  
                    {
                        if (TaiKhoan_BUS.ThemTaiKhoan(tk))
                        {
                            MessageBox.Show(" Lưu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Lưu không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (TaiKhoan_BUS.SuaTaiKhoan(tk))
                        {
                            MessageBox.Show("Cập nhật thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Cập nhật không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GiaoDien_TaiKhoan_Load_1(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GiaoDien_TaiKhoan_Load_1(object sender, EventArgs e)
        {
            dgv_TaiKhoan.AutoGenerateColumns = true;
            LayDuLieu();
            BatTat(false);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            maTaiKhoan = "";  
    
            txtMaTaiKhoan.Clear();
            txtTenHienThi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtGhiChu.Clear();
            txtMaNhanVien.Clear();
            cboQuyenHan.SelectedIndex = -1;  
            txtMaTaiKhoan.Focus();
            BatTat(true);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            maTaiKhoan = txtMaTaiKhoan.Text;
            BatTat(true);
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            GiaoDien_TaiKhoan_Load_1(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int maTaiKhoan = int.Parse(txtMaTaiKhoan.Text);

            if (TaiKhoan_BUS.XoaTaiKhoan(maTaiKhoan))
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDuLieu();  // load lại danh sách tài khoản
                BatTat(false);
 
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenDN = txtTimTaiKhoan.Text;

            List<TaiKhoan_DTO> lsttk = TaiKhoan_BUS.TimTaiKhoanTheoTenDN(tenDN);
            if (lsttk == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgv_TaiKhoan.DataSource = lsttk ;
        }
    }
}
