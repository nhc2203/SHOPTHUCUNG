﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALSanPham
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        public DALSanPham()
        {

        }
        public List<View_SanPham> loadSanPham()
        {
            List<SANPHAM> lsv = qlthucung.SANPHAMs.Select(t => t).ToList<SANPHAM>();
            var kq = lsv.ConvertAll(l => new View_SanPham()
            {

                MaSP = l.MaSP,
                TenSP = l.TenSP,
                SoLuong = l.Soluong,
                Gia = l.Gia,
                TinhTrang = l.TinhTrang,
                MoTa = l.MoTa,
                MaLoai = l.MaLoai,
                HinhAnh = l.HinhAnh

            });
            return kq.ToList<View_SanPham>();
        }
    }
}
