using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Ban_BUS
    {
        public static List<Ban_DTO> LayBan()
        {
            return Ban_DAO.LayBan();
        }

        public static bool CapNhatTrangThaiBan(int maban, string trangThai)
        {
            return Ban_DAO.CapNhatTrangThaiBan(maban, trangThai);
        }

        public static bool HuyBan(int maban)
        {
            bool xoaHoaDon = HoaDon_DAO.XoaHoaDon(maban);
            bool capNhatBan = Ban_DAO.CapNhatTrangThaiBan(maban, "trong");

            return xoaHoaDon && capNhatBan;
        }
    }
}
