using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmHoaDonChiTiet : Form
    {
        public frmHoaDonChiTiet()
        {
            InitializeComponent();
        }

        private void frmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            HienThiDSHoaDonCTLenDatagrid();
        }

        private void HienThiDSHoaDonCTLenDatagrid()
        {
            List<HoaDonChiTiet_DTO> lstHD = HoaDonChiTiet_BUS.LayDSHoaDonChiTiet();
            dgDSHDCT.DataSource = lstHD;

            dgDSHDCT.Columns["IMaHDCT"].HeaderText = "Mã hoá đơn chi tiết";
            dgDSHDCT.Columns["IMaHoaDon"].HeaderText = "Mã hoá đơn";
            dgDSHDCT.Columns["IMaBanh"].HeaderText = "Mã bánh";
            dgDSHDCT.Columns["ISoLuong"].HeaderText = "Số lượng";
            dgDSHDCT.Columns["IMaHDCT"].Width = 120;
            dgDSHDCT.Columns["IMaHoaDon"].Width = 120;
            dgDSHDCT.Columns["IMaBanh"].Width = 120;
            dgDSHDCT.Columns["ISoLuong"].Width = 100;

        }
    }
}
