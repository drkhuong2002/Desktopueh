using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=MSI;Integrated Security=True;Encrypt=True";
            SqlConnection con = new SqlConnection(strcon);
            return con;
        }
    }
}
