using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmKhachHang : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLCBKhachHang bllkhachhang = new BLLCBKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void loadDataG()
        {
                       
                dataGridView_khachhang.DataSource = bllkhachhang.loadCBKhachHang();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDataG();
        }

        private void dataGridView_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dataGridView_khachhang.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dataGridView_khachhang.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView_khachhang.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = dataGridView_khachhang.CurrentRow.Cells[4].Value.ToString();
            txt_dth.Text = dataGridView_khachhang.CurrentRow.Cells[5].Value.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thêm khách hàng này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {

                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = txt_makh.Text;

                kh.TENKH = txt_tenkh.Text;
                kh.DIACHI = txt_diachi.Text;
                kh.DTHOAI = txt_dth.Text;
                kh.NGSINH = dateTimePicker1.Value;
                qlthucung.KHACHHANGs.InsertOnSubmit(kh);
                qlthucung.SubmitChanges();
                loadDataG();
                MessageBox.Show("Thêm hóa đơn thành công !!");
            }
        }
    }
}
