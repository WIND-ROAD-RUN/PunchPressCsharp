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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.tab_stepManager.SuspendLayout();
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
            this.tab_stepManager.Location = new System.Drawing.Point(755, 63);
            this.tab_stepManager.MainPage = "";
            this.tab_stepManager.Name = "tab_stepManager";
            this.tab_stepManager.SelectedIndex = 0;
            this.tab_stepManager.Size = new System.Drawing.Size(416, 662);
            this.tab_stepManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_stepManager.TabIndex = 25;
            this.tab_stepManager.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(416, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_visualCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 737);
            this.Controls.Add(this.tab_stepManager);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_visualCorrection";
            this.Text = "frm_visualCorrection";
            this.Load += new System.EventHandler(this.Frm_visualCorrection_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.tab_stepManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox pic_Close;
        private Sunny.UI.UITabControl tab_stepManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}