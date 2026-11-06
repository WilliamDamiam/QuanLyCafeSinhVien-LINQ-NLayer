using System.Data;
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
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "sp_ThemChiTietHoaDon", conn);

                cmd.CommandType = CommandType.StoredProcedure;

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
