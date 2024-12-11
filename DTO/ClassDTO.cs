using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Bảng Loại Độc Giả
    public class LoaiDocGiaDTO
    {
        public string MaLoaiDG { get; set; }
        public string TenLoaiDG { get; set; }
    }

    // Bảng Tài Khoản
    public class TaiKhoanDTO
    {
        public string MaTK { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    }

    // Bảng Độc Giả
    public class DocGiaDTO
    {
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string MaTK { get; set; } // Foreign key to TaiKhoan
        public string MaLoaiDG { get; set; } // Foreign key to LoaiDocGia
    }

    // Bảng Thể Loại Sách
    public class TheLoaiSachDTO
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
    }

    // Bảng Nhà Xuất Bản
    public class NhaXuatBanDTO
    {
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public DateTime NamThanhLap { get; set; }
    }

    // Bảng Tác Giả
    public class TacGiaDTO
    {
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public DateTime NgaySinh { get; set; }
    }

    // Bảng Tựa Sách
    public class TuaSachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTacGia { get; set; } // Foreign key to TacGia
        public DateTime NamXuatBan { get; set; }
        public string MaTheLoai { get; set; } // Foreign key to TheLoaiSach
        public string MaNXB { get; set; } // Foreign key to NhaXuatBan
        public int SoLuongConLai { get; set; }
        public int SoLuongDaMuon { get; set; }
    }

    // Bảng Phiếu Nhập
    public class PhieuNhapDTO
    {
        public string MaPhieuNhap { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public DateTime NgayNhap { get; set; }
    }

    // Bảng Lô Sách
    public class LoSachDTO
    {
        public string MaLoSach { get; set; }
        public string MaSach { get; set; } // Foreign key to TuaSach
        public string MaPhieuNhap { get; set; } // Foreign key to PhieuNhap
        public int SoLuongSach { get; set; }
    }

    // Bảng Cuốn Sách
    public class CuonSachDTO
    {
        public string MaCuonSach { get; set; }
        public string MaLoSach { get; set; } // Foreign key to LoSach
    }

    // Bảng Phiếu Mượn
    public class PhieuMuonDTO
    {
        public string MaPhieuMuon { get; set; }
        public string MaDocGia { get; set; } // Foreign key to DocGia
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
    }

    // Bảng Chi Tiết Phiếu Mượn
    public class ChiTietPhieuMuonDTO
    {
        public string MaCTPM { get; set; }
        public string MaPhieuMuon { get; set; } // Foreign key to PhieuMuon
        public string MaCuonSach { get; set; } // Foreign key to CuonSach
    }

    // Bảng Phiếu Trả
    public class PhieuTraDTO
    {
        public string MaPhieuTra { get; set; }
        public string MaDocGia { get; set; } // Foreign key to DocGia
        public DateTime NgayTra { get; set; }
    }

    // Bảng Chi Tiết Phiếu Trả
    public class ChiTietPhieuTraDTO
    {
        public string MaPhieuTra { get; set; } // Foreign key to PhieuTra
        public string MaCuonSach { get; set; } // Foreign key to CuonSach
    }
}
