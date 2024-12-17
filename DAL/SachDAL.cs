using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        private string connectionString = @"Data Source=MSI;Initial Catalog=LQD;Integrated Security=True";

        public List<TuaSach> TraCuuSach(string tuKhoa, string theLoai, string tacGia)
        {
            List<TuaSach> danhSachSach = new List<TuaSach>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    CS.MaCuonSach,
                    TS.TenSach,
                    TLS.TenTheLoai AS TheLoai,
                    NXB.TenNXB AS NhaXuatBan,
                    TG.TenTacGia AS TacGia,
                    CASE 
                        WHEN CTPM.MaCuonSach IS NOT NULL THEN N'Đang Cho Mượn'
                        ELSE N'Sẵn Sàng'
                    END AS TinhTrang
                FROM CuonSach CS
                INNER JOIN LoSach LS ON CS.MaLoSach = LS.MaLoSach
                INNER JOIN TuaSach TS ON LS.MaSach = TS.MaSach
                INNER JOIN TheLoaiSach TLS ON TS.MaTheLoai = TLS.MaTheLoai
                INNER JOIN NhaXuatBan NXB ON TS.MaNXB = NXB.MaNXB
                INNER JOIN TacGia TG ON TS.MaTacGia = TG.MaTacGia
                LEFT JOIN ChiTietPhieuMuon CTPM ON CS.MaCuonSach = CTPM.MaCuonSach
                WHERE 
                    (TS.TenSach LIKE @TuKhoa OR @TuKhoa = '')
                    AND (TLS.TenTheLoai = @TheLoai OR @TheLoai = '')
                    AND (TG.TenTacGia = @TacGia OR @TacGia = '')
                GROUP BY 
                    CS.MaCuonSach, TS.TenSach, TLS.TenTheLoai, 
                    NXB.TenNXB, TG.TenTacGia, CTPM.MaCuonSach";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                cmd.Parameters.AddWithValue("@TheLoai", theLoai);
                cmd.Parameters.AddWithValue("@TacGia", tacGia);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSachSach.Add(new TuaSach
                        {
                            MaCuonSach = reader["MaCuonSach"].ToString(),
                            TenSach = reader["TenSach"].ToString(),
                            TheLoai = reader["TheLoai"].ToString(),
                            NhaXuatBan = reader["NhaXuatBan"].ToString(),
                            TacGia = reader["TacGia"].ToString(),
                            TinhTrang = reader["TinhTrang"].ToString()
                        });
                    }
                }
            }
            return danhSachSach;
        }
        // Phương thức lấy danh sách thể loại
        public List<string> LayDanhSachTheLoai()
        {
            List<string> danhSachTheLoai = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT TenTheLoai FROM TheLoaiSach";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSachTheLoai.Add(reader["TenTheLoai"].ToString());
                    }
                }
            }
            return danhSachTheLoai;
        }

        // Phương thức lấy danh sách tác giả
        public List<string> LayDanhSachTacGia()
        {
            List<string> danhSachTacGia = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT TenTacGia FROM TacGia";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSachTacGia.Add(reader["TenTacGia"].ToString());
                    }
                }
            }
            return danhSachTacGia;
        }

        // Phương thức lấy danh sách tên sách để autocomplete
        public List<string> LayDanhSachTenSach()
        {
            List<string> danhSachTenSach = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT TenSach FROM TuaSach";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSachTenSach.Add(reader["TenSach"].ToString());
                    }
                }
            }
            return danhSachTenSach;
        }
    }
}
