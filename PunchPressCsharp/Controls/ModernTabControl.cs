using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace PunchPressCsharp.Controls
{
    [ToolboxItem(true)]
    [DefaultProperty("CornerRadius")]
    public partial class ModernTabControl : TabControl
    {
        private int _cornerRadius = 4;                 // 扁平默认圆角
        private int _tabHeight = 36;
        private int _tabSpacing = 6;
        private int _hoverIndex = -1;

        // 扁平浅色主题
        private Color _headerBackColor = Color.White;                          // 标题条白底
        private Color _headerBorderColor = Color.FromArgb(224, 224, 224);      // 标题条底部细线
        private Color _tabBackColor = Color.White;
        private Color _tabHoverColor = Color.FromArgb(245, 245, 245);          // 悬停浅灰
        private Color _tabSelectedColor = Color.FromArgb(24, 144, 255);        // #1890FF 作为强调色
        private Color _tabSelectedBackColor = Color.White;                     // 选中仍为白底（扁平）
        private Color _tabForeColor = Color.FromArgb(85, 85, 85);              // 普通文字 #555
        private Color _tabSelectedForeColor = Color.FromArgb(51, 51, 51);      // 选中文字 #333
        private bool _underlineSelected = true;                                 // 选中下划线
        private Color _underlineColor = Color.FromArgb(24, 144, 255);
        private int _underlineHeight = 2;                                       // 更轻

        public ModernTabControl()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            // 双缓冲
            try
            {
                typeof(Control)?.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(this, true, null);
            }
            catch { }

            Alignment = TabAlignment.Top;
            DrawMode = TabDrawMode.OwnerDrawFixed;
            SizeMode = TabSizeMode.Fixed;

            // 高度通过 ItemSize 控制
            ItemSize = new Size(120, _tabHeight);
            Padding = new Point(14, 6);
            Appearance = TabAppearance.Normal;

            // 内容页浅色
            base.BackColor = Color.White;
        }

        // 可定制属性
        [Category("Modern"), Description("圆角半径（0 为纯扁平）")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = Math.Max(0, value);
                UpdateRegionClip();
                Invalidate();
            }
        }

        [Category("Modern"), Description("Tab 标题区高度")]
        public int TabHeaderHeight { get => _tabHeight; set { _tabHeight = Math.Max(28, value); ItemSize = new Size(ItemSize.Width, _tabHeight); Invalidate(); } }

        [Category("Modern"), Description("Tab 间距")]
        public int TabSpacing { get => _tabSpacing; set { _tabSpacing = Math.Max(0, value); Invalidate(); } }

        [Category("Modern"), Description("标题条背景色")]
        public Color HeaderBackColor { get => _headerBackColor; set { _headerBackColor = value; Invalidate(); } }

        [Category("Modern"), Description("标题条底部边线颜色")]
        public Color HeaderBorderColor { get => _headerBorderColor; set { _headerBorderColor = value; Invalidate(); } }

        [Category("Modern"), Description("普通 Tab 背景色")]
        public Color TabBackColor { get => _tabBackColor; set { _tabBackColor = value; Invalidate(); } }

        [Category("Modern"), Description("悬停 Tab 背景色")]
        public Color TabHoverColor { get => _tabHoverColor; set { _tabHoverColor = value; Invalidate(); } }

        [Category("Modern"), Description("选中 Tab 强调色（用于下划线/边线）")]
        public Color TabSelectedColor { get => _tabSelectedColor; set { _tabSelectedColor = value; Invalidate(); } }

        [Category("Modern"), Description("选中 Tab 背景色")]
        public Color TabSelectedBackColor { get => _tabSelectedBackColor; set { _tabSelectedBackColor = value; Invalidate(); } }

        [Category("Modern"), Description("普通 Tab 字体色")]
        public Color TabForeColor { get => _tabForeColor; set { _tabForeColor = value; Invalidate(); } }

        [Category("Modern"), Description("选中 Tab 字体色")]
        public Color TabSelectedForeColor { get => _tabSelectedForeColor; set { _tabSelectedForeColor = value; Invalidate(); } }

        [Category("Modern"), Description("是否在选中 Tab 底部绘制下划线")]
        public bool UnderlineSelected { get => _underlineSelected; set { _underlineSelected = value; Invalidate(); } }

        [Category("Modern"), Description("选中下划线颜色")]
        public Color UnderlineColor { get => _underlineColor; set { _underlineColor = value; Invalidate(); } }

        [Category("Modern"), Description("选中下划线高度")]
        public int UnderlineHeight { get => _underlineHeight; set { _underlineHeight = Math.Max(1, value); Invalidate(); } }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            foreach (TabPage page in TabPages)
            {
                page.BackColor = Color.White;
                page.ForeColor = TabForeColor;
            }
            UpdateRegionClip();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateRegionClip();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegionClip();
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            if (e.Control is TabPage page)
            {
                page.BackColor = Color.White;
                page.ForeColor = TabForeColor;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int newHover = -1;
            for (int i = 0; i < TabCount; i++)
            {
                if (GetTabRect(i).Contains(e.Location))
                {
                    newHover = i;
                    break;
                }
            }
            if (newHover != _hoverIndex)
            {
                _hoverIndex = newHover;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (_hoverIndex != -1)
            {
                _hoverIndex = -1;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // 标题条区域（白底 + 底部细线）
            int headerHeight = GetHeaderHeight();
            var headerRect = new Rectangle(0, 0, Width - 1, headerHeight);
            using (var br = new SolidBrush(HeaderBackColor))
                e.Graphics.FillRectangle(br, headerRect);

            using (var pen = new Pen(HeaderBorderColor))
                e.Graphics.DrawLine(pen, 0, headerRect.Bottom, Width, headerRect.Bottom);

            // 绘制每个 Tab
            for (int i = 0; i < TabCount; i++)
            {
                DrawTabItem(e.Graphics, i);
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // 自绘由 OnPaint 完成
        }

        private void DrawTabItem(Graphics g, int index)
        {
            Rectangle rect = GetTabRect(index);
            rect.Inflate(-_tabSpacing, 0); // Tab 间距

            bool selected = (index == SelectedIndex);
            bool hovered = (index == _hoverIndex);

            // 扁平：不画边框，仅在悬停时填充非常浅的背景，选中仅绘制下划线
            if (hovered && !selected)
            {
                DrawFlatBackground(g, rect, TabHoverColor);
            }
            else if (selected && TabSelectedBackColor != Color.Transparent)
            {
                DrawFlatBackground(g, rect, TabSelectedBackColor);
            }

            // 文本
            string text = TabPages[index].Text;
            var textRect = rect;
            textRect.Inflate(-12, -6);
            var fore = selected ? TabSelectedForeColor : TabForeColor;
            TextRenderer.DrawText(g, text, Font, textRect, fore,
                TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

            // 选中下划线（扁平强调）
            if (UnderlineSelected && selected)
            {
                var lineRect = new Rectangle(rect.X + 10, rect.Bottom - UnderlineHeight, rect.Width - 20, UnderlineHeight);
                using (var br = new SolidBrush(UnderlineColor))
                    g.FillRectangle(br, lineRect);
            }
        }

        private void DrawFlatBackground(Graphics g, Rectangle rect, Color color)
        {
            if (CornerRadius <= 0)
            {
                using (var br = new SolidBrush(color))
                    g.FillRectangle(br, rect);
            }
            else
            {
                using (var path = CreateRoundRect(rect, CornerRadius))
                using (var br = new SolidBrush(color))
                    g.FillPath(br, path);
            }
        }

        private int GetHeaderHeight()
        {
            if (TabCount > 0)
                return Math.Max(GetTabRect(0).Bottom + 2, _tabHeight + 2);
            return _tabHeight + 2;
        }

        private void UpdateRegionClip()
        {
            if (!IsHandleCreated) return;

            if (CornerRadius <= 0)
            {
                // 恢复为矩形
                Region?.Dispose();
                Region = null;
                return;
            }

            // 使用 -1 收缩，避免抗锯齿时边缘被裁切导致锯齿
            var rect = new Rectangle(0, 0, Math.Max(0, Width - 1), Math.Max(0, Height - 1));
            if (rect.Width == 0 || rect.Height == 0)
            {
                Region?.Dispose();
                Region = null;
                return;
            }

            using (var path = CreateRoundRect(rect, CornerRadius))
            {
                Region?.Dispose();
                Region = new Region(path);
            }
        }

        private static GraphicsPath CreateRoundRect(Rectangle r, int radius)
        {
            int d = Math.Min(radius, Math.Min(r.Width, r.Height) / 2) * 2;
            var path = new GraphicsPath();
            if (d <= 0)
            {
                path.AddRectangle(r);
                path.CloseFigure();
                return path;
            }

            path.AddArc(r.Left, r.Top, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Top, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.Left, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}