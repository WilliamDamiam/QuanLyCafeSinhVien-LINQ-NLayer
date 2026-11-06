using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPheSinhVien_DTO
{
    public class HoaDonDTO
    {
        public int MaHoaDon { get; set; }

        public string TenKhachHang { get; set; }

        public int SoKhach { get; set; }
        public bool LaSinhVien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTien { get; set; }
    }
}