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
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiCheckBoxGroup7 = new Sunny.UI.UICheckBoxGroup();
            this.lb_gainValue = new Sunny.UI.UILabel();
            this.lb_exposureValue = new Sunny.UI.UILabel();
            this.btn_gainIncrease = new Sunny.UI.UIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gainReduce = new Sunny.UI.UIButton();
            this.btn_exposureIncrease = new Sunny.UI.UIButton();
            this.btn_exposureReduce = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup6 = new Sunny.UI.UICheckBoxGroup();
            this.cBox_downLight = new Sunny.UI.UICheckBox();
            this.cBox_upLight = new Sunny.UI.UICheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiCheckBoxGroup8 = new Sunny.UI.UICheckBoxGroup();
            this.lb_angle = new Sunny.UI.UILabel();
            this.btn_angleIncease = new Sunny.UI.UIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_angleDecrease = new Sunny.UI.UIButton();
            this.lb_y = new Sunny.UI.UILabel();
            this.lb_x = new Sunny.UI.UILabel();
            this.btn_yIncease = new Sunny.UI.UIButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_yDecrease = new Sunny.UI.UIButton();
            this.btn_xIncease = new Sunny.UI.UIButton();
            this.btn_xDecrease = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup5 = new Sunny.UI.UICheckBoxGroup();
            this.cBox_workMode = new Sunny.UI.UICheckBox();
            this.cBox_debugMode = new Sunny.UI.UICheckBox();
            this.uiCheckBoxGroup4 = new Sunny.UI.UICheckBoxGroup();
            this.btn_runOnce = new Sunny.UI.UIButton();
            this.btn_disTemplate = new Sunny.UI.UIButton();
            this.btn_disCentral = new Sunny.UI.UIButton();
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiCheckBoxGroup3 = new Sunny.UI.UICheckBoxGroup();
            this.pbtn_templateLoad = new Sunny.UI.UIButton();
            this.btn_set = new Sunny.UI.UIButton();
            this.btn_templateLearn = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup2 = new Sunny.UI.UICheckBoxGroup();
            this.lb_plcStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_cameraStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.titleBar = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiCheckBoxGroup7.SuspendLayout();
            this.uiCheckBoxGroup6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiCheckBoxGroup8.SuspendLayout();
            this.uiCheckBoxGroup5.SuspendLayout();
            this.uiCheckBoxGroup4.SuspendLayout();
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
            this.panelContainer.Controls.Add(this.uiTabControl1);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup5);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup4);
            this.panelContainer.Controls.Add(this.vmRenderControl1);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup1);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup3);
            this.panelContainer.Controls.Add(this.uiCheckBoxGroup2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 50);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1573, 1005);
            this.panelContainer.TabIndex = 11;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(983, 278);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(620, 334);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 22;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiCheckBoxGroup7);
            this.tabPage1.Controls.Add(this.uiCheckBoxGroup6);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(620, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "光源亮度设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxGroup7
            // 
            this.uiCheckBoxGroup7.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup7.Controls.Add(this.lb_gainValue);
            this.uiCheckBoxGroup7.Controls.Add(this.lb_exposureValue);
            this.uiCheckBoxGroup7.Controls.Add(this.btn_gainIncrease);
            this.uiCheckBoxGroup7.Controls.Add(this.label4);
            this.uiCheckBoxGroup7.Controls.Add(this.label2);
            this.uiCheckBoxGroup7.Controls.Add(this.btn_gainReduce);
            this.uiCheckBoxGroup7.Controls.Add(this.btn_exposureIncrease);
            this.uiCheckBoxGroup7.Controls.Add(this.btn_exposureReduce);
            this.uiCheckBoxGroup7.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup7.Location = new System.Drawing.Point(45, 98);
            this.uiCheckBoxGroup7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup7.Name = "uiCheckBoxGroup7";
            this.uiCheckBoxGroup7.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup7.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup7.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup7.SelectedIndexes")));
            this.uiCheckBoxGroup7.Size = new System.Drawing.Size(547, 161);
            this.uiCheckBoxGroup7.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup7.TabIndex = 21;
            this.uiCheckBoxGroup7.Text = null;
            this.uiCheckBoxGroup7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_gainValue
            // 
            this.lb_gainValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lb_gainValue.ForeColor = System.Drawing.Color.White;
            this.lb_gainValue.Location = new System.Drawing.Point(178, 70);
            this.lb_gainValue.Name = "lb_gainValue";
            this.lb_gainValue.Size = new System.Drawing.Size(104, 40);
            this.lb_gainValue.Style = Sunny.UI.UIStyle.Custom;
            this.lb_gainValue.TabIndex = 27;
            this.lb_gainValue.Text = "10";
            this.lb_gainValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_exposureValue
            // 
            this.lb_exposureValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lb_exposureValue.ForeColor = System.Drawing.Color.White;
            this.lb_exposureValue.Location = new System.Drawing.Point(178, 19);
            this.lb_exposureValue.Name = "lb_exposureValue";
            this.lb_exposureValue.Size = new System.Drawing.Size(119, 40);
            this.lb_exposureValue.Style = Sunny.UI.UIStyle.Custom;
            this.lb_exposureValue.TabIndex = 28;
            this.lb_exposureValue.Text = "10000";
            this.lb_exposureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_gainIncrease
            // 
            this.btn_gainIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gainIncrease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gainIncrease.Location = new System.Drawing.Point(303, 70);
            this.btn_gainIncrease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_gainIncrease.Name = "btn_gainIncrease";
            this.btn_gainIncrease.Size = new System.Drawing.Size(68, 40);
            this.btn_gainIncrease.TabIndex = 23;
            this.btn_gainIncrease.Text = "+";
            this.btn_gainIncrease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gainIncrease.Click += new System.EventHandler(this.btn_gainIncrease_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "增益设置";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "曝光设置";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_gainReduce
            // 
            this.btn_gainReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gainReduce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gainReduce.Location = new System.Drawing.Point(104, 70);
            this.btn_gainReduce.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_gainReduce.Name = "btn_gainReduce";
            this.btn_gainReduce.Size = new System.Drawing.Size(68, 40);
            this.btn_gainReduce.TabIndex = 21;
            this.btn_gainReduce.Text = "-";
            this.btn_gainReduce.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gainReduce.Click += new System.EventHandler(this.btn_gainReduce_Click);
            // 
            // btn_exposureIncrease
            // 
            this.btn_exposureIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exposureIncrease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureIncrease.Location = new System.Drawing.Point(303, 19);
            this.btn_exposureIncrease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exposureIncrease.Name = "btn_exposureIncrease";
            this.btn_exposureIncrease.Size = new System.Drawing.Size(68, 40);
            this.btn_exposureIncrease.TabIndex = 24;
            this.btn_exposureIncrease.Text = "+";
            this.btn_exposureIncrease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureIncrease.Click += new System.EventHandler(this.btn_exposureIncrease_Click);
            // 
            // btn_exposureReduce
            // 
            this.btn_exposureReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exposureReduce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureReduce.Location = new System.Drawing.Point(104, 19);
            this.btn_exposureReduce.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exposureReduce.Name = "btn_exposureReduce";
            this.btn_exposureReduce.Size = new System.Drawing.Size(68, 40);
            this.btn_exposureReduce.TabIndex = 22;
            this.btn_exposureReduce.Text = "-";
            this.btn_exposureReduce.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exposureReduce.Click += new System.EventHandler(this.btn_exposureReduce_Click);
            // 
            // uiCheckBoxGroup6
            // 
            this.uiCheckBoxGroup6.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup6.Controls.Add(this.cBox_downLight);
            this.uiCheckBoxGroup6.Controls.Add(this.cBox_upLight);
            this.uiCheckBoxGroup6.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup6.Location = new System.Drawing.Point(45, 8);
            this.uiCheckBoxGroup6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup6.Name = "uiCheckBoxGroup6";
            this.uiCheckBoxGroup6.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup6.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup6.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup6.SelectedIndexes")));
            this.uiCheckBoxGroup6.Size = new System.Drawing.Size(547, 78);
            this.uiCheckBoxGroup6.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup6.TabIndex = 12;
            this.uiCheckBoxGroup6.Text = null;
            this.uiCheckBoxGroup6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBox_downLight
            // 
            this.cBox_downLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_downLight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBox_downLight.ForeColor = System.Drawing.Color.White;
            this.cBox_downLight.Location = new System.Drawing.Point(214, 3);
            this.cBox_downLight.MinimumSize = new System.Drawing.Size(1, 1);
            this.cBox_downLight.Name = "cBox_downLight";
            this.cBox_downLight.Size = new System.Drawing.Size(160, 59);
            this.cBox_downLight.TabIndex = 14;
            this.cBox_downLight.Text = "下光源";
            // 
            // cBox_upLight
            // 
            this.cBox_upLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_upLight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBox_upLight.ForeColor = System.Drawing.Color.White;
            this.cBox_upLight.Location = new System.Drawing.Point(21, 0);
            this.cBox_upLight.MinimumSize = new System.Drawing.Size(1, 1);
            this.cBox_upLight.Name = "cBox_upLight";
            this.cBox_upLight.Size = new System.Drawing.Size(160, 59);
            this.cBox_upLight.TabIndex = 13;
            this.cBox_upLight.Text = "上光源";
            this.cBox_upLight.CheckedChanged += new System.EventHandler(this.cBox_upLight_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiCheckBoxGroup8);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(620, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "偏移量设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxGroup8
            // 
            this.uiCheckBoxGroup8.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup8.Controls.Add(this.lb_angle);
            this.uiCheckBoxGroup8.Controls.Add(this.btn_angleIncease);
            this.uiCheckBoxGroup8.Controls.Add(this.label8);
            this.uiCheckBoxGroup8.Controls.Add(this.btn_angleDecrease);
            this.uiCheckBoxGroup8.Controls.Add(this.lb_y);
            this.uiCheckBoxGroup8.Controls.Add(this.lb_x);
            this.uiCheckBoxGroup8.Controls.Add(this.btn_yIncease);
            this.uiCheckBoxGroup8.Controls.Add(this.label6);
            this.uiCheckBoxGroup8.Controls.Add(this.label7);
            this.uiCheckBoxGroup8.Controls.Add(this.btn_yDecrease);
            this.uiCheckBoxGroup8.Controls.Add(this.btn_xIncease);
            this.uiCheckBoxGroup8.Controls.Add(this.btn_xDecrease);
            this.uiCheckBoxGroup8.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup8.Location = new System.Drawing.Point(28, 40);
            this.uiCheckBoxGroup8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup8.Name = "uiCheckBoxGroup8";
            this.uiCheckBoxGroup8.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup8.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup8.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup8.SelectedIndexes")));
            this.uiCheckBoxGroup8.Size = new System.Drawing.Size(519, 205);
            this.uiCheckBoxGroup8.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup8.TabIndex = 22;
            this.uiCheckBoxGroup8.Text = null;
            this.uiCheckBoxGroup8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_angle
            // 
            this.lb_angle.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lb_angle.ForeColor = System.Drawing.Color.White;
            this.lb_angle.Location = new System.Drawing.Point(178, 117);
            this.lb_angle.Name = "lb_angle";
            this.lb_angle.Size = new System.Drawing.Size(104, 40);
            this.lb_angle.Style = Sunny.UI.UIStyle.Custom;
            this.lb_angle.TabIndex = 32;
            this.lb_angle.Text = "10";
            this.lb_angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_angleIncease
            // 
            this.btn_angleIncease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_angleIncease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_angleIncease.Location = new System.Drawing.Point(303, 117);
            this.btn_angleIncease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_angleIncease.Name = "btn_angleIncease";
            this.btn_angleIncease.Size = new System.Drawing.Size(68, 40);
            this.btn_angleIncease.TabIndex = 31;
            this.btn_angleIncease.Text = "+";
            this.btn_angleIncease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 38);
            this.label8.TabIndex = 29;
            this.label8.Text = "角度";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_angleDecrease
            // 
            this.btn_angleDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_angleDecrease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_angleDecrease.Location = new System.Drawing.Point(104, 117);
            this.btn_angleDecrease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_angleDecrease.Name = "btn_angleDecrease";
            this.btn_angleDecrease.Size = new System.Drawing.Size(68, 40);
            this.btn_angleDecrease.TabIndex = 30;
            this.btn_angleDecrease.Text = "-";
            this.btn_angleDecrease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // lb_y
            // 
            this.lb_y.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lb_y.ForeColor = System.Drawing.Color.White;
            this.lb_y.Location = new System.Drawing.Point(178, 70);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(104, 40);
            this.lb_y.Style = Sunny.UI.UIStyle.Custom;
            this.lb_y.TabIndex = 27;
            this.lb_y.Text = "10";
            this.lb_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_x
            // 
            this.lb_x.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lb_x.ForeColor = System.Drawing.Color.White;
            this.lb_x.Location = new System.Drawing.Point(178, 19);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(119, 40);
            this.lb_x.Style = Sunny.UI.UIStyle.Custom;
            this.lb_x.TabIndex = 28;
            this.lb_x.Text = "10000";
            this.lb_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_yIncease
            // 
            this.btn_yIncease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yIncease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_yIncease.Location = new System.Drawing.Point(303, 70);
            this.btn_yIncease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_yIncease.Name = "btn_yIncease";
            this.btn_yIncease.Size = new System.Drawing.Size(68, 40);
            this.btn_yIncease.TabIndex = 23;
            this.btn_yIncease.Text = "+";
            this.btn_yIncease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Y";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_yDecrease
            // 
            this.btn_yDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yDecrease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_yDecrease.Location = new System.Drawing.Point(104, 70);
            this.btn_yDecrease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_yDecrease.Name = "btn_yDecrease";
            this.btn_yDecrease.Size = new System.Drawing.Size(68, 40);
            this.btn_yDecrease.TabIndex = 21;
            this.btn_yDecrease.Text = "-";
            this.btn_yDecrease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_xIncease
            // 
            this.btn_xIncease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xIncease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_xIncease.Location = new System.Drawing.Point(303, 19);
            this.btn_xIncease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_xIncease.Name = "btn_xIncease";
            this.btn_xIncease.Size = new System.Drawing.Size(68, 40);
            this.btn_xIncease.TabIndex = 24;
            this.btn_xIncease.Text = "+";
            this.btn_xIncease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_xDecrease
            // 
            this.btn_xDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xDecrease.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_xDecrease.Location = new System.Drawing.Point(104, 19);
            this.btn_xDecrease.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_xDecrease.Name = "btn_xDecrease";
            this.btn_xDecrease.Size = new System.Drawing.Size(68, 40);
            this.btn_xDecrease.TabIndex = 22;
            this.btn_xDecrease.Text = "-";
            this.btn_xDecrease.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiCheckBoxGroup5
            // 
            this.uiCheckBoxGroup5.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup5.Controls.Add(this.cBox_workMode);
            this.uiCheckBoxGroup5.Controls.Add(this.cBox_debugMode);
            this.uiCheckBoxGroup5.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup5.Location = new System.Drawing.Point(983, 194);
            this.uiCheckBoxGroup5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup5.Name = "uiCheckBoxGroup5";
            this.uiCheckBoxGroup5.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup5.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup5.SelectedIndexes")));
            this.uiCheckBoxGroup5.Size = new System.Drawing.Size(547, 74);
            this.uiCheckBoxGroup5.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup5.TabIndex = 11;
            this.uiCheckBoxGroup5.Text = null;
            this.uiCheckBoxGroup5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBox_workMode
            // 
            this.cBox_workMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_workMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBox_workMode.ForeColor = System.Drawing.Color.White;
            this.cBox_workMode.Location = new System.Drawing.Point(21, 0);
            this.cBox_workMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.cBox_workMode.Name = "cBox_workMode";
            this.cBox_workMode.Size = new System.Drawing.Size(160, 59);
            this.cBox_workMode.TabIndex = 10;
            this.cBox_workMode.Text = "工作模式";
            this.cBox_workMode.Click += new System.EventHandler(this.cBox_workMode_Click);
            // 
            // cBox_debugMode
            // 
            this.cBox_debugMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_debugMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBox_debugMode.ForeColor = System.Drawing.Color.White;
            this.cBox_debugMode.Location = new System.Drawing.Point(214, 0);
            this.cBox_debugMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.cBox_debugMode.Name = "cBox_debugMode";
            this.cBox_debugMode.Size = new System.Drawing.Size(169, 59);
            this.cBox_debugMode.TabIndex = 10;
            this.cBox_debugMode.Text = "调试模式";
            this.cBox_debugMode.Click += new System.EventHandler(this.cBox_debugMode_Click);
            // 
            // uiCheckBoxGroup4
            // 
            this.uiCheckBoxGroup4.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup4.Controls.Add(this.btn_runOnce);
            this.uiCheckBoxGroup4.Controls.Add(this.btn_disTemplate);
            this.uiCheckBoxGroup4.Controls.Add(this.btn_disCentral);
            this.uiCheckBoxGroup4.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup4.Location = new System.Drawing.Point(983, 749);
            this.uiCheckBoxGroup4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup4.Name = "uiCheckBoxGroup4";
            this.uiCheckBoxGroup4.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup4.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup4.SelectedIndexes")));
            this.uiCheckBoxGroup4.Size = new System.Drawing.Size(547, 66);
            this.uiCheckBoxGroup4.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup4.TabIndex = 9;
            this.uiCheckBoxGroup4.Text = null;
            this.uiCheckBoxGroup4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_runOnce
            // 
            this.btn_runOnce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_runOnce.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_runOnce.Location = new System.Drawing.Point(22, 11);
            this.btn_runOnce.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_runOnce.Name = "btn_runOnce";
            this.btn_runOnce.Size = new System.Drawing.Size(97, 32);
            this.btn_runOnce.Style = Sunny.UI.UIStyle.Custom;
            this.btn_runOnce.TabIndex = 4;
            this.btn_runOnce.Text = "执行一次";
            this.btn_runOnce.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_runOnce.Click += new System.EventHandler(this.btn_runOnce_Click);
            // 
            // btn_disTemplate
            // 
            this.btn_disTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disTemplate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_disTemplate.Location = new System.Drawing.Point(268, 11);
            this.btn_disTemplate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_disTemplate.Name = "btn_disTemplate";
            this.btn_disTemplate.Size = new System.Drawing.Size(115, 32);
            this.btn_disTemplate.Style = Sunny.UI.UIStyle.Custom;
            this.btn_disTemplate.TabIndex = 1;
            this.btn_disTemplate.Text = "显示模板";
            this.btn_disTemplate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disTemplate.Click += new System.EventHandler(this.btn_disTemplate_Click);
            // 
            // btn_disCentral
            // 
            this.btn_disCentral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disCentral.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_disCentral.Location = new System.Drawing.Point(137, 11);
            this.btn_disCentral.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_disCentral.Name = "btn_disCentral";
            this.btn_disCentral.Size = new System.Drawing.Size(115, 32);
            this.btn_disCentral.Style = Sunny.UI.UIStyle.Custom;
            this.btn_disCentral.TabIndex = 1;
            this.btn_disCentral.Text = "显示中心";
            this.btn_disCentral.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disCentral.Click += new System.EventHandler(this.btn_disCentral_Click);
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(21, 15);
            this.vmRenderControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(888, 1081);
            this.vmRenderControl1.TabIndex = 8;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup1.Controls.Add(this.uiRichTextBox1);
            this.uiCheckBoxGroup1.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(983, 858);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(547, 222);
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
            this.uiRichTextBox1.Location = new System.Drawing.Point(21, 37);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.ReadOnly = true;
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(362, 124);
            this.uiRichTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRichTextBox1.TabIndex = 0;
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBoxGroup3
            // 
            this.uiCheckBoxGroup3.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup3.Controls.Add(this.pbtn_templateLoad);
            this.uiCheckBoxGroup3.Controls.Add(this.btn_set);
            this.uiCheckBoxGroup3.Controls.Add(this.btn_templateLearn);
            this.uiCheckBoxGroup3.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup3.Location = new System.Drawing.Point(983, 645);
            this.uiCheckBoxGroup3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup3.Name = "uiCheckBoxGroup3";
            this.uiCheckBoxGroup3.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup3.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup3.SelectedIndexes")));
            this.uiCheckBoxGroup3.Size = new System.Drawing.Size(547, 66);
            this.uiCheckBoxGroup3.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup3.TabIndex = 7;
            this.uiCheckBoxGroup3.Text = null;
            this.uiCheckBoxGroup3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbtn_templateLoad
            // 
            this.pbtn_templateLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbtn_templateLoad.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pbtn_templateLoad.Location = new System.Drawing.Point(137, 11);
            this.pbtn_templateLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.pbtn_templateLoad.Name = "pbtn_templateLoad";
            this.pbtn_templateLoad.Size = new System.Drawing.Size(115, 32);
            this.pbtn_templateLoad.Style = Sunny.UI.UIStyle.Custom;
            this.pbtn_templateLoad.TabIndex = 3;
            this.pbtn_templateLoad.Text = "模板加载";
            this.pbtn_templateLoad.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pbtn_templateLoad.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_set
            // 
            this.btn_set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_set.Location = new System.Drawing.Point(268, 11);
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
            this.btn_templateLearn.Location = new System.Drawing.Point(21, 11);
            this.btn_templateLearn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_templateLearn.Name = "btn_templateLearn";
            this.btn_templateLearn.Size = new System.Drawing.Size(98, 32);
            this.btn_templateLearn.Style = Sunny.UI.UIStyle.Custom;
            this.btn_templateLearn.TabIndex = 1;
            this.btn_templateLearn.Text = "模板学习";
            this.btn_templateLearn.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_templateLearn.Click += new System.EventHandler(this.btn_templateLearn_Click);
            // 
            // uiCheckBoxGroup2
            // 
            this.uiCheckBoxGroup2.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBoxGroup2.Controls.Add(this.lb_plcStatus);
            this.uiCheckBoxGroup2.Controls.Add(this.label3);
            this.uiCheckBoxGroup2.Controls.Add(this.lb_cameraStatus);
            this.uiCheckBoxGroup2.Controls.Add(this.label1);
            this.uiCheckBoxGroup2.Controls.Add(this.uiLabel1);
            this.uiCheckBoxGroup2.Controls.Add(this.label5);
            this.uiCheckBoxGroup2.FillColor = System.Drawing.Color.DimGray;
            this.uiCheckBoxGroup2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup2.Location = new System.Drawing.Point(983, 29);
            this.uiCheckBoxGroup2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            this.uiCheckBoxGroup2.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiCheckBoxGroup2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiCheckBoxGroup2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup2.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup2.SelectedIndexes")));
            this.uiCheckBoxGroup2.Size = new System.Drawing.Size(547, 131);
            this.uiCheckBoxGroup2.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBoxGroup2.TabIndex = 5;
            this.uiCheckBoxGroup2.Text = null;
            this.uiCheckBoxGroup2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_plcStatus
            // 
            this.lb_plcStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_plcStatus.ForeColor = System.Drawing.Color.Lime;
            this.lb_plcStatus.Location = new System.Drawing.Point(296, 74);
            this.lb_plcStatus.Name = "lb_plcStatus";
            this.lb_plcStatus.Size = new System.Drawing.Size(82, 23);
            this.lb_plcStatus.TabIndex = 3;
            this.lb_plcStatus.Text = "正常";
            this.lb_plcStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(198, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLC状态:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_cameraStatus
            // 
            this.lb_cameraStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cameraStatus.ForeColor = System.Drawing.Color.Lime;
            this.lb_cameraStatus.Location = new System.Drawing.Point(106, 74);
            this.lb_cameraStatus.Name = "lb_cameraStatus";
            this.lb_cameraStatus.Size = new System.Drawing.Size(71, 23);
            this.lb_cameraStatus.TabIndex = 1;
            this.lb_cameraStatus.Text = "正常";
            this.lb_cameraStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "相机状态:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(3, 15);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(169, 55);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "冲床检测";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(297, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 55);
            this.label5.TabIndex = 6;
            this.label5.Text = "版本号V1.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 27);
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
            this.btnClose.Location = new System.Drawing.Point(1520, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.Size = new System.Drawing.Size(53, 50);
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
            this.titleBar.Size = new System.Drawing.Size(1573, 50);
            this.titleBar.TabIndex = 10;
            // 
            // Frm_PunchPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1573, 1055);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.titleBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_PunchPress";
            this.Text = "冲压设备检测系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPunchPress_FormClosing);
            this.Load += new System.EventHandler(this.FrmPunchPress_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_PunchPress_SizeChanged);
            this.panelContainer.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiCheckBoxGroup7.ResumeLayout(false);
            this.uiCheckBoxGroup6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.uiCheckBoxGroup8.ResumeLayout(false);
            this.uiCheckBoxGroup5.ResumeLayout(false);
            this.uiCheckBoxGroup4.ResumeLayout(false);
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
        private Sunny.UI.UIButton pbtn_templateLoad;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup4;
        private Sunny.UI.UICheckBox cBox_workMode;
        private Sunny.UI.UICheckBox cBox_debugMode;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup6;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup5;
        private Sunny.UI.UICheckBox cBox_downLight;
        private Sunny.UI.UICheckBox cBox_upLight;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup7;
        private Sunny.UI.UILabel lb_gainValue;
        private Sunny.UI.UILabel lb_exposureValue;
        private Sunny.UI.UIButton btn_gainIncrease;
        private Sunny.UI.UIButton btn_gainReduce;
        private Sunny.UI.UIButton btn_exposureIncrease;
        private Sunny.UI.UIButton btn_exposureReduce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup8;
        private Sunny.UI.UILabel lb_angle;
        private Sunny.UI.UIButton btn_angleIncease;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UIButton btn_angleDecrease;
        private Sunny.UI.UILabel lb_y;
        private Sunny.UI.UILabel lb_x;
        private Sunny.UI.UIButton btn_yIncease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UIButton btn_yDecrease;
        private Sunny.UI.UIButton btn_xIncease;
        private Sunny.UI.UIButton btn_xDecrease;
    }
}

