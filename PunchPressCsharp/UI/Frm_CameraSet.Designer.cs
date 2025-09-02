namespace PunchPressCsharp.UI
{
    partial class Frm_CameraSet
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
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.vmParamsConfigControl1 = new VMControls.Winform.Release.VmParamsConfigControl();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.panelContainer.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(17, 43);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(546, 557);
            this.vmRenderControl1.TabIndex = 3;
            // 
            // vmParamsConfigControl1
            // 
            this.vmParamsConfigControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.vmParamsConfigControl1.Location = new System.Drawing.Point(581, 43);
            this.vmParamsConfigControl1.ModuleSource = null;
            this.vmParamsConfigControl1.Name = "vmParamsConfigControl1";
            this.vmParamsConfigControl1.ParamsConfig = null;
            this.vmParamsConfigControl1.Size = new System.Drawing.Size(431, 557);
            this.vmParamsConfigControl1.TabIndex = 4;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.titleBar);
            this.panelContainer.Controls.Add(this.vmRenderControl1);
            this.panelContainer.Controls.Add(this.vmParamsConfigControl1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1025, 618);
            this.panelContainer.TabIndex = 6;
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
            this.titleBar.Size = new System.Drawing.Size(1025, 33);
            this.titleBar.TabIndex = 5;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(11, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "相机亮度设置";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillHoverColor = System.Drawing.Color.Red;
            this.btnClose.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.btnClose.Location = new System.Drawing.Point(984, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.Size = new System.Drawing.Size(41, 33);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_CameraSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 618);
            this.Controls.Add(this.panelContainer);
            this.Name = "Frm_CameraSet";
            this.Text = "Frm_CameraSet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_SetCamera_FormClosing);
            this.Load += new System.EventHandler(this.Frm_SetCamera_Load);
            this.panelContainer.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private VMControls.Winform.Release.VmParamsConfigControl vmParamsConfigControl1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UIButton btnClose;
    }
}