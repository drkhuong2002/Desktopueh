using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-O0PFHPI;Initial Catalog=LQD;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;

        }

    }
}
