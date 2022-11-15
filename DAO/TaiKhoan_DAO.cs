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
    public class TaiKhoan_DAO
    {
        static SqlConnection con;

        // Lấy thông tin tài khoản có tên đăng nhập và mật khẩu tương ứng, trả về null nếu không thấy
        public static TaiKhoan_DTO LayTaiKhoan(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from taikhoan where tendangnhap=N'{0}' and matkhau='{1}'", ten, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.STenDangNhap = dt.Rows[0]["tendangnhap"].ToString();
            tk.STenHienThi = dt.Rows[0]["TenHienThi"].ToString();            
            tk.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            tk.ILoaiTK = int.Parse(dt.Rows[0]["type"].ToString());


            DataProvider.DongKetNoi(con);
            return tk;
        }

        public static bool CapNhatTaiKhoan(TaiKhoan_DTO tk)
        {
            string sql = string.Format(@"update taikhoan set matkhau='{0}' where tendangnhap='{1}'", tk.SMatKhau, tk.STenDangNhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
