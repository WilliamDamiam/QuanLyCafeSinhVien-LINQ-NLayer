using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCaPheSinhVien_BUS;
using QuanLyCaPheSinhVien_DTO;
namespace QuanLyCafeSinhVien
{
    public partial class FormQuanLyCaPheSinhVien : Form
    {
        private TinhTienBUS tinhTienBUS = new TinhTienBUS();
        private HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private ThucDonBUS thucDonBUS = new ThucDonBUS();
        decimal tienTamTinh = 0;
        int soKhachTamTinh = 0;
        int tongSoKhach = 0;
        decimal tongTienThanhToan = 0;

        public FormQuanLyCaPheSinhVien()
        {
            InitializeComponent();

            this.Load -= Form1_Load;
            this.Load += Form1_Load;

            btnTinhTien.Click -= btnTinhTien_Click;
            btnTinhTien.Click += btnTinhTien_Click;

            btnNhapLai.Click -= btnNhapLai_Click;
            btnNhapLai.Click += btnNhapLai_Click;

            btnThanhToan.Click -= btnThanhToan_Click;
            btnThanhToan.Click += btnThanhToan_Click;

            btnThoat.Click -= btnThoat_Click;
            btnThoat.Click += btnThoat_Click;

            txtSoKhachHang.KeyPress -= txtSoKhachHang_KeyPress;
            txtSoKhachHang.KeyPress += txtSoKhachHang_KeyPress;

            txtTenKhachHang.TextChanged -= KiemTraThongTin;
            txtTenKhachHang.TextChanged += KiemTraThongTin;

            txtSoKhachHang.TextChanged -= KiemTraThongTin;
            txtSoKhachHang.TextChanged += KiemTraThongTin;

            radCafeDen.CheckedChanged -= KiemTraThongTin;
            radCafeDen.CheckedChanged += KiemTraThongTin;
            radCafeDa.CheckedChanged -= KiemTraThongTin;
            radCafeDa.CheckedChanged += KiemTraThongTin;
            radCafeSua.CheckedChanged -= KiemTraThongTin;
            radCafeSua.CheckedChanged += KiemTraThongTin;
            radCafeSuaDa.CheckedChanged -= KiemTraThongTin;
            radCafeSuaDa.CheckedChanged += KiemTraThongTin;
            radCafeKem.CheckedChanged -= KiemTraThongTin;
            radCafeKem.CheckedChanged += KiemTraThongTin;

            chkBanhMyTrung.CheckedChanged -= KiemTraThongTin;
            chkBanhMyTrung.CheckedChanged += KiemTraThongTin;
            chkBanhMyCa.CheckedChanged -= KiemTraThongTin;
            chkBanhMyCa.CheckedChanged += KiemTraThongTin;
            chkMyTomTrung.CheckedChanged -= KiemTraThongTin;
            chkMyTomTrung.CheckedChanged += KiemTraThongTin;
            chkMyXaoBo.CheckedChanged -= KiemTraThongTin;
            chkMyXaoBo.CheckedChanged += KiemTraThongTin;
            chkMyCay.CheckedChanged -= KiemTraThongTin;
            chkMyCay.CheckedChanged += KiemTraThongTin;

            chkSinhVien.CheckedChanged -= KiemTraThongTin;
            chkSinhVien.CheckedChanged += KiemTraThongTin;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;
            btnThoat.Enabled = true;

            lblSoKhachDaThanhToan.Text = "0";
            lblTienDaThanhToan.Text = "0 VNĐ";

            txtTenKhachHang.Focus();
        }
        private void txtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KiemTraThongTin(object sender, EventArgs e)
        {
            tienTamTinh = 0;
            soKhachTamTinh = 0;
            btnThanhToan.Enabled = false;
            btnTinhTien.Enabled = false;

            if (txtTenKhachHang.Text.Trim() == "")
                return;

            int soKhach;
            if (!int.TryParse(txtSoKhachHang.Text, out soKhach))
                return;

            if (soKhach <= 0)
                return;

            if (radCafeDen.Checked || radCafeDa.Checked ||
                radCafeSua.Checked || radCafeSuaDa.Checked ||
                radCafeKem.Checked)
            {
                btnTinhTien.Enabled = true;
            }
        }

      
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txtTenKhachHang.Focus();
                return;
            }

            int soKhach;

            if (!int.TryParse(txtSoKhachHang.Text, out soKhach)
                || soKhach <= 0)
            {
                MessageBox.Show("Số khách phải lớn hơn 0!");
                return;
            }

            string tenCafe = "";

            if (radCafeDen.Checked)
                tenCafe = "Cafe đen";
            else if (radCafeDa.Checked)
                tenCafe = "Cafe đá";
            else if (radCafeSua.Checked)
                tenCafe = "Cafe sữa";
            else if (radCafeSuaDa.Checked)
                tenCafe = "Cafe sữa đá";
            else if (radCafeKem.Checked)
                tenCafe = "Cafe kem";

            if (tenCafe == "")
            {
                MessageBox.Show("Vui lòng chọn loại cafe!");
                return;
            }

            List<string> danhSachThucAn = new List<string>();

            if (chkBanhMyTrung.Checked)
                danhSachThucAn.Add("Bánh mỳ trứng");

            if (chkBanhMyCa.Checked)
                danhSachThucAn.Add("Bánh mỳ cá");

