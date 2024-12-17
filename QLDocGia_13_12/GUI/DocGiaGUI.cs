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

namespace GUI
{
    public partial class DocGiaGUI : Form
    {
        // Khai báo biến của lớp BLL
        public DocGiaBLL docGiaBLL;
        public LoaiDocGiaBLL loaiDocGiaBLL;
        public DocGiaGUI()
        {
            InitializeComponent();
            // Khởi tạo lớp BLL
            docGiaBLL = new DocGiaBLL();
            loaiDocGiaBLL = new LoaiDocGiaBLL();
        }

        private void Load_DocGia()
        {
            try
            {
                // Gọi hàm từ lớp BLL để lấy dữ liệu
                var dataTable = docGiaBLL.DSDocGiaBLL();

                // Gán dữ liệu vào DataGridView
                GridViewDocGia.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Load_LoaiDocGia()
        {
            try
            {
                // Gọi hàm từ lớp BLL để lấy dữ liệu
                var dataTablee = loaiDocGiaBLL.DSLoaiDocGiaBLL();

                // Gán dữ liệu vào DataGridView
                GridViewDocGia.DataSource = dataTablee;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void GridViewDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DocGiaGUI_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu lên DataGridView khi form được load
            Load_DocGia();
        }

        private void btnXemLoaiDocGia_Click(object sender, EventArgs e)
        {
            Load_LoaiDocGia();
            btnXemLoaiDocGia.BackColor = Color.LightBlue;
            btnXemGocGia.BackColor = Color.White;
        }

        private void btnXemGocGia_Click(object sender, EventArgs e)
        {
            Load_DocGia();
            btnXemLoaiDocGia.BackColor = Color.White;
            btnXemGocGia.BackColor = Color.LightBlue;
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            // Tạo một instance của Form "Thêm Độc Giả"
            ChiTietDocGia themDocGia = new ChiTietDocGia();

            // Hiển thị Form dưới dạng Dialog
            themDocGia.ShowDialog();
        }
    }
}
