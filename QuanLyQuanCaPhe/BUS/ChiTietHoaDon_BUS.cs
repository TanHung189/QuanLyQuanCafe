using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDon_BUS
    {
        static SqlConnection conn;
        public static List<ChiTietHoaDon_DTO> LayChiTietHD(int hoaDonId)
        {
            return ChiTietHoaDon_DAO.LayChiTietHD(hoaDonId);
        }

        public static bool XoaChiTietTheoHoaDon(int hoaDonId)
        {
            return ChiTietHoaDon_DAO.XoaChiTietTheoHoaDon(hoaDonId);
        }

        public static bool CapNhatMon(int hoaDonId, int maMonAn, int soLuong, decimal donGia)
        {
            return ChiTietHoaDon_DAO.CapNhatMon(hoaDonId, maMonAn, soLuong, donGia);
        }
    }
}
