using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SachBLL
    {
        private SachDAL sachDAL = new SachDAL();

        public List<TuaSach> TraCuuSach(string tuKhoa, string theLoai, string tacGia)
        {
            return sachDAL.TraCuuSach(tuKhoa, theLoai, tacGia);
        }

        public List<string> LayDanhSachTheLoai()
        {
            return sachDAL.LayDanhSachTheLoai();
        }

        public List<string> LayDanhSachTacGia()
        {
            return sachDAL.LayDanhSachTacGia();
        }

        public List<string> LayDanhSachTenSach()
        {
            return sachDAL.LayDanhSachTenSach();
        }
    }
}
