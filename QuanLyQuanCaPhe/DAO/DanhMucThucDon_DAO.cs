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
    public class DanhMucThucDon_DAO
    {
        static SqlConnection conn;
        public static List<DanhMucThucDon_DTO> LayDanhMuc()
        {
            string sTruyVan = "select * from DanhMucThucDon";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<DanhMucThucDon_DTO> lstDanhMuc = new List<DanhMucThucDon_DTO> ();
            for (int i= 0; i < dt.Rows.Count; i++)
            {
                DanhMucThucDon_DTO dm = new DanhMucThucDon_DTO();
                dm.IMaDanhMuc = int.Parse(dt.Rows[i]["Id"].ToString());
                dm.STenDanhMuc = dt.Rows[i]["TenDanhMuc"].ToString();
                lstDanhMuc.Add(dm);
            }

            return lstDanhMuc;
        }
    }
}