            if (chkMyTomTrung.Checked)
                danhSachThucAn.Add("Mỳ tôm trứng");

            if (chkMyXaoBo.Checked)
                danhSachThucAn.Add("Mỳ xào bò");

            if (chkMyCay.Checked)
                danhSachThucAn.Add("Mỳ cay");

            bool laSinhVien = chkSinhVien.Checked;

            try
            {
                tienTamTinh = tinhTienBUS.TinhTien(
                    tenCafe,
                    soKhach,
                    laSinhVien,
                    danhSachThucAn);

                // Kiem tra ket qua
                if (tienTamTinh <= 0)
                {
                    MessageBox.Show("Không tìm thấy giá món trong SQL Server!");
                    return;
                }

                soKhachTamTinh = soKhach;

                MessageBox.Show(
                    "Tên khách hàng: " + txtTenKhachHang.Text.Trim() +
                    "\nSố khách: " + soKhach +
                    "\nTổng tiền: " + tienTamTinh.ToString("N0") + " VNĐ",
                    "KẾT QUẢ TÍNH TIỀN");

                btnNhapLai.Enabled = true;
                btnThanhToan.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tính tiền: " + ex.GetBaseException().Message);
            }


        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Clear();
            txtSoKhachHang.Clear();

            radCafeDen.Checked = false;
            radCafeDa.Checked = false;
            radCafeSua.Checked = false;
            radCafeSuaDa.Checked = false;
            radCafeKem.Checked = false;

            chkBanhMyTrung.Checked = false;
            chkBanhMyCa.Checked = false;
            chkMyTomTrung.Checked = false;
            chkMyXaoBo.Checked = false;
            chkMyCay.Checked = false;
            chkSinhVien.Checked = false;

            tienTamTinh = 0;
            soKhachTamTinh = 0;

            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            txtTenKhachHang.Focus();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (soKhachTamTinh <= 0 || btnThanhToan.Enabled == false)
            {
                MessageBox.Show("Vui lòng tính tiền trước!");
                return;
            }

            HoaDonDTO hd = new HoaDonDTO();

            hd.TenKhachHang = txtTenKhachHang.Text.Trim();
            hd.SoKhach = soKhachTamTinh;
            hd.LaSinhVien = chkSinhVien.Checked;
            hd.TongTien = tienTamTinh;

            List<string> tenMon = new List<string>();

            if (radCafeDen.Checked)
                tenMon.Add("Cafe đen");
            else if (radCafeDa.Checked)
                tenMon.Add("Cafe đá");
            else if (radCafeSua.Checked)
                tenMon.Add("Cafe sữa");
            else if (radCafeSuaDa.Checked)
                tenMon.Add("Cafe sữa đá");
            else if (radCafeKem.Checked)
                tenMon.Add("Cafe kem");

            if (chkBanhMyTrung.Checked)
                tenMon.Add("Bánh mỳ trứng");

            if (chkBanhMyCa.Checked)
                tenMon.Add("Bánh mỳ cá");

            if (chkMyTomTrung.Checked)
                tenMon.Add("Mỳ tôm trứng");

            if (chkMyXaoBo.Checked)
                tenMon.Add("Mỳ xào bò");

            if (chkMyCay.Checked)
                tenMon.Add("Mỳ cay");

            try
            {
                List<ThucDonDTO> thucDon = thucDonBUS.LayDanhSach();

                List<ChiTietHoaDonDTO> chiTiet = new List<ChiTietHoaDonDTO>();

                for (int i = 0; i < tenMon.Count; i++)
                {
                    ThucDonDTO mon = thucDon.FirstOrDefault(
                        m => m.TenMon == tenMon[i]);

                    if (mon == null)
                    {
                        MessageBox.Show(
                            "Không tìm thấy món: " + tenMon[i]);
                        return;
                    }

                    ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO();

                    ct.MaMon = mon.MaMon;
                    ct.DonGia = mon.DonGia;

                    if (i == 0)
                        ct.SoLuong = soKhachTamTinh;
                    else
                        ct.SoLuong = 1;

                    chiTiet.Add(ct);
                }

                decimal tongKiemTra = 0;

                foreach (ChiTietHoaDonDTO ct in chiTiet)
                {
                    tongKiemTra = tongKiemTra
                        + ct.SoLuong * ct.DonGia;
                }

                if (hd.LaSinhVien)
                {
                    tongKiemTra = tongKiemTra * 80 / 100;
                }

                if (tongKiemTra != tienTamTinh)
                {
                    MessageBox.Show(
                        "Giá món đã thay đổi. Vui lòng tính tiền lại!");
                    btnThanhToan.Enabled = false;
                    return;
                }

                if (hoaDonBUS.ThanhToan(hd, chiTiet))
                {
                    tongSoKhach = tongSoKhach + soKhachTamTinh;

                    tongTienThanhToan =
                        tongTienThanhToan + tienTamTinh;

                    lblSoKhachDaThanhToan.Text =
                        tongSoKhach.ToString();

                    lblTienDaThanhToan.Text =
                        tongTienThanhToan.ToString("N0") + " VNĐ";

                    MessageBox.Show("Thanh toán thành công!");

                    btnNhapLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thông tin hóa đơn không hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thanh toán thất bại: "
                    + ex.GetBaseException().Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (traLoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
