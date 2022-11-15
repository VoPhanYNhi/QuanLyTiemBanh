
namespace GUI
{
    partial class frmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.i_dmThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmBanBanh = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmBanh = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmLoaiBanh = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmHoaDonCT = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmSaoLuuPhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmSaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmPhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttTenHienThi = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.i_dmBanBanh,
            this.i_dmQuanLy,
            this.trợGiúpToolStripMenuItem,
            this.i_dmSaoLuuPhucHoi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dmDangXuat,
            this.i_dmDoiMK,
            this.toolStripSeparator1,
            this.i_dmThoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // i_dmDangXuat
            // 
            this.i_dmDangXuat.Name = "i_dmDangXuat";
            this.i_dmDangXuat.Size = new System.Drawing.Size(145, 22);
            this.i_dmDangXuat.Text = "Đăng xuất";
            this.i_dmDangXuat.Click += new System.EventHandler(this.i_dmDangXuat_Click);
            // 
            // i_dmDoiMK
            // 
            this.i_dmDoiMK.Name = "i_dmDoiMK";
            this.i_dmDoiMK.Size = new System.Drawing.Size(145, 22);
            this.i_dmDoiMK.Text = "Đổi mật khẩu";
            this.i_dmDoiMK.Click += new System.EventHandler(this.i_dmDoiMK_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // i_dmThoat
            // 
            this.i_dmThoat.Name = "i_dmThoat";
            this.i_dmThoat.Size = new System.Drawing.Size(145, 22);
            this.i_dmThoat.Text = "Thoát";
            this.i_dmThoat.Click += new System.EventHandler(this.i_dmThoat_Click);
            // 
            // i_dmBanBanh
            // 
            this.i_dmBanBanh.Name = "i_dmBanBanh";
            this.i_dmBanBanh.Size = new System.Drawing.Size(69, 20);
            this.i_dmBanBanh.Text = "Bán bánh";
            this.i_dmBanBanh.Click += new System.EventHandler(this.i_dmBanBanh_Click);
            // 
            // i_dmQuanLy
            // 
            this.i_dmQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dmBanh,
            this.i_dmLoaiBanh,
            this.i_dmHoaDon,
            this.i_dmHoaDonCT,
            this.i_dmThongKe});
            this.i_dmQuanLy.Name = "i_dmQuanLy";
            this.i_dmQuanLy.Size = new System.Drawing.Size(60, 20);
            this.i_dmQuanLy.Text = "Quản lý";
            // 
            // i_dmBanh
            // 
            this.i_dmBanh.Name = "i_dmBanh";
            this.i_dmBanh.Size = new System.Drawing.Size(159, 22);
            this.i_dmBanh.Text = "Bánh";
            this.i_dmBanh.Click += new System.EventHandler(this.i_dmBanh_Click);
            // 
            // i_dmLoaiBanh
            // 
            this.i_dmLoaiBanh.Name = "i_dmLoaiBanh";
            this.i_dmLoaiBanh.Size = new System.Drawing.Size(159, 22);
            this.i_dmLoaiBanh.Text = "Loại bánh";
            this.i_dmLoaiBanh.Click += new System.EventHandler(this.i_dmLoaiBanh_Click);
            // 
            // i_dmHoaDon
            // 
            this.i_dmHoaDon.Name = "i_dmHoaDon";
            this.i_dmHoaDon.Size = new System.Drawing.Size(159, 22);
            this.i_dmHoaDon.Text = "Hoá đơn";
            this.i_dmHoaDon.Click += new System.EventHandler(this.i_dmHoaDon_Click);
            // 
            // i_dmHoaDonCT
            // 
            this.i_dmHoaDonCT.Name = "i_dmHoaDonCT";
            this.i_dmHoaDonCT.Size = new System.Drawing.Size(159, 22);
            this.i_dmHoaDonCT.Text = "Hoá đơn chi tiết";
            this.i_dmHoaDonCT.Click += new System.EventHandler(this.i_dmHoaDonCT_Click);
            // 
            // i_dmThongKe
            // 
            this.i_dmThongKe.Name = "i_dmThongKe";
            this.i_dmThongKe.Size = new System.Drawing.Size(159, 22);
            this.i_dmThongKe.Text = "Thống kê";
            this.i_dmThongKe.Click += new System.EventHandler(this.i_dmThongKe_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dmHuongDan});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // i_dmHuongDan
            // 
            this.i_dmHuongDan.Name = "i_dmHuongDan";
            this.i_dmHuongDan.Size = new System.Drawing.Size(134, 22);
            this.i_dmHuongDan.Text = "Hướng dẫn";
            this.i_dmHuongDan.Click += new System.EventHandler(this.i_dmHuongDan_Click);
            // 
            // i_dmSaoLuuPhucHoi
            // 
            this.i_dmSaoLuuPhucHoi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dmSaoLuu,
            this.i_dmPhucHoi});
            this.i_dmSaoLuuPhucHoi.Name = "i_dmSaoLuuPhucHoi";
            this.i_dmSaoLuuPhucHoi.Size = new System.Drawing.Size(119, 20);
            this.i_dmSaoLuuPhucHoi.Text = "Sao lưu -  phục hồi";
            // 
            // i_dmSaoLuu
            // 
            this.i_dmSaoLuu.Name = "i_dmSaoLuu";
            this.i_dmSaoLuu.Size = new System.Drawing.Size(121, 22);
            this.i_dmSaoLuu.Text = "Sao lưu";
            this.i_dmSaoLuu.Click += new System.EventHandler(this.i_dmSaoLuu_Click);
            // 
            // i_dmPhucHoi
            // 
            this.i_dmPhucHoi.Name = "i_dmPhucHoi";
            this.i_dmPhucHoi.Size = new System.Drawing.Size(121, 22);
            this.i_dmPhucHoi.Text = "Phục hồi";
            this.i_dmPhucHoi.Click += new System.EventHandler(this.i_dmPhucHoi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttTenHienThi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttTenHienThi
            // 
            this.sttTenHienThi.Name = "sttTenHienThi";
            this.sttTenHienThi.Size = new System.Drawing.Size(118, 17);
            this.sttTenHienThi.Text = "toolStripStatusLabel1";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ TIỆM BÁNH";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_dmDangXuat;
        private System.Windows.Forms.ToolStripMenuItem i_dmDoiMK;
        private System.Windows.Forms.ToolStripMenuItem i_dmBanBanh;
        private System.Windows.Forms.ToolStripMenuItem i_dmQuanLy;
        private System.Windows.Forms.ToolStripMenuItem i_dmBanh;
        private System.Windows.Forms.ToolStripMenuItem i_dmLoaiBanh;
        private System.Windows.Forms.ToolStripMenuItem i_dmHoaDon;
        private System.Windows.Forms.ToolStripMenuItem i_dmHoaDonCT;
        private System.Windows.Forms.ToolStripMenuItem i_dmThongKe;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_dmHuongDan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttTenHienThi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem i_dmThoat;
        private System.Windows.Forms.ToolStripMenuItem i_dmSaoLuuPhucHoi;
        private System.Windows.Forms.ToolStripMenuItem i_dmSaoLuu;
        private System.Windows.Forms.ToolStripMenuItem i_dmPhucHoi;
    }
}

