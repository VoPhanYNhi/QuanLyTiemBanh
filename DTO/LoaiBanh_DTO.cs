using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiBanh_DTO
    {
        private int iMaLoai;
        private string sTenLoai;

        public int IMaLoai{ get => iMaLoai; set => iMaLoai = value; }
        public string STenLoai { get => sTenLoai; set => sTenLoai = value; }
    }
}
