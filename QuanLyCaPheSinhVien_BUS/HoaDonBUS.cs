using System.Collections.Generic;
using QuanLyCaPheSinhVien_DAO;
using QuanLyCaPheSinhVien_DTO;

namespace QuanLyCaPheSinhVien_BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAO dao = new HoaDonDAO();

        public bool ThanhToan(HoaDonDTO hd, List<ChiTietHoaDonDTO> danhSachMon)
        {
            if (hd == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(hd.TenKhachHang))
            {
                return false;
            }

            if (hd.SoKhach <= 0)
            {
                return false;
            }

            if (hd.TongTien <= 0)
            {
                return false;
            }

            if (danhSachMon == null || danhSachMon.Count == 0)
            {
                return false;
            }

            foreach (ChiTietHoaDonDTO ct in danhSachMon)
            {
                if (ct == null || ct.MaMon <= 0 ||
                    ct.SoLuong <= 0 || ct.DonGia <= 0)
                {
                    return false;
                }
            }

            hd.TenKhachHang = hd.TenKhachHang.Trim();

            return dao.LuuHoaDon(hd, danhSachMon);
        }
    }


}
