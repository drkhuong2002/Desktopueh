using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThemDocGiaDAL
    {
        public bool ThemDocGia_DAL(DocGiaDTO docGia)
        {
            using (SqlConnection connn = DBConnect.Connect())
            {
                try
                {
                    connn.Open();
                    string query = "INSERT INTO DocGia (MaDocGia, TenDocGia, NgaySinh, Email, SDT, MaTK, MaLoaiDG) VALUES (@MaDocGia, @TenDocGia, @NgaySinh, @Email, @SDT, @MaTK, @MaLoaiDG)";
                    SqlCommand cmd = new SqlCommand(query, connn);
                    cmd.Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia);
                    cmd.Parameters.AddWithValue("@TenDocGia", docGia.TenDocGia);
                    cmd.Parameters.AddWithValue("@NgaySinh", docGia.NgaySinh);
                    cmd.Parameters.AddWithValue("@Email", docGia.Email);
                    cmd.Parameters.AddWithValue("@SDT", docGia.SDT);
                    cmd.Parameters.AddWithValue("@MaTK", docGia.MaTK);
                    cmd.Parameters.AddWithValue("@MaLoaiDG", docGia.MaLoaiDG);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in DocGia - DAL " + ex.Message);
                    return false;
                }
            }
        }
    }
    public class ThemTaiKhoanDAL
    {
        public bool ThemTaiKhoan_DAL(TaiKhoanDTO taiKhoan)
        {
            using (SqlConnection connn = DBConnect.Connect())
            {
                try
                {
                    connn.Open();
                    string query = "INSERT INTO TaiKhoan (MaTK, TenDangNhap, MatKhau) VALUES (@MaTK, @TenDangNhap, @MatKhau)";
                    SqlCommand cmd = new SqlCommand(query, connn);
                    cmd.Parameters.AddWithValue("@MaTK", taiKhoan.MaTK);
                    cmd.Parameters.AddWithValue("@TenDangNhap", taiKhoan.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in TaiKhoan - DAL " + ex.Message);
                    return false;
                }
            }
        }
    }
}
