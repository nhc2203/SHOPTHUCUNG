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
    public partial class frmDoiSanPham : Form
    {
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtSanPham, dtlaysoluong, dtCTHoaDon, dtHoaDon, dtMaHoaDon, dtLayMaHD;
        DateTime TGHienTai = DateTime.Now;
        DateTime TGTam;
        string linhank = "";
        string ngay = "";
        string TenDichVu = "";
        int a;
        public static int coHieu = 0;
        public static double tiendu_tra = 0;
        public static double tienMoi = 0;
        public static int coHieu1 = 0;
        public frmDoiSanPham()
        {
            InitializeComponent();
        }
        public void showSanPham(string TenSP)
        {
            dataGridView_SanPham.AutoGenerateColumns = false;
            dtSanPham = db.LayDuLieu(" select * from SANPHAM where  TenSP like N'%" + TenSP + "%'");
            dataGridView_SanPham.DataSource = dtSanPham;
            dataGridView_SanPham.Columns[0].DataPropertyName = "TenSP";
            dataGridView_SanPham.Columns[1].DataPropertyName = "Gia";
            dataGridView_SanPham.Columns[2].DataPropertyName = "MoTa";
            dataGridView_SanPham.Columns[3].DataPropertyName = "Maloai";
            dataGridView_SanPham.Columns[4].DataPropertyName = "HinhAnh";
            Xoa_DataBindings();
            SanPham_Databiding();
        }
        private void LoadDataToCollection()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string sql = "select * from SanPham";
            dtSanPham = db.LayDuLieu(sql);
            string SetMaSP = " select count(*)+1 a from SanPham";
            dtlaysoluong = db.LayDuLieu(SetMaSP);
            int num;
            DataRow sl = dtlaysoluong.Rows[0];
            num = Convert.ToInt16(sl["a"].ToString());
            for (int i = 0; i < num - 1; i++)
            {
                DataRow getma = dtSanPham.Rows[i];
                auto2.Add(getma["TenSP"].ToString());
            }
            txt_Timkiem.AutoCompleteMode = AutoCompleteMode.Append;
            txt_Timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Timkiem.AutoCompleteCustomSource = auto2;
            txt_Timkiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Timkiem.AutoCompleteCustomSource = auto2;
        }
        public void trangthai()
        {
            txt_gia.Enabled = txt_loai.Enabled = txt_mota.Enabled = txt_tensp.Enabled = txt_Tien.Enabled = false;
            btn_chon.Enabled = btn_huy.Enabled = btn_XacNhan.Enabled = false;
        }
        void SanPham_Databiding()
        {
            txt_tensp.DataBindings.Add("Text", dtSanPham, "TenSP");
            txt_gia.DataBindings.Add("Text", dtSanPham, "Gia");
            txt_mota.DataBindings.Add("Text", dtSanPham, "MoTa");
            txt_loai.DataBindings.Add("Text", dtSanPham, "maloai");
        }
        public void Xoa_DataBindings()
        {
            txt_tensp.DataBindings.Clear();
            txt_gia.DataBindings.Clear();
            txt_mota.DataBindings.Clear();
            txt_loai.DataBindings.Clear();

        }
        public int Layvitritrung(string tensp)
        {
            for (int i = 0; i < dataGridView_SanPham.Rows.Count - 1; i++)
            {
                if (dataGridView_SanPham.Rows[i].Cells[0].Value.ToString() == tensp)
                {
                    return i;
                }
            }
            return 0;
        }
        public int Layvitritrung1(string tensp)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == tensp)
                {
                    return i;
                }
            }
            return 0;
        }
        public void xuLyChonDV(string tenSP)
        {
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells["Column7"].Value = txt_tensp.Text;
                row.Cells["Column8"].Value = numericUpDown1.Text;
                row.Cells["Column6"].Value = txt_gia.Text;
                row.Cells["Column9"].Value = tinhTienSanPhamDoi().ToString();

            }
            else
            {
                if (checkDichVu1(tenSP) == 0)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells["Column7"].Value = txt_tensp.Text;
                    row.Cells["Column8"].Value = numericUpDown1.Text;
                    row.Cells["Column6"].Value = txt_gia.Text;
                    row.Cells["Column9"].Value = tinhTienSanPhamDoi().ToString();
                }
                else
                {
                    int vitri = Layvitritrung1(tenSP);
                    string soluong = dataGridView1.Rows[vitri].Cells[1].Value.ToString();
                    a = int.Parse(soluong) + int.Parse(numericUpDown1.Text);
                    dataGridView1.Rows[vitri].Cells[1].Value = "" + a;
                    dataGridView1.Rows[vitri].Cells[3].Value = tinhTienSanPhamDoi().ToString();
                }
            }
        }
        public void XulyHuyMon()
        {
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào nhén !");
            }
            else
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                //MessageBox.Show("" + selectedrowindex);
                string tenmon = Convert.ToString(selectedRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Hủy Chọn Sản Phẩm: " + tenmon, "Thong Bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (!this.dataGridView1.Rows[selectedrowindex].IsNewRow)
                        {
                            this.dataGridView1.Rows.RemoveAt(selectedrowindex);
                            dataGridView1.Refresh();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loi Huy Mon !");
                    }
                }
            }
        }
        public void themHoaDon()
        {
            ngay = TGHienTai.ToString("yyyy - MM - dd HH:mm:ss");
            db.ThemXoaSua("Insert into HoaDon Values ('" + frmDoiTra.MaKH + "','" + ngay + "',0.0,'NV001')");
        }
        public string getMaHD(string makh, string manv)
        {
            string a = ngay + ".000";
            string sql = string.Format(@"select * from HOADON where MaKH ='{0}' and MaNV ='{1}' and NGAYHD = '" + a + "'  ", makh, manv);
            dtLayMaHD = db.LayDuLieu(sql);
            DataRow getma = dtLayMaHD.Rows[0];
            string maHD = getma["MaHD"].ToString();
            return maHD;
        }
        public void xulyOrder(string mahd, string tendv)
        {
            //nhâp chiết tiết vào hóa đơn mới
            dtCTHoaDon = db.LayDuLieu("select *from CTHoaDon");
            DataRow newrow = dtCTHoaDon.NewRow();
            newrow[0] = mahd;
            newrow[1] = getSanPham(tendv).ToString();
            newrow[2] = dataGridView1.Rows[Layvitritrung1(tendv)].Cells[1].Value.ToString();
            newrow[3] = dataGridView1.Rows[Layvitritrung1(tendv)].Cells[2].Value.ToString();
            dtCTHoaDon.Rows.Add(newrow);
            string sql1 = "select * from CTHoaDon";
            db.UpdateData(sql1, dtCTHoaDon);
            db.ThemXoaSua(" update SANPHAM set Soluong = Soluong - " + dataGridView1.Rows[Layvitritrung1(tendv)].Cells[1].Value.ToString() + " where MASP ='" + getSanPham(dataGridView1.Rows[Layvitritrung1(tendv)].Cells[0].Value.ToString()) + "'");

        }
        public string getSanPham(string tenSP)
        {
            string sql = string.Format(@"select * from SANPHAM Where TENSP = N'{0}'", tenSP);
            dtSanPham = db.LayDuLieu(sql);
            DataRow getma = dtSanPham.Rows[0];
            string masp = getma["MASP"].ToString();
            return masp;
        }
        public double tinhTien()
        {
            double tongTien = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tongTien = tongTien + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            return tongTien;
        }
        public double tinhTienSanPhamDoi()
        {
            double ThanhTien = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ThanhTien = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) * double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            return ThanhTien;
        }
        public int checkDichVu1(string tenSP)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().ToLower().Trim() == tenSP.ToLower().Trim())
                {
                    return 1;
                }
            }
            return 0;
        }
        public int checktrungtenSP(string tensp)
        {
            string masp = getSanPham(tensp);
            string sql = string.Format(@"select * from CTHoaDon Where MASP = N'{0}' and MaHD ='" + frmDoiTra.maHD + "'", masp);
            dtSanPham = db.LayDuLieu(sql);
            try
            {
                DataRow getma = dtSanPham.Rows[0];
                string ma = getma["MaSP"].ToString();
                if (masp == ma)
                {
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
            return 0; ;
        }
        public double tinhtien()
        {
            if (frmDoiTra.Tien > double.Parse(txt_Tien.Text))
            {
                coHieu1 = 1;
                return frmDoiTra.Tien - double.Parse(txt_Tien.Text);
            }
            else
            {
                coHieu1 = 2;
                return double.Parse(txt_Tien.Text) - frmDoiTra.Tien;
            }

        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            showSanPham(txt_Timkiem.Text);
            btn_chon.Enabled = true;

        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            xuLyChonDV(txt_tensp.Text);
            txt_Tien.Text = tinhTien().ToString();
            btn_huy.Enabled = btn_XacNhan.Enabled = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            XulyHuyMon();
            txt_Tien.Text = tinhTien().ToString();
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                btn_huy.Enabled = btn_XacNhan.Enabled = false;
                btn_chon.Enabled = true;
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đổi những sản phẩm này  ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                double tien = tinhtien();
                if (coHieu1 == 1)
                {
                    MessageBox.Show("Số tiền dư của quý khách là " + tien + " VND");
                    tiendu_tra = tien;
                    tienMoi = tinhTien();
                }
                if (coHieu1 == 2)
                {
                    MessageBox.Show("Quý khách cần thanh toán thêm số tiền là " + tien + " VND");
                    tiendu_tra = tien;
                    tienMoi = tinhTien();
                }
                themHoaDon();
                //MessageBox.Show(getMaHD("KH002", "NV001"));
                string Ma = getMaHD(frmDoiTra.MaKH, TruyenDuLieu.MANV).ToString();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    TenDichVu = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    xulyOrder(Ma, TenDichVu);
                    frmDoiTra.maHD = Ma;
                }
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                coHieu = 1;
                Close();
                //frmDoiTra a = new frmDoiTra();
                //a.Show();
                //frmMain formmain = new frmMain();
                //frmDoiTra FrmDP = new frmDoiTra();
                //formmain.Visible = true;
                //FrmDP.MdiParent = frmMain.ActiveForm;
                //FrmDP.Show();
            }
        }

        private void frmDoiSanPham_Load(object sender, EventArgs e)
        {
            trangthai();
            LoadDataToCollection();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int i = Layvitritrung(txt_tensp.Text);
            //    linhank = @"C:\Users\sword\OneDrive\Desktop\DA_LTCSHARP2_NHOM_02\3.Code\final_SHOPTHUCUNG\PETSHOP\husky\" + dataGridView_SanPham.Rows[i].Cells[4].Value.ToString();
            //    pictureBox5.Load(linhank);

            //}
            //catch
            //{
            //    MessageBox.Show("lỗi");
            //}
        }
    }

}
