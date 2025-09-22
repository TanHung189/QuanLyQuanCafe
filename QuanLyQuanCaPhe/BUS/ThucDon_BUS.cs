using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThucDon_BUS
    {
        public static List<ThucDon_DTO> LayThucDon()
        {
            return ThucDon_DAO.LayThucDon();
        }

        public static decimal LayGiaThucDon(int foodID)
        {
            var food = ThucDon_DAO.LayThucDon().FirstOrDefault(f => f.IMaThucDon == foodID);
            return food?.FGia ?? -1;  // Trả về -1 nếu không tìm thấy món ăn
        }

        // Lọc món ăn theo danh mục
        public static List<ThucDon_DTO> LayThucDonTheoDanhMuc(int maDanhMuc)
        {
            var allFood = LayThucDon();  // Lấy tất cả món ăn
            return allFood.Where(f => f.IMaDanhMuc == maDanhMuc).ToList();  // Lọc theo danh mục
        }

        public static bool ThemThucDon(ThucDon_DTO td)
        {
            return ThucDon_DAO.ThemThucDon(td);
        }

        public static bool SuaThucDon(ThucDon_DTO td)
        {
            return ThucDon_DAO.SuaThucDon(td);
        }

        public static bool XoaThucDon(int maThucDon)
        {
            return ThucDon_DAO.XoaThucDon(maThucDon);
        }

        public static List<ThucDon_DTO> TimThucDonTheoTen(string tenMon)
        {
            return ThucDon_DAO.TimThucDonTheoTen(tenMon);
        }
    }
}
