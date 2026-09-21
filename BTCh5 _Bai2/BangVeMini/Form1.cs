using System.Drawing.Drawing2D;
using System.Reflection;

namespace BangVeMini
{
    public partial class Form1 : Form
    {
        // Mỗi nét vẽ là một danh sách các điểm (từ lúc nhấn chuột đến lúc nhả chuột)
        private readonly List<List<Point>> cacNetVe = new List<List<Point>>();
        private List<Point> netHienTai = null;

        // true khi đang giữ chuột trái
        private bool dangVe = false;

        private readonly Pen butVe = new Pen(Color.RoyalBlue, 3f)
        {
            StartCap = LineCap.Round,
            EndCap = LineCap.Round,
            LineJoin = LineJoin.Round
        };

        public Form1()
        {
            InitializeComponent();

            // Bật DoubleBuffered cho Panel để nét vẽ mượt, không nhấp nháy
            typeof(Panel).GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic)
                ?.SetValue(pnlCanvas, true);

            CapNhatTrangThai(false);
        }

        // ===== MouseDown: đánh dấu bắt đầu nét vẽ =====
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            dangVe = true;
            netHienTai = new List<Point> { e.Location };
            cacNetVe.Add(netHienTai);

            CapNhatTrangThai(true);
            pnlCanvas.Invalidate();   // để vẽ được cả chấm khi chỉ click nhẹ
        }

        // ===== MouseMove: cập nhật tọa độ + vẽ khi đang giữ chuột =====
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Luôn cập nhật tọa độ, dù có vẽ hay không
            lblViTri.Text = $"X: {e.X},  Y: {e.Y}";

            if (dangVe && netHienTai != null)
            {
                netHienTai.Add(e.Location);
                pnlCanvas.Invalidate();
            }
        }

        // ===== MouseUp: kết thúc nét vẽ =====
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            dangVe = false;
            netHienTai = null;
            CapNhatTrangThai(false);
        }

        // ===== MouseClick: chuột phải -> xóa toàn bộ =====
        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cacNetVe.Clear();
                netHienTai = null;
                pnlCanvas.Invalidate();   // vẽ lại -> Panel trắng hoàn toàn
            }
        }

        // ===== Paint: vẽ lại toàn bộ các nét (không mất nét khi cửa sổ bị che/thu nhỏ) =====
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var net in cacNetVe)
            {
                if (net.Count == 1)
                {
                    // Chỉ click 1 điểm -> vẽ một chấm tròn
                    float d = butVe.Width;
                    using (var brush = new SolidBrush(butVe.Color))
                    {
                        e.Graphics.FillEllipse(brush, net[0].X - d / 2, net[0].Y - d / 2, d, d);
                    }
                }
                else if (net.Count > 1)
                {
                    e.Graphics.DrawLines(butVe, net.ToArray());
                }
            }
        }

        private void CapNhatTrangThai(bool dangGiuChuot)
        {
            lblTrangThai.Text = dangGiuChuot ? "Đang vẽ..." : "Sẵn sàng";
            lblTrangThai.ForeColor = dangGiuChuot ? Color.OrangeRed : Color.SeaGreen;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            butVe.Dispose();
            base.OnFormClosed(e);
        }
    }
}
