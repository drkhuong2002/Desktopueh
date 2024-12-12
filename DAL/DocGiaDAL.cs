using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.DocGiaDAL;

namespace DAL
{
    public class DocGiaDAL : DBConnect
    {
        public DocGiaDTO GetReaderById(string maDocGia)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = @"SELECT * FROM DocGia WHERE MaDocGia = @MaDocGia";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaDocGia", maDocGia);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DocGiaDTO
                            {
                                MaDocGia = reader["MaDocGia"].ToString(),
                                TenDocGia = reader["TenDocGia"].ToString(),
                                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                Email = reader["Email"].ToString(),
                                SDT = reader["SDT"].ToString(),
                                MaTK = reader["MaTK"].ToString(),
                                MaLoaiDG = reader["MaLoaiDG"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
