using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ThemDocGiaBLL
    {
        private ThemDocGiaDAL themDocGiaDAL = new ThemDocGiaDAL();
        public bool ThemDocGia_BLL(DocGiaDTO docGia)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào của độc giả
                if (string.IsNullOrEmpty(docGia.MaDocGia))
                    throw new Exception("Mã độc giả không được để trống.");
                if (string.IsNullOrEmpty(docGia.TenDocGia))
                    throw new Exception("Họ tên độc giả không được để trống.");
                if (string.IsNullOrEmpty(docGia.Email))
                    throw new Exception("Email độc giả không được để trống.");
                if (!KiemTraEmail(docGia.Email))
                    throw new Exception("Email không hợp lệ.");
                if (string.IsNullOrEmpty(docGia.SDT))
                    throw new Exception("Số điện thoại không được để trống.");
                if (!KiemTraSoDienThoai(docGia.SDT))
                    throw new Exception("Số điện thoại không hợp lệ. Phải chứa 10-12 chữ số.");
                if (docGia.NgaySinh >= DateTime.Now)
                    throw new Exception("Ngày sinh phải nhỏ hơn ngày hiện tại.");
                if ((DateTime.Now.Year - docGia.NgaySinh.Year) < 16)
                    throw new Exception("Độc giả phải trên 16 tuổi.");
                if (string.IsNullOrEmpty(docGia.MaTK))
                    throw new Exception("Mã tài khoản độc giả không được để trống.");
                if (string.IsNullOrEmpty(docGia.MaLoaiDG))
                    throw new Exception("Bạn chưa chọn loại độc giả.");

                // Gọi DAL để thêm độc giả
                return themDocGiaDAL.ThemDocGia_DAL(docGia);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Doc Gia - BLL: " + ex.Message);
                return false;
            }
        }

        //kiểm tra email
        private bool KiemTraEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //kiem tra SDT
        private bool KiemTraSoDienThoai(string soDienThoai)
{
            return soDienThoai.All(char.IsDigit) && (soDienThoai.Length >= 10 && soDienThoai.Length <= 12);
        }
        }
    }
    public class ThemTaiKhoanBLL
    {
        private ThemTaiKhoanDAL themTaiKhoanDAL = new ThemTaiKhoanDAL();
        public bool ThemTaiKhoan_BLL(TaiKhoanDTO taiKhoan)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào của độc giả
                if (string.IsNullOrEmpty(taiKhoan.MaTK))
                    throw new Exception("Mã tài khoản (khóa chính) không được để trống.");
                if (string.IsNullOrEmpty(taiKhoan.TenDangNhap))
                    throw new Exception("Tên đăng nhập không được để trống.");
                if (string.IsNullOrEmpty(taiKhoan.MatKhau))
                    throw new Exception("Mật khẩu không được để trống.");
                if (!KiemTraTenDangNhap(taiKhoan.TenDangNhap))
                    throw new Exception("Tên đăng nhập không hợp lệ.");
                if (!KiemTraMatKhau(taiKhoan.MatKhau))
                    throw new Exception("Mật khẩu không hợp lệ.");
                // Gọi DAL để thêm độc giả
                return themTaiKhoanDAL.ThemTaiKhoan_DAL(taiKhoan);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in TaiKhoan - BLL: " + ex.Message);
                return false;
            }
        }
    // Hàm kiểm tra tính hợp lệ của tên đăng nhập (tu 5-20 ky tu, khong chua ky tu dac biet, khoang trang)
    private static bool KiemTraTenDangNhap(string TenDangNhap)
    {
        string pattern = @"^[a-zA-Z0-9]{5,20}$";
        return Regex.IsMatch(TenDangNhap, pattern);
    }

    // Hàm kiểm tra tính hợp lệ của mật khẩu (tu 5-20 ky tu, khong chua ky tu dac biet, khoang trang)
    private static bool KiemTraMatKhau(string MatKhau)
    {
        string pattern = @"^[a-zA-Z0-9]{5,20}$";
        return Regex.IsMatch(MatKhau, pattern);

    }

}
