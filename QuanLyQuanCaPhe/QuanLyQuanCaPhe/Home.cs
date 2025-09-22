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
    public partial class Home : Form
    {

        private Bitmap[] images = new Bitmap[]
         {
            Properties.Resources.SlideHome1,
            Properties.Resources.SlideHome2,
            Properties.Resources.SlideHome3,
            Properties.Resources.SlideHome4,
            Properties.Resources.SlideHome5
         };


        private int currentImageIndex = 0;
        DangNhap_GUI dangNhap = null;
        string hoVaTen = "";
        string maNV = "0";
        public Home()
        {
            GiaoDien_Flash flash = new GiaoDien_Flash();
            flash.ShowDialog();
            InitializeComponent();
 
        }

        private void timer_home_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            picSlideHome.Image = images[currentImageIndex];
            
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += timer_home_Tick;
            timer.Start();

            timerSlide.Interval = 5000; 
            timerSlide.Start();
          
           
      
            ChuaDangNhap();
            DangNhap();
        }

        #region đăng nhập
        private void DangNhap()
        {
        LamLai:

            if (dangNhap == null || dangNhap.IsDisposed)
            {
                dangNhap = new DangNhap_GUI();
                dangNhap.txtTenDangNhap.Focus();
            }
            else dangNhap.txtTenDangNhap.Focus();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {

                if (dangNhap.txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (dangNhap.txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    TaiKhoan_DTO dataTable = TaiKhoan_BUS.Lay1TaiKhoan(dangNhap.txtTenDangNhap.Text, dangNhap.txtMatKhau.Text);
                    if (dataTable != null)
                    {
                        hoVaTen = dataTable.STenHienThi;
                        int quyenHan = dataTable.ILoaiTaiKhoan;
                        if (quyenHan == 1)
                            QuanLy();
                        else if (quyenHan == 2)
                            NhanVien();
                        else
                            ChuaDangNhap();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        goto LamLai;

                    }
                    dangNhap.txtMatKhau.Clear();
                    dangNhap.txtTenDangNhap.Clear();
                }
            }
        }
       

        public void ChuaDangNhap()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuThoat.Enabled = false;
            mnuBanHang.Enabled = false;
            mnuThucDon.Enabled = false;
            mnuThongTinCuaHang.Enabled = false;
            mnuThongTinPhanMem.Enabled = false;
            thôngTinLiênHệToolStripMenuItem.Enabled = false;
            btnBanHang.Enabled = false;
            btnThucDon.Enabled = false;
            btnNhanVien.Enabled = false;
            btnHome.Enabled = false;
          
            btnTaiKhoan.Enabled = false;

            
        }

        public void QuanLy()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuThoat.Enabled = true;
            mnuBanHang.Enabled = true;
            mnuThucDon.Enabled = true;
            mnuBanHang.Enabled = true;
            mnuQLTK.Enabled = true;
            mnuThongTinCuaHang.Enabled = true;
            mnuThongTinPhanMem.Enabled = true;
            thôngTinLiênHệToolStripMenuItem.Enabled = true;
            btnBanHang.Enabled = true;
            btnThucDon.Enabled = true;
            btnNhanVien.Enabled = true;
            btnHome.Enabled = true;
            submenu_PhucHoi.Enabled = true;
            submenu_SaoLuu.Enabled = true;
            menu_bcNhanVien.Enabled = true;
            menu_BcTaiKhoan.Enabled = true;
            menu_BcThucDon.Enabled = true;
            btnTaiKhoan.Enabled = true;
        }

        public void NhanVien()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuThoat.Enabled = true;
            mnuBanHang.Enabled = false;
            mnuQLTK.Enabled = false;
            mnuBanHang.Enabled = false;
            mnuThucDon.Enabled = false;
            btnBanHang.Enabled = true;
            btnThucDon.Enabled = true;
            btnNhanVien.Enabled = false;
            btnHome.Enabled = true;
            submenu_PhucHoi.Enabled = false;
            submenu_SaoLuu.Enabled = false;
            menu_bcNhanVien.Enabled = false;
            menu_BcTaiKhoan.Enabled = false;
            menu_BcThucDon.Enabled = false;

            btnTaiKhoan.Enabled = false;
            mnuThongTinCuaHang.Enabled = true;
            mnuThongTinPhanMem.Enabled = true;
            thôngTinLiênHệToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region Side_OpenClose
        private void OpenSideBar_Click(object sender, EventArgs e)
        {
            SideBar.Visible = true;
            OpenSideBar.Visible = false;
        }

        private void CloseSideBar_Click(object sender, EventArgs e)
        {
            SideBar.Visible = false;
            OpenSideBar.Visible = true;
        }
      

     
        #endregion

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex >= images.Length)
                currentImageIndex = 0; // Quay lại ảnh đầu tiên nếu đã hết ảnh

            
            picSlideHome.Image = images[currentImageIndex];
        }

        #region Chức Năng
        private void btnBanHang_Click(object sender, EventArgs e)
        {

            GiaoDien_BanHang giaoDien_BanHang = new GiaoDien_BanHang();
            giaoDien_BanHang.Show();

        }

        private void mnuThongTinCuaHang_Click(object sender, EventArgs e)
        {
            GiaoDien_ThongTinCuaHang thongTinCuaHang = new GiaoDien_ThongTinCuaHang();
            thongTinCuaHang.Show();
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            ThongTinPhanMem thongTinPhanMem = new ThongTinPhanMem();    
            thongTinPhanMem.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            GiaoDien_QLNV giaoDien_QLNV = new GiaoDien_QLNV();
            giaoDien_QLNV.Show();
        }

        private void thôngTinLiênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDien_ThongTinLienHe giaoDien_ThongTinLienHe = new GiaoDien_ThongTinLienHe();
            giaoDien_ThongTinLienHe.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            GiaoDien_TaiKhoan giaoDien_TaiKhoan = new GiaoDien_TaiKhoan();
            giaoDien_TaiKhoan.Show();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home_Load(sender,e);
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            GiaoDien_QLThucDon_NV qLThucDon = new GiaoDien_QLThucDon_NV();
            qLThucDon.Show();
        }
       

        private void mnuThucDon_Click(object sender, EventArgs e)
        {
            GiaoDien_QLThucDon giaoDien_QLThucDon = new GiaoDien_QLThucDon();
            giaoDien_QLThucDon.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                {
                    child.Close(); 
                }
            }
            var kq = MessageBox.Show("Bạn đã đăng xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChuaDangNhap();
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            GiaoDien_QLNV giaoDien_QLNV = new GiaoDien_QLNV();
            giaoDien_QLNV.Show();
        }

        private void mnuQLTK_Click(object sender, EventArgs e)
        {
            GiaoDien_TaiKhoan giaoDien_TaiKhoan = new GiaoDien_TaiKhoan();
            giaoDien_TaiKhoan.Show();
        }

        #endregion

        private void submenu_SaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void submenu_PhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK && phuchoiFile.CheckFileExists == true)
            {

                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.PhucHoi(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void menu_bcNhanVien_Click(object sender, EventArgs e)
        {
            GiaoDien_BcNhanVien giaoDien_BcNhanVien = new GiaoDien_BcNhanVien();
            giaoDien_BcNhanVien.Show();
        }

        private void picSlideHome_Click(object sender, EventArgs e)
        {

        }

        private void menu_BcThucDon_Click(object sender, EventArgs e)
        {
            GiaoDien_BcThucDon giaoDien_BcThucDon = new GiaoDien_BcThucDon();
            giaoDien_BcThucDon.Show();
        }

        private void báoCáoQLTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDien_BcTaiKhoan giaoDien_BcTaiKhoan = new GiaoDien_BcTaiKhoan();
            giaoDien_BcTaiKhoan.Show();
        }
    }
}
