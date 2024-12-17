using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DocGiaBLL
    {
        private DocGiaDAL docGiaDAL = new DocGiaDAL();

        // Kiểm tra mã độc giả và lấy thông tin
        public DataTable GetThongTinDocGia(string maDocGia)
        {

            DataTable dt = docGiaDAL.GetDocGiaById(maDocGia);

            return dt;
        }
    }
}
