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
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.lb_title = new Sunny.UI.UILabel();
            this.gBox_baseOpeator = new Sunny.UI.UIGroupBox();
            this.btn_brightness = new Sunny.UI.UIButton();
            this.btn_templateLearn = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.gBox_systemStatus = new Sunny.UI.UIGroupBox();
            this.btn_disTemplate = new Sunny.UI.UIButton();
            this.btn_disCentral = new Sunny.UI.UIButton();
            this.lb_plcStatus = new Sunny.UI.UILabel();
            this.lb_cameraStatus = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.gBox_baseOpeator.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.gBox_systemStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmRenderControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(12, 12);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(427, 663);
            this.vmRenderControl1.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_title.Location = new System.Drawing.Point(611, 49);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(136, 23);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "冲床检测系统";
            // 
            // gBox_baseOpeator
            // 
            this.gBox_baseOpeator.Controls.Add(this.btn_brightness);
            this.gBox_baseOpeator.Controls.Add(this.btn_templateLearn);
            this.gBox_baseOpeator.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBox_baseOpeator.Location = new System.Drawing.Point(517, 90);
            this.gBox_baseOpeator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_baseOpeator.MinimumSize = new System.Drawing.Size(1, 1);
            this.gBox_baseOpeator.Name = "gBox_baseOpeator";
            this.gBox_baseOpeator.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gBox_baseOpeator.Size = new System.Drawing.Size(348, 167);
            this.gBox_baseOpeator.TabIndex = 7;
            this.gBox_baseOpeator.Text = "uiGroupBox1";
            this.gBox_baseOpeator.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_brightness
            // 
            this.btn_brightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brightness.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_brightness.Location = new System.Drawing.Point(214, 72);
            this.btn_brightness.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_brightness.Name = "btn_brightness";
            this.btn_brightness.Size = new System.Drawing.Size(100, 35);
            this.btn_brightness.TabIndex = 1;
            this.btn_brightness.Text = "亮度修改";
            this.btn_brightness.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_brightness.Click += new System.EventHandler(this.btn_brightness_Click);
            // 
            // btn_templateLearn
            // 
            this.btn_templateLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_templateLearn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_templateLearn.Location = new System.Drawing.Point(24, 72);
            this.btn_templateLearn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_templateLearn.Name = "btn_templateLearn";
            this.btn_templateLearn.Size = new System.Drawing.Size(100, 35);
            this.btn_templateLearn.TabIndex = 1;
            this.btn_templateLearn.Text = "模板学习";
            this.btn_templateLearn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_templateLearn.Click += new System.EventHandler(this.btn_templateLearn_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiRichTextBox1);
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(517, 301);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(348, 201);
            this.uiGroupBox1.TabIndex = 8;
            this.uiGroupBox1.Text = "uiGroupBox1";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRichTextBox1.Location = new System.Drawing.Point(17, 37);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(297, 142);
            this.uiRichTextBox1.TabIndex = 0;
            this.uiRichTextBox1.Text = "uiRichTextBox1";
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBox_systemStatus
            // 
            this.gBox_systemStatus.Controls.Add(this.btn_disTemplate);
            this.gBox_systemStatus.Controls.Add(this.btn_disCentral);
            this.gBox_systemStatus.Controls.Add(this.lb_plcStatus);
            this.gBox_systemStatus.Controls.Add(this.lb_cameraStatus);
            this.gBox_systemStatus.Controls.Add(this.uiLabel2);
            this.gBox_systemStatus.Controls.Add(this.uiLabel1);
            this.gBox_systemStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBox_systemStatus.Location = new System.Drawing.Point(517, 512);
            this.gBox_systemStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_systemStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.gBox_systemStatus.Name = "gBox_systemStatus";
            this.gBox_systemStatus.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gBox_systemStatus.Size = new System.Drawing.Size(348, 163);
            this.gBox_systemStatus.TabIndex = 9;
            this.gBox_systemStatus.Text = "系统信息";
            this.gBox_systemStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_disTemplate
            // 
            this.btn_disTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disTemplate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disTemplate.Location = new System.Drawing.Point(218, 62);
            this.btn_disTemplate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_disTemplate.Name = "btn_disTemplate";
            this.btn_disTemplate.Size = new System.Drawing.Size(87, 23);
            this.btn_disTemplate.TabIndex = 1;
            this.btn_disTemplate.Text = "显示模板";
            this.btn_disTemplate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disTemplate.Click += new System.EventHandler(this.btn_brightness_Click);
            // 
            // btn_disCentral
            // 
            this.btn_disCentral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disCentral.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disCentral.Location = new System.Drawing.Point(218, 110);
            this.btn_disCentral.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_disCentral.Name = "btn_disCentral";
            this.btn_disCentral.Size = new System.Drawing.Size(87, 23);
            this.btn_disCentral.TabIndex = 1;
            this.btn_disCentral.Text = "显示中心";
            this.btn_disCentral.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disCentral.Click += new System.EventHandler(this.btn_brightness_Click);
            // 
            // lb_plcStatus
            // 
            this.lb_plcStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_plcStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_plcStatus.Location = new System.Drawing.Point(120, 110);
            this.lb_plcStatus.Name = "lb_plcStatus";
            this.lb_plcStatus.Size = new System.Drawing.Size(72, 23);
            this.lb_plcStatus.TabIndex = 10;
            this.lb_plcStatus.Text = "正常";
            this.lb_plcStatus.Click += new System.EventHandler(this.uiLabel4_Click);
            // 
            // lb_cameraStatus
            // 
            this.lb_cameraStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_cameraStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_cameraStatus.Location = new System.Drawing.Point(120, 62);
            this.lb_cameraStatus.Name = "lb_cameraStatus";
            this.lb_cameraStatus.Size = new System.Drawing.Size(72, 23);
            this.lb_cameraStatus.TabIndex = 9;
            this.lb_cameraStatus.Text = "正常";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(14, 110);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(88, 23);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "PLC状态";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(14, 62);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(88, 23);
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "相机状态";
            // 
            // Frm_PunchPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(998, 720);
            this.Controls.Add(this.gBox_systemStatus);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.gBox_baseOpeator);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.vmRenderControl1);
            this.Name = "Frm_PunchPress";
            this.Text = "u";
            this.Load += new System.EventHandler(this.FrmPunchPress_Load);
            this.gBox_baseOpeator.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.gBox_systemStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private Sunny.UI.UILabel lb_title;
        private Sunny.UI.UIGroupBox gBox_baseOpeator;
        private Sunny.UI.UIButton btn_brightness;
        private Sunny.UI.UIButton btn_templateLearn;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UIGroupBox gBox_systemStatus;
        private Sunny.UI.UIButton btn_disCentral;
        private Sunny.UI.UILabel lb_plcStatus;
        private Sunny.UI.UILabel lb_cameraStatus;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btn_disTemplate;
    }
}

