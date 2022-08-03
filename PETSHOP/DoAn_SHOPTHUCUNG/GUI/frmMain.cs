using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            phanQuyen();
        }

        private void kếtNốiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnection frmConnec = new frmConnection();
            frmConnec.MdiParent = this;
            frmConnec.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.MdiParent = this;
            frmHD.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.MdiParent = this;
            frmNV.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.MdiParent = this;
            frmKH.Show();
        }

        private void báoCáoTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoNgay frmbaocaongay = new frmBaoCaoNgay();
             frmbaocaongay.MdiParent = this;
            frmbaocaongay.Show();
        }

        private void báoCáoTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThang frmbaocaongay = new frmBaoCaoThang();
            frmbaocaongay.MdiParent = this;
            frmbaocaongay.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHang frmnhaphang = new frmNhapHang();
            frmnhaphang.MdiParent = this;
            frmnhaphang.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmnhacungcap = new frmNhaCungCap();
            frmnhacungcap.MdiParent = this;
            frmnhacungcap.Show();
        }
        public void Admin(bool Quyen)
        {
            hệThốngToolStripMenuItem.Enabled = Quyen;
            trangChủToolStripMenuItem.Enabled = Quyen;
            nhânViênToolStripMenuItem.Enabled = Quyen;
            thôngTinKháchHàngToolStripMenuItem.Enabled = Quyen;
            báoCáoThốngKêToolStripMenuItem.Enabled = Quyen;
        }
        public void NhanVien(bool Quyen)
        {
            hệThốngToolStripMenuItem.Enabled = Quyen;
            nhậpHàngToolStripMenuItem.Enabled = !Quyen;
            báoCáoThốngKêToolStripMenuItem.Enabled = Quyen;
            kếtNốiHệThốngToolStripMenuItem.Enabled = !Quyen;
            bánHàngToolStripMenuItem.Enabled = !Quyen;
        }

        public void phanQuyen()
        {
            if (TruyenDuLieu.ChucVu == "Quản lý")
            {
                Admin(true);
            }
            else if (TruyenDuLieu.ChucVu == "Nhân viên")
            {
                NhanVien(true);
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đổiTrảSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiTra frm = new frmDoiTra();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
