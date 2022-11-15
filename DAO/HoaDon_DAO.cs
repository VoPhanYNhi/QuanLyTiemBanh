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
    public class HoaDon_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất hoá đơn
        public static List<HoaDon_DTO> LayDSHoaDon()
        {
            string sTruyVan = "select * from hoadon";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHD = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.IMaHoaDon = int.Parse(dt.Rows[i]["mahoadon"].ToString());
                hd.DtNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());

                lstHD.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHD;
        }

        // Lấy mã hoá đơn hiện tại
        public static int LayMaHoaDonHT()
        {
            string sTruyVan = string.Format(@"select max(mahoadon) from hoadon");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            int ma = int.Parse(dt.Rows[0][0].ToString());

            DataProvider.DongKetNoi(con);
            return ma;
        }

        // Thêm hoá đơn bán bánh
        public static bool ThemHoaDonBanBanh(HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into hoadon(tongtien) values('{0}')", hd.FTongTien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Lấy danh sách hoá đơn theo ngày
        public static List<HoaDon_DTO> LayDSHoaDonTheoNgay(string ngaydau, string ngaycuoi)
        {
            string sTruyVan = string.Format(@"select * from hoadon where ngayban between '{0}' and '{1}'", ngaydau, ngaycuoi);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHD = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.IMaHoaDon = int.Parse(dt.Rows[i]["mahoadon"].ToString());
                hd.DtNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());

                lstHD.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHD;
        }
    }
}
