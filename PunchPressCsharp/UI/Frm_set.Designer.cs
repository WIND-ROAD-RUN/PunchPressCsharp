namespace PunchPressCsharp.UI
{
    partial class Frm_set
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
            this.titleBar = new System.Windows.Forms.Panel();
            this.btn_close = new Sunny.UI.UIButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lb_gainValue = new Sunny.UI.UILabel();
            this.lb_exposureValue = new Sunny.UI.UILabel();
            this.btn_gainIncrease = new Sunny.UI.UIButton();
            this.btn_gainReduce = new Sunny.UI.UIButton();
            this.btn_exposureIncrease = new Sunny.UI.UIButton();
            this.btn_exposureReduce = new Sunny.UI.UIButton();
            this.titleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.titleBar.Size = new System.Drawing.Size(1267, 40);
            this.titleBar.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FillHoverColor = System.Drawing.Color.Red;
            this.btn_close.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_close.Location = new System.Drawing.Point(1227, 0);
            this.btn_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.Style = Sunny.UI.UIStyle.Custom;
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "设置";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelContainer.Controls.Add(this.uiLabel4);
            this.panelContainer.Controls.Add(this.uiLabel1);
            this.panelContainer.Controls.Add(this.lb_gainValue);
            this.panelContainer.Controls.Add(this.lb_exposureValue);
            this.panelContainer.Controls.Add(this.btn_gainIncrease);
            this.panelContainer.Controls.Add(this.btn_gainReduce);
            this.panelContainer.Controls.Add(this.btn_exposureIncrease);
            this.panelContainer.Controls.Add(this.btn_exposureReduce);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1267, 669);
            this.panelContainer.TabIndex = 12;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(39, 190);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(147, 54);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "增益设置";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(39, 88);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(147, 54);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "曝光设置";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_gainValue
            // 
            this.lb_gainValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lb_gainValue.ForeColor = System.Drawing.Color.White;
            this.lb_gainValue.Location = new System.Drawing.Point(282, 190);
            this.lb_gainValue.Name = "lb_gainValue";
            this.lb_gainValue.Size = new System.Drawing.Size(150, 54);
            this.lb_gainValue.Style = Sunny.UI.UIStyle.Custom;
            this.lb_gainValue.TabIndex = 4;
            this.lb_gainValue.Text = "10";
            this.lb_gainValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_exposureValue
            // 
            this.lb_exposureValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lb_exposureValue.ForeColor = System.Drawing.Color.White;
            this.lb_exposureValue.Location = new System.Drawing.Point(282, 88);
            this.lb_exposureValue.Name = "lb_exposureValue";
            this.lb_exposureValue.Size = new System.Drawing.Size(150, 54);
            this.lb_exposureValue.Style = Sunny.UI.UIStyle.Custom;
            this.lb_exposureValue.TabIndex = 4;
            this.lb_exposureValue.Text = "10000";
            this.lb_exposureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_gainIncrease
            // 
            this.btn_gainIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gainIncrease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gainIncrease.Location = new System.Drawing.Point(438, 190);
            this.btn_gainIncrease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_gainIncrease.Name = "btn_gainIncrease";
            this.btn_gainIncrease.Size = new System.Drawing.Size(100, 54);
            this.btn_gainIncrease.TabIndex = 1;
            this.btn_gainIncrease.Text = "+";
            this.btn_gainIncrease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_gainReduce
            // 
            this.btn_gainReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gainReduce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gainReduce.Location = new System.Drawing.Point(212, 190);
            this.btn_gainReduce.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_gainReduce.Name = "btn_gainReduce";
            this.btn_gainReduce.Size = new System.Drawing.Size(64, 54);
            this.btn_gainReduce.TabIndex = 0;
            this.btn_gainReduce.Text = "-";
            this.btn_gainReduce.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_exposureIncrease
            // 
            this.btn_exposureIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exposureIncrease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureIncrease.Location = new System.Drawing.Point(438, 88);
            this.btn_exposureIncrease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exposureIncrease.Name = "btn_exposureIncrease";
            this.btn_exposureIncrease.Size = new System.Drawing.Size(100, 54);
            this.btn_exposureIncrease.TabIndex = 1;
            this.btn_exposureIncrease.Text = "+";
            this.btn_exposureIncrease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureIncrease.Click += new System.EventHandler(this.btn_exposureIncrease_Click);
            // 
            // btn_exposureReduce
            // 
            this.btn_exposureReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exposureReduce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureReduce.Location = new System.Drawing.Point(212, 88);
            this.btn_exposureReduce.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exposureReduce.Name = "btn_exposureReduce";
            this.btn_exposureReduce.Size = new System.Drawing.Size(64, 54);
            this.btn_exposureReduce.TabIndex = 0;
            this.btn_exposureReduce.Text = "-";
            this.btn_exposureReduce.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureReduce.Click += new System.EventHandler(this.btn_exposureReduce_Click);
            // 
            // Frm_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 709);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.titleBar);
            this.Name = "Frm_set";
            this.Load += new System.EventHandler(this.Frm_set_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private Sunny.UI.UIButton btn_close;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContainer;
        private Sunny.UI.UIButton btn_exposureIncrease;
        private Sunny.UI.UIButton btn_exposureReduce;
        private Sunny.UI.UILabel lb_exposureValue;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lb_gainValue;
        private Sunny.UI.UIButton btn_gainIncrease;
        private Sunny.UI.UIButton btn_gainReduce;
    }
}