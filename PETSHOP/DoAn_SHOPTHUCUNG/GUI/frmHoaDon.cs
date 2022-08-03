﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLHoaDon bllbanghoadon = new BLLHoaDon();
        BLLCBHoaDon bllcbhoadon = new BLLCBHoaDon();
        BLLSanPham bllsanpham = new BLLSanPham();
        BLLCBKhachHang bllcbkhachhang = new BLLCBKhachHang();
        BLLCBNhanVien bllcbnhanvien = new BLLCBNhanVien();
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtSanPham, dtlaysoluong;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void loadcombo()
        {

            cbo_mahd.DataSource = bllcbhoadon.loadCBHoaDon();
            cbo_mahd.DisplayMember = "MAHD";
            cbo_mahd.ValueMember = "MAHD";
            cbo_makh.DataSource = bllcbkhachhang.loadCBKhachHang();
            cbo_makh.DisplayMember = "TenKH";
            cbo_makh.ValueMember = "MaKH";
            cbo_manv.DataSource = bllcbnhanvien.loadCBNhanVien();
            cbo_manv.DisplayMember = "TenNV";
            cbo_manv.ValueMember = "MaNV";


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
            txt_timkiem.AutoCompleteMode = AutoCompleteMode.Append;
            txt_timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_timkiem.AutoCompleteCustomSource = auto2;
            txt_timkiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_timkiem.AutoCompleteCustomSource = auto2;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadcombo();
            loadDataG();
            LoadDataToCollection();
           

        }

        private void cbo_mahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataG();
            hientongtien();

        }
        public void loadDataG()
        {
           
            if (cbo_mahd.SelectedValue.ToString() != "DTO.HOADON")
            {
              
                int mahd = int.Parse(cbo_mahd.SelectedValue.ToString());
                dataGridView_CTHD.DataSource = bllbanghoadon.loadCTHoaDon(mahd);
                //dataGridView_SanPham.DataSource = bllsanpham.loadSanPham();
              
            }


        }
        public void hientongtien()
        {
            double tongtien = 0;
            int sc = dataGridView_CTHD.Rows.Count;
            for (int i = 0; i < sc; i++)
                tongtien += double.Parse(dataGridView_CTHD.Rows[i].Cells[4].Value.ToString());
            txt_tongtien.Text = tongtien.ToString();
        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sp.Text = dataGridView_SanPham.CurrentRow.Cells[1].Value.ToString();
            txt_masp.Text = dataGridView_SanPham.CurrentRow.Cells[0].Value.ToString();
            txt_dongia.Text = dataGridView_SanPham.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_mua_Click(object sender, EventArgs e)
        {
            if (cbo_mahd.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để thanh toán!!!");
            }
            else
            {
                DialogResult h = MessageBox.Show
                   ("Bạn có chắc muốn thanh toán hóa đơn " + cbo_mahd.SelectedValue.ToString() + " không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    if (dataGridView_CTHD.RowCount < 1)
                    {
                        MessageBox.Show("Chưa có sản phẩm trong hóa đơn!!!");
                        return;
                    }
                    else
                    {
                        if (nguoidung.upDateSoLuongSanPham(int.Parse(cbo_mahd.SelectedValue.ToString())) != -1)
                        {
                            MessageBox.Show("Đã Thanh toán hóa đơn với giá " + txt_tongtien.Text + "");
                            loadDataG();
                        }
                    }


                }
                }

        }
        public void bt_them_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            DialogResult h = MessageBox.Show
                  ("Bạn có chắc muốn thêm chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (txt_sp.Text == "")
                {
                    errorProvider1.SetError(txt_sp, "Không được để trống tên hóa đơn");
                    txt_sp.Focus();
                    return;
                }
                if (txt_dongia.Text == "" || !char.IsDigit(txt_dongia.Text.ToString(), 0))
                {
                    errorProvider2.SetError(txt_dongia, "Không được để trống đơn giá");
                    txt_dongia.Focus();
                    return;
                }
                if (nguoidung.GetSoLuongSanPham(txt_masp.Text) < number.Value)
                {
                    MessageBox.Show("Không đủ số lượng!!!");
                    return;
                }
                else
                {

                    CTHOADON hoadons = qlthucung.CTHOADONs.Where(t => t.MAHD == int.Parse(cbo_mahd.SelectedValue.ToString())).FirstOrDefault();
                    int sanphams = -1;
                    var sps = from sp in qlthucung.SANPHAMs
                              join
                                  cthd in qlthucung.CTHOADONs
                                  on sp.MaSP equals cthd.MASP
                              where cthd.MAHD.Equals(cbo_mahd.SelectedValue)
                              select new
                              {
                                  sp.MaSP
                              };
                    foreach (var product in sps)
                    {
                        sanphams = product.MaSP;
                    }

                    if (sanphams != -1)
                    {
                        if (hoadons.MAHD.Equals(int.Parse(cbo_mahd.SelectedValue.ToString())) && sanphams.Equals(int.Parse(txt_masp.Text)))
                        {
                            CTHOADON ct = qlthucung.CTHOADONs.Where(t => t.MAHD == hoadons.MAHD && t.MASP == sanphams).FirstOrDefault();
                            ct.SOLUONG += int.Parse(number.Value.ToString());
                            ct.DONGIA = decimal.Parse(txt_dongia.Text);
                            if (nguoidung.GetSoLuongSanPham(txt_masp.Text) < ct.SOLUONG)
                            {
                                MessageBox.Show("Không đủ số lượng!!!");
                                return;
                            }
                            qlthucung.SubmitChanges();
                            loadDataG();
                        }
                        else
                        {

                            CTHOADON cthd = new CTHOADON();
                            cthd.MAHD = int.Parse(cbo_mahd.SelectedValue.ToString());

                            cthd.MASP = int.Parse(txt_masp.Text);
                            cthd.SOLUONG = int.Parse(number.Value.ToString());
                            cthd.DONGIA = decimal.Parse(txt_dongia.Text);

                            qlthucung.CTHOADONs.InsertOnSubmit(cthd);
                            qlthucung.SubmitChanges();
                            loadDataG();
                        }
                    }

                    else
                    {

                        CTHOADON cthd = new CTHOADON();
                        cthd.MAHD = int.Parse(cbo_mahd.SelectedValue.ToString());

                        cthd.MASP = int.Parse(txt_masp.Text);
                        cthd.SOLUONG = int.Parse(number.Value.ToString());
                        cthd.DONGIA = decimal.Parse(txt_dongia.Text);

                        qlthucung.CTHOADONs.InsertOnSubmit(cthd);
                        qlthucung.SubmitChanges();
                        loadDataG();
                    }

                }
            }
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                  ("Bạn có chắc muốn xóa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int cthd = int.Parse(dataGridView_CTHD.CurrentRow.Cells[0].Value.ToString());
                CTHOADON ct = qlthucung.CTHOADONs.Where(t => t.MAHD == cthd).FirstOrDefault();
                qlthucung.CTHOADONs.DeleteOnSubmit(ct);
                qlthucung.SubmitChanges();
                loadDataG();
            }
        }


        private void dataGridView_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_sp.Text = dataGridView_SanPham.CurrentRow.Cells[1].Value.ToString();
            number.Value = int.Parse(dataGridView_SanPham.CurrentRow.Cells[2].Value.ToString());
            txt_masp.Text = dataGridView_SanPham.CurrentRow.Cells[0].Value.ToString();
            txt_dongia.Text = dataGridView_SanPham.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                 ("Bạn có chắc muốn sửa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int cthd = int.Parse(dataGridView_CTHD.CurrentRow.Cells[0].Value.ToString());
                CTHOADON ct = qlthucung.CTHOADONs.Where(t => t.MAHD == cthd).FirstOrDefault();
                ct.SOLUONG = int.Parse(number.Value.ToString());
                ct.DONGIA = decimal.Parse(txt_dongia.Text);
                if (nguoidung.GetSoLuongSanPham(txt_masp.Text) < number.Value)
                {
                    MessageBox.Show("Không đủ số lượng!!!");
                    return;
                }
                qlthucung.SubmitChanges();
                loadDataG();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbo_mahd.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in!!!");
            }
            else
            {
                TruyenDuLieu.MAHD = int.Parse(cbo_mahd.SelectedValue.ToString());
                frmInHoaDon frm = new frmInHoaDon();
                frm.ShowDialog();
            }
        }

        private void bt_them2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                 ("Bạn có chắc muốn thêm chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {

                HOADON hd = new HOADON();
                hd.MANV = cbo_manv.SelectedValue.ToString();

                hd.MAKH = cbo_makh.SelectedValue.ToString();
                hd.NGAYHD = DateTime.Now;

                qlthucung.HOADONs.InsertOnSubmit(hd);
                qlthucung.SubmitChanges();
                loadDataG();
                MessageBox.Show("Thêm hóa đơn thành công !!");
            }
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
        void SanPham_Databiding()
        {
            txt_sp.DataBindings.Add("Text", dtSanPham, "TenSP");
            txt_dongia.DataBindings.Add("Text", dtSanPham, "Gia");
            txt_masp.DataBindings.Add("Text", dtSanPham, "MaSP");
        }
        public void Xoa_DataBindings()
        {
            txt_sp.DataBindings.Clear();
            txt_dongia.DataBindings.Clear();
            txt_masp.DataBindings.Clear();

        }
        private void bt_tim_Click(object sender, EventArgs e)
        {
            showSanPham(txt_timkiem.Text);
        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
             int cthd;
            var cts = from kh in qlthucung.CTHOADONs
                      join
                     hd in qlthucung.HOADONs
                     on kh.MAHD equals hd.MAHD
                      where hd.MAHD.Equals(cbo_mahd.SelectedValue)
                      select new
                      {
                          kh.MAHD
                      };

            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn xóa chi tiết hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (cts != null)
                {
                    foreach (var customer in cts)
                    {
                        cthd = customer.MAHD;
                        CTHOADON ct = qlthucung.CTHOADONs.Where(t => t.MAHD == cthd).FirstOrDefault();
                        qlthucung.CTHOADONs.DeleteOnSubmit(ct);
                        qlthucung.SubmitChanges();
                        loadDataG();
                    }
                }
                int hd = int.Parse(cbo_mahd.SelectedValue.ToString());
                HOADON hoadon = qlthucung.HOADONs.Where(t => t.MAHD == hd).FirstOrDefault();
                qlthucung.HOADONs.DeleteOnSubmit(hoadon);
                qlthucung.SubmitChanges();
                loadcombo();
            }
        }
        
    }
}
