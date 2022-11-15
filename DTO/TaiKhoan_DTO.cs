using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string sTenDangNhap;
        private string sTenHienThi;
        private string sMatKhau;
        private int iLoaiTK;

        public string STenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public string STenHienThi { get => sTenHienThi; set => sTenHienThi = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public int ILoaiTK { get => iLoaiTK; set => iLoaiTK = value; }
    }
}
