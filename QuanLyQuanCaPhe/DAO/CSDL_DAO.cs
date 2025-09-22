using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection con;
        // Backup
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QuanLyQuanCaPhe_TH(" + DateTime.Now.Day.ToString() + "_" +
                        DateTime.Now.Month.ToString() + "_" +
                        DateTime.Now.Year.ToString() + "_" +
                        DateTime.Now.Hour.ToString() + "_" +
                        DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QuanLyQuanCaPhe_TH TO DISK = N'" + sDuongDan + sTen + "'";
            con = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }

        public static bool PhucHoiDuLieu(string sDuongDan)
        {
            string sql = "USE master; " +
                 "ALTER DATABASE QuanLyQuanCaPhe_TH SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                 "RESTORE DATABASE QuanLyQuanCaPhe_TH FROM DISK = N'" + sDuongDan + "' WITH REPLACE;";

            try
            {
                using (SqlConnection con = MyDataTable.MoKetNoi())
                {
                    bool kq = MyDataTable.TruyVanKhongLayDuLieu(sql, con);
                    return kq;
                }
            }
            catch (Exception ex)
            {
                // Có thể log lỗi ra MessageBox hoặc Console để debug
                throw new Exception("Lỗi khi phục hồi dữ liệu: " + ex.Message);

            }
        }
    }
}
