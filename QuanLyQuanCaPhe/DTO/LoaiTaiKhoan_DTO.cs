using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiTaiKhoan_DTO
    {
        private int iMaLoaiTaiKhoan;
        private string sTenLoai;

        public int IMaLoaiTaiKhoan { get => iMaLoaiTaiKhoan; set => iMaLoaiTaiKhoan = value; }
        public string STenLoai { get => sTenLoai; set => sTenLoai = value; }
    }
}
