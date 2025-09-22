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
    public class HoaDon_DAO
    {
        static SqlConnection conn;

        // Lấy danh sách tất cả hóa đơn
        public static List<HoaDon_DTO> LayHoaDonTheoBan(int maBan)
        {
            string sTruyVan = "SELECT * FROM HoaDon WHERE BanId = @BanId AND TrangThai = 0";
            conn = MyDataTable.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            cmd.Parameters.AddWithValue("@BanId", maBan);

            DataTable dt = MyDataTable.TruyVanLayDuLieu(cmd);
            if (dt.Rows.Count == 0)
                return null;

            List<HoaDon_DTO> lstHoaDon = new List<HoaDon_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                HoaDon_DTO hoaDon = new HoaDon_DTO
                {
                    IMaHoaDon = Convert.ToInt32(row["Id"]),
                    DThoiGianVao = Convert.ToDateTime(row["ThoiGianVao"]),
                    IMaBan = Convert.ToInt32(row["BanId"]),
                    ITrangThai = Convert.ToInt32(row["TrangThai"])
                };
                lstHoaDon.Add(hoaDon);
            }
            return lstHoaDon;
        }


        // Thêm một hóa đơn mới
        public static bool ThemHoaDon(HoaDon_DTO hoaDon)
        {
            string sTruyVan = "INSERT INTO HoaDon (ThoiGianVao, BanId, TrangThai) VALUES (@ThoiGianVao, @BanId, @TrangThai)";
            conn = MyDataTable.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            cmd.Parameters.AddWithValue("@ThoiGianVao", hoaDon.DThoiGianVao);
            cmd.Parameters.AddWithValue("@BanId", hoaDon.IMaBan);
            cmd.Parameters.AddWithValue("@TrangThai", hoaDon.ITrangThai);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
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

        // Cập nhật thông tin hóa đơn
        public static bool CapNhatHoaDon(HoaDon_DTO hd)
        {
            string sTruyVan = "UPDATE HoaDon SET ThoiGianVao = @ThoiGianVao, BanId = @BanId, TrangThai = @TrangThai WHERE Id = @Id";
            conn = MyDataTable.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            cmd.Parameters.AddWithValue("@ThoiGianVao", hd.DThoiGianVao);
            cmd.Parameters.AddWithValue("@BanId", hd.IMaBan);
            cmd.Parameters.AddWithValue("@TrangThai", hd.ITrangThai);
            cmd.Parameters.AddWithValue("@Id", hd.IMaHoaDon);

            return MyDataTable.TruyVanKhongLayDuLieu(cmd);
        }

        // Xóa hóa đơn
        public static bool XoaHoaDon(int id)
        {
            string sTruyVan = "DELETE FROM HoaDon WHERE Id = @Id";
            conn = MyDataTable.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            return MyDataTable.TruyVanKhongLayDuLieu(cmd);
        }

        public static DataTable LayChiTietHoaDonTheoBan(int banId)
        {
            string query = @"
                SELECT td.TenMon, cthd.SoLuong, cthd.DonGia, cthd.ThanhTien
                FROM HoaDon hd
                JOIN ChiTietHoaDon cthd ON hd.Id = cthd.HoaDonId
                JOIN ThucDon td ON cthd.MonAnId = td.Id
                WHERE hd.BanId = @BanId AND hd.TrangThai = 0";

            conn = MyDataTable.MoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BanId", banId);

            DataTable dt = MyDataTable.TruyVanLayDuLieu(cmd);
            return dt;
        }

        public static bool CapNhatTongTienHoaDon(int hoaDonId)
        {
            conn = MyDataTable.MoKetNoi();

            string query = @"
        UPDATE HoaDon SET TongGiaTri = (
            SELECT SUM(SoLuong * DonGia) FROM ChiTietHoaDon WHERE HoaDonId = @hoaDonId
        )
        WHERE Id = @hoaDonId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@hoaDonId", hoaDonId);

            int rows = cmd.ExecuteNonQuery();
            MyDataTable.DongKetNoi();

            return rows > 0;
        }

        public static decimal LayTongTienHoaDon(int hoaDonId)
        {
            conn = MyDataTable.MoKetNoi();
            string query = "SELECT SUM(SoLuong * DonGia) FROM ChiTietHoaDon WHERE HoaDonId = @hoaDonId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@hoaDonId", hoaDonId);

            object result = cmd.ExecuteScalar();
            MyDataTable.DongKetNoi();

            if (result != DBNull.Value && result != null)
                return Convert.ToDecimal(result);
            else
                return 0;
        }

        public static decimal TinhTongTienHoaDon(int hoaDonId)
        {
            conn = MyDataTable.MoKetNoi();

            string query = "SELECT SUM(SoLuong * DonGia) FROM ChiTietHoaDon WHERE HoaDonId = @hoaDonId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@hoaDonId", hoaDonId);

            object result = cmd.ExecuteScalar();
            MyDataTable.DongKetNoi();

            if (result != null && decimal.TryParse(result.ToString(), out decimal tongTien))
                return tongTien;
            else
                return 0;
        }

        public static DataTable LayChiTietHoaDonTheoHoaDon(int hoaDonId)
        {
            string query = @"
        SELECT td.Id AS MonAnId,
               td.TenMon,
               cthd.SoLuong,
               cthd.DonGia,
               cthd.ThanhTien
        FROM ChiTietHoaDon cthd
        INNER JOIN ThucDon td ON cthd.MonAnId = td.Id
        WHERE cthd.HoaDonId = @hoaDonId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10\SQLEXPRESS;Initial Catalog=QuanLyQuanCaPhe_TH;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@hoaDonId", hoaDonId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("report");
                da.Fill(dt);
                return dt;
            }
        }
    }
}
