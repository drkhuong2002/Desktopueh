using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGiaDTO
    {
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgaySinh{ get; set; }
        public string Email { get; set; }
        public string SDT  { get; set; }
        public string MaTK { get; set; }
        public string MaLoaiDG { get; set; }
    }
    public class TaiKhoanDTO
    {
        public string MaTK { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    }
    }
