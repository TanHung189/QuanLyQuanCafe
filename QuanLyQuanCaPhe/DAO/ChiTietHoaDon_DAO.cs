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
    public class ChiTietHoaDon_DAO
    {
        static SqlConnection conn;
        public static List<ChiTietHoaDon_DTO> LayChiTietHD(int maHoaDon)
        {
            string sTruyVan = "SELECT * FROM ChiTietHoaDon WHERE HoaDonId = " + maHoaDon;
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<ChiTietHoaDon_DTO> lstcthd = new List<ChiTietHoaDon_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietHoaDon_DTO cthd = new ChiTietHoaDon_DTO();
                cthd.IMaChiTietHoaDon = int.Parse(row["Id"].ToString());
                cthd.IMaHoaDon = int.Parse(row["HoaDonId"].ToString());
                cthd.IMaMonAn = int.Parse(row["MonAnId"].ToString());
                cthd.ISoLuong = int.Parse(row["SoLuong"].ToString());
                cthd.DeDonGia = decimal.Parse(row["DonGia"].ToString());
                cthd.DeThanhTien = decimal.Parse(row["ThanhTien"].ToString());

                lstcthd.Add(cthd);
            }

            return lstcthd;
        }


        public static bool CapNhatMon(int hoaDonId, int maMonAn, int soLuong, decimal donGia)
        {
            conn = MyDataTable.MoKetNoi();

            string checkQuery = "SELECT SoLuong FROM ChiTietHoaDon WHERE HoaDonId = @hoaDonId AND MonAnId = @maMonAn";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@hoaDonId", hoaDonId);
            checkCmd.Parameters.AddWithValue("@maMonAn", maMonAn);

            object result = checkCmd.ExecuteScalar();

            if (result != null)
            {
                int soLuongCu = Convert.ToInt32(result);
                int soLuongMoi = soLuongCu + soLuong;

                string updateQuery = "UPDATE ChiTietHoaDon SET SoLuong = @soLuong WHERE HoaDonId = @hoaDonId AND MonAnId = @maMonAn";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@soLuong", soLuongMoi);
                updateCmd.Parameters.AddWithValue("@hoaDonId", hoaDonId);
                updateCmd.Parameters.AddWithValue("@maMonAn", maMonAn);

                int rows = updateCmd.ExecuteNonQuery();
                MyDataTable.DongKetNoi();
                return rows > 0;
            }
            else
            {
                string insertQuery = "INSERT INTO ChiTietHoaDon (HoaDonId, MonAnId, SoLuong, DonGia) VALUES (@hoaDonId, @maMonAn, @soLuong, @donGia)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@hoaDonId", hoaDonId);
                insertCmd.Parameters.AddWithValue("@maMonAn", maMonAn);
                insertCmd.Parameters.AddWithValue("@soLuong", soLuong);
                insertCmd.Parameters.AddWithValue("@donGia", donGia);

                int rows = insertCmd.ExecuteNonQuery();
                MyDataTable.DongKetNoi();
                return rows > 0;
            }
        }

        public static bool XoaChiTietTheoHoaDon(int hoaDonId)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE HoaDonId = @HoaDonId";
            conn = MyDataTable.MoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@HoaDonId", hoaDonId);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows >= 0; 
            }
            catch
            {
                return false;
            }
            finally
            {
                MyDataTable.DongKetNoi();
            }
        }
    }
}
