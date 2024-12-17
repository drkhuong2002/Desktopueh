using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydocgia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void HienThiLichSuMuonTra(string maDocGia)
        {
            try
            {
                string connectionString = "your_connection_string_here";

                LichSuMuonTraBLL lichSuBLL = new LichSuMuonTraBLL(connectionString);

                // Lấy danh sách lịch sử mượn trả
                List<LichSuMuonTraDTO> danhSachLichSu = lichSuBLL.LayLichSuMuonTraTheoDocGia(maDocGia);

                // Kiểm tra số lượng bản ghi
                if (danhSachLichSu.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu lịch sử mượn trả.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Gán nguồn dữ liệu cho DataGridView
                dgvLichSuMuonTra.DataSource = danhSachLichSu;

                // Tùy chỉnh tiêu đề cột
                if (dgvLichSuMuonTra.Columns.Count > 0)
                {
                    dgvLichSuMuonTra.Columns["MaPhieuMuon"].HeaderText = "Mã Phiếu Mượn";
                    dgvLichSuMuonTra.Columns["MaSach"].HeaderText = "Mã Sách";
                    dgvLichSuMuonTra.Columns["TenSach"].HeaderText = "Tên Sách";
                    dgvLichSuMuonTra.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                    dgvLichSuMuonTra.Columns["HanTra"].HeaderText = "Hạn Trả";
                    dgvLichSuMuonTra.Columns["TrangThaiTra"].HeaderText = "Trạng Thái Trả";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // In chi tiết lỗi ra Output của Visual Studio để debug
                System.Diagnostics.Debug.WriteLine($"Chi tiết lỗi: {ex}");
            }
        }
    }
}
