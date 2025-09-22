using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThucDon_DTO
    {
        private int iMaThucDon;
        public int IMaThucDon { get => iMaThucDon; set => iMaThucDon = value; }

        private string sTenMon;
        public string STenMon { get => sTenMon; set => sTenMon = value; }

        private int iMaDanhMuc;
        public int IMaDanhMuc { get => iMaDanhMuc; set => iMaDanhMuc = value; }

        private int iSoLuong;
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }

        private decimal fGia;
        public decimal FGia { get => fGia; set => fGia = value; }
    }
}
