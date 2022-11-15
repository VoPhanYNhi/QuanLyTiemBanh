using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;


namespace GUI
{
    public partial class frmLoaiBanh : Form
    {
        public frmLoaiBanh()
        {
            InitializeComponent();
        }

        private void frmLoaiBanh_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiBanhLenDatagrid();
        }

        private void HienThiDSLoaiBanhLenDatagrid()
        {
            List<LoaiBanh_DTO> lstLoaiBanh = LoaiBanh_BUS.LayDSLoaiBanh();
            dgDSLoaiBanh.DataSource = lstLoaiBanh;

            dgDSLoaiBanh.Columns["IMaLoai"].HeaderText = "Mã loại";
            dgDSLoaiBanh.Columns["STenLoai"].HeaderText = "Tên loại bánh";
            dgDSLoaiBanh.Columns["IMaLoai"].Width = 110;
            dgDSLoaiBanh.Columns["STenLoai"].Width = 280;
        }

        private void dgDSLoaiBanh_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSLoaiBanh.SelectedRows[0];
            txtMaLoai.Text = r.Cells["IMaLoai"].Value.ToString();
            txtTenLoai.Text = r.Cells["STenLoai"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtTenLoai.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            LoaiBanh_DTO lb = new LoaiBanh_DTO();
            lb.STenLoai = txtTenLoai.Text;

            if (LoaiBanh_BUS.ThemLoaiBanh(lb) == false)
            {
                MessageBox.Show("Không thêm được");
                return;
            }
            HienThiDSLoaiBanhLenDatagrid();
            MessageBox.Show("Đã thêm loại bánh");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiBanh_DTO lb = new LoaiBanh_DTO();
            lb.IMaLoai = int.Parse(txtMaLoai.Text);
            lb.STenLoai = txtTenLoai.Text;

            if (LoaiBanh_BUS.SuaLoaiBanh(lb) == true)
            {
                HienThiDSLoaiBanhLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin loại bánh");
            }
            else
            {
                MessageBox.Show("Không cập nhật được");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaiBanh_DTO lb = new LoaiBanh_DTO();
            lb.IMaLoai = int.Parse(txtMaLoai.Text);

            if (LoaiBanh_BUS.XoaLoaiBanh(lb) == true)
            {
                HienThiDSLoaiBanhLenDatagrid();
                MessageBox.Show("Đã xoá loại bánh");
            }
            else
            {
                MessageBox.Show("Không xoá được");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTimTenLoai.Text;
            List<LoaiBanh_DTO> lstLoaiBanh = LoaiBanh_BUS.TimLoaiBanhTheoTen(ten);
            if(lstLoaiBanh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSLoaiBanh.DataSource = lstLoaiBanh;
        }
    }
}
