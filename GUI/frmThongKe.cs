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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            HienThiDSHoaDonLenDatagrid();
        }

        private void HienThiDSHoaDonLenDatagrid()
        {
            List<HoaDon_DTO> lstHD = HoaDon_BUS.LayDSHoaDon();
            dgDSHoaDon.DataSource = lstHD;

            dgDSHoaDon.Columns["IMaHoaDon"].HeaderText = "Mã hoá đơn";
            dgDSHoaDon.Columns["DtNgayBan"].HeaderText = "Ngày bán";
            dgDSHoaDon.Columns["fTongTien"].HeaderText = "Tổng tiền";
            dgDSHoaDon.Columns["IMaHoaDon"].Width = 100;
            dgDSHoaDon.Columns["DtNgayBan"].Width = 170;
            dgDSHoaDon.Columns["fTongTien"].Width = 120;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string ngayDau = dtNgayBatDau.Value.ToString("MM/dd/yyyy");
            string ngayCuoi = dtNgayKetThuc.Value.ToString("MM/dd/yyyy");

            List<HoaDon_DTO> lstHD = HoaDon_BUS.LayDSHoaDonTheoNgay(ngayDau, ngayCuoi);
            if (lstHD == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSHoaDon.DataSource = lstHD;
            DataGridViewRow dr;
            float Tong = 0;
            for (int i = 0; i < dgDSHoaDon.RowCount; i++)
            {
                dr = dgDSHoaDon.Rows[i];
                Tong += float.Parse(dr.Cells["FTongTien"].Value.ToString());
            }
            txtTongDoanhThu.Text = Tong + "";
            txtTongHD.Text = dgDSHoaDon.RowCount + "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiDSHoaDonLenDatagrid();
            DataGridViewRow dr;
            float Tong = 0;
            for (int i = 0; i < dgDSHoaDon.RowCount; i++)
            {
                dr = dgDSHoaDon.Rows[i];
                Tong += float.Parse(dr.Cells["FTongTien"].Value.ToString());
            }
            txtTongDoanhThu.Text = Tong + "";
            txtTongHD.Text = dgDSHoaDon.RowCount + "";
        }
    }
}
