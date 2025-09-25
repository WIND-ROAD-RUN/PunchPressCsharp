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
            this.txt_gainStep = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txt_gainMax = new Sunny.UI.UITextBox();
            this.txt_gainMin = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.groupExposure = new Sunny.UI.UICheckBoxGroup();
            this.txt_exposureStep = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txt_exposureMax = new Sunny.UI.UITextBox();
            this.txt_exposureMin = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupAngle = new Sunny.UI.UICheckBoxGroup();
            this.txt_angleCorrectionStep = new Sunny.UI.UITextBox();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.txt_angleCorrectionMax = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txt_angleCorrectionMin = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.groupCenterY = new Sunny.UI.UICheckBoxGroup();
            this.txt_centralYStep = new Sunny.UI.UITextBox();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.txt_centralYCorrectionMax = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txt_centralYCorrectionMin = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.groupCenterX = new Sunny.UI.UICheckBoxGroup();
            this.txt_centralXStep = new Sunny.UI.UITextBox();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.txt_centralXCorrectionMax = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txt_centralXCorrectionMin = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.cbox_downLight = new Sunny.UI.UICheckBox();
            this.cbox_upLight = new Sunny.UI.UICheckBox();
            this.uiCheckBoxGroup2 = new Sunny.UI.UICheckBoxGroup();
            this.btn_gainForVisualCorrection = new Sunny.UI.UITextBox();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.btn_exposureForVisualCorrection = new Sunny.UI.UITextBox();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.btnSave = new Sunny.UI.UIButton();
            this.uiTextBox10 = new Sunny.UI.UITextBox();
            this.uiTextBox9 = new Sunny.UI.UITextBox();
            this.uiTextBox8 = new Sunny.UI.UITextBox();
            this.uiTextBox7 = new Sunny.UI.UITextBox();
            this.uiTextBox6 = new Sunny.UI.UITextBox();
            this.uiTextBox5 = new Sunny.UI.UITextBox();
            this.btn_exit = new Sunny.UI.UIButton();
            this.uiTextBox11 = new Sunny.UI.UITextBox();
            this.uiTextBox4 = new Sunny.UI.UITextBox();
            this.titleBar.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupGain.SuspendLayout();
            this.groupExposure.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupAngle.SuspendLayout();
            this.groupCenterY.SuspendLayout();
            this.groupCenterX.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.uiCheckBoxGroup2.SuspendLayout();
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
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 45);
            this.uiTabControl1.Location = new System.Drawing.Point(2, 46);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(642, 538);
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
            this.tabPage1.Size = new System.Drawing.Size(642, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "光源亮度设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupGain
            // 
            this.groupGain.Controls.Add(this.txt_gainStep);
            this.groupGain.Controls.Add(this.uiLabel12);
            this.groupGain.Controls.Add(this.uiLabel1);
            this.groupGain.Controls.Add(this.txt_gainMax);
            this.groupGain.Controls.Add(this.txt_gainMin);
            this.groupGain.Controls.Add(this.uiLabel4);
            this.groupGain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupGain.Location = new System.Drawing.Point(1, 243);
            this.groupGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupGain.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupGain.Name = "groupGain";
            this.groupGain.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupGain.Radius = 15;
            this.groupGain.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupGain.SelectedIndexes")));
            this.groupGain.Size = new System.Drawing.Size(644, 192);
            this.groupGain.TabIndex = 6;
            this.groupGain.Text = "增益设置";
            this.groupGain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_gainStep
            // 
            this.txt_gainStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gainStep.DoubleValue = 1000D;
            this.txt_gainStep.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gainStep.IntValue = 1000;
            this.txt_gainStep.Location = new System.Drawing.Point(293, 138);
            this.txt_gainStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gainStep.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_gainStep.Name = "txt_gainStep";
            this.txt_gainStep.Padding = new System.Windows.Forms.Padding(5);
            this.txt_gainStep.ShowText = false;
            this.txt_gainStep.Size = new System.Drawing.Size(160, 35);
            this.txt_gainStep.TabIndex = 8;
            this.txt_gainStep.Text = "1000";
            this.txt_gainStep.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_gainStep.Watermark = "";
            this.txt_gainStep.Click += new System.EventHandler(this.txt_gainStep_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(183, 144);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(100, 23);
            this.uiLabel12.TabIndex = 7;
            this.uiLabel12.Text = "设置步长:";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // txt_gainMax
            // 
            this.txt_gainMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gainMax.DoubleValue = 1000D;
            this.txt_gainMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gainMax.IntValue = 1000;
            this.txt_gainMax.Location = new System.Drawing.Point(293, 93);
            this.txt_gainMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gainMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_gainMax.Name = "txt_gainMax";
            this.txt_gainMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_gainMax.ShowText = false;
            this.txt_gainMax.Size = new System.Drawing.Size(160, 35);
            this.txt_gainMax.TabIndex = 4;
            this.txt_gainMax.Text = "1000";
            this.txt_gainMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_gainMax.Watermark = "";
            this.txt_gainMax.Click += new System.EventHandler(this.txt_gainMax_Click);
            // 
            // txt_gainMin
            // 
            this.txt_gainMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gainMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gainMin.Location = new System.Drawing.Point(293, 48);
            this.txt_gainMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gainMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_gainMin.Name = "txt_gainMin";
            this.txt_gainMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_gainMin.ShowText = false;
            this.txt_gainMin.Size = new System.Drawing.Size(160, 35);
            this.txt_gainMin.TabIndex = 2;
            this.txt_gainMin.Text = "0";
            this.txt_gainMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_gainMin.Watermark = "";
            this.txt_gainMin.Click += new System.EventHandler(this.txt_gainMin_Click);
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
            this.groupExposure.Controls.Add(this.txt_exposureStep);
            this.groupExposure.Controls.Add(this.uiLabel11);
            this.groupExposure.Controls.Add(this.uiLabel2);
            this.groupExposure.Controls.Add(this.txt_exposureMax);
            this.groupExposure.Controls.Add(this.txt_exposureMin);
            this.groupExposure.Controls.Add(this.uiLabel3);
            this.groupExposure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupExposure.Location = new System.Drawing.Point(-2, 47);
            this.groupExposure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupExposure.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupExposure.Name = "groupExposure";
            this.groupExposure.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupExposure.Radius = 15;
            this.groupExposure.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupExposure.SelectedIndexes")));
            this.groupExposure.Size = new System.Drawing.Size(644, 186);
            this.groupExposure.TabIndex = 5;
            this.groupExposure.Text = "曝光设置";
            this.groupExposure.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.groupExposure.ValueChanged += new Sunny.UI.UICheckBoxGroup.OnValueChanged(this.uiCheckBoxGroup1_ValueChanged);
            // 
            // txt_exposureStep
            // 
            this.txt_exposureStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_exposureStep.DoubleValue = 1000D;
            this.txt_exposureStep.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_exposureStep.IntValue = 1000;
            this.txt_exposureStep.Location = new System.Drawing.Point(293, 138);
            this.txt_exposureStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_exposureStep.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_exposureStep.Name = "txt_exposureStep";
            this.txt_exposureStep.Padding = new System.Windows.Forms.Padding(5);
            this.txt_exposureStep.ShowText = false;
            this.txt_exposureStep.Size = new System.Drawing.Size(160, 35);
            this.txt_exposureStep.TabIndex = 6;
            this.txt_exposureStep.Text = "1000";
            this.txt_exposureStep.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_exposureStep.Watermark = "";
            this.txt_exposureStep.Click += new System.EventHandler(this.txt_exposureStep_Click);
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.Location = new System.Drawing.Point(183, 144);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(100, 23);
            this.uiLabel11.TabIndex = 5;
            this.uiLabel11.Text = "设置步长:";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // txt_exposureMax
            // 
            this.txt_exposureMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_exposureMax.DoubleValue = 1000D;
            this.txt_exposureMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_exposureMax.IntValue = 1000;
            this.txt_exposureMax.Location = new System.Drawing.Point(293, 93);
            this.txt_exposureMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_exposureMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_exposureMax.Name = "txt_exposureMax";
            this.txt_exposureMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_exposureMax.ShowText = false;
            this.txt_exposureMax.Size = new System.Drawing.Size(160, 35);
            this.txt_exposureMax.TabIndex = 4;
            this.txt_exposureMax.Text = "1000";
            this.txt_exposureMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_exposureMax.Watermark = "";
            this.txt_exposureMax.Click += new System.EventHandler(this.txt_exposureMax_Click);
            // 
            // txt_exposureMin
            // 
            this.txt_exposureMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_exposureMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_exposureMin.Location = new System.Drawing.Point(293, 48);
            this.txt_exposureMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_exposureMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_exposureMin.Name = "txt_exposureMin";
            this.txt_exposureMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_exposureMin.ShowText = false;
            this.txt_exposureMin.Size = new System.Drawing.Size(160, 35);
            this.txt_exposureMin.TabIndex = 2;
            this.txt_exposureMin.Text = "0";
            this.txt_exposureMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_exposureMin.Watermark = "";
            this.txt_exposureMin.Click += new System.EventHandler(this.txt_exposureMin_Click);
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
            this.tabPage2.Size = new System.Drawing.Size(642, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "偏移量设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupAngle
            // 
            this.groupAngle.Controls.Add(this.txt_angleCorrectionStep);
            this.groupAngle.Controls.Add(this.uiLabel15);
            this.groupAngle.Controls.Add(this.txt_angleCorrectionMax);
            this.groupAngle.Controls.Add(this.uiLabel9);
            this.groupAngle.Controls.Add(this.txt_angleCorrectionMin);
            this.groupAngle.Controls.Add(this.uiLabel10);
            this.groupAngle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupAngle.Location = new System.Drawing.Point(16, 332);
            this.groupAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupAngle.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupAngle.Name = "groupAngle";
            this.groupAngle.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupAngle.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupAngle.SelectedIndexes")));
            this.groupAngle.Size = new System.Drawing.Size(616, 156);
            this.groupAngle.TabIndex = 7;
            this.groupAngle.Text = "角度矫正";
            this.groupAngle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_angleCorrectionStep
            // 
            this.txt_angleCorrectionStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_angleCorrectionStep.DoubleValue = 1000D;
            this.txt_angleCorrectionStep.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_angleCorrectionStep.IntValue = 1000;
            this.txt_angleCorrectionStep.Location = new System.Drawing.Point(302, 116);
            this.txt_angleCorrectionStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_angleCorrectionStep.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_angleCorrectionStep.Name = "txt_angleCorrectionStep";
            this.txt_angleCorrectionStep.Padding = new System.Windows.Forms.Padding(5);
            this.txt_angleCorrectionStep.ShowText = false;
            this.txt_angleCorrectionStep.Size = new System.Drawing.Size(160, 35);
            this.txt_angleCorrectionStep.TabIndex = 8;
            this.txt_angleCorrectionStep.Text = "1000";
            this.txt_angleCorrectionStep.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_angleCorrectionStep.Watermark = "";
            this.txt_angleCorrectionStep.Click += new System.EventHandler(this.txt_angleCorrectionStep_Click);
            // 
            // uiLabel15
            // 
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel15.Location = new System.Drawing.Point(192, 122);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(100, 23);
            this.uiLabel15.TabIndex = 7;
            this.uiLabel15.Text = "设置步长:";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_angleCorrectionMax
            // 
            this.txt_angleCorrectionMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_angleCorrectionMax.DoubleValue = 360D;
            this.txt_angleCorrectionMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_angleCorrectionMax.IntValue = 360;
            this.txt_angleCorrectionMax.Location = new System.Drawing.Point(302, 80);
            this.txt_angleCorrectionMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_angleCorrectionMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_angleCorrectionMax.Name = "txt_angleCorrectionMax";
            this.txt_angleCorrectionMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_angleCorrectionMax.ShowText = false;
            this.txt_angleCorrectionMax.Size = new System.Drawing.Size(160, 30);
            this.txt_angleCorrectionMax.TabIndex = 4;
            this.txt_angleCorrectionMax.Text = "360";
            this.txt_angleCorrectionMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_angleCorrectionMax.Watermark = "";
            this.txt_angleCorrectionMax.Click += new System.EventHandler(this.txt_angleCorrectionMax_Click);
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
            // txt_angleCorrectionMin
            // 
            this.txt_angleCorrectionMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_angleCorrectionMin.DoubleValue = -360D;
            this.txt_angleCorrectionMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_angleCorrectionMin.IntValue = -360;
            this.txt_angleCorrectionMin.Location = new System.Drawing.Point(302, 38);
            this.txt_angleCorrectionMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_angleCorrectionMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_angleCorrectionMin.Name = "txt_angleCorrectionMin";
            this.txt_angleCorrectionMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_angleCorrectionMin.ShowText = false;
            this.txt_angleCorrectionMin.Size = new System.Drawing.Size(160, 30);
            this.txt_angleCorrectionMin.TabIndex = 3;
            this.txt_angleCorrectionMin.Text = "-360";
            this.txt_angleCorrectionMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_angleCorrectionMin.Watermark = "";
            this.txt_angleCorrectionMin.Click += new System.EventHandler(this.txt_angleCorrectionMin_Click);
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
            this.groupCenterY.Controls.Add(this.txt_centralYStep);
            this.groupCenterY.Controls.Add(this.uiLabel14);
            this.groupCenterY.Controls.Add(this.txt_centralYCorrectionMax);
            this.groupCenterY.Controls.Add(this.uiLabel7);
            this.groupCenterY.Controls.Add(this.txt_centralYCorrectionMin);
            this.groupCenterY.Controls.Add(this.uiLabel8);
            this.groupCenterY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupCenterY.Location = new System.Drawing.Point(16, 173);
            this.groupCenterY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupCenterY.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupCenterY.Name = "groupCenterY";
            this.groupCenterY.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupCenterY.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupCenterY.SelectedIndexes")));
            this.groupCenterY.Size = new System.Drawing.Size(616, 154);
            this.groupCenterY.TabIndex = 7;
            this.groupCenterY.Text = "中心矫正y";
            this.groupCenterY.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_centralYStep
            // 
            this.txt_centralYStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_centralYStep.DoubleValue = 1000D;
            this.txt_centralYStep.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_centralYStep.IntValue = 1000;
            this.txt_centralYStep.Location = new System.Drawing.Point(301, 117);
            this.txt_centralYStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_centralYStep.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_centralYStep.Name = "txt_centralYStep";
            this.txt_centralYStep.Padding = new System.Windows.Forms.Padding(5);
            this.txt_centralYStep.ShowText = false;
            this.txt_centralYStep.Size = new System.Drawing.Size(160, 32);
            this.txt_centralYStep.TabIndex = 8;
            this.txt_centralYStep.Text = "1000";
            this.txt_centralYStep.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_centralYStep.Watermark = "";
            this.txt_centralYStep.Click += new System.EventHandler(this.txt_centralYStep_Click);
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel14.Location = new System.Drawing.Point(191, 117);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(100, 23);
            this.uiLabel14.TabIndex = 7;
            this.uiLabel14.Text = "设置步长:";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_centralYCorrectionMax
            // 
            this.txt_centralYCorrectionMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_centralYCorrectionMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_centralYCorrectionMax.Location = new System.Drawing.Point(302, 80);
            this.txt_centralYCorrectionMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_centralYCorrectionMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_centralYCorrectionMax.Name = "txt_centralYCorrectionMax";
            this.txt_centralYCorrectionMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_centralYCorrectionMax.ShowText = false;
            this.txt_centralYCorrectionMax.Size = new System.Drawing.Size(160, 30);
            this.txt_centralYCorrectionMax.TabIndex = 4;
            this.txt_centralYCorrectionMax.TagString = "200";
            this.txt_centralYCorrectionMax.Text = "0";
            this.txt_centralYCorrectionMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_centralYCorrectionMax.Watermark = "";
            this.txt_centralYCorrectionMax.Click += new System.EventHandler(this.txt_centralYCorrectionMax_Click);
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
            // txt_centralYCorrectionMin
            // 
            this.txt_centralYCorrectionMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_centralYCorrectionMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_centralYCorrectionMin.Location = new System.Drawing.Point(302, 38);
            this.txt_centralYCorrectionMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_centralYCorrectionMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_centralYCorrectionMin.Name = "txt_centralYCorrectionMin";
            this.txt_centralYCorrectionMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_centralYCorrectionMin.ShowText = false;
            this.txt_centralYCorrectionMin.Size = new System.Drawing.Size(160, 30);
            this.txt_centralYCorrectionMin.TabIndex = 3;
            this.txt_centralYCorrectionMin.Text = "0";
            this.txt_centralYCorrectionMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_centralYCorrectionMin.Watermark = "";
            this.txt_centralYCorrectionMin.Click += new System.EventHandler(this.txt_centralYCorrectionMin_Click);
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
            this.groupCenterX.Controls.Add(this.txt_centralXStep);
            this.groupCenterX.Controls.Add(this.uiLabel13);
            this.groupCenterX.Controls.Add(this.txt_centralXCorrectionMax);
            this.groupCenterX.Controls.Add(this.uiLabel6);
            this.groupCenterX.Controls.Add(this.txt_centralXCorrectionMin);
            this.groupCenterX.Controls.Add(this.uiLabel5);
            this.groupCenterX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupCenterX.Location = new System.Drawing.Point(15, 14);
            this.groupCenterX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupCenterX.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupCenterX.Name = "groupCenterX";
            this.groupCenterX.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupCenterX.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("groupCenterX.SelectedIndexes")));
            this.groupCenterX.Size = new System.Drawing.Size(616, 156);
            this.groupCenterX.TabIndex = 6;
            this.groupCenterX.Text = "中心矫正x";
            this.groupCenterX.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_centralXStep
            // 
            this.txt_centralXStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_centralXStep.DoubleValue = 1000D;
            this.txt_centralXStep.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_centralXStep.IntValue = 1000;
            this.txt_centralXStep.Location = new System.Drawing.Point(302, 120);
            this.txt_centralXStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_centralXStep.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_centralXStep.Name = "txt_centralXStep";
            this.txt_centralXStep.Padding = new System.Windows.Forms.Padding(5);
            this.txt_centralXStep.ShowText = false;
            this.txt_centralXStep.Size = new System.Drawing.Size(160, 29);
            this.txt_centralXStep.TabIndex = 8;
            this.txt_centralXStep.Text = "1000";
            this.txt_centralXStep.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_centralXStep.Watermark = "";
            this.txt_centralXStep.Click += new System.EventHandler(this.txt_centralXStep_Click);
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel13.Location = new System.Drawing.Point(192, 126);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(100, 23);
            this.uiLabel13.TabIndex = 7;
            this.uiLabel13.Text = "设置步长:";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_centralXCorrectionMax
            // 
            this.txt_centralXCorrectionMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_centralXCorrectionMax.DoubleValue = 200D;
            this.txt_centralXCorrectionMax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_centralXCorrectionMax.IntValue = 200;
            this.txt_centralXCorrectionMax.Location = new System.Drawing.Point(302, 80);
            this.txt_centralXCorrectionMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_centralXCorrectionMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_centralXCorrectionMax.Name = "txt_centralXCorrectionMax";
            this.txt_centralXCorrectionMax.Padding = new System.Windows.Forms.Padding(5);
            this.txt_centralXCorrectionMax.ShowText = false;
            this.txt_centralXCorrectionMax.Size = new System.Drawing.Size(160, 30);
            this.txt_centralXCorrectionMax.TabIndex = 4;
            this.txt_centralXCorrectionMax.Text = "200";
            this.txt_centralXCorrectionMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_centralXCorrectionMax.Watermark = "";
            this.txt_centralXCorrectionMax.Click += new System.EventHandler(this.txt_centralXCorrectionMax_Click);
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
            // txt_centralXCorrectionMin
            // 
            this.txt_centralXCorrectionMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_centralXCorrectionMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_centralXCorrectionMin.Location = new System.Drawing.Point(302, 38);
            this.txt_centralXCorrectionMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_centralXCorrectionMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_centralXCorrectionMin.Name = "txt_centralXCorrectionMin";
            this.txt_centralXCorrectionMin.Padding = new System.Windows.Forms.Padding(5);
            this.txt_centralXCorrectionMin.ShowText = false;
            this.txt_centralXCorrectionMin.Size = new System.Drawing.Size(160, 30);
            this.txt_centralXCorrectionMin.TabIndex = 3;
            this.txt_centralXCorrectionMin.Text = "0";
            this.txt_centralXCorrectionMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_centralXCorrectionMin.Watermark = "";
            this.txt_centralXCorrectionMin.Click += new System.EventHandler(this.txt_centralXCorrectionMin_Click);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uiCheckBoxGroup1);
            this.tabPage3.Controls.Add(this.uiCheckBoxGroup2);
            this.tabPage3.Location = new System.Drawing.Point(0, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(642, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.cbox_downLight);
            this.uiCheckBoxGroup1.Controls.Add(this.cbox_upLight);
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(1, 248);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.Radius = 15;
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(644, 192);
            this.uiCheckBoxGroup1.TabIndex = 8;
            this.uiCheckBoxGroup1.Text = "光源设置";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_downLight
            // 
            this.cbox_downLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_downLight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbox_downLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbox_downLight.Location = new System.Drawing.Point(235, 111);
            this.cbox_downLight.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbox_downLight.Name = "cbox_downLight";
            this.cbox_downLight.Size = new System.Drawing.Size(150, 29);
            this.cbox_downLight.TabIndex = 0;
            this.cbox_downLight.Text = "下光源";
            // 
            // cbox_upLight
            // 
            this.cbox_upLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_upLight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbox_upLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbox_upLight.Location = new System.Drawing.Point(235, 49);
            this.cbox_upLight.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbox_upLight.Name = "cbox_upLight";
            this.cbox_upLight.Size = new System.Drawing.Size(150, 29);
            this.cbox_upLight.TabIndex = 0;
            this.cbox_upLight.Text = "上光源";
            this.cbox_upLight.Click += new System.EventHandler(this.cbox_upLight_Click);
            // 
            // uiCheckBoxGroup2
            // 
            this.uiCheckBoxGroup2.Controls.Add(this.btn_gainForVisualCorrection);
            this.uiCheckBoxGroup2.Controls.Add(this.uiLabel17);
            this.uiCheckBoxGroup2.Controls.Add(this.btn_exposureForVisualCorrection);
            this.uiCheckBoxGroup2.Controls.Add(this.uiLabel16);
            this.uiCheckBoxGroup2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBoxGroup2.Location = new System.Drawing.Point(1, 29);
            this.uiCheckBoxGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            this.uiCheckBoxGroup2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup2.Radius = 15;
            this.uiCheckBoxGroup2.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup2.SelectedIndexes")));
            this.uiCheckBoxGroup2.Size = new System.Drawing.Size(641, 209);
            this.uiCheckBoxGroup2.TabIndex = 7;
            this.uiCheckBoxGroup2.Text = "亮度设置";
            this.uiCheckBoxGroup2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_gainForVisualCorrection
            // 
            this.btn_gainForVisualCorrection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_gainForVisualCorrection.DoubleValue = 1000D;
            this.btn_gainForVisualCorrection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gainForVisualCorrection.IntValue = 1000;
            this.btn_gainForVisualCorrection.Location = new System.Drawing.Point(275, 100);
            this.btn_gainForVisualCorrection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_gainForVisualCorrection.MinimumSize = new System.Drawing.Size(1, 16);
            this.btn_gainForVisualCorrection.Name = "btn_gainForVisualCorrection";
            this.btn_gainForVisualCorrection.Padding = new System.Windows.Forms.Padding(5);
            this.btn_gainForVisualCorrection.ShowText = false;
            this.btn_gainForVisualCorrection.Size = new System.Drawing.Size(160, 35);
            this.btn_gainForVisualCorrection.TabIndex = 10;
            this.btn_gainForVisualCorrection.Text = "1000";
            this.btn_gainForVisualCorrection.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gainForVisualCorrection.Watermark = "";
            this.btn_gainForVisualCorrection.Click += new System.EventHandler(this.btn_gainForVisualCorrection_Click);
            // 
            // uiLabel17
            // 
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel17.Location = new System.Drawing.Point(165, 106);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(100, 23);
            this.uiLabel17.TabIndex = 9;
            this.uiLabel17.Text = "增益";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_exposureForVisualCorrection
            // 
            this.btn_exposureForVisualCorrection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_exposureForVisualCorrection.DoubleValue = 1000D;
            this.btn_exposureForVisualCorrection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureForVisualCorrection.IntValue = 1000;
            this.btn_exposureForVisualCorrection.Location = new System.Drawing.Point(275, 40);
            this.btn_exposureForVisualCorrection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exposureForVisualCorrection.MinimumSize = new System.Drawing.Size(1, 16);
            this.btn_exposureForVisualCorrection.Name = "btn_exposureForVisualCorrection";
            this.btn_exposureForVisualCorrection.Padding = new System.Windows.Forms.Padding(5);
            this.btn_exposureForVisualCorrection.ShowText = false;
            this.btn_exposureForVisualCorrection.Size = new System.Drawing.Size(160, 35);
            this.btn_exposureForVisualCorrection.TabIndex = 8;
            this.btn_exposureForVisualCorrection.Text = "1000";
            this.btn_exposureForVisualCorrection.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exposureForVisualCorrection.Watermark = "";
            this.btn_exposureForVisualCorrection.Click += new System.EventHandler(this.btn_exposureForVisualCorrection_Click);
            // 
            // uiLabel16
            // 
            this.uiLabel16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel16.Location = new System.Drawing.Point(165, 46);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(100, 23);
            this.uiLabel16.TabIndex = 7;
            this.uiLabel16.Text = "曝光";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(491, 600);
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
            this.btn_exit.Location = new System.Drawing.Point(12, 600);
            this.btn_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(144, 44);
            this.btn_exit.TabIndex = 31;
            this.btn_exit.Text = "退出";
            this.btn_exit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // uiTextBox11
            // 
            this.uiTextBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox11.DoubleValue = 1000D;
            this.uiTextBox11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox11.IntValue = 1000;
            this.uiTextBox11.Location = new System.Drawing.Point(293, 93);
            this.uiTextBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox11.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox11.Name = "uiTextBox11";
            this.uiTextBox11.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox11.ShowText = false;
            this.uiTextBox11.Size = new System.Drawing.Size(160, 35);
            this.uiTextBox11.TabIndex = 4;
            this.uiTextBox11.Text = "1000";
            this.uiTextBox11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox11.Watermark = "";
            // 
            // uiTextBox4
            // 
            this.uiTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox4.DoubleValue = 1000D;
            this.uiTextBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox4.IntValue = 1000;
            this.uiTextBox4.Location = new System.Drawing.Point(293, 138);
            this.uiTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox4.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox4.Name = "uiTextBox4";
            this.uiTextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox4.ShowText = false;
            this.uiTextBox4.Size = new System.Drawing.Size(160, 35);
            this.uiTextBox4.TabIndex = 6;
            this.uiTextBox4.Text = "1000";
            this.uiTextBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox4.Watermark = "";
            // 
            // Frm_Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(647, 668);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Configuration";
            this.Text = "Frm_Configuration";
            this.Load += new System.EventHandler(this.Frm_Configuration_Load);
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
            this.tabPage3.ResumeLayout(false);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup2.ResumeLayout(false);
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
        private Sunny.UI.UITextBox txt_exposureMax;
        private Sunny.UI.UITextBox txt_exposureMin;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UICheckBoxGroup groupGain;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_gainMax;
        private Sunny.UI.UITextBox txt_gainMin;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UICheckBoxGroup groupAngle;
        private Sunny.UI.UITextBox txt_angleCorrectionMax;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txt_angleCorrectionMin;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UICheckBoxGroup groupCenterY;
        private Sunny.UI.UITextBox txt_centralYCorrectionMax;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txt_centralYCorrectionMin;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UICheckBoxGroup groupCenterX;
        private Sunny.UI.UITextBox txt_centralXCorrectionMax;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txt_centralXCorrectionMin;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox uiTextBox10;
        private Sunny.UI.UITextBox uiTextBox9;
        private Sunny.UI.UITextBox uiTextBox8;
        private Sunny.UI.UITextBox uiTextBox7;
        private Sunny.UI.UITextBox uiTextBox6;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UIButton btn_exit;
        private Sunny.UI.UITextBox txt_exposureStep;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txt_gainStep;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox txt_angleCorrectionStep;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UITextBox txt_centralYStep;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UITextBox txt_centralXStep;
        private Sunny.UI.UILabel uiLabel13;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup2;
        private Sunny.UI.UITextBox btn_exposureForVisualCorrection;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UITextBox uiTextBox11;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox btn_gainForVisualCorrection;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UICheckBox cbox_downLight;
        private Sunny.UI.UICheckBox cbox_upLight;
    }
}