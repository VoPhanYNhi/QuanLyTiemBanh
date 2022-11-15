using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonChiTiet_DTO
    {
        private int iMaHDCT;
        private int iMaHoaDon;
        private int iMaBanh;
        private int iSoLuong;

        public int IMaHDCT { get => iMaHDCT; set => iMaHDCT = value; }
        public int IMaHoaDon { get => iMaHoaDon; set => iMaHoaDon = value; }
        public int IMaBanh { get => iMaBanh; set => iMaBanh = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
    }
}
