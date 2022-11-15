using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Banh_BUS
    {
        //Lấy DS bánh
        public static List<Banh_DTO> LayDSBanh()
        {
            return Banh_DAO.LayDSBanh();
        }

        //Lấy DS bánh theo tên
        public static List<Banh_DTO> TimBanhTheoTen(string ten)
        {
            return Banh_DAO.TimBanhTheoTen(ten);
        }

        //Lấy DS bánh theo loại
        public static List<Banh_DTO> TimBanhTheoLoai(int loai)
        {
            return Banh_DAO.TimBanhTheoLoai(loai);
        }

        //Thêm 1 bánh
        public static bool ThemBanh(Banh_DTO ba)
        {
            return Banh_DAO.ThemBanh(ba);
        }

        //Sửa 1 bánh
        public static bool SuaBanh(Banh_DTO ba)
        {
            return Banh_DAO.SuaBanh(ba);
        }

        //Xoá 1 bánh
        public static bool XoaBanh(Banh_DTO ba)
        {
            return Banh_DAO.XoaBanh(ba);
        }

        //Lấy số lượng bánh
        public static int LaySoLuongBanhTheoMa(int ma)
        {
            return Banh_DAO.LaySoLuongBanhTheoMa(ma);
        }

        //Lấy số lượng bánh
        public static float LayGiaBanhTheoMa(int ma)
        {
            return Banh_DAO.LayGiaBanhTheoMa(ma);
        }

        //Sửa số lượng bánh
        public static bool SuaSLBanh(int ma, int soluong)
        {
            return Banh_DAO.SuaSLBanh(ma, soluong);
        }
    }
}
