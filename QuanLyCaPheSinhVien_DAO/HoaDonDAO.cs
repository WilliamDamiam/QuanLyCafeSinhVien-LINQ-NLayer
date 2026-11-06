using System;
using System.Data.SqlClient;
using QuanLyCaPheSinhVien_DTO;
using System.Collections.Generic;

namespace QuanLyCaPheSinhVien_DAO
{
    public class HoaDonDAO
    {
        private string chuoiKetNoi =
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=QuanLyCafeSinhVien;
              Integrated Security=True";

        public int ThemHoaDon(HoaDonDTO hd)
        {
            using (SqlConnection conn =
                new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                string sql = @"INSERT INTO HoaDon
                    (TenKhachHang, SoKhach, LaSinhVien, TongTien)
                    OUTPUT INSERTED.MaHoaDon
                    VALUES
                    (@TenKhachHang, @SoKhach, @LaSinhVien, @TongTien)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@TenKhachHang", hd.TenKhachHang);

                cmd.Parameters.AddWithValue(
                    "@SoKhach", hd.SoKhach);

                cmd.Parameters.AddWithValue(
                    "@LaSinhVien", hd.LaSinhVien);

                cmd.Parameters.AddWithValue(
                    "@TongTien", hd.TongTien);

                // Them va lay ma hoa don moi
                int maHoaDon = Convert.ToInt32(
                    cmd.ExecuteScalar());

                return maHoaDon;
            }
        }

        public bool LuuHoaDon(HoaDonDTO hd, List<ChiTietHoaDonDTO> danhSachMon)
        {
            if (hd == null || danhSachMon == null || danhSachMon.Count == 0)
            {
                return false;
            }

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sql = @"INSERT INTO HoaDon
                (TenKhachHang, SoKhach, LaSinhVien, TongTien)
                OUTPUT INSERTED.MaHoaDon
                VALUES
                (@Ten, @SoKhach, @SinhVien, @TongTien)";

                    SqlCommand cmd = new SqlCommand(sql, conn, tran);

                    cmd.Parameters.AddWithValue(
                        "@Ten", hd.TenKhachHang);

                    cmd.Parameters.AddWithValue(
                        "@SoKhach", hd.SoKhach);

                    cmd.Parameters.AddWithValue(
                        "@SinhVien", hd.LaSinhVien);

                    cmd.Parameters.AddWithValue(
                        "@TongTien", hd.TongTien);

                    int maHoaDon = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (ChiTietHoaDonDTO ct in danhSachMon)
                    {
                        string sqlCT = @"INSERT INTO ChiTietHoaDon
                    (MaHoaDon, MaMon, SoLuong, DonGia)
                    VALUES
                    (@MaHoaDon, @MaMon, @SoLuong, @DonGia)";

                        SqlCommand cmdCT =
                            new SqlCommand(sqlCT, conn, tran);

                        cmdCT.Parameters.AddWithValue(
                            "@MaHoaDon", maHoaDon);

                        cmdCT.Parameters.AddWithValue(
                            "@MaMon", ct.MaMon);

                        cmdCT.Parameters.AddWithValue(
                            "@SoLuong", ct.SoLuong);

                        cmdCT.Parameters.AddWithValue(
                            "@DonGia", ct.DonGia);

                        cmdCT.ExecuteNonQuery();
                    }

                    tran.Commit();

                    return true;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }



    }
}
