using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static List<TaiKhoan_DTO> LayDSTaiKhoan()
        {
            return TaiKhoan_DAO.DanhSachTaiKhoan();
        }

        public static TaiKhoan_DTO Lay1TaiKhoan(string tendn, string mk)
        {
            return TaiKhoan_DAO.Lay1TaiKhoan(tendn, mk);
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.ThemTaiKhoan(tk);
        }

        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.SuaTaiKhoan(tk);
        }

        public static bool XoaTaiKhoan(int maTaiKhoan)
        {
            return TaiKhoan_DAO.XoaTaiKhoan(maTaiKhoan);
        }

        public static List<TaiKhoan_DTO> TimTaiKhoanTheoTenDN(string tenDN)
        {
            return TaiKhoan_DAO.TimTaiKhoanTheoTenDN(tenDN);
        }
    }
}
