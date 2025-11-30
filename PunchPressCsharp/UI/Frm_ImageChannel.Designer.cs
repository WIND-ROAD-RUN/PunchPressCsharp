namespace PunchPressCsharp.UI
{
    partial class Frm_ImageChannel
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.vmParamsConfigWithRenderControl1 = new VMControls.Winform.Release.VmParamsConfigWithRenderControl();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.modernTabControl1 = new PunchPressCsharp.Controls.ModernTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vmParamsConfigWithRenderControl2 = new VMControls.Winform.Release.VmParamsConfigWithRenderControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vmParamsConfigWithRenderControl3 = new VMControls.Winform.Release.VmParamsConfigWithRenderControl();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.modernTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelContainer.Controls.Add(this.modernTabControl1);
            this.panelContainer.Controls.Add(this.pic_Close);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.Color.Black;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1139, 779);
            this.panelContainer.TabIndex = 4;
            // 
            // vmParamsConfigWithRenderControl1
            // 
            this.vmParamsConfigWithRenderControl1.BackColor = System.Drawing.Color.White;
            this.vmParamsConfigWithRenderControl1.CoordinateInfoVisible = true;
            this.vmParamsConfigWithRenderControl1.ImageSource = null;
            this.vmParamsConfigWithRenderControl1.Location = new System.Drawing.Point(6, 3);
            this.vmParamsConfigWithRenderControl1.ModuleSource = null;
            this.vmParamsConfigWithRenderControl1.MultiImageButtonVisible = false;
            this.vmParamsConfigWithRenderControl1.Name = "vmParamsConfigWithRenderControl1";
            this.vmParamsConfigWithRenderControl1.ParamsConfig = null;
            this.vmParamsConfigWithRenderControl1.ROIVisible = true;
            this.vmParamsConfigWithRenderControl1.Size = new System.Drawing.Size(1119, 667);
            this.vmParamsConfigWithRenderControl1.TabIndex = 6;
            // 
            // pic_Close
            // 
            this.pic_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Close.Image = global::PunchPressCsharp.Properties.Resources.x;
            this.pic_Close.Location = new System.Drawing.Point(1078, 4);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(49, 49);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Close.TabIndex = 14;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            // 
            // modernTabControl1
            // 
            this.modernTabControl1.Controls.Add(this.tabPage1);
            this.modernTabControl1.Controls.Add(this.tabPage2);
            this.modernTabControl1.Controls.Add(this.tabPage3);
            this.modernTabControl1.CornerRadius = 4;
            this.modernTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.modernTabControl1.HeaderBackColor = System.Drawing.Color.White;
            this.modernTabControl1.HeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.modernTabControl1.ItemSize = new System.Drawing.Size(120, 36);
            this.modernTabControl1.Location = new System.Drawing.Point(3, 59);
            this.modernTabControl1.Name = "modernTabControl1";
            this.modernTabControl1.Padding = new System.Drawing.Point(14, 6);
            this.modernTabControl1.SelectedIndex = 0;
            this.modernTabControl1.Size = new System.Drawing.Size(1136, 717);
            this.modernTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.modernTabControl1.TabBackColor = System.Drawing.Color.White;
            this.modernTabControl1.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.modernTabControl1.TabHeaderHeight = 36;
            this.modernTabControl1.TabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.modernTabControl1.TabIndex = 15;
            this.modernTabControl1.TabSelectedBackColor = System.Drawing.Color.White;
            this.modernTabControl1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.modernTabControl1.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.modernTabControl1.TabSpacing = 6;
            this.modernTabControl1.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.modernTabControl1.UnderlineHeight = 2;
            this.modernTabControl1.UnderlineSelected = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.vmParamsConfigWithRenderControl1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1128, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "颜色通道选择";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.vmParamsConfigWithRenderControl2);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图像增强";
            // 
            // vmParamsConfigWithRenderControl2
            // 
            this.vmParamsConfigWithRenderControl2.BackColor = System.Drawing.Color.White;
            this.vmParamsConfigWithRenderControl2.CoordinateInfoVisible = true;
            this.vmParamsConfigWithRenderControl2.ImageSource = null;
            this.vmParamsConfigWithRenderControl2.Location = new System.Drawing.Point(5, 3);
            this.vmParamsConfigWithRenderControl2.ModuleSource = null;
            this.vmParamsConfigWithRenderControl2.MultiImageButtonVisible = false;
            this.vmParamsConfigWithRenderControl2.Name = "vmParamsConfigWithRenderControl2";
            this.vmParamsConfigWithRenderControl2.ParamsConfig = null;
            this.vmParamsConfigWithRenderControl2.ROIVisible = true;
            this.vmParamsConfigWithRenderControl2.Size = new System.Drawing.Size(1119, 667);
            this.vmParamsConfigWithRenderControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.vmParamsConfigWithRenderControl3);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1128, 673);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图像滤波";
            // 
            // vmParamsConfigWithRenderControl3
            // 
            this.vmParamsConfigWithRenderControl3.BackColor = System.Drawing.Color.White;
            this.vmParamsConfigWithRenderControl3.CoordinateInfoVisible = true;
            this.vmParamsConfigWithRenderControl3.ImageSource = null;
            this.vmParamsConfigWithRenderControl3.Location = new System.Drawing.Point(5, 3);
            this.vmParamsConfigWithRenderControl3.ModuleSource = null;
            this.vmParamsConfigWithRenderControl3.MultiImageButtonVisible = false;
            this.vmParamsConfigWithRenderControl3.Name = "vmParamsConfigWithRenderControl3";
            this.vmParamsConfigWithRenderControl3.ParamsConfig = null;
            this.vmParamsConfigWithRenderControl3.ROIVisible = true;
            this.vmParamsConfigWithRenderControl3.Size = new System.Drawing.Size(1119, 667);
            this.vmParamsConfigWithRenderControl3.TabIndex = 7;
            // 
            // Frm_ImageChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 779);
            this.Controls.Add(this.panelContainer);
            this.Name = "Frm_ImageChannel";
            this.Text = "Frm_ImageChannel";
            this.Load += new System.EventHandler(this.Frm_ImageChannel_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.modernTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pic_Close;
        private VMControls.Winform.Release.VmParamsConfigWithRenderControl vmParamsConfigWithRenderControl1;
        private Controls.ModernTabControl modernTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private VMControls.Winform.Release.VmParamsConfigWithRenderControl vmParamsConfigWithRenderControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private VMControls.Winform.Release.VmParamsConfigWithRenderControl vmParamsConfigWithRenderControl3;
    }
}