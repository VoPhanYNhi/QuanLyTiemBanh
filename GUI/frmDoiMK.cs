using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        string tenDN;

        public frmDoiMK(string stenDN)
        {
            tenDN = stenDN;
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txtMKcu.UseSystemPasswordChar = true;
            txtMKmoi.UseSystemPasswordChar = true;
            txtMKnhaplai.UseSystemPasswordChar = true;
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                txtMKcu.UseSystemPasswordChar = false;
                txtMKmoi.UseSystemPasswordChar = false;
                txtMKnhaplai.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKcu.UseSystemPasswordChar = true;
                txtMKmoi.UseSystemPasswordChar = true;
                txtMKnhaplai.UseSystemPasswordChar = true;
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if(txtMKmoi.Text != txtMKnhaplai.Text)
            {
                MessageBox.Show("Mật khẩu phải khớp");
                return;
            }
            // xác nhận mật khẩu cũ
            if (TaiKhoan_BUS.LayTaiKhoan(tenDN, txtMKcu.Text) == null)
            {
                MessageBox.Show("Mật khẩu không đúng.");
                return;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.STenDangNhap = tenDN;
            tk.SMatKhau = txtMKcu.Text;
            // ghi nhận mật khẩu mới
            if (TaiKhoan_BUS.DoiMatKhau(tk, txtMKmoi.Text) == false)
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            MessageBox.Show("Đã thay đổi mật khẩu.");
        }
    }
}
