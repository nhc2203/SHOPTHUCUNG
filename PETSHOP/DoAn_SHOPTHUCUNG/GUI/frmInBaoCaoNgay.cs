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
    public partial class frmInBaoCaoNgay : Form
    {
        QL_NguoiDung xldt = new QL_NguoiDung();
        public frmInBaoCaoNgay()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoNgay_Load(object sender, EventArgs e)
        {
            
        }

        public void loadBaoCao()
        {
            DataTable dt = new DataTable();
            dt = xldt.DocDuLieu("select SANPHAM.TenSP, HOADON.NGAYHD, CTNHAPHANG.DONGIA AS DONGIANHAP, CTHOADON.DONGIA AS DONGIABAN, SUM(CTHOADON.SOLUONG) AS SoLuong,SUM(CTHOADON.DONGIA * CTHOADON.SOLUONG - CTNHAPHANG.DONGIA * CTHOADON.SOLUONG) AS DOANHTHU \n" +
        "  " + "                 from CTNHAPHANG INNER JOIN \n" +
        "  " + "                                   CTHOADON ON CTNHAPHANG.MASP = CTHOADON.MASP INNER JOIN \n" +
        "   " + "                                  HOADON ON CTHOADON.MAHD = HOADON.MAHD INNER JOIN \n" +
        "   " + "                                  NHAPHANG ON CTNHAPHANG.MANHAP = NHAPHANG.MANHAP INNER JOIN \n" +
        "   " + "                                  SANPHAM ON CTNHAPHANG.MASP = SANPHAM.MaSP AND CTHOADON.MASP = SANPHAM.MaSP \n" +
        "   " + "               and NGAYHD = '" + TruyenDuLieu.ngaybaocao.ToString("yyyy-M-dd") + "' GROUP BY SANPHAM.TenSP, HOADON.NGAYHD, CTNHAPHANG.DONGIA, CTHOADON.DONGIA");

            BaoCaoNgay rpBao = new BaoCaoNgay();
            rpBao.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpBao;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            loadBaoCao();
        }
    }
}
