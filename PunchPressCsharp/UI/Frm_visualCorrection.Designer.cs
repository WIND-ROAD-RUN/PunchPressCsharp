namespace PunchPressCsharp.UI
{
    partial class Frm_visualCorrection
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
            this.panel1 = new AntdUI.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.tab_stepManager = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btn_punchForDistortion = new Sunny.UI.UIButton();
            this.btn_nextStepForDistortion = new Sunny.UI.UIButton();
            this.btn_calibrationForDistortion = new Sunny.UI.UIButton();
            this.btn_calibrationForCalibration = new Sunny.UI.UIButton();
            this.btn_finish = new Sunny.UI.UIButton();
            this.proBar_forNineCalibration = new Sunny.UI.UIProcessBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.tab_stepManager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.pic_Close);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 56);
            this.panel1.TabIndex = 24;
            this.panel1.Text = "panel1";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(12, 8);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(286, 40);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = " 视觉检测-视觉矫正";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_Close
            // 
            this.pic_Close.BackColor = System.Drawing.Color.Transparent;
            this.pic_Close.Image = global::PunchPressCsharp.Properties.Resources.x;
            this.pic_Close.Location = new System.Drawing.Point(1131, 4);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(49, 49);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Close.TabIndex = 18;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            // 
            // tab_stepManager
            // 
            this.tab_stepManager.Controls.Add(this.tabPage1);
            this.tab_stepManager.Controls.Add(this.tabPage2);
            this.tab_stepManager.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_stepManager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_stepManager.ItemSize = new System.Drawing.Size(150, 40);
            this.tab_stepManager.Location = new System.Drawing.Point(641, 63);
            this.tab_stepManager.MainPage = "";
            this.tab_stepManager.Name = "tab_stepManager";
            this.tab_stepManager.SelectedIndex = 0;
            this.tab_stepManager.Size = new System.Drawing.Size(530, 662);
            this.tab_stepManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_stepManager.TabIndex = 25;
            this.tab_stepManager.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_nextStepForDistortion);
            this.tabPage1.Controls.Add(this.btn_calibrationForDistortion);
            this.tabPage1.Controls.Add(this.btn_punchForDistortion);
            this.tabPage1.Controls.Add(this.uiLabel2);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(530, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.proBar_forNineCalibration);
            this.tabPage2.Controls.Add(this.btn_finish);
            this.tabPage2.Controls.Add(this.btn_calibrationForCalibration);
            this.tabPage2.Controls.Add(this.uiLabel3);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(530, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(13, 63);
            this.vmRenderControl1.Margin = new System.Windows.Forms.Padding(4);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(603, 662);
            this.vmRenderControl1.TabIndex = 26;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(16, 14);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(144, 29);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "畸变矫正";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(16, 15);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(144, 29);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "九点标定";
            // 
            // btn_punchForDistortion
            // 
            this.btn_punchForDistortion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punchForDistortion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_punchForDistortion.Location = new System.Drawing.Point(19, 365);
            this.btn_punchForDistortion.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_punchForDistortion.Name = "btn_punchForDistortion";
            this.btn_punchForDistortion.Size = new System.Drawing.Size(495, 65);
            this.btn_punchForDistortion.TabIndex = 2;
            this.btn_punchForDistortion.Text = "冲压";
            this.btn_punchForDistortion.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_nextStepForDistortion
            // 
            this.btn_nextStepForDistortion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextStepForDistortion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextStepForDistortion.Location = new System.Drawing.Point(19, 535);
            this.btn_nextStepForDistortion.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_nextStepForDistortion.Name = "btn_nextStepForDistortion";
            this.btn_nextStepForDistortion.Size = new System.Drawing.Size(495, 65);
            this.btn_nextStepForDistortion.TabIndex = 3;
            this.btn_nextStepForDistortion.Text = "下一步";
            this.btn_nextStepForDistortion.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_calibrationForDistortion
            // 
            this.btn_calibrationForDistortion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calibrationForDistortion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_calibrationForDistortion.Location = new System.Drawing.Point(19, 450);
            this.btn_calibrationForDistortion.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_calibrationForDistortion.Name = "btn_calibrationForDistortion";
            this.btn_calibrationForDistortion.Size = new System.Drawing.Size(495, 65);
            this.btn_calibrationForDistortion.TabIndex = 2;
            this.btn_calibrationForDistortion.Text = "标定";
            this.btn_calibrationForDistortion.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_calibrationForCalibration
            // 
            this.btn_calibrationForCalibration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calibrationForCalibration.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_calibrationForCalibration.Location = new System.Drawing.Point(19, 435);
            this.btn_calibrationForCalibration.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_calibrationForCalibration.Name = "btn_calibrationForCalibration";
            this.btn_calibrationForCalibration.Size = new System.Drawing.Size(495, 65);
            this.btn_calibrationForCalibration.TabIndex = 3;
            this.btn_calibrationForCalibration.Text = "标定";
            this.btn_calibrationForCalibration.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_finish
            // 
            this.btn_finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finish.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_finish.Location = new System.Drawing.Point(19, 535);
            this.btn_finish.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(495, 65);
            this.btn_finish.TabIndex = 4;
            this.btn_finish.Text = "完成";
            this.btn_finish.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // proBar_forNineCalibration
            // 
            this.proBar_forNineCalibration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.proBar_forNineCalibration.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proBar_forNineCalibration.Location = new System.Drawing.Point(19, 74);
            this.proBar_forNineCalibration.MinimumSize = new System.Drawing.Size(3, 3);
            this.proBar_forNineCalibration.Name = "proBar_forNineCalibration";
            this.proBar_forNineCalibration.Size = new System.Drawing.Size(495, 50);
            this.proBar_forNineCalibration.TabIndex = 5;
            this.proBar_forNineCalibration.Text = "uiProcessBar1";
            // 
            // Frm_visualCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 737);
            this.Controls.Add(this.vmRenderControl1);
            this.Controls.Add(this.tab_stepManager);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_visualCorrection";
            this.Text = "frm_visualCorrection";
            this.Load += new System.EventHandler(this.Frm_visualCorrection_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.tab_stepManager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox pic_Close;
        private Sunny.UI.UITabControl tab_stepManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton btn_punchForDistortion;
        private Sunny.UI.UIButton btn_nextStepForDistortion;
        private Sunny.UI.UIButton btn_calibrationForDistortion;
        private Sunny.UI.UIButton btn_calibrationForCalibration;
        private Sunny.UI.UIButton btn_finish;
        private Sunny.UI.UIProcessBar proBar_forNineCalibration;
    }
}