using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DTO;
using BUS;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_ThanhToanHoaDon : Form
    {
        public GiaoDien_ThanhToanHoaDon(int maBan, int hoaDonId, decimal tongTien)
        {
            InitializeComponent();
            this.maBan = maBan;
            this.hoaDonId = hoaDonId;
            this.tongTien = tongTien;
        }

        private int maBan;
        private int hoaDonId;
        private decimal tongTien;


        private void GiaoDien_ThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            lblTableID.Text = $"Bàn: {maBan}";
            txtTongTien.Text = tongTien.ToString("N0", new CultureInfo("vi-VN")) + " VNĐ";
            lblLoggedInUserID.Text = $"Nhân viên: {GetLoggedInUserID()}";
            lblTableStatus.Text = "Chưa thanh toán";

        }

        public static class GlobalSession
        {
            public static int UserID { get; set; } = 1; 
        }

        private int GetLoggedInUserID()
        {
            return GlobalSession.UserID; // GlobalSession.UserID là ID của nhân viên đăng nhập
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tienKhachDua = 0;
                if (!decimal.TryParse(txtTienKhachDua.Text, out tienKhachDua) || tienKhachDua < 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal tongTienCanThanhToan = decimal.Parse(
                    txtTongTien.Text.Replace(" VNĐ", "").Replace(",", ""),
                    CultureInfo.InvariantCulture);

                if (tienKhachDua < tongTienCanThanhToan)
                {
                    MessageBox.Show("Số tiền khách đưa không đủ, vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật trạng thái hóa đơn đã thanh toán
                HoaDon_DTO hd = new HoaDon_DTO()
                {
                    IMaHoaDon = hoaDonId,
                    ITrangThai = 1,
                    IMaBan = maBan,
                    DThoiGianVao = DateTime.Now // hoặc giữ nguyên thời gian vào nếu cần
                };
                HoaDon_BUS.CapNhatHoaDon(hd);

                // Cập nhật trạng thái bàn thành "trong"
                Ban_BUS.CapNhatTrangThaiBan(maBan, "trong");

                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(txtTongTien.Text.Replace(" VNĐ", "").Replace(",", "")); // Tổng tiền ban đầu
            int discount = int.Parse(txtDiscount.Text); // Phần trăm giảm giá

            decimal finalTotal = total - (total * discount / 100);
            txtTongTien.Text = finalTotal.ToString("N0");
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy số tiền khách đưa từ ô nhập
                decimal tienKhachDua = 0;
                bool isNumeric = decimal.TryParse(txtTienKhachDua.Text, out tienKhachDua);

                if (!isNumeric || tienKhachDua < 0)
                {
                    lblTienThua.Text = "0 VNĐ"; // Hiển thị mặc định nếu nhập sai
                    return;
                }

                // Lấy tổng tiền cần thanh toán
                decimal tongTienCanThanhToan = decimal.TryParse(
                    txtTongTien.Text.Replace(" VNĐ", "").Replace(",", ""),
                    out tongTienCanThanhToan
                ) ? tongTienCanThanhToan : 0;

                // Tính tiền thừa
                decimal tienThua = tienKhachDua - tongTienCanThanhToan;

                // Hiển thị tiền thừa (Nếu tiền thừa âm, mặc định là 0)
                lblTienThua.Text = Math.Max(tienThua, 0).ToString("N0", new CultureInfo("vi-VN")) + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính tiền thừa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int maHoaDon = this.hoaDonId;  // Lấy ID hóa đơn thực tế

                // Lấy chi tiết hóa đơn
                DataTable dt = HoaDon_BUS.LayChiTietHoaDonTheoHoaDon(maHoaDon);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Hóa đơn không có dữ liệu để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Lấy tổng tiền hóa đơn
                decimal tongTien = HoaDon_BUS.TinhTongTienHoaDon(maHoaDon);

                // Mở form InHoaDon và truyền DataTable + tổng tiền
                InHoaDon frm = new InHoaDon(dt, tongTien);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
