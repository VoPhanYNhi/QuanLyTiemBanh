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
    public partial class frmBanh : Form
    {
        public frmBanh()
        {
            InitializeComponent();
        }

        private void frmBanh_Load(object sender, EventArgs e)
        {
           
            HienThiLoaiBanhLenCombobox();          
            HienThiDSBanhLenDatagrid();
            HienThiCotLoai();
            HienThiLoai();
        }

        private void HienThiLoaiBanhLenCombobox()
        {
            List<LoaiBanh_DTO> lstLoaiBanh = LoaiBanh_BUS.LayDSLoaiBanh();
            cboLoaiBanh.DataSource = lstLoaiBanh;
            cboLoaiBanh.DisplayMember = "STenLoai";
            cboLoaiBanh.ValueMember = "IMaLoai";

            cboTimLoai.DataSource = lstLoaiBanh;
            cboTimLoai.DisplayMember = "STenLoai";
            cboTimLoai.ValueMember = "IMaLoai";
        }

        private void HienThiDSBanhLenDatagrid()
        {
            List<Banh_DTO> lstBanh = Banh_BUS.LayDSBanh();
            dgDSBanh.DataSource = lstBanh;

            dgDSBanh.Columns["IMaBanh"].HeaderText = "Mã bánh";
            //dgDSBanh.Columns["IMaLoai"].HeaderText = "Mã loại";
            dgDSBanh.Columns["STenBanh"].HeaderText = "Tên bánh";
            dgDSBanh.Columns["ISoLuong"].HeaderText = "Số lượng";
            dgDSBanh.Columns["FGia"].HeaderText = "Giá";

            dgDSBanh.Columns["IMaLoai"].Visible = false;
            dgDSBanh.Columns["IMaBanh"].Width = 80;
            dgDSBanh.Columns["STenBanh"].Width = 200;
            dgDSBanh.Columns["ISoLuong"].Width = 80;
            dgDSBanh.Columns["FGia"].Width = 150;

        }

        private void HienThiCotLoai()
        {
            DataGridViewColumn clTenLoai = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            clTenLoai.CellTemplate = cell;
            clTenLoai.Name = "STenLoai";
            clTenLoai.HeaderText = "Tên loại";
            clTenLoai.Width = 170;
            dgDSBanh.Columns.Add(clTenLoai);
        }

        private void HienThiLoai()
        {
            // Hiển thị tên loại tương ứng
            string tenloai;

            for (int i = 0; i < dgDSBanh.RowCount; i++)
            {
                tenloai = LoaiBanh_BUS.LayTenLoaiBanhTheoMa(int.Parse(dgDSBanh.Rows[i].Cells["IMaLoai"].Value.ToString()));
                dgDSBanh.Rows[i].Cells["STenLoai"].Value = tenloai;
               
            }
        }

        private void dgDSBanh_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSBanh.SelectedRows[0];
            txtMaBanh.Text = r.Cells["IMaBanh"].Value.ToString();
            txtTenBanh.Text = r.Cells["STenBanh"].Value.ToString();
            cboLoaiBanh.SelectedValue = int.Parse(r.Cells["IMaLoai"].Value.ToString());
            txtSoLuong.Text = r.Cells["ISoLuong"].Value.ToString();
            txtDonGia.Text = r.Cells["FGia"].Value.ToString();
        }

        private void btnTimLoai_Click(object sender, EventArgs e)
        {
            int loai = int.Parse(cboTimLoai.SelectedValue.ToString());
            List<Banh_DTO> lstBanh = Banh_BUS.TimBanhTheoLoai(loai);
            if (lstBanh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSBanh.DataSource = lstBanh;
            HienThiLoai();
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            string ten = txtTimTen.Text;
            List<Banh_DTO> lstBanh = Banh_BUS.TimBanhTheoTen(ten);
            if (lstBanh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSBanh.DataSource = lstBanh;
            HienThiLoai();
        }

        private void btnHuyTim_Click(object sender, EventArgs e)
        {
            HienThiDSBanhLenDatagrid();
            HienThiLoai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtTenBanh.Text == "" || txtDonGia.Text =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            Banh_DTO ba = new Banh_DTO();
            ba.STenBanh = txtTenBanh.Text;
            ba.IMaLoai = int.Parse(cboLoaiBanh.SelectedValue.ToString());
            ba.ISoLuong = int.Parse(txtSoLuong.Value.ToString());
            ba.FGia = float.Parse(txtDonGia.Text);

            if (Banh_BUS.ThemBanh(ba) == false)
            {
                MessageBox.Show("Không thêm được");
                return;
            }
            HienThiDSBanhLenDatagrid();
            MessageBox.Show("Đã thêm bánh");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Banh_DTO ba = new Banh_DTO();
            ba.IMaBanh = int.Parse(txtMaBanh.Text);
            ba.STenBanh = txtTenBanh.Text;
            ba.IMaLoai = int.Parse(cboLoaiBanh.SelectedValue.ToString());
            ba.ISoLuong = int.Parse(txtSoLuong.Value.ToString());
            ba.FGia = float.Parse(txtDonGia.Text);

            if (Banh_BUS.SuaBanh(ba) == true)
            {
                HienThiDSBanhLenDatagrid();
                HienThiLoai();
                MessageBox.Show("Đã cập nhật thông tin bánh");
            }
            else
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Banh_DTO ba = new Banh_DTO();
            ba.IMaBanh = int.Parse(txtMaBanh.Text);

            if (Banh_BUS.XoaBanh(ba) == true)
            {
                HienThiDSBanhLenDatagrid();
                HienThiLoai(); 
                MessageBox.Show("Đã xoá bánh");
            }
            else
            {
                MessageBox.Show("Không xoá được");
            }
        }
    }
}
