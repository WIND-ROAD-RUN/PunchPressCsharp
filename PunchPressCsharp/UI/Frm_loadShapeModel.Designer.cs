namespace PunchPressCsharp.UI
{
    partial class Frm_loadShapeModel
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
            this.tim_getState = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_srcImg = new System.Windows.Forms.PictureBox();
            this.table_modelInfo = new Sunny.UI.UITableLayoutPanel();
            this.btn_delete = new Sunny.UI.UIButton();
            this.btn_loadModel = new Sunny.UI.UIButton();
            this.btn_nextModel = new Sunny.UI.UIButton();
            this.btn_preModel = new Sunny.UI.UIButton();
            this.btn_exit = new Sunny.UI.UIButton();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.roundGroupBox1 = new PunchPressCsharp.Controls.RoundGroupBox();
            this.list_modelList = new Sunny.UI.UIListBox();
            this.roundGroupBox2 = new PunchPressCsharp.Controls.RoundGroupBox();
            this.roundedPanel1 = new PunchPressCsharp.Controls.RoundedPanel();
            this.roundGroupBox3 = new PunchPressCsharp.Controls.RoundGroupBox();
            this.panel1 = new AntdUI.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srcImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.roundGroupBox1.SuspendLayout();
            this.roundGroupBox2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.roundGroupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tim_getState
            // 
            this.tim_getState.Enabled = true;
            this.tim_getState.Interval = 5000;
            // 
            // pictureBox_srcImg
            // 
            this.pictureBox_srcImg.Location = new System.Drawing.Point(23, 32);
            this.pictureBox_srcImg.Name = "pictureBox_srcImg";
            this.pictureBox_srcImg.Size = new System.Drawing.Size(722, 467);
            this.pictureBox_srcImg.TabIndex = 0;
            this.pictureBox_srcImg.TabStop = false;
            // 
            // table_modelInfo
            // 
            this.table_modelInfo.ColumnCount = 2;
            this.table_modelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch, ((byte)(134)));
            this.table_modelInfo.Location = new System.Drawing.Point(7, 30);
            this.table_modelInfo.Name = "table_modelInfo";
            this.table_modelInfo.RowCount = 9;
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.Size = new System.Drawing.Size(267, 178);
            this.table_modelInfo.TabIndex = 0;
            this.table_modelInfo.TagString = null;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Location = new System.Drawing.Point(439, 83);
            this.btn_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 69);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除";
            this.btn_delete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_loadModel
            // 
            this.btn_loadModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_loadModel.Location = new System.Drawing.Point(588, 83);
            this.btn_loadModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_loadModel.Name = "btn_loadModel";
            this.btn_loadModel.Size = new System.Drawing.Size(121, 69);
            this.btn_loadModel.TabIndex = 0;
            this.btn_loadModel.Text = "加载";
            this.btn_loadModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_loadModel.Click += new System.EventHandler(this.btn_loadModel_Click);
            // 
            // btn_nextModel
            // 
            this.btn_nextModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextModel.Location = new System.Drawing.Point(283, 83);
            this.btn_nextModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_nextModel.Name = "btn_nextModel";
            this.btn_nextModel.Size = new System.Drawing.Size(117, 69);
            this.btn_nextModel.TabIndex = 0;
            this.btn_nextModel.Text = "下一个";
            this.btn_nextModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextModel.Click += new System.EventHandler(this.btn_nextModel_Click);
            // 
            // btn_preModel
            // 
            this.btn_preModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_preModel.Location = new System.Drawing.Point(152, 83);
            this.btn_preModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_preModel.Name = "btn_preModel";
            this.btn_preModel.Size = new System.Drawing.Size(113, 69);
            this.btn_preModel.TabIndex = 0;
            this.btn_preModel.Text = "上一个";
            this.btn_preModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_preModel.Click += new System.EventHandler(this.btn_preModel_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(14, 83);
            this.btn_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(118, 69);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "退出";
            this.btn_exit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pic_Close
            // 
            this.pic_Close.BackColor = System.Drawing.Color.Transparent;
            this.pic_Close.Image = global::PunchPressCsharp.Properties.Resources.x;
            this.pic_Close.Location = new System.Drawing.Point(1065, 0);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(49, 49);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Close.TabIndex = 18;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            // 
            // roundGroupBox1
            // 
            this.roundGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.roundGroupBox1.Controls.Add(this.list_modelList);
            this.roundGroupBox1.CornerRadius = 16;
            this.roundGroupBox1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundGroupBox1.Location = new System.Drawing.Point(12, 63);
            this.roundGroupBox1.Name = "roundGroupBox1";
            this.roundGroupBox1.Size = new System.Drawing.Size(286, 526);
            this.roundGroupBox1.TabIndex = 19;
            this.roundGroupBox1.TabStop = false;
            this.roundGroupBox1.Text = "模型列表";
            // 
            // list_modelList
            // 
            this.list_modelList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.list_modelList.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.list_modelList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_modelList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.list_modelList.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_modelList.ItemSelectForeColor = System.Drawing.Color.White;
            this.list_modelList.Location = new System.Drawing.Point(17, 31);
            this.list_modelList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_modelList.MinimumSize = new System.Drawing.Size(1, 1);
            this.list_modelList.Name = "list_modelList";
            this.list_modelList.Padding = new System.Windows.Forms.Padding(2);
            this.list_modelList.RectColor = System.Drawing.Color.Gray;
            this.list_modelList.ShowText = false;
            this.list_modelList.Size = new System.Drawing.Size(250, 468);
            this.list_modelList.TabIndex = 13;
            this.list_modelList.Text = "uiListBox1";
            this.list_modelList.SelectedIndexChanged += new System.EventHandler(this.list_modelList_SelectedIndexChanged);
            // 
            // roundGroupBox2
            // 
            this.roundGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.roundGroupBox2.Controls.Add(this.pictureBox_srcImg);
            this.roundGroupBox2.CornerRadius = 16;
            this.roundGroupBox2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundGroupBox2.Location = new System.Drawing.Point(335, 64);
            this.roundGroupBox2.Name = "roundGroupBox2";
            this.roundGroupBox2.Size = new System.Drawing.Size(774, 528);
            this.roundGroupBox2.TabIndex = 20;
            this.roundGroupBox2.TabStop = false;
            this.roundGroupBox2.Text = "图片列表";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.btn_loadModel);
            this.roundedPanel1.Controls.Add(this.btn_delete);
            this.roundedPanel1.Controls.Add(this.btn_exit);
            this.roundedPanel1.Controls.Add(this.btn_preModel);
            this.roundedPanel1.Controls.Add(this.btn_nextModel);
            this.roundedPanel1.CornerRadius = 16;
            this.roundedPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(335, 596);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.roundedPanel1.Size = new System.Drawing.Size(773, 219);
            this.roundedPanel1.TabIndex = 21;
            // 
            // roundGroupBox3
            // 
            this.roundGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.roundGroupBox3.Controls.Add(this.table_modelInfo);
            this.roundGroupBox3.CornerRadius = 16;
            this.roundGroupBox3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundGroupBox3.Location = new System.Drawing.Point(13, 600);
            this.roundGroupBox3.Name = "roundGroupBox3";
            this.roundGroupBox3.Size = new System.Drawing.Size(285, 219);
            this.roundGroupBox3.TabIndex = 22;
            this.roundGroupBox3.TabStop = false;
            this.roundGroupBox3.Text = "模型参数";
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.pic_Close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 56);
            this.panel1.TabIndex = 23;
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
            this.uiLabel1.Text = " 视觉检测-模板选择";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_loadShapeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 820);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundGroupBox3);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundGroupBox2);
            this.Controls.Add(this.roundGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_loadShapeModel";
            this.Text = "Frm_loadShapeModel";
            this.Load += new System.EventHandler(this.Frm_loadShapeModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srcImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.roundGroupBox1.ResumeLayout(false);
            this.roundGroupBox2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundGroupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tim_getState;
        private Sunny.UI.UIListBox list_modelList;
        private Sunny.UI.UIButton btn_loadModel;
        private Sunny.UI.UIButton btn_nextModel;
        private Sunny.UI.UIButton btn_preModel;
        private Sunny.UI.UIButton btn_exit;
        private Sunny.UI.UIButton btn_delete;
        private System.Windows.Forms.PictureBox pictureBox_srcImg;
        private Sunny.UI.UITableLayoutPanel table_modelInfo;
        private System.Windows.Forms.PictureBox pic_Close;
        private Controls.RoundGroupBox roundGroupBox1;
        private Controls.RoundGroupBox roundGroupBox2;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundGroupBox roundGroupBox3;
        private AntdUI.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
    }
}