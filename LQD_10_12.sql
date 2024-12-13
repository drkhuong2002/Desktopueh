-- Sử dụng cơ sở dữ liệu
USE LQD;
GO

-- Bảng Loại Độc Giả
CREATE TABLE LoaiDocGia (
    MaLoaiDG CHAR(10) PRIMARY KEY,
    TenLoaiDG NVARCHAR(MAX)
);

-- Bảng Tài Khoản
CREATE TABLE TaiKhoan (
    MaTK CHAR(10) PRIMARY KEY,
    TenDangNhap CHAR(20),
    MatKhau CHAR(10)
);

-- Bảng Độc Giả
CREATE TABLE DocGia (
    MaDocGia CHAR(10) PRIMARY KEY,
    TenDocGia NVARCHAR(MAX),
    NgaySinh DATE,
    Email VARCHAR(MAX),
    SDT CHAR(10),
    MaTK CHAR(10) REFERENCES TaiKhoan(MaTK),
    MaLoaiDG CHAR(10) REFERENCES LoaiDocGia(MaLoaiDG)
);

-- Bảng Thể Loại Sách
CREATE TABLE TheLoaiSach (
    MaTheLoai CHAR(10) PRIMARY KEY,
    TenTheLoai NVARCHAR(MAX)
);

-- Bảng Nhà Xuất Bản
CREATE TABLE NhaXuatBan (
    MaNXB CHAR(10) PRIMARY KEY,
    TenNXB NVARCHAR(MAX),
    DiaChi NVARCHAR(MAX),
    NamThanhLap DATE
);

-- Bảng Tác Giả
CREATE TABLE TacGia (
    MaTacGia CHAR(10) PRIMARY KEY,
    TenTacGia NVARCHAR(MAX),
    NgaySinh DATE
);

-- Bảng Tựa Sách
CREATE TABLE TuaSach (
    MaSach CHAR(10) PRIMARY KEY,
    TenSach NVARCHAR(MAX),
    MaTacGia CHAR(10) REFERENCES TacGia(MaTacGia),
    NamXuatBan DATE,
    MaTheLoai CHAR(10) REFERENCES TheLoaiSach(MaTheLoai),
    MaNXB CHAR(10) REFERENCES NhaXuatBan(MaNXB),
    SoLuongConLai INT,
    SoLuongDaMuon INT
);

-- Bảng Phiếu Nhập
CREATE TABLE PhieuNhap (
    MaPhieuNhap CHAR(10) PRIMARY KEY,
    SoLuong INT,
    ThanhTien MONEY,
    NgayNhap DATE
);

-- Bảng Lô Sách
CREATE TABLE LoSach (
    MaLoSach CHAR(10) unique,
    MaSach CHAR(10) REFERENCES TuaSach(MaSach),
    MaPhieuNhap CHAR(10) REFERENCES PhieuNhap(MaPhieuNhap),
    SoLuongSach INT,
    PRIMARY KEY (MaSach, MaPhieuNhap)
);

-- Bảng Cuốn Sách
CREATE TABLE CuonSach (
    MaCuonSach CHAR(10) PRIMARY KEY,
    MaLoSach CHAR(10) REFERENCES LoSach(MaLoSach)
);

-- Bảng Phiếu Mượn
CREATE TABLE PhieuMuon (
    MaPhieuMuon CHAR(10) PRIMARY KEY,
    MaDocGia CHAR(10) REFERENCES DocGia(MaDocGia),
    NgayMuon DATE,
    NgayTra DATE
);

-- Bảng Chi Tiết Phiếu Mượn
CREATE TABLE ChiTietPhieuMuon (
    MaCTPM CHAR(10),
    MaPhieuMuon CHAR(10) REFERENCES PhieuMuon(MaPhieuMuon),
    MaCuonSach CHAR(10) REFERENCES CuonSach(MaCuonSach),
    PRIMARY KEY (MaPhieuMuon, MaCuonSach)
);

-- Bảng Phiếu Trả
CREATE TABLE PhieuTra (
    MaPhieuTra CHAR(10) PRIMARY KEY,
    MaDocGia CHAR(10) REFERENCES DocGia(MaDocGia),
    NgayTra DATE
);

