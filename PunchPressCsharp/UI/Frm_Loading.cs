// Frm_Loading.cs
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PunchPress
{
    public partial class Frm_Loading : Form
    {
        #region 窗体阴影效果
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private const int CS_DROPSHADOW = 0x00020000;
        private bool m_aeroEnabled;

        private struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return enabled == 1;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0085 && m_aeroEnabled) // WM_NCPAINT
            {
                int v = 2;
                DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                MARGINS margins = new MARGINS()
                {
                    bottomHeight = 1,
                    leftWidth = 0,
                    rightWidth = 0,
                    topHeight = 0
                };
                DwmExtendFrameIntoClientArea(this.Handle, ref margins);
            }
            base.WndProc(ref m);
        }
        #endregion

        #region 自定义变量
        private Timer loadingTimer;
        private int loadingProgress = 0;
        private const int LoadingDuration = 3000; // 3秒加载时间
        #endregion

        public Frm_Loading()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // 启用双缓冲防止闪烁
            ApplyIndustrialStyle();
        }

        private void ApplyIndustrialStyle()
        {
            // 深色工业风格配色
            this.BackColor = Color.FromArgb(45, 45, 48);
            panelContainer.BackColor = Color.FromArgb(30, 30, 32);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblStatus.ForeColor = Color.White;
            progressBar.BackColor = Color.FromArgb(60, 60, 65);
            progressBar.ForeColor = Color.FromArgb(0, 122, 204);
        }

        private void Frm_Loading_Load(object sender, EventArgs e)
        {
            // 设置窗体位置在屏幕中央
            this.StartPosition = FormStartPosition.CenterScreen;

            // 初始化加载计时器
            loadingTimer = new Timer();
            loadingTimer.Interval = 30; // 约30FPS
            loadingTimer.Tick += LoadingTimer_Tick;
            loadingTimer.Start();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            loadingProgress += (100 * loadingTimer.Interval) / LoadingDuration;

            if (loadingProgress >= 100)
            {
                loadingProgress = 100;
                loadingTimer.Stop();

                // 进度条更新和界面刷新
                progressBar.Value = loadingProgress;
                lblStatus.Text = $"系统初始化完成";
                progressBar.Invalidate();

                // === 添加页面跳转逻辑 ===
                this.Hide(); // 先隐藏当前加载窗体

                Frm_PunchPress frm_PunchPress = new Frm_PunchPress();
                frm_PunchPress.Show();

                        
            }
            else
            {
                progressBar.Value = loadingProgress;
                lblStatus.Text = $"系统初始化中... {loadingProgress}%";
                progressBar.Invalidate();
            }
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {
            // 创建圆角路径
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 15;
                Rectangle rect = panelContainer.ClientRectangle;
                rect.Width--;
                rect.Height--;

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panelContainer.Region = new Region(path);

                // 绘制圆角边框
                using (var pen = new Pen(Color.FromArgb(70, 70, 70), 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            // 自定义进度条绘制
            ProgressBar bar = (ProgressBar)sender;
            Rectangle rect = bar.ClientRectangle;
            rect.Inflate(-3, -3); // 减少边框

            // 绘制背景
            using (SolidBrush bgBrush = new SolidBrush(bar.BackColor))
            {
                e.Graphics.FillRectangle(bgBrush, rect);
            }

            // 绘制进度
            if (bar.Value > 0)
            {
                Rectangle progressRect = new Rectangle(
                    rect.X, rect.Y,
                    (int)(rect.Width * ((double)bar.Value / bar.Maximum)),
                    rect.Height
                );

                // 创建渐变画笔
                using (LinearGradientBrush progressBrush = new LinearGradientBrush(
                    progressRect,
                    Color.FromArgb(0, 122, 204),
                    Color.FromArgb(0, 150, 255),
                    0f))
                {
                    e.Graphics.FillRectangle(progressBrush, progressRect);
                }

                // 添加光晕效果
                using (Pen glowPen = new Pen(Color.FromArgb(100, 200, 255, 255), 2))
                {
                    e.Graphics.DrawLine(glowPen,
                        progressRect.Right, rect.Y + 2,
                        progressRect.Right, rect.Bottom - 2);
                }
            }

            // 绘制文本
            string text = $"{bar.Value}%";
            using (Font font = new Font("Microsoft YaHei UI", 9, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                SizeF textSize = e.Graphics.MeasureString(text, font);
                PointF textPos = new PointF(
                    rect.Right - textSize.Width - 5,
                    rect.Y + (rect.Height - textSize.Height) / 2
                );
                e.Graphics.DrawString(text, font, textBrush, textPos);
            }
        }
    }
}