﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        // Hàm mã hóa
        // Tham khảo tại https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5.aspx 
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static TaiKhoan_DTO LayTaiKhoan(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAO.LayTaiKhoan(ten, matkhau_mahoa);
        }

        public static bool DoiMatKhau(TaiKhoan_DTO tk, string matkhaumoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhaumoi);
            tk.SMatKhau = matkhau_mahoa;
            return TaiKhoan_DAO.CapNhatTaiKhoan(tk);
        }
    }
}
