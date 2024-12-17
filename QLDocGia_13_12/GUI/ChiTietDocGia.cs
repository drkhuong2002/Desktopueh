using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class ChiTietDocGia : Form
    {
        public ThemDocGiaBLL themDocGiaBLL = new ThemDocGiaBLL();
        public ThemTaiKhoanBLL themTaiKhoanBLL = new ThemTaiKhoanBLL();
        public ChiTietDocGia()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblLoaiDocGia_Click(object sender, EventArgs e)
        {

        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        public void btn_HanhDongDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ giao diện
                string maDocGia = tbMaDocGia.Text;
                string ten = tbTen.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string email = tbEmail.Text;
                string soDienThoai = tbSDT.Text;
                string maTaiKhoan = tbMaTK.Text;
                string taiKhoan = tbTaiKhoan.Text;
                string matKhau = tbMatKhau.Text;
                string loaiDocGia = cbbLoaiDocGia.SelectedItem.ToString();

                // Gửi dữ liệu đến lớp BLL để xử lý - cho vào DTO
                TaiKhoanDTO taiKhoann = new TaiKhoanDTO
                {
                    MaTK = maTaiKhoan,
                    TenDangNhap = taiKhoan,
                    MatKhau = matKhau,
                };
                DocGiaDTO docGia = new DocGiaDTO
                {
                    MaDocGia = maDocGia,
                    TenDocGia = ten,
                    NgaySinh = ngaySinh,
                    Email = email,
                    SDT = soDienThoai,
                    MaLoaiDG = loaiDocGia,
                    MaTK = maTaiKhoan,
                };
                // Gửi dữ liệu tài khoản đến BLL
                bool TaiKhoanGUI = themTaiKhoanBLL.ThemTaiKhoan_BLL(taiKhoann);

                if (TaiKhoanGUI)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại. - Không gửi được dl từ GUI đến BLL");
                }

                // Gửi dữ liệu độc giả đến BLL
                bool DocGiaGUI = themDocGiaBLL.ThemDocGia_BLL(docGia);

                if (DocGiaGUI)
                {
                    MessageBox.Show("Thêm độc giả thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thất bại.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error in GUI: " + ex.Message);
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
