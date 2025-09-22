using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVien_BUS
    {   
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_DAO.LayNhanVien();
        }

        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNhanVien(nv); 
        }

        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.SuaNhanVien(nv);
        }

        public static bool XoaNhanVien(int maNhanVien)
        {
            return NhanVien_DAO.XoaNhanVien(maNhanVien);
        }

        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NhanVien_DAO.TimNhanVienTheoTen(ten);
        }

    }
}
