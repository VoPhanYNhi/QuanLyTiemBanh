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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text == "") {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được bỏ trống!");
                return;
            }
            TaiKhoan_DTO tk = TaiKhoan_BUS.LayTaiKhoan(txtTenDN.Text, txtMatKhau.Text);
            if(tk == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản");
                txtTenDN.Text = "";
                txtMatKhau.Text = "";
                return;
            }

            this.Visible = false;
            frmChinh fCh = new frmChinh(tk.STenDangNhap, tk.STenHienThi, tk.ILoaiTK);
            fCh.ShowDialog();
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            this.Visible = true;
        }
    }
}
