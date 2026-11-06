using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyCaPheSinhVien_DTO;

namespace QuanLyCaPheSinhVien_DAO
{
    public class ThucDonDAO
    {
        private string chuoiKetNoi =
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=QuanLyCafeSinhVien;
              Integrated Security=True";

        public List<ThucDonDTO> LayDanhSach()
        {
            List<ThucDonDTO> danhSach = new List<ThucDonDTO>();

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "sp_LayDanhSachThucDon", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ThucDonDTO mon = new ThucDonDTO();

                    mon.MaMon = Convert.ToInt32(reader["MaMon"]);
                    mon.TenMon = reader["TenMon"].ToString();
                    mon.LoaiMon = reader["LoaiMon"].ToString();
                    mon.DonGia = Convert.ToDecimal(reader["DonGia"]);

                    danhSach.Add(mon);
                }

                reader.Close();
            }

            return danhSach;
        }
    }
}
