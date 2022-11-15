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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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

        private void dgDSHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSHoaDon.SelectedRows[0];
            txtMaHoaDon.Text = r.Cells["IMaHoaDon"].Value.ToString();
            txtTongTien.Text = r.Cells["FTongTien"].Value.ToString();
            dtNgayBan.Value = DateTime.Parse(r.Cells["DtNgayBan"].Value.ToString());
        }
    }
}
