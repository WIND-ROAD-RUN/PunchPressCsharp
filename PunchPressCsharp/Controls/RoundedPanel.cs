using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PunchPressCsharp.Controls
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    [DesignTimeVisible(true)]
    public partial class RoundedPanel : Panel   // 从 UserControl 改为 Panel
    {
        private int _cornerRadius = 12;
        private Color _fillColor = Color.DimGray;
        private Color _borderColor = Color.FromArgb(90, 90, 90);
        private int _borderThickness = 1;

        public RoundedPanel()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
            DoubleBuffered = true;
            Padding = new Padding(6); // 给点内边距，避免子控件贴边被裁掉
        }

        [Category("Appearance")]
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = Math.Max(0, value); UpdateRegion(); Invalidate(); } }
        [Category("Appearance")]
        public Color FillColor { get => _fillColor; set { _fillColor = value; Invalidate(); } }
        [Category("Appearance")]
        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
        [Category("Appearance")]
        public int BorderThickness { get => _borderThickness; set { _borderThickness = Math.Max(0, value); Invalidate(); } }

        protected override void OnResize(EventArgs e) { base.OnResize(e); UpdateRegion(); }
        protected override void OnPaintBackground(PaintEventArgs e) { /* 交给 OnPaint，减少闪烁 */ }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (var path = CreateRoundRectanglePath(rect, CornerRadius))
            using (var br = new SolidBrush(FillColor))
                e.Graphics.FillPath(br, path);

            if (BorderThickness > 0)
                using (var pen = new Pen(BorderColor, BorderThickness))
                    e.Graphics.DrawPath(pen, CreateRoundRectanglePath(rect, CornerRadius));
        }

        private void UpdateRegion()
        {
            var rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;
            using (var path = CreateRoundRectanglePath(rect, CornerRadius))
            {
                Region?.Dispose();
                Region = new Region(path);
            }
        }

        private static GraphicsPath CreateRoundRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int r = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2);
            int d = r * 2;
            if (r <= 0) { path.AddRectangle(rect); path.CloseFigure(); return path; }

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}