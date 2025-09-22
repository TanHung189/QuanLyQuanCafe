using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVien_DAO
    {
        static SqlConnection conn;
        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "select * from NhanVien";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for(int i = 0; i < dt.Rows.Count ; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IMaNhanVien = int.Parse(dt.Rows[i]["Id"].ToString());
                nv.SHoTen = dt.Rows[i]["HoTen"].ToString();
                nv.DNgaySinh = Convert.ToDateTime(dt.Rows[i]["NgaySinh"]);
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                nv.SSoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                nv.SEmail = dt.Rows[i]["Email"].ToString();
                nv.SChucVu = dt.Rows[i]["ChucVu"].ToString();
                nv.IMaLoaiTaiKhoan = int.Parse(dt.Rows[i]["LoaiTaiKhoanId"].ToString());

                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }

        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            conn = MyDataTable.MoKetNoi();
            DateTime ngaylam = DateTime.Now;
            string sTruyVan = string.Format(@"INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, ChucVu, LoaiTaiKhoanId, NgayVaoLam)
VALUES (N'{0}', '{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}',{7},'{8}')",
 nv.SHoTen, nv.DNgaySinh.ToString("yyyy-MM-dd"), nv.SGioiTinh, nv.SDiaChi, nv.SSoDienThoai, nv.SEmail, nv.SChucVu,nv.IMaLoaiTaiKhoan,ngaylam.ToString("yyyy-MM-dd"));
           
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi();
            return kq;
        }

        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            conn = MyDataTable.MoKetNoi();
            string sTruyVan = string.Format(@"UPDATE NhanVien SET HoTen=N'{1}', NgaySinh=N'{2}', GioiTinh=N'{3}', DiaChi=N'{4}', SoDienThoai=N'{5}', Email=N'{6}', ChucVu=N'{7}', LoaiTaiKhoanId={8} WHERE Id={0}",
            nv.IMaNhanVien, nv.SHoTen, nv.DNgaySinh.ToString("yyyy-MM-dd"), nv.SGioiTinh, nv.SDiaChi, nv.SSoDienThoai, nv.SEmail, nv.SChucVu, nv.IMaLoaiTaiKhoan);

            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi();
            return kq;
        }

        public static bool XoaNhanVien(int maNhanVien)
        {
            string sTruyVan = $"DELETE FROM NhanVien WHERE Id = {maNhanVien}";
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi();
            return kq;
        }

        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from NhanVien where HoTen like N'%{0}%'", ten);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IMaNhanVien = int.Parse(dt.Rows[i]["Id"].ToString());
                nv.SHoTen = dt.Rows[i]["HoTen"].ToString();
                nv.DNgaySinh = Convert.ToDateTime(dt.Rows[i]["NgaySinh"]);
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                nv.SSoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                nv.SEmail = dt.Rows[i]["Email"].ToString();
                nv.SChucVu = dt.Rows[i]["ChucVu"].ToString();
                nv.IMaLoaiTaiKhoan = int.Parse(dt.Rows[i]["LoaiTaiKhoanId"].ToString());
                lstNhanVien.Add(nv);
            }
            MyDataTable.DongKetNoi();
            return lstNhanVien;
        }

    }
}
