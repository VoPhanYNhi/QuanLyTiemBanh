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

namespace GUI
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private string stenDN;
        private string stenHT;
        private int iquyen;

        public frmChinh(string tenDN, string tenHT, int quyen)
        {
            stenDN = tenDN;
            stenHT = tenHT;
            iquyen = quyen;
            InitializeComponent();
        }

        frmBanBanh fBB;
        frmBanh fB;
        frmLoaiBanh fLB;
        frmHoaDon fHD;
        frmHoaDonChiTiet fCT;
        frmThongKe fTK;
        frmDoiMK fMK;

        private void i_dmBanBanh_Click(object sender, EventArgs e)
        {
            if (fBB == null || fBB.IsDisposed)
            {
                fBB = new frmBanBanh();
                fBB.MdiParent = this;
                fBB.Show();
            }
        }

        private void i_dmBanh_Click(object sender, EventArgs e)
        {
            if (fB == null || fB.IsDisposed)
            {
                fB = new frmBanh();
                fB.MdiParent = this;
                fB.Show();
            }
        }

        private void i_dmLoaiBanh_Click(object sender, EventArgs e)
        {
            if (fLB == null || fLB.IsDisposed)
            {
                fLB = new frmLoaiBanh();
                fLB.MdiParent = this;
                fLB.Show();
            }
        }

        private void i_dmHoaDon_Click(object sender, EventArgs e)
        {
            if (fHD == null || fHD.IsDisposed)
            {
                fHD = new frmHoaDon();
                fHD.MdiParent = this;
                fHD.Show();
            }
        }

        private void i_dmHoaDonCT_Click(object sender, EventArgs e)
        {
            if (fCT == null || fCT.IsDisposed)
            {
                fCT = new frmHoaDonChiTiet();
                fCT.MdiParent = this;
                fCT.Show();
            }
        }

        private void i_dmThongKe_Click(object sender, EventArgs e)
        {
            if (fTK == null || fTK.IsDisposed)
            {
                fTK = new frmThongKe();
                fTK.MdiParent = this;
                fTK.Show();
            }
        }

        private void HienThiMenu(string tenHT, int quyen)
        {
            sttTenHienThi.Text = "Người dùng: " + tenHT;
            if(quyen == 1)
            {
                i_dmBanBanh.Visible = true;
                i_dmQuanLy.Visible = true;
                i_dmSaoLuuPhucHoi.Visible = true;
            }
            else
            {
                i_dmBanBanh.Visible = true;
                i_dmQuanLy.Visible = false;
                i_dmSaoLuuPhucHoi.Visible = false;
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            HienThiMenu(stenHT, iquyen);
        }

        private void i_dmDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void i_dmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void i_dmDoiMK_Click(object sender, EventArgs e)
        {
            if (fMK == null || fMK.IsDisposed)
            {
                fMK = new frmDoiMK(stenDN);
                fMK.MdiParent = this;
                fMK.Show();
            }
        }

        private void i_dmSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void i_dmPhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
            phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.PhucHoi(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại" + sDuongDan);
            }
        }

        private void i_dmHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QLTB.chm");
        }
    }
}
