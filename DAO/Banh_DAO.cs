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
    public class Banh_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả bánh
        public static List<Banh_DTO> LayDSBanh()
        {
            string sTruyVan = "select * from banh";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Banh_DTO> lstBanh = new List<DTO.Banh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Banh_DTO ba = new Banh_DTO();
                ba.IMaBanh = int.Parse(dt.Rows[i]["mabanh"].ToString());
                ba.IMaLoai = int.Parse(dt.Rows[i]["maloai"].ToString());
                ba.STenBanh = dt.Rows[i]["tenbanh"].ToString();
                ba.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ba.FGia = float.Parse(dt.Rows[i]["gia"].ToString());

                lstBanh.Add(ba);
            }
            DataProvider.DongKetNoi(con);
            return lstBanh;
        }

        // Tìm ds bánh theo tên, trả về null nếu không thấy
        public static List<Banh_DTO> TimBanhTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from banh where tenbanh like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Banh_DTO> lstBanh = new List<DTO.Banh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Banh_DTO ba = new Banh_DTO();
                ba.IMaBanh = int.Parse(dt.Rows[i]["mabanh"].ToString());
                ba.IMaLoai = int.Parse(dt.Rows[i]["maloai"].ToString());
                ba.STenBanh = dt.Rows[i]["tenbanh"].ToString();
                ba.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ba.FGia = float.Parse(dt.Rows[i]["gia"].ToString());

                lstBanh.Add(ba);
            }
            DataProvider.DongKetNoi(con);
            return lstBanh;
        }

        // Tìm ds bánh theo loại, trả về null nếu không thấy
        public static List<Banh_DTO> TimBanhTheoLoai(int loai)
        {
            string sTruyVan = string.Format(@"select * from banh where maloai = '{0}'", loai);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Banh_DTO> lstBanh = new List<DTO.Banh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Banh_DTO ba = new Banh_DTO();
                ba.IMaBanh = int.Parse(dt.Rows[i]["mabanh"].ToString());
                ba.IMaLoai = int.Parse(dt.Rows[i]["maloai"].ToString());
                ba.STenBanh = dt.Rows[i]["tenbanh"].ToString();
                ba.ISoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ba.FGia = float.Parse(dt.Rows[i]["gia"].ToString());

                lstBanh.Add(ba);
            }
            DataProvider.DongKetNoi(con);
            return lstBanh;
        }

        // Thêm bánh
        public static bool ThemBanh(Banh_DTO ba)
        {
            string sTruyVan = string.Format(@"insert into banh values(N'{0}','{1}','{2}','{3}')", ba.STenBanh, ba.IMaLoai, ba.ISoLuong, ba.FGia);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Sửa bánh
        public static bool SuaBanh(Banh_DTO ba)
        {
            string sTruyVan = string.Format(@"update banh set tenbanh=N'{0}', maloai='{1}', soluong='{2}', gia='{3}' where mabanh='{4}'", ba.STenBanh, ba.IMaLoai, ba.ISoLuong, ba.FGia, ba.IMaBanh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        // Xóa loại bánh
        public static bool XoaBanh(Banh_DTO ba)
        {
            string sTruyVan = string.Format(@"delete from banh where mabanh='{0}'", ba.IMaBanh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Lấy số lượng bánh theo mã
        public static int LaySoLuongBanhTheoMa(int ma)
        {
            string sTruyVan = string.Format(@"select soluong from banh where mabanh='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            int soLuong = int.Parse(dt.Rows[0]["soluong"].ToString());

            DataProvider.DongKetNoi(con);
            return soLuong;
        }


        // Lấy giá bánh theo mã
        public static float LayGiaBanhTheoMa(int ma)
        {
            string sTruyVan = string.Format(@"select gia from banh where mabanh='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            float gia = float.Parse(dt.Rows[0]["gia"].ToString());

            DataProvider.DongKetNoi(con);
            return gia;
        }

        // Sửa số lượng bánh
        public static bool SuaSLBanh(int ma, int soluong)
        {
            string sTruyVan = string.Format(@"update banh set soluong=soluong-'{0}' where mabanh='{1}'", soluong, ma);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
    }
}
