using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhMucThucDon_BUS
    {
        public static List<DanhMucThucDon_DTO> LayDanhMuc()
        {
            return DanhMucThucDon_DAO.LayDanhMuc();
        }
    }
}
