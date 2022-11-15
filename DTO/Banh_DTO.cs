using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Banh_DTO
    {
        private int iMaBanh;
        private string sTenBanh;
        private int iMaLoai;
        private int iSoLuong;
        private float fGia;

        public int IMaBanh { get => iMaBanh; set => iMaBanh = value; }
        public string STenBanh { get => sTenBanh; set => sTenBanh = value; }
        public int IMaLoai { get => iMaLoai; set => iMaLoai = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public float FGia { get => fGia; set => fGia = value; }
    }
}