-- Bảng Chi Tiết Phiếu Trả
CREATE TABLE ChiTietPhieuTra (
    MaPhieuTra CHAR(10) REFERENCES PhieuTra(MaPhieuTra),
    MaCuonSach CHAR(10) REFERENCES CuonSach(MaCuonSach),
    PRIMARY KEY (MaPhieuTra, MaCuonSach)
);
GO
use LQD
go
INSERT INTO LoaiDocGia (MaLoaiDG, TenLoaiDG) VALUES
('LDG001', N'Giảng viên'),
('LDG002', N'Sinh viên');
go
INSERT INTO TaiKhoan (MaTK, TenDangNhap, MatKhau) VALUES
('TK001', 'user001', 'password1'),
('TK002', 'user002', 'password2'),
('TK003', 'user003', 'password3'),
('TK004', 'user004', 'password4'),
('TK005', 'user005', 'password5'),
('TK006', 'user006', 'password6'),
('TK007', 'user007', 'password7'),
('TK008', 'user008', 'password8'),
('TK009', 'user009', 'password9'),
('TK010', 'user010', 'password10');
go
INSERT INTO DocGia (MaDocGia, TenDocGia, NgaySinh, Email, SDT, MaTK, MaLoaiDG) VALUES
('DG001', N'Nguyễn Văn A', '1990-03-15', 'nguyenvana@gmail.com', '0912345678', 'TK001', 'LDG001'),
('DG002', N'Phạm Thị B', '1985-07-25', 'phamthib@gmail.com', '0918765432', 'TK002', 'LDG002'),
('DG003', N'Nguyễn Thị C', '1992-05-10', 'nguyen.thi.c@gmail.com', '0901122334', 'TK003', 'LDG002'),
('DG004', N'Hoàng Văn D', '1980-11-18', 'hoangvandung@gmail.com', '0904455667', 'TK004', 'LDG001'),
('DG005', N'Vũ Thị E', '1995-02-05', 'vuthie@gmail.com', '0912334455', 'TK005', 'LDG001'),
('DG006', N'Lê Văn F', '1988-08-12', 'levanf@gmail.com', '0901122334', 'TK006', 'LDG002'),
('DG007', N'Trần Thị G', '1994-06-20', 'tranthig@gmail.com', '0911445566', 'TK007', 'LDG002'),
('DG008', N'Phan Văn H', '1982-10-03', 'phanvanh@gmail.com', '0907788990', 'TK008', 'LDG001'),
('DG009', N'Nguyễn Minh I', '1991-09-11', 'nguyenminhi@gmail.com', '0911223344', 'TK009', 'LDG001'),
('DG010', N'Đặng Thị K', '1993-12-15', 'dangthik@gmail.com', '0905566778', 'TK010', 'LDG002');
go
INSERT INTO TheLoaiSach (MaTheLoai, TenTheLoai) VALUES
('TL001', N'Tiểu Thuyết'),
('TL002', N'Khoa Học Viễn Tưởng'),
('TL003', N'Lịch Sử'),
('TL004', N'Văn Học'),
('TL005', N'Trẻ Em'),
('TL006', N'Tâm Lý'),
('TL007', N'Học Thuật'),
('TL008', N'Tôn Giáo'),
('TL009', N'Trinh Thám'),
('TL010', N'Kỹ Năng Sống');
go
INSERT INTO NhaXuatBan (MaNXB, TenNXB, DiaChi, NamThanhLap) VALUES
('NXB001', N'Kim Đồng', N'Hà Nội', '1957-06-17'),
('NXB002', N'Giáo Dục', N'Hồ Chí Minh', '1959-04-12'),
('NXB003', N'Tre', N'Hà Nội', '1975-09-05'),
('NXB004', N'Lao Động', N'Hà Nội', '1980-11-20'),
('NXB005', N'Phụ Nữ', N'Hồ Chí Minh', '1963-02-10'),
('NXB006', N'Khoa Học Kỹ Thuật', N'Đà Nẵng', '1970-03-15'),
('NXB007', N'Văn Hóa', N'Hà Nội', '1985-07-19'),
('NXB008', N'Thanh Niên', N'Hồ Chí Minh', '1978-08-22'),
('NXB009', N'Tài Chính', N'Hà Nội', '1982-10-01'),
('NXB010', N'Thể Dục Thể Thao', N'Hồ Chí Minh', '1987-01-29');
go
INSERT INTO TacGia (MaTacGia, TenTacGia, NgaySinh) VALUES
('TG001', N'Nguyễn Nhật Ánh', '1955-05-20'),
('TG002', N'J.K. Rowling', '1965-07-31'),
('TG003', N'Dan Brown', '1964-06-22'),
('TG004', N'Tô Hoài', '1920-09-27'),
('TG005', N'Nguyễn Du', '1766-01-03'),
('TG006', N'Thích Nhất Hạnh', '1926-10-11'),
('TG007', N'Trịnh Xuân Thuận', '1948-08-20'),
('TG008', N'Vũ Trọng Phụng', '1912-10-20'),
('TG009', N'George Orwell', '1903-06-25'),
('TG010', N'Isaac Newton', '1643-01-04');
go
INSERT INTO TuaSach (MaSach, TenSach, MaTacGia, NamXuatBan, MaTheLoai, MaNXB, SoLuongConLai, SoLuongDaMuon) VALUES
('S001', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 'TG001', '2008-05-05', 'TL004', 'NXB001', 10, 2),
('S002', N'Harry Potter Và Hòn Đá Phù Thủy', 'TG002', '1997-06-26', 'TL002', 'NXB002', 8, 12),
('S003', N'Mật Mã Da Vinci', 'TG003', '2003-03-18', 'TL009', 'NXB003', 5, 15),
('S004', N'Dế Mèn Phiêu Lưu Ký', 'TG004', '1941-07-15', 'TL005', 'NXB004', 20, 5),
('S005', N'Truyện Kiều', 'TG005', '1813-01-01', 'TL004', 'NXB005', 6, 10),
('S006', N'Hành Trình Về Phương Đông', 'TG006', '1987-12-25', 'TL008', 'NXB006', 15, 5),
('S007', N'Giai Điệu Của Vũ Trụ', 'TG007', '2001-08-15', 'TL006', 'NXB007', 10, 3),
('S008', N'Số Đỏ', 'TG008', '1936-01-01', 'TL009', 'NXB008', 5, 7),
('S009', N'1984', 'TG009', '1949-06-08', 'TL009', 'NXB009', 12, 8),
('S010', N'Thuyết Vạn Vật', 'TG010', '1687-07-05', 'TL007', 'NXB010', 2, 1);
go
INSERT INTO PhieuNhap (MaPhieuNhap, SoLuong, ThanhTien, NgayNhap) VALUES
('PN001', 20, 400000, '2023-11-01'),
('PN002', 15, 300000, '2023-11-02'),
('PN003', 25, 500000, '2023-11-03'),
('PN004', 10, 200000, '2023-11-04'),
('PN005', 12, 240000, '2023-11-05'),
('PN006', 8, 160000, '2023-11-06'),
('PN007', 30, 600000, '2023-11-07'),
('PN008', 20, 400000, '2023-11-08'),
('PN009', 5, 100000, '2023-11-09'),
('PN010', 10, 200000, '2023-11-10');
go
INSERT INTO LoSach (MaLoSach, MaSach, MaPhieuNhap, SoLuongSach) VALUES
('LO001', 'S001', 'PN001', 20),
('LO002', 'S002', 'PN002', 15),
('LO003', 'S003', 'PN003', 25),
('LO004', 'S004', 'PN004', 10),
('LO005', 'S005', 'PN005', 12),
('LO006', 'S006', 'PN006', 8),
('LO007', 'S007', 'PN007', 30),
('LO008', 'S008', 'PN008', 20),
('LO009', 'S009', 'PN009', 5),
('LO010', 'S010', 'PN010', 10);
go
INSERT INTO CuonSach (MaCuonSach, MaLoSach) VALUES
('CS001', 'LO001'),
('CS002', 'LO001'),
('CS003', 'LO002'),
('CS004', 'LO003'),
('CS005', 'LO004'),
('CS006', 'LO005'),
('CS007', 'LO006'),
('CS008', 'LO007'),
('CS009', 'LO008'),
('CS010', 'LO009');
go
INSERT INTO PhieuMuon (MaPhieuMuon, MaDocGia, NgayMuon, NgayTra) VALUES
('PM001', 'DG001', '2024-11-01', '2024-11-15'),
('PM002', 'DG002', '2024-11-02', '2024-11-16'),
('PM003', 'DG003', '2024-11-03', '2024-11-17'),
('PM004', 'DG004', '2024-11-04', '2024-11-18'),
('PM005', 'DG005', '2024-11-05', '2024-11-19'),
('PM006', 'DG006', '2024-11-06', '2024-11-20'),
('PM007', 'DG007', '2024-11-07', '2024-11-21'),
('PM008', 'DG008', '2024-11-08', '2024-11-22'),
('PM009', 'DG009', '2024-11-09', '2024-11-23'),
('PM010', 'DG010', '2024-11-10', '2024-11-24');
go
INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaCuonSach, MaCTPM) VALUES
('PM001', 'CS001', 'CTPM001'),
('PM001', 'CS002', 'CTPM002'),
('PM002', 'CS003', 'CTPM003'),
('PM002', 'CS004', 'CTPM004'),
('PM003', 'CS005', 'CTPM005'),
('PM003', 'CS006', 'CTPM006'),
('PM004', 'CS007', 'CTPM007'),
('PM004', 'CS008', 'CTPM008'),
('PM005', 'CS009', 'CTPM009'),
('PM005', 'CS010', 'CTPM010');
go
INSERT INTO PhieuTra (MaPhieuTra, MaDocGia, NgayTra) VALUES
('PT001', 'DG001', '2024-11-15'),
('PT002', 'DG002', '2024-11-16'),
('PT003', 'DG003', '2024-11-17'),
('PT004', 'DG004', '2024-11-18'),
('PT005', 'DG005', '2024-11-19'),
('PT006', 'DG006', '2024-11-20'),
('PT007', 'DG007', '2024-11-21'),
('PT008', 'DG008', '2024-11-22'),
('PT009', 'DG009', '2024-11-23'),
('PT010', 'DG010', '2024-11-24');
go
INSERT INTO ChiTietPhieuTra (MaPhieuTra, MaCuonSach) VALUES
('PT001', 'CS001'),
('PT001', 'CS002'),
('PT002', 'CS003'),
('PT002', 'CS004'),
('PT003', 'CS005'),
('PT003', 'CS006'),
('PT004', 'CS007'),
('PT004', 'CS008'),
('PT005', 'CS009'),
('PT005', 'CS010');
