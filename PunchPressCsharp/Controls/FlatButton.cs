using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PunchPressCsharp.Controls
{
    public enum FlatButtonStyle
    {
        Filled,   // 实心按钮（默认）
        Outline,  // 描边按钮
        Text      // 文字按钮（无边框/背景）
    }

    [ToolboxItem(true)]
    [DefaultProperty("Text")]
    public partial class FlatButton : Button
    {
        private bool _hovered;
        private bool _pressed;

        private Color _accentColor = Color.FromArgb(24, 144, 255); // #1890FF
        private FlatButtonStyle _style = FlatButtonStyle.Filled;
        private int _cornerRadius = 6;
        private int _borderThickness = 0;

        private Padding _contentPadding = new Padding(12, 6, 12, 6);

        public FlatButton()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.AllPaintingInWmPaint, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;

            // 默认尺寸/颜色（扁平/浅色主题友好）
            Size = new Size(96, 34);
            Font = new Font(Font.FontFamily, 10f, FontStyle.Regular);
            ForeColor = Color.White;
            BackColor = Color.Transparent; // 交由自绘 & 父背景渲染

            // 初始区域更新（构造时可能还没有尺寸，OnResize 会再次更新）
            UpdateRegionClip();
        }

        [Category("Flat"), Description("按钮风格：实心/描边/文字")]
        public FlatButtonStyle Style
        {
            get => _style;
            set { _style = value; Invalidate(); }
        }

        [Category("Flat"), Description("主题强调色")]
        public Color AccentColor
        {
            get => _accentColor;
            set { _accentColor = value; Invalidate(); }
        }

        [Category("Flat"), Description("圆角半径（0 表示直角）")]
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

        [Category("Flat"), Description("边框粗细（仅 Style=Outline 时有效）")]
        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                _borderThickness = Math.Max(0, value);
                UpdateRegionClip(); // 边框变更也同步区域，避免描边被裁掉
                Invalidate();
            }
        }

        [Category("Flat"), Description("内容内边距（影响文本/图标布局）")]
        public Padding ContentPadding
        {
            get => _contentPadding;
            set { _contentPadding = value; Invalidate(); }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegionClip();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hovered = false;
            _pressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                _pressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _pressed = false;
            Invalidate();
        }

        // 让透明处与父容器背景一致（避免默认背景填充）
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Parent != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                using (var br = new SolidBrush(Parent.BackColor))
                {
                    e.Graphics.FillRectangle(br, e.ClipRectangle);
                }
            }
            else
            {
                base.OnPaintBackground(e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // 使用 -1 的矩形，避免描边被 Region 裁掉
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            // 计算状态色
            var accent = AccentColor;
            var back = CalcBackColor(accent);
            var border = CalcBorderColor(accent);
            var fore = CalcForeColor(accent);

            using (var path = CreateRoundRect(rect, CornerRadius))
            {
                // 背景填充：Filled 直接用强调色，其它风格仅在 hover/press 时轻微反馈
                using (var br = new SolidBrush(back))
                    e.Graphics.FillPath(br, path);

                // 边框（仅描边风格）
                if (Style == FlatButtonStyle.Outline && BorderThickness > 0 && Enabled)
                {
                    // 收缩半个像素保证整条描边在 Region 内可见
                    var borderRect = Rectangle.Inflate(rect, -BorderThickness / 2, -BorderThickness / 2);
                    using (var pen = new Pen(border, BorderThickness))
                    using (var borderPath = CreateRoundRect(borderRect, CornerRadius))
                        e.Graphics.DrawPath(pen, borderPath);
                }
            }

            // 文本/图标绘制（居中）
            var textRect = Rectangle.Inflate(rect, -ContentPadding.Left, -ContentPadding.Top);
            textRect.Width -= ContentPadding.Right;
            textRect.Height -= ContentPadding.Bottom;

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                textRect,
                fore,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            // 焦点虚线框（可选）
            if (Focused && ShowFocusCues && Enabled)
            {
                var focusRect = Rectangle.Inflate(rect, -4, -4);
                ControlPaint.DrawFocusRectangle(e.Graphics, focusRect);
            }
        }

        private void UpdateRegionClip()
        {
            // 使用内容区域 -1，避免描边被 Region 裁切
            var rect = new Rectangle(0, 0, Math.Max(0, Width - 1), Math.Max(0, Height - 1));
            if (rect.Width == 0 || rect.Height == 0)
            {
                Region = null;
                return;
            }

            // 为了让描边完整显示，适当收缩 Region（当有描边时）
            int shrink = Math.Max(0, BorderThickness / 2);
            var regionRect = Rectangle.Inflate(rect, -shrink, -shrink);

            using (var path = CreateRoundRect(regionRect, CornerRadius))
            {
                Region?.Dispose();
                Region = new Region(path);
            }
        }

        private Color CalcBackColor(Color accent)
        {
            if (!Enabled)
            {
                switch (Style)
                {
                    case FlatButtonStyle.Filled: return Mix(accent, Color.White, 0.65);
                    case FlatButtonStyle.Outline:
                    case FlatButtonStyle.Text: return Color.Transparent;
                }
            }

            if (_pressed)
            {
                switch (Style)
                {
                    case FlatButtonStyle.Filled: return Darken(accent, 0.15);
                    case FlatButtonStyle.Outline: return Mix(accent, Color.White, 0.9);
                    case FlatButtonStyle.Text: return Mix(accent, Color.White, 0.92);
                }
            }
            if (_hovered)
            {
                switch (Style)
                {
                    case FlatButtonStyle.Filled: return Lighten(accent, 0.12);
                    case FlatButtonStyle.Outline: return Mix(accent, Color.White, 0.94);
                    case FlatButtonStyle.Text: return Mix(accent, Color.White, 0.96);
                }
            }

            switch (Style)
            {
                case FlatButtonStyle.Filled: return accent;
                case FlatButtonStyle.Outline:
                case FlatButtonStyle.Text: return Color.Transparent;
            }

            return accent;
        }

        private Color CalcBorderColor(Color accent)
        {
            if (!Enabled) return Mix(accent, Color.Gray, 0.6);
            return accent;
        }

        private Color CalcForeColor(Color accent)
        {
            if (!Enabled)
            {
                return Style == FlatButtonStyle.Filled ? Color.White : Mix(accent, Color.Gray, 0.6);
            }

            switch (Style)
            {
                case FlatButtonStyle.Filled: return Color.White;
                case FlatButtonStyle.Outline:
                case FlatButtonStyle.Text: return accent;
            }
            return Color.White;
        }

        // 颜色工具
        private static Color Lighten(Color c, double amount)
        {
            int r = (int)Math.Min(255, c.R + 255 * amount);
            int g = (int)Math.Min(255, c.G + 255 * amount);
            int b = (int)Math.Min(255, c.B + 255 * amount);
            return Color.FromArgb(c.A, r, g, b);
        }

        private static Color Darken(Color c, double amount)
        {
            int r = (int)Math.Max(0, c.R - 255 * amount);
            int g = (int)Math.Max(0, c.G - 255 * amount);
            int b = (int)Math.Max(0, c.B - 255 * amount);
            return Color.FromArgb(c.A, r, g, b);
        }

        private static Color Mix(Color a, Color b, double ratioB)
        {
            double rb = Math.Max(0, Math.Min(1, ratioB));
            double ra = 1 - rb;
            int r = (int)(a.R * ra + b.R * rb);
            int g = (int)(a.G * ra + b.G * rb);
            int bl = (int)(a.B * ra + b.B * rb);
            return Color.FromArgb((int)(a.A * ra + b.A * rb), r, g, bl);
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