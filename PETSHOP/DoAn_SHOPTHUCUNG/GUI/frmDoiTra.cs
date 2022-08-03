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
    public partial class frmDoiTra : Form
    {
        public static string maHD = "";
        public static double Tien = 0.0;
        public static string MaKH = "";
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtHoaDon, dtCTHoaDon, dtKhachHang;
        DataColumn[] keySP = new DataColumn[1];
        DateTime TGHienTai = DateTime.Now;
        public frmDoiTra()
        {
            InitializeComponent();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            timkiem(txt_MaHD.Text, dpk_ngaydat.Text);
            txt_tongTien.Text = tinhTienhoadon().ToString();
            btn_chonSPTRa.Enabled = true;
            maHD = txt_MaHD.Text;
        }
        public void timkiem(string mahd, string ngaymua)
        {
            try
            {
                DateTime ngaymuahang = DateTime.Parse(ngaymua);
                if (kiemTraHD(mahd, ngaymua) == 1)
                {
                    if (KiemTraNgayHoaDon(ngaymuahang, TGHienTai) == 1)
                    {
                        showCTHoaDon(mahd);
                        getKhachHang(MaKH);
                    }
                }
            }
            catch
            {
                MessageBox.Show("lỗi rồi");
            }

        }
        public void getKhachHang(string makh)
        {
            string sql = string.Format(@"select * from KhachHang Where MAKH = N'{0}'", makh);
            dtKhachHang = db.LayDuLieu(sql);
            DataRow getma = dtKhachHang.Rows[0];
            txt_TenKH.Text = getma["TenKH"].ToString();
            txt_SDT.Text = getma["DTHOAI"].ToString();
        }
        public string getSanPham(string tenSP)
        {
            string sql = string.Format(@"select * from SANPHAM Where TENSP = N'{0}'", tenSP);
            dtKhachHang = db.LayDuLieu(sql);
            DataRow getma = dtKhachHang.Rows[0];
            string masp = getma["MASP"].ToString();
            return masp;
        }
        public int KiemTraNgayHoaDon(DateTime ngaymua, DateTime ngaytra)
        {
            ngaymua = Convert.ToDateTime(dpk_ngaydat.Text);
            ngaytra = Convert.ToDateTime(TGHienTai);
            TimeSpan Time = ngaytra - ngaymua;
            int TongSoNgay = Time.Days;
            if (TongSoNgay > 7)
            {
                MessageBox.Show("Hóa đơn không đủ điều kiện để đổi trả");
                return 0;
            }
            else
            {
                MessageBox.Show("Hóa đơn đủ điều kiện để đổi trả");
                return 1;
            }
        }
        public void showCTHoaDon(string mahd)
        {
            dataGridView_CTHoaDon.AutoGenerateColumns = false;
            dtCTHoaDon = db.LayDuLieu("select ROW_NUMBER() OVER (ORDER BY MaHD) AS STT,(CThoaDon.SOLUONG * DONGIA) as ThanhTien, TenSP,CThoaDon.SOLUONG ,DonGia from CTHOADON,SANPHAM where SANPHAM.MaSP=CTHOADON.MaSP  and MAHD = '" + mahd + "'");
            dataGridView_CTHoaDon.DataSource = dtCTHoaDon;
            dataGridView_CTHoaDon.Columns[0].DataPropertyName = "STT";
            dataGridView_CTHoaDon.Columns[1].DataPropertyName = "TenSP";
            dataGridView_CTHoaDon.Columns[2].DataPropertyName = "SOLUONG";
            dataGridView_CTHoaDon.Columns[3].DataPropertyName = "DonGia";
            dataGridView_CTHoaDon.Columns[4].DataPropertyName = "ThanhTien";
            Xoa_DataBindings();
            CTHoaDon_Databiding();
        }
        public int kiemTraHD(string mahd, string ngaymua)
        {
            dtHoaDon = db.LayDuLieu("select * from HOADON where MAHD='" + mahd + "'");
            try
            {
                DataRow getma = dtHoaDon.Rows[0];
                string ngay = getma["NGAYHD"].ToString();
                MaKH = getma["MAKH"].ToString();
                txt_tongTien.Text = getma["TONGTIEN"].ToString();
                if (ngay.Contains(ngaymua))
                {
                    MessageBox.Show("Hóa đơn hợp lệ");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Hóa đơn không tồn tại");
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            return 0;
        }
        public void CTHoaDon_Databiding()
        {
            txt_tenSP.DataBindings.Add("Text", dtCTHoaDon, "TenSP");
            txt_soLuong.DataBindings.Add("Text", dtCTHoaDon, "SOLUONG");
            txt_donGia.DataBindings.Add("Text", dtCTHoaDon, "DonGia");
            txt_ThanhTien.DataBindings.Add("Text", dtCTHoaDon, "ThanhTien");
        }
        public void Xoa_DataBindings()
        {
            txt_tenSP.DataBindings.Clear();
            txt_soLuong.DataBindings.Clear();
            txt_donGia.DataBindings.Clear();
            txt_ThanhTien.DataBindings.Clear();

        }
        private void btn_chonSPTRa_Click(object sender, EventArgs e)
        {
            xuLyChonDV(txt_tenSP.Text);
            txt_TienTra.Text = tinhTienTraLai().ToString();
            txt_PhuPhi.Text = (tinhTienTraLai() * 0.05).ToString();
            txt_TienDu.Text = (double.Parse(txt_TienTra.Text) - (double.Parse(txt_TienTra.Text) * 0.05)).ToString();
            btn_Huy.Enabled = btn_XacNhan.Enabled = btn_doi.Enabled = true;
        }
        public void xuLyChonDV(string tenSP)
        {
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells["Column7"].Value = txt_tenSP.Text;
                row.Cells["Column8"].Value = txt_soLuong.Text;
                row.Cells["Column6"].Value = txt_donGia.Text;
                row.Cells["Column9"].Value = txt_ThanhTien.Text;

            }
            else
            {
                if (checkDichVu1(tenSP) == 1)
                {
                    MessageBox.Show("Sản phẩm đã được chọn");
                }
                else
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells["Column7"].Value = txt_tenSP.Text;
                    row.Cells["Column8"].Value = txt_soLuong.Text;
                    row.Cells["Column6"].Value = txt_donGia.Text;
                    row.Cells["Column9"].Value = txt_ThanhTien.Text;
                }
            }
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
        public double tinhTienTraLai()
        {
            double tongTien = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tongTien = tongTien + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            return tongTien;
        }
        public double tinhTienhoadon()
        {
            double tongTien = 0;
            for (int i = 0; i < dataGridView_CTHoaDon.Rows.Count - 1; i++)
            {
                tongTien = tongTien + double.Parse(dataGridView_CTHoaDon.Rows[i].Cells[4].Value.ToString());
            }
            return tongTien;
        }
        public void xacNhanTra(string mahd)
        {
            try
            {
                //db.ThemXoaSua(" update HoaDon set MaNV = '" + MaNV + "',NgayHD = GETDATE() where MAHD ='" + mahd + "'");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    db.ThemXoaSua(" delete  from CTHOADON  where  MAHD='" + mahd + "' and MASP ='" + getSanPham(dataGridView1.Rows[i].Cells[0].Value.ToString()) + "'");
                    db.ThemXoaSua(" update SANPHAM set Soluong = Soluong + " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " where MASP ='" + getSanPham(dataGridView1.Rows[i].Cells[0].Value.ToString()) + "'");
                }
                MessageBox.Show("succsess");
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                showCTHoaDon(mahd);
            }
            catch
            {
                MessageBox.Show("lỗi rồi ");
            }

        }
        public void XulyHuy()
        {
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào hết nhé!");
            }
            else
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                //MessageBox.Show("" + selectedrowindex);
                string tenmon = Convert.ToString(selectedRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác Nhận hủy: " + tenmon, "Thong Bao", MessageBoxButtons.YesNo);
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
                        MessageBox.Show("Loi Huy sản phẩm !");
                    }
                }
            }
        }
        public void trangthai()
        {
            txt_TenKH.Enabled = txt_donGia.Enabled = txt_SDT.Enabled = txt_soLuong.Enabled = txt_tenSP.Enabled = txt_ThanhTien.Enabled = false;
            txt_tongTien.Enabled = txt_TienTra.Enabled = false;
            txt_PhuPhi.Enabled = txt_TienDu.Enabled = false;
        }
        public void trangthaiBTN(bool mo)
        {
            btn_chonSPTRa.Enabled = btn_XacNhan.Enabled = btn_doi.Enabled = mo;
            btn_Huy.Enabled = mo;
            btn_resert.Enabled = mo;
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận trả hàng ", "Thong Bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                double tien = double.Parse(txt_TienTra.Text) - (double.Parse(txt_TienTra.Text) * 0.05);
                MessageBox.Show("Sô tiền trả lại cho khách là " + tien + " VND");
                xacNhanTra(txt_MaHD.Text);
                trangthaiBTN(false);
            }
        }

        private void btn_doi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận đổi những sản phẩm này ", "Thong Bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                double tien = int.Parse(txt_TienTra.Text) - (int.Parse(txt_TienTra.Text) * 0.05);
                Tien = tien;
                xacNhanTra(txt_MaHD.Text);
                frmDoiSanPham a = new frmDoiSanPham();
                a.Show();
                btn_resert.Enabled = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            XulyHuy();
            txt_TienTra.Text = tinhTienTraLai().ToString();
            txt_PhuPhi.Text = (tinhTienTraLai() * 0.05).ToString();
            txt_TienDu.Text = (double.Parse(txt_TienTra.Text) - (double.Parse(txt_TienTra.Text) * 0.05)).ToString();
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                btn_Huy.Enabled = btn_XacNhan.Enabled = btn_doi.Enabled = false;
            }
        }

        private void frmDoiTra_Load(object sender, EventArgs e)
        {
            trangthai();
            trangthaiBTN(false);
            if (frmDoiSanPham.coHieu == 1)
            {
                txt_MaHD.Text = maHD;
                showCTHoaDon(maHD);
                getKhachHang(MaKH);
                if (frmDoiSanPham.coHieu1 == 1)
                {
                    label11.Text = "Tiền dư hóa đơn cũ";
                    txt_TienTra.Text = Tien.ToString();
                    lab_phuphi.Text = "Tiền sản phẩm đã đổi";
                    txt_PhuPhi.Text = frmDoiSanPham.tienMoi.ToString();
                    lab_tienDu.Text = "Tiền dư";
                    txt_TienDu.Text = frmDoiSanPham.tiendu_tra.ToString();

                }
                if (frmDoiSanPham.coHieu1 == 2)
                {
                    label11.Text = "Tiền dư hóa đơn cũ";
                    txt_TienTra.Text = Tien.ToString();
                    lab_phuphi.Text = "Tiền sản phẩm đã đổi";
                    txt_PhuPhi.Text = frmDoiSanPham.tienMoi.ToString();
                    lab_tienDu.Text = "Tiền khách phải trả";
                    txt_TienDu.Text = frmDoiSanPham.tiendu_tra.ToString();
                }

            }
            frmDoiSanPham.coHieu = 0;
        }

        private void btn_resert_Click(object sender, EventArgs e)
        {
            frmDoiTra_Load(sender, e);
        }

    }
}
