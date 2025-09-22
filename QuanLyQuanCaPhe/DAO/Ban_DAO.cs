using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Ban_DAO
    {
        static SqlConnection conn;
        public static List<Ban_DTO> LayBan()
        {
            string sTruyVan = "select * from BanQuan";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            
            List<Ban_DTO> lstBan = new List<Ban_DTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.IMaBan = int.Parse(dt.Rows[i]["Id"].ToString());
                ban.STenBan = dt.Rows[i]["TenBan"].ToString();
                ban.STrangThai = dt.Rows[i]["TrangThai"].ToString();
                lstBan.Add(ban);
            }
            return lstBan;
        }


        public static bool CapNhatTrangThaiBan(int maBan, string trangThai)
        {
            try
            {

                SqlConnection conn = MyDataTable.MoKetNoi();
                string query = "UPDATE BanQuan SET TrangThai = @TrangThai WHERE Id = @MaBan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@MaBan", maBan);

                int rowsAffected = cmd.ExecuteNonQuery();
                MyDataTable.DongKetNoi();

                return rowsAffected > 0; 
            }
            catch (Exception)
            {
                return false; // trả về false nếu lỗi xảy ra
            }
        }


    }
}
