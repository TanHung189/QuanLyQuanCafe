using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private int iMaTaiKhoan;
        private string sTenDangNhap;
        private string sTenHienThi;
        private string sMatKhau;
        private int iLoaiTaiKhoan;
        private string sGhiChu;
        private int iMaNhanVien;

        public int IMaTaiKhoan { get => iMaTaiKhoan; set => iMaTaiKhoan = value; }
        public string STenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public string STenHienThi { get => sTenHienThi; set => sTenHienThi = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public int ILoaiTaiKhoan { get => iLoaiTaiKhoan; set => iLoaiTaiKhoan = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
        public int IMaNhanVien { get => iMaNhanVien; set => iMaNhanVien = value; }
    }
}
