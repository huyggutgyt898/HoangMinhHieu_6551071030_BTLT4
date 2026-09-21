namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Tạo mới một đối tượng ColorDialog
            using (ColorDialog colorDlg = new ColorDialog())
            {
                // Hiển thị hộp thoại chọn màu và kiểm tra nếu người dùng bấm nút OK
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    // Gán màu nền của Form bằng màu đã chọn
                    this.BackColor = colorDlg.Color;
                }
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatKichThuocStatusStrip();

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            CapNhatKichThuocStatusStrip();
        }

        private void CapNhatKichThuocStatusStrip()
        {
            int tongCacLabelKhac = lblGioHienTai.Width + lblTrangThai.Width;
            int khoangDu = statusStrip1.Width - tongCacLabelKhac;

            if (khoangDu > 0)
            {
                lblTenQuan.Width = khoangDu;
            }
        }
        private void lblGioHienTai_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            int currentHour = DateTime.Now.Hour;

            if (currentHour >= 6 && currentHour < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
