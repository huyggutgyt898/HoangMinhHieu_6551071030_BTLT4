namespace BTCh4_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCongViecMoi.Text.Trim() != "")
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void danhDauHoanThanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    int viTri = lstCongViec.SelectedIndex;
                    lstCongViec.Items[viTri] = "[Hoàn thành] " + congViec;
                }
            }
        }

        private void xoaCongViecNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa!");
            }
        }

        private void xoaTatCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa tất cả công việc không?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}