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
    public partial class frmBanBanh : Form
    {
        public frmBanBanh()
        {
            InitializeComponent();
        }

        private void frmBanBanh_Load(object sender, EventArgs e)
        {
            //txtMaHoaDon.Text = HoaDon_BUS.LayMaHoaDonHT() +"";
            txtTongTien.Text = "0";
            HienThiBanhLenCombobox();
        }

        private void HienThiBanhLenCombobox()
        {
            List<Banh_DTO> lstBanh = Banh_BUS.LayDSBanh();
            cboBanh.DataSource = lstBanh;
            cboBanh.DisplayMember = "STenBanh";
            cboBanh.ValueMember = "IMaBanh";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sl = Banh_BUS.LaySoLuongBanhTheoMa(int.Parse(cboBanh.SelectedValue.ToString()));
            float gia = Banh_BUS.LayGiaBanhTheoMa(int.Parse(cboBanh.SelectedValue.ToString()));
            if (int.Parse(txtSoLuong.Value.ToString()) > sl)
            {
                MessageBox.Show("Bánh đã hết");
                return;
            }
            DataGridViewRow row = (DataGridViewRow)dgDSChonBanh.Rows[0].Clone();
            row.Cells[3].Value = cboBanh.SelectedValue.ToString();
            row.Cells[0].Value = cboBanh.Text;
            row.Cells[1].Value = txtSoLuong.Value.ToString();
            row.Cells[2].Value = gia;
            dgDSChonBanh.Rows.Add(row);
            txtTongTien.Text = int.Parse(txtTongTien.Text) + int.Parse(txtSoLuong.Value.ToString())*gia + "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSChonBanh.SelectedRows[0];
            txtTongTien.Text = int.Parse(txtTongTien.Text) - int.Parse(r.Cells[2].Value.ToString()) * int.Parse(r.Cells[1].Value.ToString()) + "";
            dgDSChonBanh.Rows.Remove(r);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTimBanh.Text;
            List<Banh_DTO> lstBanh = Banh_BUS.TimBanhTheoTen(ten);
            if (lstBanh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            cboBanh.DataSource = lstBanh;
            cboBanh.DisplayMember = "STenBanh";
            cboBanh.ValueMember = "IMaBanh";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtTongTien.Text) == 0)
            {
                MessageBox.Show("Vui lòng chọn món!");
                return;
            }
                       

            HoaDon_DTO hd = new HoaDon_DTO();
            hd.FTongTien = float.Parse(txtTongTien.Text);

            if (HoaDon_BUS.ThemHoaDonBanBanh(hd) == false)
            {
                MessageBox.Show("Không thanh toán được");
                return;
            }
            int mahd = HoaDon_BUS.LayMaHoaDonHT();
            DataGridViewRow dr;

            for (int i = 0; i < dgDSChonBanh.RowCount - 1; i++)
            {
                dr = dgDSChonBanh.Rows[i];
                //MessageBox.Show("Bánh " + dr.Cells[0].Value.ToString()+mahd);
                HoaDonChiTiet_DTO hdct = new HoaDonChiTiet_DTO();
                hdct.IMaHoaDon = mahd;
                hdct.IMaBanh = int.Parse(dr.Cells[3].Value.ToString());
                hdct.ISoLuong = int.Parse(dr.Cells[1].Value.ToString());
                if(Banh_BUS.SuaSLBanh(hdct.IMaBanh, hdct.ISoLuong) == false)
                {
                    MessageBox.Show("Lỗi số lượng");
                }
                if (HoaDonChiTiet_BUS.ThemHoaDonChiTiet(hdct) == false)
                {
                    MessageBox.Show("Không thêm được"+ hdct.IMaHoaDon+" bánh"+ hdct.IMaBanh+" sl "+ hdct.ISoLuong);
                    return;
                }
            }
            MessageBox.Show("Đã thanh toán");
            this.Controls.Clear();
            this.InitializeComponent();
            frmBanBanh_Load(sender,  e);
        }

    }
}
