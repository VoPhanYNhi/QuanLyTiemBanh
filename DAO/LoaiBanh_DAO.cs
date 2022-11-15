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
    public class LoaiBanh_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả loại bánh
        public static List<LoaiBanh_DTO> LayDSLoaiBanh()
        {
            string sTruyVan = "select * from loaibanh";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiBanh_DTO> lstLoaiBanh = new List<DTO.LoaiBanh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiBanh_DTO lb = new LoaiBanh_DTO();
                lb.IMaLoai = int.Parse(dt.Rows[i]["maloai"].ToString());
                lb.STenLoai = dt.Rows[i]["tenloai"].ToString();

                lstLoaiBanh.Add(lb);
            }
            DataProvider.DongKetNoi(con);
            return lstLoaiBanh;
        }


        // Thêm loại bánh
        public static bool ThemLoaiBanh(LoaiBanh_DTO lb)
        {
            string sTruyVan = string.Format(@"insert into loaibanh values(N'{0}')", lb.STenLoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Sửa loại bánh
        public static bool SuaLoaiBanh(LoaiBanh_DTO lb)
        {
            string sTruyVan = string.Format(@"update loaibanh set tenloai=N'{0}' where maloai=N'{1}'", lb.STenLoai, lb.IMaLoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        // Xóa loại bánh
        public static bool XoaLoaiBanh(LoaiBanh_DTO lb)
        {
            string sTruyVan = string.Format(@"delete from loaibanh where maloai=N'{0}'", lb.IMaLoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Tìm ds loại bánh theo tên, trả về null nếu không thấy
        public static List<LoaiBanh_DTO> TimLoaiBanhTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from loaibanh where tenloai like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<LoaiBanh_DTO> lstLoaiBanh = new List<DTO.LoaiBanh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiBanh_DTO lb = new LoaiBanh_DTO();
                lb.IMaLoai = int.Parse(dt.Rows[i]["maloai"].ToString());
                lb.STenLoai = dt.Rows[i]["tenloai"].ToString();

                lstLoaiBanh.Add(lb);
            }
            DataProvider.DongKetNoi(con);
            return lstLoaiBanh;
        }

        // Lấy thông tin loại bánh có mã ma, trả về null nếu không thấy
        public static string LayTenLoaiBanhTheoMa(int ma)
        {
            string sTruyVan = string.Format(@"select tenloai from loaibanh where maloai='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            string tenLoai = dt.Rows[0]["tenloai"].ToString();

            DataProvider.DongKetNoi(con);
            return tenLoai;
        }
    }
}
