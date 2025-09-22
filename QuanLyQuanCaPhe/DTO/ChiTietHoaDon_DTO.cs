using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon_DTO
    {
        private int iMaChiTietHoaDon;
        private int iMaHoaDon;
        private int iMaMonAn;
        private int iSoLuong;
        private decimal deDonGia;
        private decimal deThanhTien;

        public int IMaChiTietHoaDon { get => iMaChiTietHoaDon; set => iMaChiTietHoaDon = value; }
        public int IMaHoaDon { get => iMaHoaDon; set => iMaHoaDon = value; }
        public int IMaMonAn { get => iMaMonAn; set => iMaMonAn = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public decimal DeDonGia { get => deDonGia; set => deDonGia = value; }
        public decimal DeThanhTien { get => deThanhTien; set => deThanhTien = value; }
    }
}
