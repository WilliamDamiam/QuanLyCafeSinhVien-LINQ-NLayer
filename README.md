1. Giải nén file RAR, mở file .sln/.slnx bằng Visual Studio.
2. Nếu thiếu project: chuột phải Solution → Add → Existing Project, thêm 4 file .csproj của GUI, BUS, DAO, DTO.
3. Mở SQL Server, chạy file QuanLyCafeSinhVien_dbbai1.sql để tạo CSDL và dữ liệu mẫu.
4. Nếu tên SQL Server thầy khác máy em, sửa Data Source trong chuỗi kết nối ở các lớp DAO (ThucDonDAO.cs, HoaDonDAO.cs, ChiTietHoaDonDAO.cs).
5. Trong Visual Studio: đặt project GUI làm Startup Project, kiểm tra Program.cs chạy FormMain; Build Solution (Ctrl+Shift+B), sau đó F5.
6. Trên FormMain, bấm “Quản Lý Thanh Toán” để mở chương trình.

Bài sử dụng: C# WinForms, ADO.NET, LINQ, N-Layer (GUI/BUS/DAO/DTO), SQL Server cho bài 1 trong file BaiTapVeNha.

2351010250-Trương Hoàng Vũ-DH24SE01C-6/11/2026
