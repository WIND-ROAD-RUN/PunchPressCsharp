namespace PunchPressCsharp
{
    partial class FrmPunchPress
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
            this.lb_title = new System.Windows.Forms.Label();
            this.gBox_baseOpeator = new System.Windows.Forms.GroupBox();
            this.btn_brightness = new System.Windows.Forms.Button();
            this.btn_templateLearn = new System.Windows.Forms.Button();
            this.gBox_info = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gBox_systemStatus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cameraStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_plcStatus = new System.Windows.Forms.Label();
            this.btn_disTemplate = new System.Windows.Forms.Button();
            this.btn_displayCentral = new System.Windows.Forms.Button();
            this.gBox_baseOpeator.SuspendLayout();
            this.gBox_info.SuspendLayout();
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
            this.vmRenderControl1.Size = new System.Drawing.Size(414, 599);
            this.vmRenderControl1.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(690, 53);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(77, 12);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "冲床检测系统";
            // 
            // gBox_baseOpeator
            // 
            this.gBox_baseOpeator.Controls.Add(this.btn_brightness);
            this.gBox_baseOpeator.Controls.Add(this.btn_templateLearn);
            this.gBox_baseOpeator.Location = new System.Drawing.Point(557, 96);
            this.gBox_baseOpeator.Name = "gBox_baseOpeator";
            this.gBox_baseOpeator.Size = new System.Drawing.Size(356, 102);
            this.gBox_baseOpeator.TabIndex = 3;
            this.gBox_baseOpeator.TabStop = false;
            this.gBox_baseOpeator.Text = "基本操作";
            // 
            // btn_brightness
            // 
            this.btn_brightness.Location = new System.Drawing.Point(262, 45);
            this.btn_brightness.Name = "btn_brightness";
            this.btn_brightness.Size = new System.Drawing.Size(75, 23);
            this.btn_brightness.TabIndex = 0;
            this.btn_brightness.Text = "亮度修改";
            this.btn_brightness.UseVisualStyleBackColor = true;
            // 
            // btn_templateLearn
            // 
            this.btn_templateLearn.Location = new System.Drawing.Point(44, 45);
            this.btn_templateLearn.Name = "btn_templateLearn";
            this.btn_templateLearn.Size = new System.Drawing.Size(75, 23);
            this.btn_templateLearn.TabIndex = 0;
            this.btn_templateLearn.Text = "模板学习";
            this.btn_templateLearn.UseVisualStyleBackColor = true;
            // 
            // gBox_info
            // 
            this.gBox_info.Controls.Add(this.richTextBox1);
            this.gBox_info.Location = new System.Drawing.Point(557, 236);
            this.gBox_info.Name = "gBox_info";
            this.gBox_info.Size = new System.Drawing.Size(356, 238);
            this.gBox_info.TabIndex = 4;
            this.gBox_info.TabStop = false;
            this.gBox_info.Text = "信息日志";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 186);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // gBox_systemStatus
            // 
            this.gBox_systemStatus.Controls.Add(this.btn_displayCentral);
            this.gBox_systemStatus.Controls.Add(this.btn_disTemplate);
            this.gBox_systemStatus.Controls.Add(this.lb_plcStatus);
            this.gBox_systemStatus.Controls.Add(this.label3);
            this.gBox_systemStatus.Controls.Add(this.lb_cameraStatus);
            this.gBox_systemStatus.Controls.Add(this.label1);
            this.gBox_systemStatus.Location = new System.Drawing.Point(557, 511);
            this.gBox_systemStatus.Name = "gBox_systemStatus";
            this.gBox_systemStatus.Size = new System.Drawing.Size(356, 100);
            this.gBox_systemStatus.TabIndex = 5;
            this.gBox_systemStatus.TabStop = false;
            this.gBox_systemStatus.Text = "系统状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "相机状态";
            // 
            // lb_cameraStatus
            // 
            this.lb_cameraStatus.AutoSize = true;
            this.lb_cameraStatus.Location = new System.Drawing.Point(103, 40);
            this.lb_cameraStatus.Name = "lb_cameraStatus";
            this.lb_cameraStatus.Size = new System.Drawing.Size(29, 12);
            this.lb_cameraStatus.TabIndex = 3;
            this.lb_cameraStatus.Text = "正常";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLC状态";
            // 
            // lb_plcStatus
            // 
            this.lb_plcStatus.AutoSize = true;
            this.lb_plcStatus.Location = new System.Drawing.Point(103, 71);
            this.lb_plcStatus.Name = "lb_plcStatus";
            this.lb_plcStatus.Size = new System.Drawing.Size(29, 12);
            this.lb_plcStatus.TabIndex = 5;
            this.lb_plcStatus.Text = "正常";
            // 
            // btn_disTemplate
            // 
            this.btn_disTemplate.Location = new System.Drawing.Point(262, 35);
            this.btn_disTemplate.Name = "btn_disTemplate";
            this.btn_disTemplate.Size = new System.Drawing.Size(75, 23);
            this.btn_disTemplate.TabIndex = 0;
            this.btn_disTemplate.Text = "显示模板";
            this.btn_disTemplate.UseVisualStyleBackColor = true;
            // 
            // btn_displayCentral
            // 
            this.btn_displayCentral.Location = new System.Drawing.Point(262, 71);
            this.btn_displayCentral.Name = "btn_displayCentral";
            this.btn_displayCentral.Size = new System.Drawing.Size(75, 23);
            this.btn_displayCentral.TabIndex = 6;
            this.btn_displayCentral.Text = "显示中心";
            this.btn_displayCentral.UseVisualStyleBackColor = true;
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(998, 720);
            this.Controls.Add(this.gBox_systemStatus);
            this.Controls.Add(this.gBox_info);
            this.Controls.Add(this.gBox_baseOpeator);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.vmRenderControl1);
            this.Name = "FrmMainWindow";
            this.Text = "u";
            this.gBox_baseOpeator.ResumeLayout(false);
            this.gBox_info.ResumeLayout(false);
            this.gBox_systemStatus.ResumeLayout(false);
            this.gBox_systemStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.GroupBox gBox_baseOpeator;
        private System.Windows.Forms.Button btn_brightness;
        private System.Windows.Forms.Button btn_templateLearn;
        private System.Windows.Forms.GroupBox gBox_info;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox gBox_systemStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_cameraStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_displayCentral;
        private System.Windows.Forms.Button btn_disTemplate;
        private System.Windows.Forms.Label lb_plcStatus;
    }
}

