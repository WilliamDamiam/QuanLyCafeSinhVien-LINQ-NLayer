CREATE DATABASE QuanLyCafeSinhVien;
GO

USE QuanLyCafeSinhVien;
GO

CREATE TABLE ThucDon
(
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    LoaiMon NVARCHAR(20) NOT NULL,
    DonGia DECIMAL(12,0) NOT NULL,

    CHECK (DonGia > 0),
    CHECK (LoaiMon IN (N'Cà phê', N'Thức ăn'))
);
GO

CREATE TABLE HoaDon
(
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    TenKhachHang NVARCHAR(100) NOT NULL,
    SoKhach INT NOT NULL,
    LaSinhVien BIT NOT NULL DEFAULT 0,
    NgayThanhToan DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(12,0) NOT NULL,

    CHECK (SoKhach > 0),
    CHECK (TongTien >= 0)
);
GO

CREATE TABLE ChiTietHoaDon
(
    MaHoaDon INT NOT NULL,
    MaMon INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(12,0) NOT NULL,

    PRIMARY KEY (MaHoaDon, MaMon),

    FOREIGN KEY (MaHoaDon)
        REFERENCES HoaDon(MaHoaDon),

    FOREIGN KEY (MaMon)
        REFERENCES ThucDon(MaMon),

    CHECK (SoLuong > 0),
    CHECK (DonGia >= 0)
);
GO


USE QuanLyCafeSinhVien;
GO

INSERT INTO ThucDon (TenMon, LoaiMon, DonGia)
VALUES
(N'Cafe đen', N'Cà phê', 20000),
(N'Cafe đá', N'Cà phê', 25000),
(N'Cafe sữa', N'Cà phê', 25000),
(N'Cafe sữa đá', N'Cà phê', 30000),
(N'Cafe kem', N'Cà phê', 35000);

INSERT INTO ThucDon (TenMon, LoaiMon, DonGia)
VALUES
(N'Bánh mỳ trứng', N'Thức ăn', 15000),
(N'Bánh mỳ cá', N'Thức ăn', 15000),
(N'Mỳ tôm trứng', N'Thức ăn', 20000),
(N'Mỳ xào bò', N'Thức ăn', 30000),
(N'Mỳ cay', N'Thức ăn', 50000);
GO

USE QuanLyCafeSinhVien;
GO

CREATE OR ALTER PROCEDURE sp_LayDanhSachThucDon
AS
BEGIN
    SELECT MaMon, TenMon, LoaiMon, DonGia
    FROM ThucDon;
END;
GO

CREATE OR ALTER PROCEDURE sp_ThemHoaDon
    @TenKhachHang NVARCHAR(100),
    @SoKhach INT,
    @LaSinhVien BIT,
    @TongTien DECIMAL(12,0)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO HoaDon
        (TenKhachHang, SoKhach, LaSinhVien, TongTien)
    VALUES
        (@TenKhachHang, @SoKhach, @LaSinhVien, @TongTien);

    SELECT CAST(SCOPE_IDENTITY() AS INT);
END;
GO


CREATE OR ALTER PROCEDURE sp_ThemChiTietHoaDon
    @MaHoaDon INT,
    @MaMon INT,
    @SoLuong INT,
    @DonGia DECIMAL(12,0)
AS
BEGIN
    INSERT INTO ChiTietHoaDon
        (MaHoaDon, MaMon, SoLuong, DonGia)
    VALUES
        (@MaHoaDon, @MaMon, @SoLuong, @DonGia);
END;
GO

