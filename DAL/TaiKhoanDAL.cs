using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL : DBConnect
    {
        public bool ChangePassword(string maTK, string newPassword)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                connection = DBConnect.Connect();
                connection.Open();

                string query = "UPDATE Account SET Password = @NewPassword WHERE MaTK = @MaTK";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@MaTK", maTK);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Lỗi thay đổi mật khẩu: " + ex.Message);
                return false;
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
