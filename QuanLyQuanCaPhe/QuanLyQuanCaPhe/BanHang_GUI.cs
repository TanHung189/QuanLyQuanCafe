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
using System.Globalization;
using DTO;
using BUS;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_BanHang : Form
    {
        public GiaoDien_BanHang()
        {
            InitializeComponent();
           
        }

        int maban = 0;
 
        public void GiaoDien_BanHang_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_BanHang_Tick;
            timer.Start();
            nurSoLuong.Value = 1;

   
            dataGridView_BanHang.AutoGenerateColumns = true;
            dataGridView_BanHang.Columns.Clear();

            List<DanhMucThucDon_DTO> lstDanhMuc = DanhMucThucDon_BUS.LayDanhMuc();
            cboDanhMuc.DataSource = lstDanhMuc;
            cboDanhMuc.DisplayMember = "STenDanhMuc";
            cboDanhMuc.ValueMember = "IMaDanhMuc";

            List<ThucDon_DTO> lstThucDon = ThucDon_BUS.LayThucDon();
            cboThucDon.DataSource = lstThucDon;
            cboThucDon.DisplayMember = "STenMon";
            cboThucDon.ValueMember = "IMaThucDon";

            loadBan();

        }

        private void loadBan()
        {
            List<Ban_DTO> lstBan = Ban_BUS.LayBan();
            flowLayoutPanel_Ban.Controls.Clear();
            foreach (var ban in lstBan)
            {
                Button btnBan = new Button
                {

                    Text = ban.STenBan + ban.STrangThai,
                    BackColor = (ban.STrangThai == "trong" ? Color.White : Color.Yellow),
                    Tag = ban.IMaBan,
                    Width = 75,
                    Height = 75,
        
                    ImageAlign = ContentAlignment.MiddleCenter,  // Căn giữa ảnh trong button
                    TextAlign = ContentAlignment.MiddleCenter  // Căn chỉnh text dưới ảnh
                };
                btnBan.Click += BtnBan_Click;
                flowLayoutPanel_Ban.Controls.Add(btnBan);
            }
        }

        private void showHoaDon(int maban)
        {

            DataTable dtChiTiet = HoaDon_BUS.LayChiTietHoaDonTheoBan(maban);
            dataGridView_BanHang.DataSource = dtChiTiet;
            CapNhatTongTienVaSoLuong();
        }


      

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btnBan = (Button)sender;
            maban = (int)btnBan.Tag;

            // Lấy hóa đơn chưa thanh toán của bàn
            List<HoaDon_DTO> lstHoaDon = HoaDon_BUS.LayHoaDonTheoBan(maban);

            if (lstHoaDon == null || lstHoaDon.Count == 0)
            {
                
                HoaDon_DTO hd = new HoaDon_DTO()
                {
                    DThoiGianVao = DateTime.Now,
                    IMaBan = maban,
                    ITrangThai = 0
                };
                if (HoaDon_BUS.ThemHoaDon(hd))
                {
                    // Lấy lại hóa đơn mới tạo
                    lstHoaDon = HoaDon_BUS.LayHoaDonTheoBan(maban);
                }
                else
                {
                    MessageBox.Show("Không thể tạo hóa đơn cho bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
  
            int hoaDonId = lstHoaDon[0].IMaHoaDon;
            DataTable dtChiTiet = HoaDon_BUS.LayChiTietHoaDonTheoBan(maban);
            dataGridView_BanHang.DataSource = dtChiTiet;

            // Cập nhật tổng tiền và số lượng
            CapNhatTongTienVaSoLuong();

            btnBan.BackColor = Color.Yellow;

         
            Ban_BUS.CapNhatTrangThaiBan(maban, "co nguoi");
            loadBan();  
        }

      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_BanHang_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
      
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (maban == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboThucDon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maMonAn = (int)cboThucDon.SelectedValue;
            int soLuong = (int)nurSoLuong.Value;
            decimal donGia = ThucDon_BUS.LayGiaThucDon(maMonAn);

            if (donGia == -1)
            {
                MessageBox.Show("Không tìm thấy giá món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<HoaDon_DTO> lstHoaDon = HoaDon_BUS.LayHoaDonTheoBan(maban);
                int hoaDonId;

                if (lstHoaDon == null || lstHoaDon.Count == 0)
                {
                    // Tạo mới hóa đơn
                    HoaDon_DTO hoaDon = new HoaDon_DTO
                    {
                        DThoiGianVao = DateTime.Now,
                        IMaBan = maban,
                        ITrangThai = 0
                    };

                    if (!HoaDon_BUS.ThemHoaDon(hoaDon))
                    {
                        MessageBox.Show("Không thể tạo hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lstHoaDon = HoaDon_BUS.LayHoaDonTheoBan(maban);
                    hoaDonId = lstHoaDon[0].IMaHoaDon;
                }
                else
                {
                    hoaDonId = lstHoaDon[0].IMaHoaDon;
                }

                if (ChiTietHoaDon_BUS.CapNhatMon(hoaDonId, maMonAn, soLuong, donGia))
                {
                    HoaDon_BUS.CapNhatTongTienHoaDon(hoaDonId);
                    Ban_BUS.CapNhatTrangThaiBan(maban, "co nguoi");

                    showHoaDon(maban);
                    loadBan();

                    MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thêm món, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatTongTienVaSoLuong()
        {
            int totalQuantity = 0;
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView_BanHang.Rows)
            {
                if (row.IsNewRow) continue; // bỏ dòng mới

                int soLuong = 0;
                decimal donGia = 0;

                if (row.Cells["SoLuong"].Value != null)
                    int.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong);

                if (row.Cells["DonGia"].Value != null)
                    decimal.TryParse(row.Cells["DonGia"].Value.ToString(), out donGia);

                totalQuantity += soLuong;
                totalAmount += donGia * soLuong;
            }

            txtTongSoLuong.Text = totalQuantity.ToString();
            txtTongTien.Text = totalAmount.ToString("C2", CultureInfo.CurrentCulture);
        }
    
        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedValue != null && int.TryParse(cboDanhMuc.SelectedValue.ToString(), out int maDanhMuc))
            {
                List<ThucDon_DTO> lstFilteredThucDon = ThucDon_BUS.LayThucDonTheoDanhMuc(maDanhMuc);  
                 cboThucDon.DataSource = lstFilteredThucDon;
                cboThucDon.DisplayMember = "STenMon";   // Hiển thị tên món ăn
                cboThucDon.ValueMember = "IMaThucDon";  // Lưu giá trị ID của món ăn
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (maban == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy hóa đơn chưa thanh toán
            List<HoaDon_DTO> lstHoaDon = HoaDon_BUS.LayHoaDonTheoBan(maban);
            if (lstHoaDon == null || lstHoaDon.Count == 0)
            {
                MessageBox.Show("Bàn này chưa có hóa đơn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int hoaDonId = lstHoaDon[0].IMaHoaDon;  
            decimal tongTien = HoaDon_BUS.TinhTongTienHoaDon(hoaDonId);

            GiaoDien_ThanhToanHoaDon frmThanhToan = new GiaoDien_ThanhToanHoaDon(maban, hoaDonId, tongTien);
            frmThanhToan.ShowDialog();

         
            showHoaDon(maban);
            loadBan();
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            if (maban == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn hủy bàn này? Mọi món đã gọi sẽ bị xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool ketQua = HuyBan(maban);

                if (ketQua)
                {
                    MessageBox.Show("Hủy bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadBan();
                    dataGridView_BanHang.DataSource = null;
                    txtTongSoLuong.Text = "0";
                    txtTongTien.Text = "0";
                    maban = 0;
                }
                else
                {
                    MessageBox.Show("Hủy bàn không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static bool HuyBan(int maBan)
        {
            var lstHoaDon = HoaDon_BUS.LayHoaDonTheoBan(maBan);

            bool ketQuaXoaHoaDon = true;

            if (lstHoaDon != null)
            {
                foreach (var hd in lstHoaDon)
                {
                    bool xoaChiTiet = ChiTietHoaDon_BUS.XoaChiTietTheoHoaDon(hd.IMaHoaDon);
                    bool xoaHoaDon = HoaDon_BUS.XoaHoaDon(hd.IMaHoaDon);

                    if (!xoaChiTiet || !xoaHoaDon)
                        ketQuaXoaHoaDon = false;
                }
            }

            bool capNhatTrangThai = Ban_BUS.CapNhatTrangThaiBan(maBan, "trong");

            return ketQuaXoaHoaDon && capNhatTrangThai;
        }
        
    }
}
