using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichSuMuonTraDAL
    {
        private string connectionString;

        public LichSuMuonTraDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<LichSuMuonTraDTO> LayLichSuMuonTraTheoDocGia(string maDocGia)
        {
            List<LichSuMuonTraDTO> danhSachLichSu = new List<LichSuMuonTraDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                pm.MaPhieuMuon, 
                ts.MaSach, 
                ts.TenSach, 
                pm.NgayMuon, 
                DATEADD(DAY, 30, pm.NgayMuon) AS HanTra,
                CASE 
                    WHEN pt.NgayTra IS NOT NULL THEN N'Đã trả'
                    ELSE N'Chưa trả'
                END AS TrangThaiTra
            FROM PhieuMuon pm
            INNER JOIN ChiTietPhieuMuon ctpm ON pm.MaPhieuMuon = ctpm.MaPhieuMuon
            INNER JOIN CuonSach cs ON ctpm.MaCuonSach = cs.MaCuonSach
            INNER JOIN LoSach ls ON cs.MaLoSach = ls.MaLoSach
            INNER JOIN TuaSach ts ON ls.MaSach = ts.MaSach
            LEFT JOIN ChiTietPhieuTra ctpt ON ctpm.MaCuonSach = ctpt.MaCuonSach
            LEFT JOIN PhieuTra pt ON ctpt.MaPhieuTra = pt.MaPhieuTra
            WHERE pm.MaDocGia = @MaDocGia
            ORDER BY pm.NgayMuon DESC";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaDocGia", maDocGia);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                danhSachLichSu.Add(new LichSuMuonTraDTO
                                {
                                    MaPhieuMuon = reader["MaPhieuMuon"].ToString().Trim(),
                                    MaSach = reader["MaSach"].ToString().Trim(),
                                    TenSach = reader["TenSach"].ToString().Trim(),
                                    NgayMuon = Convert.ToDateTime(reader["NgayMuon"]),
                                    HanTra = Convert.ToDateTime(reader["HanTra"]),
                                    TrangThaiTra = reader["TrangThaiTra"].ToString().Trim()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // In ra thông báo lỗi chi tiết để debug
                    Console.WriteLine($"Lỗi truy vấn: {ex.Message}");
                    throw;
                }
            }

            return danhSachLichSu;
        }
    }
}
