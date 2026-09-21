namespace C5_cau1_fromNhapLieuSieuThi
{
    partial class FromBanHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtMaSP = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(220, 208);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(185, 27);
            txtDonGia.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(220, 147);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(185, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(220, 82);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(185, 27);
            txtMaSP.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.Location = new Point(136, 298);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = Color.Red;
            btnXoaTrang.Location = new Point(311, 298);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(132, 29);
            btnXoaTrang.TabIndex = 4;
            btnXoaTrang.Text = "Xóa trang (F5)";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 89);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 150);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 215);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Đơn giá";
            // 
            // lstKetQua
            // 
            lstKetQua.BackColor = Color.FromArgb(192, 255, 255);
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(491, 82);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(270, 224);
            lstKetQua.TabIndex = 8;
            // 
            // FromBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtMaSP);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            KeyPreview = true;
            Name = "FromBanHang";
            Text = "FormBanHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtMaSP;
        private Button btnThem;
        private Button btnXoaTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstKetQua;
    }
}
