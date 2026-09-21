namespace BangVeMini
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlCanvas.Location = new System.Drawing.Point(12, 40);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(760, 440);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblViTri.Location = new System.Drawing.Point(12, 10);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(94, 20);
            this.lblViTri.TabIndex = 1;
            this.lblViTri.Text = "X: 0,  Y: 0";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTrangThai.Location = new System.Drawing.Point(622, 10);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(150, 23);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Sẵn sàng";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            this.lblHuongDan.Location = new System.Drawing.Point(12, 488);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(320, 15);
            this.lblHuongDan.TabIndex = 3;
            this.lblHuongDan.Text = "Giữ chuột trái và kéo để vẽ  |  Nhấn chuột phải để xóa toàn bộ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.pnlCanvas);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng vẽ mini - Ghi chú nhanh";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblHuongDan;
    }
}
