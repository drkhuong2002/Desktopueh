using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuaSachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTacGia { get; set; }
        public DateTime NamXuatBan { get; set; }
        public string MaTheLoai { get; set; }
        public string MaNXB { get; set; }
        public int SoLuongConLai { get; set; }
        public int SoLuongDaMuon { get; set; }
    }
}
