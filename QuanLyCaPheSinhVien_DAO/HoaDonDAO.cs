using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyCaPheSinhVien_DTO;

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
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "sp_ThemHoaDon", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@TenKhachHang", hd.TenKhachHang);

                cmd.Parameters.AddWithValue(
                    "@SoKhach", hd.SoKhach);

                cmd.Parameters.AddWithValue(
                    "@LaSinhVien", hd.LaSinhVien);

                cmd.Parameters.AddWithValue(
                    "@TongTien", hd.TongTien);

                int maHoaDon = Convert.ToInt32(
                    cmd.ExecuteScalar());

                return maHoaDon;
            }
        }

        public bool LuuHoaDon(
            HoaDonDTO hd,
            List<ChiTietHoaDonDTO> danhSachMon)
        {
            if (hd == null || danhSachMon == null ||
                danhSachMon.Count == 0)
            {
                return false;
            }

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(
                            "sp_ThemHoaDon", conn, tran);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@TenKhachHang", hd.TenKhachHang);

                        cmd.Parameters.AddWithValue(
                            "@SoKhach", hd.SoKhach);

                        cmd.Parameters.AddWithValue(
                            "@LaSinhVien", hd.LaSinhVien);

                        cmd.Parameters.AddWithValue(
                            "@TongTien", hd.TongTien);

                        int maHoaDon = Convert.ToInt32(
                            cmd.ExecuteScalar());

                        foreach (ChiTietHoaDonDTO ct in danhSachMon)
                        {
                            SqlCommand cmdCT = new SqlCommand(
                                "sp_ThemChiTietHoaDon", conn, tran);

                            cmdCT.CommandType =
                                CommandType.StoredProcedure;

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
}
