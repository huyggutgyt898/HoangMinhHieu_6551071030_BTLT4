using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTCh4_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboGoiTap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboGoiTap.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGoiTap.Items.Add("Basic");
            cboGoiTap.Items.Add("VIP");
            cboGoiTap.Items.Add("Premium");

            cboGoiTap.SelectedIndexChanged += cboGoiTap_SelectedIndexChanged;

            numSoBuoiTap.Minimum = 1;
            numSoBuoiTap.Maximum = 7;

            numSoBuoiTap.Value = 1;

            numSoBuoiTap.Increment = 1;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                // Lấy thông tin từ các control
                string hoTen = txtHoTen.Text;
                string sdt = txtSDT.Text;
                string goiTap = cboGoiTap.SelectedItem.ToString();
                int soBuoi = (int)numSoBuoiTap.Value;

                // Hiển thị thông tin tổng hợp
                string thongTin = $"Họ tên: {hoTen}\n" +
                                  $"SĐT: {sdt}\n" +
                                  $"Gói tập: {goiTap}\n" +
                                  $"Số buổi/tuần: {soBuoi}";

                MessageBox.Show(thongTin, "Thông tin đăng ký", MessageBoxButtons.OK);
            }
        }
    }
}
