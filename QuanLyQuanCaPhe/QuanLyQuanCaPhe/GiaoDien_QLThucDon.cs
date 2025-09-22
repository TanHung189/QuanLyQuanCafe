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
    public partial class GiaoDien_QLThucDon : Form
    {
        public GiaoDien_QLThucDon()
        {
            InitializeComponent();
        }
      
        string maThucDon = "";

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GiaoDien_QLThucDon_Load(object sender, EventArgs e)
        {
            HienThiDGV();
            batTat(true);
        }

        private void HienThiDGV()
        {

         

            // Binding dữ liệu lên các điều khiển khác (TextBoxes, ComboBox, etc.)
            List<DanhMucThucDon_DTO> lstDanhMuc = DanhMucThucDon_BUS.LayDanhMuc();
            cboDanhMuc.DataSource = lstDanhMuc;
            cboDanhMuc.DisplayMember = "STenDanhMuc";      // Hiển thị tên danh mục
            cboDanhMuc.ValueMember = "IMaDanhMuc";          // Gán giá trị là ID
            cboDanhMuc.SelectedIndex = -1;

            List<ThucDon_DTO> lstThucDon = ThucDon_BUS.LayThucDon();

            // Liên kết dữ liệu vào DataGridView
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lstThucDon;
            dgv_ThucDon.DataSource = bindingSource;


            // Hiển thị dữ liệu vào DataGridView

            // Liên kết dữ liệu từ DataGridView lên các control
            txtMaThucDon.DataBindings.Clear();
            txtTenThucDon.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            cboDanhMuc.DataBindings.Clear();

            cboDanhMuc.DataBindings.Add("SelectedValue", bindingSource, "IMaDanhMuc", true, DataSourceUpdateMode.Never);
            txtMaThucDon.DataBindings.Add("Text", bindingSource, "IMaThucDon", false, DataSourceUpdateMode.Never);
            txtSoLuong.DataBindings.Add("Text", bindingSource, "ISoLuong", false, DataSourceUpdateMode.Never);
            txtTenThucDon.DataBindings.Add("Text", bindingSource, "STenMon", false, DataSourceUpdateMode.Never);
            txtGia.DataBindings.Add("Text", bindingSource, "FGia", false, DataSourceUpdateMode.Never);

        }
       
        private void batTat(bool giaTri)
        {
            txtMaThucDon.Enabled = false;
            cboDanhMuc.Enabled = !giaTri;
            txtGia.Enabled = !giaTri;
            txtTenThucDon.Enabled = !giaTri;
            txtSoLuong.Enabled = !giaTri;
            btnLuu.Enabled = !giaTri;
            btnHuy.Enabled = !giaTri;

            btnThem.Enabled = giaTri;
            btnSua.Enabled = giaTri;
            btnXoa.Enabled = giaTri;
        }
        #region nút chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Đánh dấu là Thêm mới
            maThucDon = "";

            // Xóa trắng các trường
            txtMaThucDon.Clear();
            txtTenThucDon.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
            txtMaThucDon.Focus();
            batTat(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtTenThucDon.Text))
            {
                MessageBox.Show("Tên thực đơn không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtGia.Text) || !decimal.TryParse(txtGia.Text, out _))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboDanhMuc.SelectedItem == null)
            {
                MessageBox.Show("Danh mục không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Số Lượng phải hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (soLuong < 0)
            {
                MessageBox.Show("Số Lượng phải hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ThucDon_DTO td = new ThucDon_DTO();
                    td.STenMon = txtTenThucDon.Text.Trim();
                    td.IMaDanhMuc = Convert.ToInt32(cboDanhMuc.SelectedValue);
                    td.ISoLuong = int.Parse(txtSoLuong.Text.Trim());
                    td.FGia = Convert.ToDecimal(txtGia.Text.Trim());
                    if (maThucDon == "") // Insert new record 
                    {
                        if (ThucDon_BUS.ThemThucDon(td))
                        {
                            MessageBox.Show(" Lưu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Lưu không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (ThucDon_BUS.SuaThucDon(td))
                        {
                            MessageBox.Show("Cập nhật thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Cập nhật không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GiaoDien_QLThucDon_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThucDon.Text))
            {
                MessageBox.Show("Vui lòng chọn thực đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa thực đơn {txtTenThucDon.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int maThucDon = int.Parse(txtMaThucDon.Text);

                    if (ThucDon_BUS.XoaThucDon(maThucDon))
                    {
                        MessageBox.Show("Xóa thực đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDGV();
                        
                        cboDanhMuc.SelectedIndex = -1;
                       
                    }
                    else
                    {
                        MessageBox.Show("Xóa thực đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thực đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            GiaoDien_QLThucDon_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Đánh dấu là Cập nhật
            maThucDon = txtMaThucDon.Text;

            // Bật/Tắt các controls
            batTat(false);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTimThucDon.Text;
            List<ThucDon_DTO> lsttd = ThucDon_BUS.TimThucDonTheoTen(ten);
            if (lsttd == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgv_ThucDon.DataSource = lsttd;

        }
    }
}
