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
    public class LoaiTaiKhoan_DAO
    {
        static SqlConnection conn;
        public static List<LoaiTaiKhoan_DTO> LayLoaiTaiKhoan()
        {
            string sTruyVan = "select * from LoaiTaiKhoan";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<LoaiTaiKhoan_DTO> lstLoaiTaiKhoan = new List<LoaiTaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiTaiKhoan_DTO ltk = new LoaiTaiKhoan_DTO();
                ltk.IMaLoaiTaiKhoan = int.Parse(dt.Rows[i]["Id"].ToString());
                ltk.STenLoai = dt.Rows[i]["TenLoai"].ToString();

                lstLoaiTaiKhoan.Add(ltk);
            }
            return lstLoaiTaiKhoan;
        }
    }
}
