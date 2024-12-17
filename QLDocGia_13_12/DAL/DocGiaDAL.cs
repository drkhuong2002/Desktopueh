using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        public DataTable ListDocGia()
        { 
            //logic
            SqlConnection connn = DBConnect.Connect();
            connn.Open();
            string querydocgia = "SELECT * FROM DocGia";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querydocgia, connn);
            DataTable DSDocGia = new DataTable();
            sqlDataAdapter.Fill(DSDocGia);
            connn.Close();
            //trả kết quả của logic
            return DSDocGia;
        }
        public class LoaiDocGiaDAL
        {
            public DataTable ListLoaiDocGia()
            {
                //logic
                SqlConnection connn = DBConnect.Connect();
                connn.Open();
                string queryloaidocgia = "SELECT * FROM LoaiDocGia";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryloaidocgia, connn);
                DataTable DSLoaiDocGia = new DataTable();
                sqlDataAdapter.Fill(DSLoaiDocGia);
                connn.Close();
                //trả kết quả của logic
                return DSLoaiDocGia;
            }
        }
        }
}
