using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucThucDon_DTO
    {
        private int iMaDanhMuc;
        private string sTenDanhMuc;

        public int IMaDanhMuc { get => iMaDanhMuc; set => iMaDanhMuc = value; }
        public string STenDanhMuc { get => sTenDanhMuc; set => sTenDanhMuc = value; }
    }
}
