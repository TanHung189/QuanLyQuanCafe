using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MyDataTable
    {
        private static SqlConnection KetNoi; 

        
        public static SqlConnection MoKetNoi()
        {
            if (KetNoi == null || KetNoi.State == ConnectionState.Closed)
            {
                string s = @"Data Source=WINDOWS-10\SQLEXPRESS;Initial Catalog=QuanLyQuanCaPhe_TH;Integrated Security=True;";
                KetNoi = new SqlConnection(s);
                KetNoi.Open();
            }
            return KetNoi;
        }

        public static void DongKetNoi()
        {
            if (KetNoi != null && KetNoi.State == ConnectionState.Open)
            {
                KetNoi.Close();
            }
        }

        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable TruyVanLayDuLieu(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static bool TruyVanKhongLayDuLieu(SqlCommand cmd)
        {
            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                return false;
            }
        }


    }
}
