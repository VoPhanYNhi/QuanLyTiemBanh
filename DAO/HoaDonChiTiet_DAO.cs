using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class HoaDonChiTiet_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất hoá đơn
        public static List<HoaDonChiTiet_DTO> LayDSHoaDonChiTiet()
        {
            string sTruyVan = "select * from hoadonchitiet";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonChiTiet_DTO> lstHD = new List<DTO.HoaDonChiTiet_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonChiTiet_DTO hd = new HoaDonChiTiet_DTO();
                hd.IMaHDCT = int.Parse(dt.Rows[i]["mahdct"].ToString());
                hd.IMaHoaDon = int.Parse(dt.Rows[i]["mahoadon"].ToString());
                hd.IMaBanh = int.Parse(dt.Rows[i]["mabanh"].ToString());
                hd.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());

                lstHD.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHD;
        }

        // Thêm hoá đơn chi tiết
        public static bool ThemHoaDonChiTiet(HoaDonChiTiet_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into hoadonchitiet values('{0}', '{1}', '{2}')", hd.IMaHoaDon, hd.IMaBanh, hd.ISoLuong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
