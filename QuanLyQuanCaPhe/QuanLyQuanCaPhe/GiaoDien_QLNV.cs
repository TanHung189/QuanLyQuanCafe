using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_QLNV : Form
    {
        public GiaoDien_QLNV()
        {
            InitializeComponent();
            dgv.CellClick += new DataGridViewCellEventHandler(dgv_CellClick);
        }
        string MaNV = "";
       

        private void BatTat(bool giaTri)
        {
            btnthem.Enabled = giaTri;
            btnsua.Enabled = giaTri;
            btnxoa.Enabled = giaTri;
            btnghi.Enabled = !giaTri;
            btnlammoi.Enabled = !giaTri;

            // Vô hiệu hóa các textboxes và comboboxes ban đầu
            txtMaNV.Enabled = false;
            txtTen.Enabled = !giaTri;
            cboChucVu.Enabled = !giaTri;
            dtbNgaySinh.Enabled = !giaTri;
            txtDiaChi.Enabled = !giaTri;
            txtSoDienThoai.Enabled = !giaTri;
            txtEmail.Enabled = !giaTri;
            rdbnam.Enabled = !giaTri;
            rdbnu.Enabled = !giaTri;
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "GioiTinh")
            {
                // Assuming 1 represents "Nam" and 0 represents "Nữ"
                e.Value = Convert.ToByte(e.Value) == 1 ? "Nam" : "Nữ";
            }
        }


        private void GiaoDien_QLNV_Load(object sender, EventArgs e)
        {
            BatTat(true);
            
            HienThiDSNVlenDgv();

        }

        private void HienThiDSNVlenDgv()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            cboChucVu.DataSource = lstNhanVien;
            cboChucVu.DisplayMember = "SChucVu";
            cboChucVu.ValueMember = "SChucVu";

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lstNhanVien; ;
            dgv.DataSource = bindingSource;



            cboChucVu.DataBindings.Clear();
            txtMaNV.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            rdbnam.DataBindings.Clear();
            rdbnu.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Clear();
            dtbNgaySinh.DataBindings.Clear();
            txtEmail.DataBindings.Clear();

            cboChucVu.DataBindings.Add("SelectedValue", bindingSource, "SChucVu", true, DataSourceUpdateMode.Never);
            txtMaNV.DataBindings.Add("Text", bindingSource, "IMaNhanVien", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "SDiaChi", false, DataSourceUpdateMode.Never);
            txtTen.DataBindings.Add("Text", bindingSource, "SHoTen", false, DataSourceUpdateMode.Never);
            // Binding cho RadioButton "Nam"
            Binding nam = new Binding("Checked", dgv.DataSource, "SGioiTinh");
            nam.Format += (s, evt) =>
            {
                evt.Value = evt.Value?.ToString() == "Nam"; // Nếu giá trị là "Nam", Checked = true
            };
            rdbnam.DataBindings.Add(nam);

            // Binding cho RadioButton "Nữ"
            Binding nu = new Binding("Checked", dgv.DataSource, "SGioiTinh");
            nu.Format += (s, evt) =>
            {
                evt.Value = evt.Value?.ToString() == "Nữ"; // Nếu giá trị là "Nữ", Checked = true
            };
            rdbnu.DataBindings.Add(nu);

            txtSoDienThoai.DataBindings.Add("Text", bindingSource, "SSoDienThoai", false, DataSourceUpdateMode.Never);
            dtbNgaySinh.DataBindings.Add("Text", bindingSource, "DNgaySinh", false, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", bindingSource, "SEmail", false, DataSourceUpdateMode.Never);
            /*dgv.AutoGenerateColumns = true;

            dgv.Columns["IMaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgv.Columns["SHoTen"].HeaderText = "Họ Tên";
            dgv.Columns["DNgaySinh"].HeaderText = "Ngày Sinh";
            dgv.Columns["SGioiTinh"].HeaderText = "Giới Tính";
            dgv.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgv.Columns["SSoDienThoai"].HeaderText = "Số Điện Thoại";
            dgv.Columns["SEmail"].HeaderText = "Email";
            dgv.Columns["SChucVu"].HeaderText = "Chức Vụ";*/


            /*dgv.Columns["SMaHopDong"].Width = 120;
            dgv.Columns["SMSSV"].Width = 120;
            dgv.Columns["SMaPhong"].Width = 120;
            dgv.Columns["SNgayLamHopDong"].Width = 150;
            dgv.Columns["SNgayKetThucHopDong"].Width = 150;*/

            // Căn giữa tiêu đề cột
            /*dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn giữa tất cả các ô dữ liệu mặc định
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;*/
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            GiaoDien_QLNV_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MaNV = txtMaNV.Text;  // Lưu mã nhân viên hiện tại


            BatTat(false);

            txtTen.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnthem_Click_1(object sender, EventArgs e)
        {

            MaNV = "";
            // Xóa trắng các ô nhập liệu
            txtMaNV.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            dtbNgaySinh.Value = DateTime.Today;
            BatTat(false);
            btnghi.Enabled = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "")
                MessageBox.Show("Họ và tên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboChucVu.Text.Trim() == "")
                MessageBox.Show("Chức vụ không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDiaChi.Text.Trim() == "")
                MessageBox.Show("Địa chỉ không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtSoDienThoai.Text.Trim() == "")
                MessageBox.Show("Số Điện thoại không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtEmail.Text.Trim() == "")
                MessageBox.Show("Email không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {

                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.SHoTen = txtTen.Text;
                    nv.DNgaySinh = dtbNgaySinh.Value;
                    nv.SGioiTinh = (rdbnam.Checked ? "Nam" : "Nữ");
                    nv.SDiaChi = txtDiaChi.Text;
                    nv.SSoDienThoai = txtSoDienThoai.Text;
                    nv.SEmail = txtEmail.Text;
                    nv.SChucVu = cboChucVu.SelectedValue.ToString();
                    nv.IMaLoaiTaiKhoan = (cboChucVu.SelectedValue.ToString() == "Quan ly") ? 1 : 2; ;
                    if (MaNV == "") // Insert new record 
                    {
                        if (NhanVien_BUS.ThemNhanVien(nv))
                        {
                            MessageBox.Show(" Lưu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Lưu không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (NhanVien_BUS.SuaNhanVien(nv))
                        {
                            MessageBox.Show("Cập nhật thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Cập nhật không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GiaoDien_QLNV_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {txtTen.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int maNhanVien = int.Parse(txtMaNV.Text);

                    if (NhanVien_BUS.XoaNhanVien(maNhanVien))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSNVlenDgv();
                        btnghi.Enabled = false;
                        txtMaNV.Clear();
                        txtTen.Clear();
                        txtDiaChi.Clear();
                        txtSoDienThoai.Clear();
                        txtEmail.Clear();
                        cboChucVu.SelectedIndex = -1;
                        dtbNgaySinh.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTimNhanVien.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgv.DataSource = lstnv;

        }
    }
}
