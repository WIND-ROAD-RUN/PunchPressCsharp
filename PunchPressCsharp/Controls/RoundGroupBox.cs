using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunchPressCsharp.Controls
{
    public partial class RoundGroupBox : GroupBox
    {
        public int CornerRadius { get; set; } = 16;

        public RoundGroupBox()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 不调用 base.OnPaint(e)，避免系统自动绘制造成重影

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = this.ClientRectangle;
            bounds.Width -= 1;
            bounds.Height -= 1;

            using (GraphicsPath path = GetRoundRectPath(bounds, CornerRadius))
            using (Pen pen = new Pen(this.ForeColor, 1.5f))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(80, this.BackColor)))
            {
                // 填充圆角区域（半透明）
                e.Graphics.FillPath(brush, path);
                // 绘制圆角边框
                e.Graphics.DrawPath(pen, path);
            }

            // 绘制标题文本
            SizeF textSize = e.Graphics.MeasureString(Text, Font);
            Rectangle textRect = new Rectangle(10, 0, (int)textSize.Width + 6, (int)textSize.Height);

            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(brush, textRect);
            }
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(Text, Font, brush, 12, 0);
            }
        }
        private GraphicsPath GetRoundRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
