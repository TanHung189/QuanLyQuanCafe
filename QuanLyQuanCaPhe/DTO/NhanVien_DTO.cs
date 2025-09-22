using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private int iMaNhanVien;
        public int IMaNhanVien { get => iMaNhanVien; set => iMaNhanVien = value; }

        private string sHoTen;
        public string SHoTen { get => sHoTen; set => sHoTen = value; }

        private DateTime dNgaySinh;
        public DateTime DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }

        private string sGioiTinh;
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }

        private string sDiaChi;
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }

        private string sSoDienThoai;
        public string SSoDienThoai { get => sSoDienThoai; set => sSoDienThoai = value; }

        private string sEmail;
        public string SEmail { get => sEmail; set => sEmail = value; }

        private string sChucVu;
        public string SChucVu { get => sChucVu; set => sChucVu = value; }

        private int iMaLoaiTaiKhoan;
        public int IMaLoaiTaiKhoan { get => iMaLoaiTaiKhoan; set => iMaLoaiTaiKhoan = value; }

        private DateTime dNgayVaoLam;
        public DateTime DNgayVaoLam { get => dNgayVaoLam; set => dNgayVaoLam = value; }


    }
}
