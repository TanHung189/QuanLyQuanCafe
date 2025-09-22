using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private int iMaHoaDon;
        private DateTime dThoiGianVao;
        private int iMaBan;
        private int iTrangThai;

        public int IMaHoaDon { get => iMaHoaDon; set => iMaHoaDon = value; }
        public DateTime DThoiGianVao { get => dThoiGianVao; set => dThoiGianVao = value; }
        public int IMaBan { get => iMaBan; set => iMaBan = value; }
        public int ITrangThai { get => iTrangThai; set => iTrangThai = value; }
    }
}
