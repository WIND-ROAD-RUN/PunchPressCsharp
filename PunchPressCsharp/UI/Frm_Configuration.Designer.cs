namespace PunchPressCsharp.UI
{
    partial class Frm_Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Configuration));
            this.titleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupGain = new Sunny.UI.UICheckBoxGroup();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txt_GainMax = new Sunny.UI.UITextBox();
            this.txt_GainMin = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.groupExposure = new Sunny.UI.UICheckBoxGroup();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txt_ExplorMax = new Sunny.UI.UITextBox();
            this.txt_ExplorMin = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupAngle = new Sunny.UI.UICheckBoxGroup();
            this.txt_OffsetAngleMax = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txt_OffsetAngleMin = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.groupCenterY = new Sunny.UI.UICheckBoxGroup();
            this.txt_OffsetYMax = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txt_OffsetYMin = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.groupCenterX = new Sunny.UI.UICheckBoxGroup();
            this.txt_OffsetXMax = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txt_OffsetXMin = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.btnSave = new Sunny.UI.UIButton();
            this.uiTextBox10 = new Sunny.UI.UITextBox();
            this.uiTextBox9 = new Sunny.UI.UITextBox();
            this.uiTextBox8 = new Sunny.UI.UITextBox();
            this.uiTextBox7 = new Sunny.UI.UITextBox();
            this.uiTextBox6 = new Sunny.UI.UITextBox();
            this.uiTextBox5 = new Sunny.UI.UITextBox();
            this.btn_exit = new Sunny.UI.UIButton();
            this.titleBar.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupGain.SuspendLayout();
            this.groupExposure.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupAngle.SuspendLayout();
            this.groupCenterY.SuspendLayout();
            this.groupCenterX.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(647, 40);
            this.titleBar.TabIndex = 27;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "系统参数配置";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(602, 0);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 45);
            this.uiTabControl1.Location = new System.Drawing.Point(2, 46);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(642, 501);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 29;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupGain);
            this.tabPage1.Controls.Add(this.groupExposure);
            this.tabPage1.Location = new System.Drawing.Point(0, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(642, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "光源亮度设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupGain
            // 
            this.groupGain.Controls.Add(this.uiLabel1);
            this.groupGain.Controls.Add(this.txt_GainMax);
            this.groupGain.Controls.Add(this.txt_GainMin);
            this.groupGain.Controls.Add(this.uiLabel4);
            this.groupGain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupGain.Location = new System.Drawing.Point(1, 243);
            this.groupGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupGain.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupGain.Name = "groupGain";
            this.groupGain.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupGain.Radius = 15;
            this.groupGain.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupGain.SelectedIndexes")));
            this.groupGain.Size = new System.Drawing.Size(644, 155);
            this.groupGain.TabIndex = 6;
            this.groupGain.Text = "增益设置";
            this.groupGain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(183, 53);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "最小值:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_GainMax
            // 
            this.txt_GainMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GainMax.DoubleValue = 1000D;
            this.txt_GainMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_GainMax.IntValue = 1000;
            this.txt_GainMax.Location = new System.Drawing.Point(293, 93);
            this.txt_GainMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GainMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_GainMax.Name = "txt_GainMax";
            this.txt_GainMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_GainMax.ShowText = false;
            this.txt_GainMax.Size = new System.Drawing.Size(160, 35);
            this.txt_GainMax.TabIndex = 4;
            this.txt_GainMax.Text = "1000";
            this.txt_GainMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_GainMax.Watermark = "";
            // 
            // txt_GainMin
            // 
            this.txt_GainMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GainMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_GainMin.Location = new System.Drawing.Point(293, 48);
            this.txt_GainMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GainMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_GainMin.Name = "txt_GainMin";
            this.txt_GainMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_GainMin.ShowText = false;
            this.txt_GainMin.Size = new System.Drawing.Size(160, 35);
            this.txt_GainMin.TabIndex = 2;
            this.txt_GainMin.Text = "0";
            this.txt_GainMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_GainMin.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(183, 99);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "最大值:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupExposure
            // 
            this.groupExposure.Controls.Add(this.uiLabel2);
            this.groupExposure.Controls.Add(this.txt_ExplorMax);
            this.groupExposure.Controls.Add(this.txt_ExplorMin);
            this.groupExposure.Controls.Add(this.uiLabel3);
            this.groupExposure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupExposure.Location = new System.Drawing.Point(-2, 47);
            this.groupExposure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupExposure.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupExposure.Name = "groupExposure";
            this.groupExposure.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupExposure.Radius = 15;
            this.groupExposure.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupExposure.SelectedIndexes")));
            this.groupExposure.Size = new System.Drawing.Size(644, 155);
            this.groupExposure.TabIndex = 5;
            this.groupExposure.Text = "曝光设置";
            this.groupExposure.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.groupExposure.ValueChanged += new Sunny.UI.UICheckBoxGroup.OnValueChanged(this.uiCheckBoxGroup1_ValueChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(183, 53);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "最小值:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ExplorMax
            // 
            this.txt_ExplorMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ExplorMax.DoubleValue = 1000D;
            this.txt_ExplorMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ExplorMax.IntValue = 1000;
            this.txt_ExplorMax.Location = new System.Drawing.Point(293, 93);
            this.txt_ExplorMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ExplorMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_ExplorMax.Name = "txt_ExplorMax";
            this.txt_ExplorMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ExplorMax.ShowText = false;
            this.txt_ExplorMax.Size = new System.Drawing.Size(160, 35);
            this.txt_ExplorMax.TabIndex = 4;
            this.txt_ExplorMax.Text = "1000";
            this.txt_ExplorMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_ExplorMax.Watermark = "";
            // 
            // txt_ExplorMin
            // 
            this.txt_ExplorMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ExplorMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ExplorMin.Location = new System.Drawing.Point(293, 48);
            this.txt_ExplorMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ExplorMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_ExplorMin.Name = "txt_ExplorMin";
            this.txt_ExplorMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ExplorMin.ShowText = false;
            this.txt_ExplorMin.Size = new System.Drawing.Size(160, 35);
            this.txt_ExplorMin.TabIndex = 2;
            this.txt_ExplorMin.Text = "0";
            this.txt_ExplorMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_ExplorMin.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(183, 99);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "最大值:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel3.Click += new System.EventHandler(this.uiLabel3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupAngle);
            this.tabPage2.Controls.Add(this.groupCenterY);
            this.tabPage2.Controls.Add(this.groupCenterX);
            this.tabPage2.Location = new System.Drawing.Point(0, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(642, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "偏移量设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupAngle
            // 
            this.groupAngle.Controls.Add(this.txt_OffsetAngleMax);
            this.groupAngle.Controls.Add(this.uiLabel9);
            this.groupAngle.Controls.Add(this.txt_OffsetAngleMin);
            this.groupAngle.Controls.Add(this.uiLabel10);
            this.groupAngle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupAngle.Location = new System.Drawing.Point(15, 297);
            this.groupAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupAngle.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupAngle.Name = "groupAngle";
            this.groupAngle.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupAngle.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupAngle.SelectedIndexes")));
            this.groupAngle.Size = new System.Drawing.Size(616, 128);
            this.groupAngle.TabIndex = 7;
            this.groupAngle.Text = "角度矫正";
            this.groupAngle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_OffsetAngleMax
            // 
            this.txt_OffsetAngleMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OffsetAngleMax.DoubleValue = 360D;
            this.txt_OffsetAngleMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OffsetAngleMax.IntValue = 360;
            this.txt_OffsetAngleMax.Location = new System.Drawing.Point(302, 80);
            this.txt_OffsetAngleMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OffsetAngleMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_OffsetAngleMax.Name = "txt_OffsetAngleMax";
            this.txt_OffsetAngleMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_OffsetAngleMax.ShowText = false;
            this.txt_OffsetAngleMax.Size = new System.Drawing.Size(160, 30);
            this.txt_OffsetAngleMax.TabIndex = 4;
            this.txt_OffsetAngleMax.Text = "360";
            this.txt_OffsetAngleMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_OffsetAngleMax.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(182, 84);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(100, 23);
            this.uiLabel9.TabIndex = 4;
            this.uiLabel9.Text = "最大值:";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_OffsetAngleMin
            // 
            this.txt_OffsetAngleMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OffsetAngleMin.DoubleValue = -360D;
            this.txt_OffsetAngleMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OffsetAngleMin.IntValue = -360;
            this.txt_OffsetAngleMin.Location = new System.Drawing.Point(302, 38);
            this.txt_OffsetAngleMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OffsetAngleMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_OffsetAngleMin.Name = "txt_OffsetAngleMin";
            this.txt_OffsetAngleMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_OffsetAngleMin.ShowText = false;
            this.txt_OffsetAngleMin.Size = new System.Drawing.Size(160, 30);
            this.txt_OffsetAngleMin.TabIndex = 3;
            this.txt_OffsetAngleMin.Text = "-360";
            this.txt_OffsetAngleMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_OffsetAngleMin.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(185, 42);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 23);
            this.uiLabel10.TabIndex = 2;
            this.uiLabel10.Text = "最小值:";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupCenterY
            // 
            this.groupCenterY.Controls.Add(this.txt_OffsetYMax);
            this.groupCenterY.Controls.Add(this.uiLabel7);
            this.groupCenterY.Controls.Add(this.txt_OffsetYMin);
            this.groupCenterY.Controls.Add(this.uiLabel8);
            this.groupCenterY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupCenterY.Location = new System.Drawing.Point(15, 154);
            this.groupCenterY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupCenterY.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupCenterY.Name = "groupCenterY";
            this.groupCenterY.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupCenterY.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupCenterY.SelectedIndexes")));
            this.groupCenterY.Size = new System.Drawing.Size(616, 128);
            this.groupCenterY.TabIndex = 7;
            this.groupCenterY.Text = "中心矫正y";
            this.groupCenterY.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_OffsetYMax
            // 
            this.txt_OffsetYMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OffsetYMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OffsetYMax.Location = new System.Drawing.Point(302, 80);
            this.txt_OffsetYMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OffsetYMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_OffsetYMax.Name = "txt_OffsetYMax";
            this.txt_OffsetYMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_OffsetYMax.ShowText = false;
            this.txt_OffsetYMax.Size = new System.Drawing.Size(160, 30);
            this.txt_OffsetYMax.TabIndex = 4;
            this.txt_OffsetYMax.TagString = "200";
            this.txt_OffsetYMax.Text = "0";
            this.txt_OffsetYMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_OffsetYMax.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(182, 84);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(100, 23);
            this.uiLabel7.TabIndex = 4;
            this.uiLabel7.Text = "最大值:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_OffsetYMin
            // 
            this.txt_OffsetYMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OffsetYMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OffsetYMin.Location = new System.Drawing.Point(302, 38);
            this.txt_OffsetYMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OffsetYMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_OffsetYMin.Name = "txt_OffsetYMin";
            this.txt_OffsetYMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_OffsetYMin.ShowText = false;
            this.txt_OffsetYMin.Size = new System.Drawing.Size(160, 30);
            this.txt_OffsetYMin.TabIndex = 3;
            this.txt_OffsetYMin.Text = "0";
            this.txt_OffsetYMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_OffsetYMin.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(185, 42);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 23);
            this.uiLabel8.TabIndex = 2;
            this.uiLabel8.Text = "最小值:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupCenterX
            // 
            this.groupCenterX.Controls.Add(this.txt_OffsetXMax);
            this.groupCenterX.Controls.Add(this.uiLabel6);
            this.groupCenterX.Controls.Add(this.txt_OffsetXMin);
            this.groupCenterX.Controls.Add(this.uiLabel5);
            this.groupCenterX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupCenterX.Location = new System.Drawing.Point(15, 14);
            this.groupCenterX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupCenterX.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupCenterX.Name = "groupCenterX";
            this.groupCenterX.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupCenterX.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupCenterX.SelectedIndexes")));
            this.groupCenterX.Size = new System.Drawing.Size(616, 128);
            this.groupCenterX.TabIndex = 6;
            this.groupCenterX.Text = "中心矫正x";
            this.groupCenterX.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_OffsetXMax
            // 
            this.txt_OffsetXMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OffsetXMax.DoubleValue = 200D;
            this.txt_OffsetXMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OffsetXMax.IntValue = 200;
            this.txt_OffsetXMax.Location = new System.Drawing.Point(302, 80);
            this.txt_OffsetXMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OffsetXMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_OffsetXMax.Name = "txt_OffsetXMax";
            this.txt_OffsetXMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_OffsetXMax.ShowText = false;
            this.txt_OffsetXMax.Size = new System.Drawing.Size(160, 30);
            this.txt_OffsetXMax.TabIndex = 4;
            this.txt_OffsetXMax.Text = "200";
            this.txt_OffsetXMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_OffsetXMax.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(182, 84);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 4;
            this.uiLabel6.Text = "最大值:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_OffsetXMin
            // 
            this.txt_OffsetXMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OffsetXMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OffsetXMin.Location = new System.Drawing.Point(302, 38);
            this.txt_OffsetXMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OffsetXMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_OffsetXMin.Name = "txt_OffsetXMin";
            this.txt_OffsetXMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_OffsetXMin.ShowText = false;
            this.txt_OffsetXMin.Size = new System.Drawing.Size(160, 30);
            this.txt_OffsetXMin.TabIndex = 3;
            this.txt_OffsetXMin.Text = "0";
            this.txt_OffsetXMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_OffsetXMin.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(185, 42);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 2;
            this.uiLabel5.Text = "最小值:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(500, 559);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 44);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "保存配置";
            this.btnSave.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiTextBox10
            // 
            this.uiTextBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox10.Location = new System.Drawing.Point(133, 37);
            this.uiTextBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox10.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox10.Name = "uiTextBox10";
            this.uiTextBox10.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox10.ShowText = false;
            this.uiTextBox10.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox10.TabIndex = 2;
            this.uiTextBox10.Text = "uiTextBox10";
            this.uiTextBox10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox10.Watermark = "";
            // 
            // uiTextBox9
            // 
            this.uiTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox9.Location = new System.Drawing.Point(133, 76);
            this.uiTextBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox9.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox9.Name = "uiTextBox9";
            this.uiTextBox9.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox9.ShowText = false;
            this.uiTextBox9.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox9.TabIndex = 4;
            this.uiTextBox9.Text = "uiTextBox9";
            this.uiTextBox9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox9.Watermark = "";
            // 
            // uiTextBox8
            // 
            this.uiTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox8.Location = new System.Drawing.Point(133, 37);
            this.uiTextBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox8.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox8.Name = "uiTextBox8";
            this.uiTextBox8.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox8.ShowText = false;
            this.uiTextBox8.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox8.TabIndex = 2;
            this.uiTextBox8.Text = "uiTextBox8";
            this.uiTextBox8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox8.Watermark = "";
            // 
            // uiTextBox7
            // 
            this.uiTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox7.Location = new System.Drawing.Point(133, 76);
            this.uiTextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox7.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox7.Name = "uiTextBox7";
            this.uiTextBox7.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox7.ShowText = false;
            this.uiTextBox7.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox7.TabIndex = 4;
            this.uiTextBox7.Text = "uiTextBox7";
            this.uiTextBox7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox7.Watermark = "";
            // 
            // uiTextBox6
            // 
            this.uiTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox6.Location = new System.Drawing.Point(133, 37);
            this.uiTextBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox6.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox6.Name = "uiTextBox6";
            this.uiTextBox6.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox6.ShowText = false;
            this.uiTextBox6.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox6.TabIndex = 2;
            this.uiTextBox6.Text = "uiTextBox6";
            this.uiTextBox6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox6.Watermark = "";
            // 
            // uiTextBox5
            // 
            this.uiTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox5.Location = new System.Drawing.Point(133, 76);
            this.uiTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox5.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox5.Name = "uiTextBox5";
            this.uiTextBox5.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox5.ShowText = false;
            this.uiTextBox5.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox5.TabIndex = 4;
            this.uiTextBox5.Text = "uiTextBox5";
            this.uiTextBox5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox5.Watermark = "";
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(0, 559);
            this.btn_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(144, 44);
            this.btn_exit.TabIndex = 31;
            this.btn_exit.Text = "退出";
            this.btn_exit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Frm_Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(647, 615);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Configuration";
            this.Text = "Frm_Configuration";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupGain.ResumeLayout(false);
            this.groupExposure.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupAngle.ResumeLayout(false);
            this.groupCenterY.ResumeLayout(false);
            this.groupCenterX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UICheckBoxGroup groupExposure;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_ExplorMax;
        private Sunny.UI.UITextBox txt_ExplorMin;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UICheckBoxGroup groupGain;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_GainMax;
        private Sunny.UI.UITextBox txt_GainMin;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UICheckBoxGroup groupAngle;
        private Sunny.UI.UITextBox txt_OffsetAngleMax;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txt_OffsetAngleMin;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UICheckBoxGroup groupCenterY;
        private Sunny.UI.UITextBox txt_OffsetYMax;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txt_OffsetYMin;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UICheckBoxGroup groupCenterX;
        private Sunny.UI.UITextBox txt_OffsetXMax;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txt_OffsetXMin;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox uiTextBox10;
        private Sunny.UI.UITextBox uiTextBox9;
        private Sunny.UI.UITextBox uiTextBox8;
        private Sunny.UI.UITextBox uiTextBox7;
        private Sunny.UI.UITextBox uiTextBox6;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UIButton btn_exit;
    }
}