namespace DocGia
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        // Tạo đối tượng ở BLL để truyền dữ liệu
        private DocGiaGUI DocGia = new DocGiaGUI();

    }
}
