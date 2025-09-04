namespace PunchPressCsharp.UI
{
    partial class Frm_PunchPress
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PunchPress));
            this.tim_getState = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.label5 = new System.Windows.Forms.Label();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiCheckBoxGroup3 = new Sunny.UI.UICheckBoxGroup();
            this.btn_set = new Sunny.UI.UIButton();
            this.btn_templateLearn = new Sunny.UI.UIButton();
            this.btn_brightnessChange = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup2 = new Sunny.UI.UICheckBoxGroup();
            this.btn_disCentral = new Sunny.UI.UIButton();
            this.btn_disTemplate = new Sunny.UI.UIButton();
            this.lb_plcStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_cameraStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.titleBar = new System.Windows.Forms.Panel();
            this.btn_runOnce = new Sunny.UI.UIButton();
            this.panelContainer.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.uiCheckBoxGroup3.SuspendLayout();
            this.uiCheckBoxGroup2.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tim_getState
            // 
            this.tim_getState.Enabled = true;
            this.tim_getState.Interval = 5000;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelContainer.Controls.Add(this.vmRenderControl1);
            this.panelContainer.Controls.Add(this.uiLabel1);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup1);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup3);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1114, 680);
            this.panelContainer.TabIndex = 11;
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(16, 12);
            this.vmRenderControl1.Margin = new System.Windows.Forms.Padding(4);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(484, 610);
            this.vmRenderControl1.TabIndex = 8;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(616, 28);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(354, 54);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "冲床检测系统";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(899, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "版本号V1.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup1.Controls.Add(this.uiRichTextBox1);
            this.uiCheckBoxGroup1.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(516, 224);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(532, 187);
            this.uiCheckBoxGroup1.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup1.TabIndex = 4;
            this.uiCheckBoxGroup1.Text = "信息日志";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.uiRichTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.uiRichTextBox1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRichTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.uiRichTextBox1.Location = new System.Drawing.Point(42, 29);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.ReadOnly = true;
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(460, 153);
            this.uiRichTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRichTextBox1.TabIndex = 0;
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBoxGroup3
            // 
            this.uiCheckBoxGroup3.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup3.Controls.Add(this.btn_set);
            this.uiCheckBoxGroup3.Controls.Add(this.btn_templateLearn);
            this.uiCheckBoxGroup3.Controls.Add(this.btn_brightnessChange);
            this.uiCheckBoxGroup3.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup3.Location = new System.Drawing.Point(516, 99);
            this.uiCheckBoxGroup3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup3.Name = "uiCheckBoxGroup3";
            this.uiCheckBoxGroup3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup3.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup3.SelectedIndexes")));
            this.uiCheckBoxGroup3.Size = new System.Drawing.Size(531, 101);
            this.uiCheckBoxGroup3.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup3.TabIndex = 7;
            this.uiCheckBoxGroup3.Text = "基本操作";
            this.uiCheckBoxGroup3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_set
            // 
            this.btn_set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_set.Location = new System.Drawing.Point(374, 47);
            this.btn_set.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(115, 32);
            this.btn_set.Style = Sunny.UI.UIStyle.Custom;
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = "设置";
            this.btn_set.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_templateLearn
            // 
            this.btn_templateLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_templateLearn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_templateLearn.Location = new System.Drawing.Point(42, 47);
            this.btn_templateLearn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_templateLearn.Name = "btn_templateLearn";
            this.btn_templateLearn.Size = new System.Drawing.Size(126, 32);
            this.btn_templateLearn.Style = Sunny.UI.UIStyle.Custom;
            this.btn_templateLearn.TabIndex = 1;
            this.btn_templateLearn.Text = "模板学习";
            this.btn_templateLearn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_templateLearn.Click += new System.EventHandler(this.btn_templateLearn_Click);
            // 
            // btn_brightnessChange
            // 
            this.btn_brightnessChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brightnessChange.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_brightnessChange.Location = new System.Drawing.Point(207, 47);
            this.btn_brightnessChange.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_brightnessChange.Name = "btn_brightnessChange";
            this.btn_brightnessChange.Size = new System.Drawing.Size(115, 32);
            this.btn_brightnessChange.Style = Sunny.UI.UIStyle.Custom;
            this.btn_brightnessChange.TabIndex = 2;
            this.btn_brightnessChange.Text = "亮度修改";
            this.btn_brightnessChange.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_brightnessChange.Click += new System.EventHandler(this.btn_brightnessChange_Click);
            // 
            // uiCheckBoxGroup2
            // 
            this.uiCheckBoxGroup2.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup2.Controls.Add(this.btn_runOnce);
            this.uiCheckBoxGroup2.Controls.Add(this.btn_disCentral);
            this.uiCheckBoxGroup2.Controls.Add(this.btn_disTemplate);
            this.uiCheckBoxGroup2.Controls.Add(this.lb_plcStatus);
            this.uiCheckBoxGroup2.Controls.Add(this.label3);
            this.uiCheckBoxGroup2.Controls.Add(this.lb_cameraStatus);
            this.uiCheckBoxGroup2.Controls.Add(this.label1);
            this.uiCheckBoxGroup2.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup2.Location = new System.Drawing.Point(516, 421);
            this.uiCheckBoxGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            this.uiCheckBoxGroup2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup2.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup2.SelectedIndexes")));
            this.uiCheckBoxGroup2.Size = new System.Drawing.Size(531, 132);
            this.uiCheckBoxGroup2.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup2.TabIndex = 5;
            this.uiCheckBoxGroup2.Text = "系统状态";
            this.uiCheckBoxGroup2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_disCentral
            // 
            this.btn_disCentral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disCentral.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_disCentral.Location = new System.Drawing.Point(374, 80);
            this.btn_disCentral.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_disCentral.Name = "btn_disCentral";
            this.btn_disCentral.Size = new System.Drawing.Size(126, 32);
            this.btn_disCentral.Style = Sunny.UI.UIStyle.Custom;
            this.btn_disCentral.TabIndex = 1;
            this.btn_disCentral.Text = "显示中心";
            this.btn_disCentral.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disCentral.Click += new System.EventHandler(this.btn_disCentral_Click);
            // 
            // btn_disTemplate
            // 
            this.btn_disTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disTemplate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_disTemplate.Location = new System.Drawing.Point(374, 42);
            this.btn_disTemplate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_disTemplate.Name = "btn_disTemplate";
            this.btn_disTemplate.Size = new System.Drawing.Size(126, 32);
            this.btn_disTemplate.Style = Sunny.UI.UIStyle.Custom;
            this.btn_disTemplate.TabIndex = 1;
            this.btn_disTemplate.Text = "显示模板";
            this.btn_disTemplate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disTemplate.Click += new System.EventHandler(this.btn_disTemplate_Click);
            // 
            // lb_plcStatus
            // 
            this.lb_plcStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_plcStatus.ForeColor = System.Drawing.Color.Lime;
            this.lb_plcStatus.Location = new System.Drawing.Point(104, 89);
            this.lb_plcStatus.Name = "lb_plcStatus";
            this.lb_plcStatus.Size = new System.Drawing.Size(120, 23);
            this.lb_plcStatus.TabIndex = 3;
            this.lb_plcStatus.Text = "正常";
            this.lb_plcStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLC状态:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_cameraStatus
            // 
            this.lb_cameraStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cameraStatus.ForeColor = System.Drawing.Color.Lime;
            this.lb_cameraStatus.Location = new System.Drawing.Point(105, 46);
            this.lb_cameraStatus.Name = "lb_cameraStatus";
            this.lb_cameraStatus.Size = new System.Drawing.Size(111, 23);
            this.lb_cameraStatus.TabIndex = 1;
            this.lb_cameraStatus.Text = "正常";
            this.lb_cameraStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "相机状态:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "冲床检测系统";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillHoverColor = System.Drawing.Color.Red;
            this.btnClose.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClose.Location = new System.Drawing.Point(1074, 0);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1114, 40);
            this.titleBar.TabIndex = 10;
            // 
            // btn_runOnce
            // 
            this.btn_runOnce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_runOnce.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_runOnce.Location = new System.Drawing.Point(207, 72);
            this.btn_runOnce.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_runOnce.Name = "btn_runOnce";
            this.btn_runOnce.Size = new System.Drawing.Size(115, 32);
            this.btn_runOnce.Style = Sunny.UI.UIStyle.Custom;
            this.btn_runOnce.TabIndex = 4;
            this.btn_runOnce.Text = "执行一次";
            this.btn_runOnce.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_runOnce.Click += new System.EventHandler(this.btn_runOnce_Click);
            // 
            // Frm_PunchPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1114, 720);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.titleBar);
            this.Name = "Frm_PunchPress";
            this.Text = "冲压设备检测系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPunchPress_FormClosing);
            this.Load += new System.EventHandler(this.FrmPunchPress_Load);
            this.panelContainer.ResumeLayout(false);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup3.ResumeLayout(false);
            this.uiCheckBoxGroup2.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tim_getState;
        private System.Windows.Forms.Panel panelContainer;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup3;
        private Sunny.UI.UIButton btn_templateLearn;
        private Sunny.UI.UIButton btn_brightnessChange;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup2;
        private Sunny.UI.UIButton btn_disCentral;
        private Sunny.UI.UIButton btn_disTemplate;
        private System.Windows.Forms.Label lb_plcStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_cameraStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UIButton btnClose;
        private System.Windows.Forms.Panel titleBar;
        private Sunny.UI.UIButton btn_set;
        private Sunny.UI.UIButton btn_runOnce;
    }
}

