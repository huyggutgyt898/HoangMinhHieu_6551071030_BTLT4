namespace C5_cau1_fromNhapLieuSieuThi
{
    public partial class FromBanHang : Form
    {
        public FromBanHang()
        {
            InitializeComponent();

            // Cho Form bat phim tat
            this.KeyPreview = true;

            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            txtDonGia.KeyPress += txtDonGia_KeyPress;

            btnXoaTrang.Click += btnXoaTrang_Click;

            this.KeyDown += FromBanHang_KeyDown;
        }

        // Chi cho nhap so vao txtSoLuong
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Chi cho nhap so vao txtDonGia
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Nut Them
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string donGia = txtDonGia.Text.Trim();

            if (maSP == "" || soLuong == "" || donGia == "")
            {
                MessageBox.Show(
                    "Vui long nhap day du thong tin!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string dong = maSP + " | " + soLuong + " | " + donGia;

            lstKetQua.Items.Add(dong);
        }

        // Nut Xoa trang
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtMaSP.Focus();
        }

        // Xu ly phim tat F2, F5, ESC
        private void FromBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            // F2 -> Them
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
                e.SuppressKeyPress = true;
            }

            // F5 -> Xoa trang
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
                e.SuppressKeyPress = true;
            }

            // ESC -> Thoat
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Ban co muon thoat?",
                    "Xac nhan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

                e.SuppressKeyPress = true;
            }
        }
    }
}