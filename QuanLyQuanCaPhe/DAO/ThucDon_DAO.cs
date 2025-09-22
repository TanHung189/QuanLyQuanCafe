using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ThucDon_DAO
    {
        static SqlConnection conn;
        public static List<ThucDon_DTO> LayThucDon()
        {
            string sTruyVan = "select * from ThucDon";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThucDon_DTO> lstThucDon = new List<ThucDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThucDon_DTO td = new ThucDon_DTO();
                td.IMaThucDon = int.Parse(dt.Rows[i]["Id"].ToString());
                td.STenMon = dt.Rows[i]["TenMon"].ToString();
                td.IMaDanhMuc = int.Parse(dt.Rows[i]["DanhMucId"].ToString());
                td.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                td.FGia = decimal.Parse(dt.Rows[i]["Gia"].ToString());

                // Thêm đối tượng vào danh sách
                lstThucDon.Add(td);

            }
            return lstThucDon;

        }

        public static bool ThemThucDon(ThucDon_DTO td)
        {
            string sTruyVan = string.Format(@"INSERT INTO ThucDon(TenMon, DanhMucId, SoLuong, Gia) VALUES(N'{0}', '{1}','{2}', '{3}')",
                td.STenMon,
                td.IMaDanhMuc,
                td.ISoLuong,
                td.FGia);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi();
            return kq;
        }

        public static bool SuaThucDon(ThucDon_DTO td)
        {
            conn = MyDataTable.MoKetNoi();

            string sTruyVan = string.Format(@"UPDATE ThucDon SET 
        TenMon = N'{1}', 
        DanhMucId = {2}, 
        SoLuong = {3}, 
        Gia = {4} 
        WHERE Id = {0}",
                td.IMaThucDon,
                td.STenMon,
                td.IMaDanhMuc,
                td.ISoLuong,
                td.FGia);

            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi();

            return kq;
        }

        public static bool XoaThucDon(int maThucDon)
        {
            string sTruyVan = $"DELETE FROM ThucDon WHERE Id = {maThucDon}";
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi();
            return kq;
        }

        public static List<ThucDon_DTO> TimThucDonTheoTen(string tenMon)
        {
            string sTruyVan = string.Format(@"select * from ThucDon where TenMon like N'%{0}%'", tenMon);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThucDon_DTO> lstThucDon = new List<ThucDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThucDon_DTO td = new ThucDon_DTO();
                td.IMaThucDon = int.Parse(dt.Rows[i]["Id"].ToString());
                td.STenMon = dt.Rows[i]["TenMon"].ToString();
                td.IMaDanhMuc = int.Parse(dt.Rows[i]["DanhMucId"].ToString());
                td.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                td.FGia = decimal.Parse(dt.Rows[i]["Gia"].ToString());

                // Thêm đối tượng vào danh sách
                lstThucDon.Add(td);

            }
            return lstThucDon;

        }
    }
}
