Use Master
GO
    IF exists(Select name From sys.databases Where name='QLTB' )
    DROP Database QLTB
GO
    Create Database QLTB
GO

USE QLTB;

CREATE TABLE TaiKhoan
(
	TenDangNhap NVARCHAR(100) PRIMARY KEY,	
	TenHienThi NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE LoaiBanh
(
	MaLoai INT IDENTITY PRIMARY KEY,
	TenLoai NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Banh
(
	MaBanh INT IDENTITY PRIMARY KEY,
	TenBanh NVARCHAR(100) NOT NULL,
	MaLoai INT NOT NULL,
	SoLuong INT NOT NULL,
	Gia FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (MaLoai) REFERENCES LoaiBanh(MaLoai)
)
GO

CREATE TABLE HoaDon
(
	MaHoaDon INT IDENTITY PRIMARY KEY,
	NgayBan DATETIME NOT NULL DEFAULT GETDATE(),
	TongTien FLOAT NOT NULL
)
GO

CREATE TABLE HoaDonChiTiet
(
	MaHDCT INT IDENTITY PRIMARY KEY,
	MaHoaDon INT NOT NULL,
	MaBanh INT NOT NULL,
	SoLuong INT NOT NULL
	
	FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
	FOREIGN KEY (MaBanh) REFERENCES Banh(MaBanh)
)
GO

-- Dữ liệu bảng TaiKhoan
INSERT INTO TaiKhoan VALUES(N'quantri', N'Võ Phan Ý Nhi','e99a18c428cb38d5f260853678922e03',1);	/* Mật khẩu abc123 */
INSERT INTO TaiKhoan VALUES(N'nhanvien', N'Nguyễn Văn A', 'a906449d5769fa7361d7ecc6aa3f6d28',0);	/* Mật khẩu 123abc */

-- Dữ liệu bảng LoaiBanh
INSERT INTO LoaiBanh VALUES(N'Bánh mì');
INSERT INTO LoaiBanh VALUES(N'Cupcake');
INSERT INTO LoaiBanh VALUES(N'Cheesecake');
INSERT INTO LoaiBanh VALUES(N'Bánh bông lan');
INSERT INTO LoaiBanh VALUES(N'Bánh Gato');
INSERT INTO LoaiBanh VALUES(N'Khác');

-- Dữ liệu bảng Banh
INSERT INTO Banh VALUES(N'Bánh su kem', 6, 50, 10000);
INSERT INTO Banh VALUES(N'Bánh bông lan trứng muối', 4, 10, 35000);
INSERT INTO Banh VALUES(N'Bánh bông lan bơ', 6, 10, 30000);
INSERT INTO Banh VALUES(N'Cupcake kem tươi', 2, 30, 20000);
INSERT INTO Banh VALUES(N'Cupcake trái cây', 2, 20, 20000);
INSERT INTO Banh VALUES(N'Cupcake socola', 2, 20, 20000);
INSERT INTO Banh VALUES(N'Bánh mì thường', 1, 50, 3000);
INSERT INTO Banh VALUES(N'Bánh mì bơ sữa', 1, 30, 50000);
INSERT INTO Banh VALUES(N'Cheesecake sữa chua', 3, 10, 35000);
INSERT INTO Banh VALUES(N'Cheesecake matcha', 3, 10, 35000);
INSERT INTO Banh VALUES(N'Gato bông lan', 5, 10, 50000);

-- Dữ liệu bảng HoaDon
INSERT INTO HoaDon (TongTien) VALUES(40000);
INSERT INTO HoaDon (TongTien) VALUES(50000);
INSERT INTO HoaDon (TongTien) VALUES(30000);

-- Dữ liệu bảng HoaDonChiTiet
INSERT INTO HoaDonChiTiet VALUES(1, 1, 2);
INSERT INTO HoaDonChiTiet VALUES(1, 5, 1);
INSERT INTO HoaDonChiTiet VALUES(2, 11, 1);
INSERT INTO HoaDonChiTiet VALUES(3, 1, 1);
INSERT INTO HoaDonChiTiet VALUES(3, 4, 1);

SELECT MAX(MaHoaDon)+1 FROM HoaDon;
UPDATE Banh SET SoLuong = SoLuong+41 WHERE MaBanh = 1;
SELECT SoLuong FROM Banh WHERE MaBanh = 1;