using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonChiTiet_BUS
    {
        //Lấy DS hoá đơn
        public static List<HoaDonChiTiet_DTO> LayDSHoaDonChiTiet()
        {
            return HoaDonChiTiet_DAO.LayDSHoaDonChiTiet();
        }

        //Thêm hoá đơn chi tiết
        public static bool ThemHoaDonChiTiet(HoaDonChiTiet_DTO hd)
        {
            return HoaDonChiTiet_DAO.ThemHoaDonChiTiet(hd);
        }
    }
}
