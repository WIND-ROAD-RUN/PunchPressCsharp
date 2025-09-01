namespace PunchPressCsharp
{
    partial class Frm_Learning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Learning));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.btn_close = new Sunny.UI.UIButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.btn_learning = new Sunny.UI.UIButton();
            this.vmParamsConfigControl1 = new VMControls.Winform.Release.VmParamsConfigControl();
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.tim_refresh = new System.Windows.Forms.Timer(this.components);
            this.titleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(17, 56);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(679, 40);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "视觉检测 - 模板学习";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar.Controls.Add(this.btn_close);
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1321, 40);
            this.titleBar.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FillHoverColor = System.Drawing.Color.Red;
            this.btn_close.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_close.Location = new System.Drawing.Point(1281, 0);
            this.btn_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.Style = Sunny.UI.UIStyle.Custom;
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "模板学习";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelContainer.Controls.Add(this.uiLabel1);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup1);
            this.panelContainer.Controls.Add(this.btn_learning);
            this.panelContainer.Controls.Add(this.vmParamsConfigControl1);
            this.panelContainer.Controls.Add(this.vmRenderControl1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1321, 1016);
            this.panelContainer.TabIndex = 3;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(703, 105);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(504, 35);
            this.uiCheckBoxGroup1.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup1.TabIndex = 4;
            this.uiCheckBoxGroup1.Text = "参数配置";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_learning
            // 
            this.btn_learning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_learning.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btn_learning.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.btn_learning.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_learning.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_learning.Location = new System.Drawing.Point(887, 56);
            this.btn_learning.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_learning.Name = "btn_learning";
            this.btn_learning.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btn_learning.Size = new System.Drawing.Size(126, 40);
            this.btn_learning.Style = Sunny.UI.UIStyle.Custom;
            this.btn_learning.TabIndex = 3;
            this.btn_learning.Text = "开始学习";
            this.btn_learning.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // vmParamsConfigControl1
            // 
            this.vmParamsConfigControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.vmParamsConfigControl1.Location = new System.Drawing.Point(703, 195);
            this.vmParamsConfigControl1.Margin = new System.Windows.Forms.Padding(5);
            this.vmParamsConfigControl1.ModuleSource = null;
            this.vmParamsConfigControl1.Name = "vmParamsConfigControl1";
            this.vmParamsConfigControl1.ParamsConfig = null;
            this.vmParamsConfigControl1.Size = new System.Drawing.Size(504, 646);
            this.vmParamsConfigControl1.TabIndex = 2;
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(14, 105);
            this.vmRenderControl1.Margin = new System.Windows.Forms.Padding(5);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(679, 736);
            this.vmRenderControl1.TabIndex = 1;
            // 
            // tim_refresh
            // 
            this.tim_refresh.Enabled = true;
            this.tim_refresh.Interval = 500;
            // 
            // Frm_Learning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 1016);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.panelContainer);
            this.Name = "Frm_Learning";
            this.Text = "Frm_Learning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Learning_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Learning_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Panel titleBar;
        private Sunny.UI.UIButton btn_close;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContainer;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UIButton btn_learning;
        private VMControls.Winform.Release.VmParamsConfigControl vmParamsConfigControl1;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private System.Windows.Forms.Timer tim_refresh;
    }
}