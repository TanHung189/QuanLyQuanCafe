using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        static SqlConnection conn;
        public static List<TaiKhoan_DTO> DanhSachTaiKhoan()
        {
            string struyVan = @"select *from TaiKhoan";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(struyVan, conn);
            MyDataTable.DongKetNoi();
            if (dt.Rows.Count > 0)
            {
                List<TaiKhoan_DTO> lst = new List<TaiKhoan_DTO>();
                foreach (DataRow dr in dt.Rows)
                {
                    TaiKhoan_DTO tk = new TaiKhoan_DTO();
                    tk.IMaTaiKhoan = int.Parse(dr["Id"].ToString());
                    tk.STenHienThi = dr["TenHienThi"].ToString();
                    tk.STenDangNhap = dr["TenDangNhap"].ToString();
                    tk.SMatKhau = dr["MatKhau"].ToString();
                    tk.ILoaiTaiKhoan = int.Parse(dr["LoaiTaiKhoanId"].ToString());
                    tk.SGhiChu = dr["GhiChu"].ToString();
                    tk.IMaNhanVien = int.Parse(dr["NhanVienId"].ToString());
                    lst.Add(tk);
                }
                return lst;
            }
            return null;
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            conn = MyDataTable.MoKetNoi();
            string sTruyVan = @"INSERT INTO TaiKhoan (TenDangNhap, TenHienThi, MatKhau, LoaiTaiKhoanId, GhiChu, NhanVienId)
                       VALUES (@TenDangNhap, @TenHienThi, @MatKhau, @LoaiTaiKhoanId, @GhiChu, @NhanVienId)";
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            cmd.Parameters.AddWithValue("@TenDangNhap", tk.STenDangNhap);
            cmd.Parameters.AddWithValue("@TenHienThi", tk.STenHienThi);
            cmd.Parameters.AddWithValue("@MatKhau", tk.SMatKhau);
            cmd.Parameters.AddWithValue("@LoaiTaiKhoanId", tk.ILoaiTaiKhoan);
            cmd.Parameters.AddWithValue("@GhiChu", tk.SGhiChu ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@NhanVienId", tk.IMaNhanVien);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                MyDataTable.DongKetNoi();
            }
        }

        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            try
            {
                conn = MyDataTable.MoKetNoi();
                string sTruyVan = @"UPDATE TaiKhoan 
                            SET TenDangNhap = @TenDangNhap, 
                                TenHienThi = @TenHienThi, 
                                MatKhau = @MatKhau, 
                                LoaiTaiKhoanId = @LoaiTaiKhoanId, 
                                GhiChu = @GhiChu,
                                NhanVienId = @NhanVienId
                            WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(sTruyVan, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tk.STenDangNhap);
                cmd.Parameters.AddWithValue("@TenHienThi", tk.STenHienThi);
                cmd.Parameters.AddWithValue("@MatKhau", tk.SMatKhau);
                cmd.Parameters.AddWithValue("@LoaiTaiKhoanId", tk.ILoaiTaiKhoan);
                cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrEmpty(tk.SGhiChu) ? (object)DBNull.Value : tk.SGhiChu);
                cmd.Parameters.AddWithValue("@NhanVienId", tk.IMaNhanVien);
                cmd.Parameters.AddWithValue("@Id", tk.IMaTaiKhoan);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                MyDataTable.DongKetNoi();
            }
        }

        public static bool XoaTaiKhoan(int maTaiKhoan)
        {
            try
            {
                conn = MyDataTable.MoKetNoi();
                string sTruyVan = "DELETE FROM TaiKhoan WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sTruyVan, conn);
                cmd.Parameters.AddWithValue("@Id", maTaiKhoan);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                
                return false;
            }
            finally
            {
                MyDataTable.DongKetNoi();
            }
        }

        public static TaiKhoan_DTO Lay1TaiKhoan(string tenDN, string MK)
        {
            string sTruyVan = string.Format(@"select *from TaiKhoan where TenDangNhap=N'{0}' and MatKhau=N'{1}'", tenDN, MK);
            conn = MyDataTable.MoKetNoi();
            DataTable dtk = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi();
            if (dtk.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SMatKhau = dtk.Rows[0]["MatKhau"].ToString();
            tk.IMaTaiKhoan = int.Parse(dtk.Rows[0]["Id"].ToString());
            tk.STenHienThi = dtk.Rows[0]["TenHienThi"].ToString();
            tk.STenDangNhap = dtk.Rows[0]["TenDangNhap"].ToString();
            tk.ILoaiTaiKhoan = int.Parse(dtk.Rows[0]["LoaiTaiKhoanId"].ToString());
            tk.SGhiChu = dtk.Rows[0]["GhiChu"].ToString();
            return tk;
        }

        public static List<TaiKhoan_DTO> TimTaiKhoanTheoTenDN(string tenDN)
        {
            string sTruyVan = string.Format(@"select * from TaiKhoan where TenDangNhap like N'%{0}%'", tenDN);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<TaiKhoan_DTO> lsttk = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.SMatKhau = dt.Rows[0]["MatKhau"].ToString();
                tk.IMaTaiKhoan = int.Parse(dt.Rows[0]["Id"].ToString());
                tk.STenHienThi = dt.Rows[0]["TenHienThi"].ToString();
                tk.STenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                tk.ILoaiTaiKhoan = int.Parse(dt.Rows[0]["LoaiTaiKhoanId"].ToString());
                tk.SGhiChu = dt.Rows[0]["GhiChu"].ToString();
                lsttk.Add(tk);
            }
            MyDataTable.DongKetNoi();
            return lsttk;
        }
    }
}
