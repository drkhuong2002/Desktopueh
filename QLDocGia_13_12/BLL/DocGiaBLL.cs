using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using static DAL.DocGiaDAL;


namespace BLL
{
    public class DocGiaBLL
    {
        public DocGiaDAL docGiaDAL;
        public DocGiaBLL()
        {
            docGiaDAL = new DocGiaDAL();
        }
        public DataTable DSDocGiaBLL()
        {
            DataTable docgia = docGiaDAL.ListDocGia();
            return docgia;
        }
    }

    public class LoaiDocGiaBLL
    {
        public LoaiDocGiaDAL loaiDocGiaDAL;
        public LoaiDocGiaBLL()
        {
            loaiDocGiaDAL= new LoaiDocGiaDAL();
        }
        public DataTable DSLoaiDocGiaBLL()
        {
            DataTable loaidocgia = loaiDocGiaDAL.ListLoaiDocGia();
            return loaidocgia;
        }
    }
}
