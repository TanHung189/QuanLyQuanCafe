
CREATE DATABASE QuanLyQuanCaPhe_TH;
GO

USE QuanLyQuanCaPhe_TH;
GO


CREATE TABLE BanQuan
(
    Id INT IDENTITY PRIMARY KEY,
    TenBan NVARCHAR(100) NOT NULL DEFAULT N'chua dat ten',
    TrangThai NVARCHAR(100) NOT NULL DEFAULT N'trong'
);
GO


CREATE TABLE LoaiTaiKhoan
(
    Id INT IDENTITY PRIMARY KEY,
    TenLoai NVARCHAR(50) NOT NULL
);
GO


CREATE TABLE NhanVien
(
    Id INT IDENTITY PRIMARY KEY, 
    HoTen NVARCHAR(100) NOT NULL, 
    NgaySinh DATE NOT NULL, 
    GioiTinh NVARCHAR(10) NOT NULL DEFAULT N'khong ro', 
    DiaChi NVARCHAR(255) NOT NULL DEFAULT N'khong co dia chi', 
    SoDienThoai NVARCHAR(20) NOT NULL DEFAULT N'khong co so dien thoai', 
    Email NVARCHAR(100) NOT NULL DEFAULT N'khong co email', 
    ChucVu NVARCHAR(50) NOT NULL DEFAULT N'nhan vien', 
    LoaiTaiKhoanId INT NOT NULL, 
    NgayVaoLam DATE DEFAULT GETDATE(),
    FOREIGN KEY (LoaiTaiKhoanId) REFERENCES LoaiTaiKhoan(Id)
);
GO


CREATE TABLE TaiKhoan
(
    Id INT IDENTITY PRIMARY KEY,
    TenDangNhap NVARCHAR(20) NOT NULL,
    TenHienThi NVARCHAR(50) NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL,
    LoaiTaiKhoanId INT NOT NULL,
    GhiChu NVARCHAR(MAX) DEFAULT NULL,
    NhanVienId INT NOT NULL,
    FOREIGN KEY (LoaiTaiKhoanId) REFERENCES LoaiTaiKhoan(Id),
    FOREIGN KEY (NhanVienId) REFERENCES NhanVien(Id)
);
GO


CREATE TABLE ThongTinCuaHang
(
    Id INT IDENTITY PRIMARY KEY,
    TenCuaHang NVARCHAR(100) NOT NULL DEFAULT N'cua hang khong ten',
    DiaChi NVARCHAR(255) NOT NULL DEFAULT N'khong co dia chi',
    SoDienThoai INT NOT NULL DEFAULT N'khong co so dien thoai',
    GhiChu NVARCHAR(MAX) DEFAULT NULL
);
GO


CREATE TABLE DanhMucThucDon
(
    Id INT IDENTITY PRIMARY KEY,
    TenDanhMuc NVARCHAR(100) NOT NULL DEFAULT N'chua dat ten'
);
GO


CREATE TABLE ThucDon
(
    Id INT IDENTITY PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL DEFAULT N'chua dat ten',
    DanhMucId INT NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0,
    Gia DECIMAL(18,0) NOT NULL DEFAULT 0,
    FOREIGN KEY (DanhMucId) REFERENCES DanhMucThucDon(Id)
);
GO


CREATE TABLE HoaDon
(
    Id INT IDENTITY PRIMARY KEY,
    ThoiGianVao DATETIME NOT NULL DEFAULT GETDATE(),
    BanId INT NOT NULL,
    TrangThai INT NOT NULL DEFAULT 0, -- 1: Da thanh toan, 0: Chua thanh toan
    FOREIGN KEY (BanId) REFERENCES BanQuan(Id)
);
GO


CREATE TABLE ChiTietHoaDon
(
    Id INT IDENTITY PRIMARY KEY,
    HoaDonId INT NOT NULL,
    MonAnId INT NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0,
    DonGia DECIMAL(18, 2) NOT NULL,
    ThanhTien AS (SoLuong * DonGia) PERSISTED,
    FOREIGN KEY (HoaDonId) REFERENCES HoaDon(Id),
    FOREIGN KEY (MonAnId) REFERENCES ThucDon(Id)
);
GO

INSERT INTO BanQuan (TenBan, TrangThai)
VALUES 
    (N'ban 1', N'trong'),
    (N'ban 2', N'trong'),
    (N'ban 3', N'trong'),
    (N'ban 4', N'trong'),
    (N'ban 5', N'co nguoi'),
    (N'ban 6', N'trong'),
    (N'ban 7', N'trong'),
    (N'ban 8', N'trong'),
    (N'ban 9', N'trong'),
    (N'ban 10', N'trong'),
    (N'ban 11', N'trong'),
    (N'ban 12', N'trong');
GO


INSERT INTO LoaiTaiKhoan (TenLoai)
VALUES 
    (N'quan ly'),
    (N'nhan vien');
GO

INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, ChucVu, LoaiTaiKhoanId, NgayVaoLam)
VALUES 
    (N'Bùi Đỗ Tấn Hưng', '2004-09-18', N'Nam', N'123 Đường Phạm Cư Lượng, TP. Long Xuyên', N'0399308547', N'hung@gmail.com', N'Quan ly', 1, '2020-01-01'),
    (N'Nguyễn Thành Luận', '2004-05-06', N'Nam', N'123 Đường Trần Hưng Đạo, TP. Long Xuyên', N'0344097744', N'luan@gmail.com', N'Quan ly', 1, '2020-02-01'),
    (N'Nguyễn Văn A', '2004-12-05', N'Nam', N'18 Đường ABC, TP. Long Xuyên', N'0346475676', N'A_@gmail.com', N'Nhan vien thu ngan', 2, '2021-03-01'),
    (N'Lê Thị Thúy', '2004-11-04', N'Nữ', N'453 Đường Trần Hưng Đạo, TP. Long Xuyên', N'0345653462', N'Thuy_@gmail.com', N'Nhan vien pha che', 2, '2021-04-01'),
    (N'Trần Văn Bảo', '2004-06-04', N'Nam', N'138 Đường ABC, TP. Long Xuyên', N'0343453667', N'Bao_@gmail.com', N'Nhan vien phuc vu', 2, '2021-05-01'),
    (N'Nguyễn Chí Hào', '2004-03-21', N'Nam', N'45 Đường Nguyễn Văn Linh, TP. Long Xuyên', N'0536574574', N'Hao_@gmail.com', N'Nhan vien phuc vu', 2, '2021-06-01');
GO


INSERT INTO TaiKhoan (TenDangNhap, TenHienThi, MatKhau, LoaiTaiKhoanId, GhiChu, NhanVienId)
VALUES 
    (N'admin', N'Quan ly chinh', N'admin12345', 1, N'Quan ly he thong', 1),
    (N'luan_manager', N'Nguyen Thanh Luan', N'luan12345', 1, N'Quan ly chi nhanh', 2),
    (N'van_staff', N'Nguyen Thi Mai', N'van12345', 2, N'Nhan vien thu ngan', 3),
    (N'thuy_staff', N'Le Thi Thuy', N'thuy12345', 2, N'Nhan vien pha che', 4),
    (N'bao_staff', N'Tran Thi Bao', N'bao12345', 2, N'Nhan vien phuc vu', 5),
    (N'hao_staff', N'Nguyen Chi Hao', N'hao12345', 2, N'Nhan vien phuc vu', 6);
GO


INSERT INTO ThongTinCuaHang (TenCuaHang, DiaChi, SoDienThoai, GhiChu)
VALUES 
    (N'LH COFFEE', N'123 Phạm Cự Lượng, P. Mỹ Quý, TP. Long Xuyên, AG', N'0399308545', N'Cua hang ca phe sang trong');
GO


INSERT INTO DanhMucThucDon (TenDanhMuc)
VALUES 
    (N'Cafe truyen thong'),
    (N'Tra dac biet'),
    (N'Nước ép trái cây'),
    (N'Dac biet');
GO


INSERT INTO ThucDon (TenMon, DanhMucId, SoLuong, Gia)
VALUES 
    (N'Cafe Nâu (H/I)', 1, 100, 30000),
    (N'Cafe Đen (H/I)', 1, 50, 30000),
    (N'Cà Phê Cốt Dừa', 1, 80, 55000),
    (N'Cà Phê Hạt Dẻ', 1, 60, 59000),
    (N'Cà Phê Bạc Xỉu', 1, 120, 49000),
    (N'Hồng Trà Trân Châu', 2, 150, 30000),
    (N'Trà Thạch Đào', 2, 200, 30000),
    (N'Trà Thanh Long', 2, 180, 55000),
    (N'Trà Kiwi Nha Đam', 2, 160, 55000),
    (N'Nước Ép Cam Tươi', 3, 300, 30000),
    (N'Nước Ép Dưa Hấu', 3, 250, 55000),
    (N'Nước Dừa Tươi', 3, 350, 35000),
    (N'Chanh Leo', 3, 100, 35000),
    (N'Mojito', 4, 80, 55000),
    (N'Mojito (Đặc biệt)', 4, 60, 65000);
GO


INSERT INTO HoaDon (ThoiGianVao, BanId, TrangThai)
VALUES 
    ('2023-05-01 10:00:00', 1, 0), -- Chưa thanh toán
    ('2023-05-02 11:00:00', 2, 1); -- Đã thanh toán
GO


INSERT INTO ChiTietHoaDon (HoaDonId, MonAnId, SoLuong, DonGia)
VALUES 
    (1, 1, 2, 30000),   -- 2 ly Cafe Nâu (H/I) @ 30,000
    (1, 3, 1, 55000),   -- 1 ly Cà Phê Cốt Dừa @ 55,000
    (2, 4, 3, 59000);   -- 3 ly Cà Phê Hạt Dẻ @ 59,000
GO



SELECT * FROM BanQuan;
SELECT * FROM LoaiTaiKhoan;
SELECT * FROM NhanVien;
SELECT * FROM TaiKhoan;
SELECT * FROM ThongTinCuaHang;
SELECT * FROM DanhMucThucDon;
SELECT * FROM ThucDon;
SELECT * FROM HoaDon;
SELECT * FROM ChiTietHoaDon;