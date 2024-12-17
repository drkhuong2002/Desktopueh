using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydocgia
{
    public partial class Form1 : Form
    {
        public DocGiaBLL docGiaBLL = new DocGiaBLL();
        public Form1()
        {
            InitializeComponent();
            XemThongTin();
        }
        private void XemThongTin()
        {
               string maDocGia = "DG001";

                // Lấy thông tin độc giả từ BLL
                DataTable dt = docGiaBLL.GetThongTinDocGia(maDocGia);

                // Hiển thị thông tin lên giao diện
                lblTen.Text = dt.Rows[0]["TenDocGia"].ToString();
                lblNgaySinh.Text = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                lblEmail.Text = dt.Rows[0]["Email"].ToString();
                lblSDT.Text = dt.Rows[0]["SDT"].ToString();
           
        }
    }
}
