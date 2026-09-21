namespace CafeStatusDemo
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblGioHienTai = new ToolStripStatusLabel();
            lblTenQuan = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(660, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, thoátToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(85, 24);
            toolStripMenuItem1.Text = "Hệ thống";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 26);
            toolStripMenuItem2.Text = "Đổi màu nền";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(177, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.AllowItemReorder = true;
            statusStrip1.GripMargin = new Padding(0);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblGioHienTai, lblTenQuan, lblTrangThai });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.No;
            statusStrip1.ShowItemToolTips = true;
            statusStrip1.Size = new Size(660, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblGioHienTai
            // 
            lblGioHienTai.Name = "lblGioHienTai";
            lblGioHienTai.Size = new Size(98, 20);
            lblGioHienTai.Text = "lblGioHienTai";
            lblGioHienTai.Click += lblGioHienTai_Click;
            // 
            // lblTenQuan
            // 
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Padding = new Padding(300, 0, 0, 0);
            lblTenQuan.Size = new Size(437, 20);
            lblTenQuan.Text = "CAFE ÁNH DƯƠNG";
            // 
            // lblTrangThai
            // 
            lblTrangThai.BackColor = SystemColors.Control;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(86, 20);
            lblTrangThai.Text = "ádsadasdsa";
            lblTrangThai.TextAlign = ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(660, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "CAFE ÁNH DƯƠNG";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblGioHienTai;
        private ToolStripStatusLabel lblTenQuan;
        private ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Timer timer1;
        private ColorDialog colorDialog1;
    }
}
