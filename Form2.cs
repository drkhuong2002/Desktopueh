using BLL;
using DTO;
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
    public partial class Form2 : Form
    {
        private SachBLL sachBLL = new SachBLL();
        public Form2()
        {
            InitializeComponent();
            ConfigureControls();
            LoadInitialData();

            // Thêm các sự kiện lọc
            txtTimKiem.TextChanged += FilterDataGridView;
            cbTheLoai.SelectedIndexChanged += FilterDataGridView;
            cbTacGia.SelectedIndexChanged += FilterDataGridView;
        }

        private void FilterDataGridView(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string theLoai = cbTheLoai.SelectedItem?.ToString() ?? "";
            string tacGia = cbTacGia.SelectedItem?.ToString() ?? "";

            var ketQuaLoc = danhSachSachGoc.Where(s =>
                (string.IsNullOrEmpty(tuKhoa) || s.TenSach.ToLower().Contains(tuKhoa)) &&
                (string.IsNullOrEmpty(theLoai) || s.TheLoai == theLoai) &&
                (string.IsNullOrEmpty(tacGia) || s.TacGia == tacGia)
            ).ToList();

            dgvSach.DataSource = ketQuaLoc;
        }
        private void ConfigureControls()
        {
            // Cấu hình AutoComplete cho TextBox tìm kiếm
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Cấu hình DataGridView
            dgvSach.AutoGenerateColumns = true;
            dgvSach.ReadOnly = true;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Thêm sự kiện Click cho nút Reset
            btnReset.Click += btnReset_Click;
        }

        private List<TuaSach> danhSachSachGoc;
        private void LoadInitialData()
        {
            // Nạp danh sách tên sách cho AutoComplete
            AutoCompleteStringCollection tenSachCollection = new AutoCompleteStringCollection();
            tenSachCollection.AddRange(sachBLL.LayDanhSachTenSach().ToArray());
            txtTimKiem.AutoCompleteCustomSource = tenSachCollection;

            // Nạp danh sách thể loại
            cbTheLoai.Items.Clear();
            cbTheLoai.Items.Add(""); // Thêm lựa chọn rỗng
            cbTheLoai.Items.AddRange(sachBLL.LayDanhSachTheLoai().ToArray());

            // Nạp danh sách tác giả
            cbTacGia.Items.Clear();
            cbTacGia.Items.Add(""); // Thêm lựa chọn rỗng
            cbTacGia.Items.AddRange(sachBLL.LayDanhSachTacGia().ToArray());

            // Nạp toàn bộ dữ liệu ban đầu
            CapNhatDataGridView("", "", "");

            // Lưu trữ dữ liệu gốc
            danhSachSachGoc = sachBLL.TraCuuSach("", "", "");

            // Nạp dữ liệu vào DataGridView
            dgvSach.DataSource = danhSachSachGoc;

            // Nạp danh sách thể loại từ dữ liệu gốc
            var theLoai = danhSachSachGoc
                .Select(s => s.TheLoai)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            cbTheLoai.Items.Clear();
            cbTheLoai.Items.Add(""); // Thêm lựa chọn rỗng
            cbTheLoai.Items.AddRange(theLoai.ToArray());

            // Tương tự với danh sách tác giả
            var tacGia = danhSachSachGoc
                .Select(s => s.TacGia)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            cbTacGia.Items.Clear();
            cbTacGia.Items.Add(""); // Thêm lựa chọn rỗng
            cbTacGia.Items.AddRange(tacGia.ToArray());
        }

        private void CapNhatDataGridView(string tuKhoa, string theLoai, string tacGia)
        {
            try
            {
                List<TuaSach> danhSachSach = sachBLL.TraCuuSach(tuKhoa, theLoai, tacGia);

                // Kiểm tra và thông báo nếu không có kết quả
                if (danhSachSach.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách phù hợp!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Gán nguồn dữ liệu cho DataGridView
                dgvSach.DataSource = danhSachSach;

                // Đặt tên cột tiếng Việt
                if (dgvSach.Columns.Count > 0)
                {
                    dgvSach.Columns["MaCuonSach"].HeaderText = "Mã Cuốn Sách";
                    dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
                    dgvSach.Columns["TheLoai"].HeaderText = "Thể Loại";
                    dgvSach.Columns["NhaXuatBan"].HeaderText = "Nhà Xuất Bản";
                    dgvSach.Columns["TacGia"].HeaderText = "Tác Giả";
                    dgvSach.Columns["TinhTrang"].HeaderText = "Tình Trạng";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string theLoai = cbTheLoai.SelectedItem?.ToString() ?? "";
            string tacGia = cbTacGia.SelectedItem?.ToString() ?? "";

            var ketQuaLoc = danhSachSachGoc.Where(s =>
                (string.IsNullOrEmpty(tuKhoa) || s.TenSach.ToLower().Contains(tuKhoa)) &&
                (string.IsNullOrEmpty(theLoai) || s.TheLoai == theLoai) &&
                (string.IsNullOrEmpty(tacGia) || s.TacGia == tacGia)
            ).ToList();

            dgvSach.DataSource = ketQuaLoc;
        }

        // Thêm sự kiện để reset kết quả
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa các điều kiện tìm kiếm
            txtTimKiem.Clear();
            cbTheLoai.SelectedIndex = -1;  // Về trạng thái không chọn gì
            cbTacGia.SelectedIndex = -1;   // Về trạng thái không chọn gì

            // Khôi phục toàn bộ dữ liệu ban đầu
            dgvSach.DataSource = danhSachSachGoc;
        }
    }
}
