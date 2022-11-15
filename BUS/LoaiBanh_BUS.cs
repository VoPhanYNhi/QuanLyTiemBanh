using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiBanh_BUS
    {
        //Lấy DS loại bánh
        public static List<LoaiBanh_DTO> LayDSLoaiBanh()
        {
            return LoaiBanh_DAO.LayDSLoaiBanh();
        }

        //Thêm 1 loại bánh
        public static bool ThemLoaiBanh(LoaiBanh_DTO lb)
        {
            return LoaiBanh_DAO.ThemLoaiBanh(lb);
        }

        //Sửa 1 loại bánh
        public static bool SuaLoaiBanh(LoaiBanh_DTO lb)
        {
            return LoaiBanh_DAO.SuaLoaiBanh(lb);
        }

        //Xóa 1 loại bánh
        public static bool XoaLoaiBanh(LoaiBanh_DTO lb)
        {
            return LoaiBanh_DAO.XoaLoaiBanh(lb);
        }

        //Lấy DS loại bánh theo tên
        public static List<LoaiBanh_DTO> TimLoaiBanhTheoTen(string ten)
        {
            return LoaiBanh_DAO.TimLoaiBanhTheoTen(ten);
        }

        //Lấy tên một loại bánh theo mã
        public static string LayTenLoaiBanhTheoMa(int ma)
        {
            return LoaiBanh_DAO.LayTenLoaiBanhTheoMa(ma);
        }
    }
}
