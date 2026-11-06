using System.Collections.Generic;
using System.Linq;
using QuanLyCaPheSinhVien_DAO;
using QuanLyCaPheSinhVien_DTO;

namespace QuanLyCaPheSinhVien_BUS
{
    public class ThucDonBUS
    {
        private ThucDonDAO dao = new ThucDonDAO();

        public List<ThucDonDTO> LayDanhSach()
        {
            return dao.LayDanhSach();
        }

        public decimal LayGiaMon(string tenMon)
        {
            List<ThucDonDTO> danhSach = dao.LayDanhSach();

            ThucDonDTO mon = danhSach
                .FirstOrDefault(m => m.TenMon == tenMon);

            if (mon == null)
            {
                return 0;
            }

            return mon.DonGia;
        }
    }


}
