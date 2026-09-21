namespace BTCh4_Bai3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            danhDauHoanThanhToolStripMenuItem = new ToolStripMenuItem();
            xoaCongViecNayToolStripMenuItem = new ToolStripMenuItem();
            xoaTatCaToolStripMenuItem = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(10, 10);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(550, 31);
            txtCongViecMoi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(570, 10);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(200, 31);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(12, 47);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(760, 354);
            lstCongViec.TabIndex = 2;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(24, 24);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { danhDauHoanThanhToolStripMenuItem, xoaCongViecNayToolStripMenuItem, xoaTatCaToolStripMenuItem });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(257, 100);
            // 
            // danhDauHoanThanhToolStripMenuItem
            // 
            danhDauHoanThanhToolStripMenuItem.Name = "danhDauHoanThanhToolStripMenuItem";
            danhDauHoanThanhToolStripMenuItem.Size = new Size(256, 32);
            danhDauHoanThanhToolStripMenuItem.Text = "Đánh dấu hoàn thành";
            danhDauHoanThanhToolStripMenuItem.Click += danhDauHoanThanhToolStripMenuItem_Click;
            // 
            // xoaCongViecNayToolStripMenuItem
            // 
            xoaCongViecNayToolStripMenuItem.Name = "xoaCongViecNayToolStripMenuItem";
            xoaCongViecNayToolStripMenuItem.Size = new Size(256, 32);
            xoaCongViecNayToolStripMenuItem.Text = "Xóa công việc này";
            xoaCongViecNayToolStripMenuItem.Click += xoaCongViecNayToolStripMenuItem_Click;
            // 
            // xoaTatCaToolStripMenuItem
            // 
            xoaTatCaToolStripMenuItem.Name = "xoaTatCaToolStripMenuItem";
            xoaTatCaToolStripMenuItem.Size = new Size(256, 32);
            xoaTatCaToolStripMenuItem.Text = "Xóa tất cả";
            xoaTatCaToolStripMenuItem.Click += xoaTatCaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = "Danh sách việc cần làm";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;

        private ContextMenuStrip cmsCongViec;

        private ToolStripMenuItem danhDauHoanThanhToolStripMenuItem;
        private ToolStripMenuItem xoaCongViecNayToolStripMenuItem;
        private ToolStripMenuItem xoaTatCaToolStripMenuItem;
    }
}