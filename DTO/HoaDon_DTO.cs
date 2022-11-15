using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private int iMaHoaDon;
        private DateTime dtNgayBan;
        private float fTongTien;

        public int IMaHoaDon { get => iMaHoaDon; set => iMaHoaDon = value; }
        public DateTime DtNgayBan { get => dtNgayBan; set => dtNgayBan = value; }
        public float FTongTien { get => fTongTien; set => fTongTien = value; }
    }
}
