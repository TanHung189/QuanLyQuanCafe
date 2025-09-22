using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban_DTO
    {
        private int iMaBan;

        private string sTenBan;
        private string sTrangThai;
        public int IMaBan { get => iMaBan; set => iMaBan = value; }
        public string STenBan { get => sTenBan; set => sTenBan = value; }
        public string STrangThai { get => sTrangThai; set => sTrangThai = value; }
    }
}
