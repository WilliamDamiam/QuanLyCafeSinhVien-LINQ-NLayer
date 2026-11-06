using System.Collections.Generic;

namespace QuanLyCaPheSinhVien_BUS
{
    public class TinhTienBUS
    {
        private ThucDonBUS thucDonBUS = new ThucDonBUS();
        public decimal TinhTien(
            string tenCafe,
            int soKhach,
            bool laSinhVien,
            List<string> danhSachThucAn)
        {
            if (soKhach <= 0)
            {
                return 0;
            }

            decimal giaCafe = thucDonBUS.LayGiaMon(tenCafe);

            if (giaCafe <= 0)
            {
                return 0;
            }

            decimal tongTien = giaCafe * soKhach;

            foreach (string tenMon in danhSachThucAn)
            {
                decimal giaMon = thucDonBUS.LayGiaMon(tenMon);

                if (giaMon <= 0)
                {
                    return 0;
                }

                tongTien = tongTien + giaMon;
            }

            if (laSinhVien == true)
            {
                tongTien = tongTien * 80 / 100;
            }

            return tongTien;
        }
    }

}
