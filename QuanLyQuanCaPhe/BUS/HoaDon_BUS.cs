using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static List<HoaDon_DTO> LayHoaDonTheoBan(int maban)
        {
            return HoaDon_DAO.LayHoaDonTheoBan(maban);
        }

        public static bool ThemHoaDon(HoaDon_DTO hoaDon)
        {
            return HoaDon_DAO.ThemHoaDon(hoaDon);
        }

        public static bool XoaHoaDon(int id)
        {
            return HoaDon_DAO.XoaHoaDon(id);
        }
        public static DataTable LayChiTietHoaDonTheoBan(int banId)
        {
            return HoaDon_DAO.LayChiTietHoaDonTheoBan(banId);
        }
        public static bool CapNhatTongTienHoaDon(int hoaDonId)
        {
            return HoaDon_DAO.CapNhatTongTienHoaDon(hoaDonId);
        }

        public static decimal LayTongTienHoaDon(int hoaDonId)
        {
            return HoaDon_DAO.LayTongTienHoaDon(hoaDonId);
        }

        public static decimal TinhTongTienHoaDon(int hoaDonId)
        {
            return HoaDon_DAO.TinhTongTienHoaDon(hoaDonId);
        }

        public static bool CapNhatHoaDon(HoaDon_DTO hd)
        {
            return HoaDon_DAO.CapNhatHoaDon(hd);
        }

        public static DataTable LayChiTietHoaDonTheoHoaDon(int hoaDonId)
        {
            return HoaDon_DAO.LayChiTietHoaDonTheoHoaDon(hoaDonId);
        }
    }
}
