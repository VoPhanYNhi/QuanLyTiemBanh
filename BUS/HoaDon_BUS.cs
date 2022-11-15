using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDon_BUS
    {
        //Lấy DS hoá đơn
        public static List<HoaDon_DTO> LayDSHoaDon()
        {
            return HoaDon_DAO.LayDSHoaDon();
        }

        //Lấy mã hoá đơn
        public static int LayMaHoaDonHT()
        {
            return HoaDon_DAO.LayMaHoaDonHT();
        }

        //Thêm hoá đơn bán bánh
        public static bool ThemHoaDonBanBanh(HoaDon_DTO hd)
        {
            return HoaDon_DAO.ThemHoaDonBanBanh(hd);
        }

        //Lấy DS hoá đơn theo ngày
        public static List<HoaDon_DTO> LayDSHoaDonTheoNgay(string ngaydau, string ngaycuoi)
        {
            return HoaDon_DAO.LayDSHoaDonTheoNgay(ngaydau, ngaycuoi);
        }

    }
}
