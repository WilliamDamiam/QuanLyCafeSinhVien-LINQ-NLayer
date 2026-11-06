using System.Data.SqlClient;
using QuanLyCaPheSinhVien_DTO;

namespace QuanLyCaPheSinhVien_DAO
{
    public class ChiTietHoaDonDAO
    {
        private string chuoiKetNoi =
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=QuanLyCafeSinhVien;
              Integrated Security=True";
        public bool ThemChiTietHoaDon(ChiTietHoaDonDTO ct)
        {
            using (SqlConnection conn =
                new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                string sql = @"INSERT INTO ChiTietHoaDon
                    (MaHoaDon, MaMon, SoLuong, DonGia)
                    VALUES
                    (@MaHoaDon, @MaMon, @SoLuong, @DonGia)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaHoaDon", ct.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaMon", ct.MaMon);
                cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", ct.DonGia);
                int ketQua = cmd.ExecuteNonQuery();

                return ketQua > 0;
            }
        }


    }
}
