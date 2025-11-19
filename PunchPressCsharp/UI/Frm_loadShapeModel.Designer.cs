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
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new AntdUI.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.roundGroupBox3 = new PunchPressCsharp.Controls.RoundGroupBox();
            this.table_modelInfo = new Sunny.UI.UITableLayoutPanel();
            this.roundedPanel1 = new PunchPressCsharp.Controls.RoundedPanel();
            this.btn_loadModel = new Sunny.UI.UIButton();
            this.btn_delete = new Sunny.UI.UIButton();
            this.btn_exit = new Sunny.UI.UIButton();
            this.btn_preModel = new Sunny.UI.UIButton();
            this.btn_nextModel = new Sunny.UI.UIButton();
            this.roundGroupBox2 = new PunchPressCsharp.Controls.RoundGroupBox();
            this.pictureBox_srcImg = new System.Windows.Forms.PictureBox();
            this.roundGroupBox1 = new PunchPressCsharp.Controls.RoundGroupBox();
            this.list_modelList = new Sunny.UI.UIListBox();
            this.btn_listByRole = new Sunny.UI.UIButton();
            this.btn_listAll = new Sunny.UI.UIButton();
            this.textBox_searchStr = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.panel1.SuspendLayout();
            this.roundGroupBox3.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.roundGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srcImg)).BeginInit();
            this.roundGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tim_getState
            // 
            this.tim_getState.Enabled = true;
            this.tim_getState.Interval = 5000;
            // 
            // pic_Close
            // 
            this.pic_Close.BackColor = System.Drawing.Color.Transparent;
            this.pic_Close.Image = global::PunchPressCsharp.Properties.Resources.x;
            this.pic_Close.Location = new System.Drawing.Point(1438, 0);
            this.pic_Close.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(65, 61);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Close.TabIndex = 18;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.pic_Close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1531, 70);
            this.panel1.TabIndex = 23;
            this.panel1.Text = "panel1";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(16, 10);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(381, 50);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = " 视觉检测-模板选择";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundGroupBox3
            // 
            this.roundGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.roundGroupBox3.Controls.Add(this.table_modelInfo);
            this.roundGroupBox3.CornerRadius = 16;
            this.roundGroupBox3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundGroupBox3.Location = new System.Drawing.Point(17, 750);
            this.roundGroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.roundGroupBox3.Name = "roundGroupBox3";
            this.roundGroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.roundGroupBox3.Size = new System.Drawing.Size(380, 290);
            this.roundGroupBox3.TabIndex = 22;
            this.roundGroupBox3.TabStop = false;
            this.roundGroupBox3.Text = "模型参数";
            // 
            // table_modelInfo
            // 
            this.table_modelInfo.AutoSize = true;
            this.table_modelInfo.ColumnCount = 2;
            this.table_modelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch, ((byte)(134)));
            this.table_modelInfo.Location = new System.Drawing.Point(8, 31);
            this.table_modelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.table_modelInfo.Name = "table_modelInfo";
            this.table_modelInfo.RowCount = 9;
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table_modelInfo.Size = new System.Drawing.Size(356, 251);
            this.table_modelInfo.TabIndex = 0;
            this.table_modelInfo.TagString = null;
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
            this.roundedPanel1.Location = new System.Drawing.Point(447, 745);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.roundedPanel1.Size = new System.Drawing.Size(1031, 290);
            this.roundedPanel1.TabIndex = 21;
            // 
            // btn_loadModel
            // 
            this.btn_loadModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_loadModel.Location = new System.Drawing.Point(784, 104);
            this.btn_loadModel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_loadModel.Name = "btn_loadModel";
            this.btn_loadModel.Size = new System.Drawing.Size(161, 86);
            this.btn_loadModel.TabIndex = 0;
            this.btn_loadModel.Text = "加载";
            this.btn_loadModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_loadModel.Click += new System.EventHandler(this.btn_loadModel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Location = new System.Drawing.Point(585, 104);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(160, 86);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除";
            this.btn_delete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(19, 104);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(157, 86);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "退出";
            this.btn_exit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_preModel
            // 
            this.btn_preModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_preModel.Location = new System.Drawing.Point(203, 104);
            this.btn_preModel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_preModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_preModel.Name = "btn_preModel";
            this.btn_preModel.Size = new System.Drawing.Size(151, 86);
            this.btn_preModel.TabIndex = 0;
            this.btn_preModel.Text = "上一个";
            this.btn_preModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_preModel.Click += new System.EventHandler(this.btn_preModel_Click);
            // 
            // btn_nextModel
            // 
            this.btn_nextModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextModel.Location = new System.Drawing.Point(377, 104);
            this.btn_nextModel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nextModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_nextModel.Name = "btn_nextModel";
            this.btn_nextModel.Size = new System.Drawing.Size(156, 86);
            this.btn_nextModel.TabIndex = 0;
            this.btn_nextModel.Text = "下一个";
            this.btn_nextModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextModel.Click += new System.EventHandler(this.btn_nextModel_Click);
            // 
            // roundGroupBox2
            // 
            this.roundGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.roundGroupBox2.Controls.Add(this.pictureBox_srcImg);
            this.roundGroupBox2.CornerRadius = 16;
            this.roundGroupBox2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundGroupBox2.Location = new System.Drawing.Point(447, 80);
            this.roundGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.roundGroupBox2.Name = "roundGroupBox2";
            this.roundGroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.roundGroupBox2.Size = new System.Drawing.Size(1032, 660);
            this.roundGroupBox2.TabIndex = 20;
            this.roundGroupBox2.TabStop = false;
            this.roundGroupBox2.Text = "图片列表";
            // 
            // pictureBox_srcImg
            // 
            this.pictureBox_srcImg.Location = new System.Drawing.Point(31, 40);
            this.pictureBox_srcImg.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_srcImg.Name = "pictureBox_srcImg";
            this.pictureBox_srcImg.Size = new System.Drawing.Size(963, 584);
            this.pictureBox_srcImg.TabIndex = 0;
            this.pictureBox_srcImg.TabStop = false;
            // 
            // roundGroupBox1
            // 
            this.roundGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.roundGroupBox1.Controls.Add(this.textBox_searchStr);
            this.roundGroupBox1.Controls.Add(this.btn_listAll);
            this.roundGroupBox1.Controls.Add(this.btn_listByRole);
            this.roundGroupBox1.Controls.Add(this.list_modelList);
            this.roundGroupBox1.CornerRadius = 16;
            this.roundGroupBox1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundGroupBox1.Location = new System.Drawing.Point(16, 79);
            this.roundGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.roundGroupBox1.Name = "roundGroupBox1";
            this.roundGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.roundGroupBox1.Size = new System.Drawing.Size(381, 658);
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
            this.list_modelList.Location = new System.Drawing.Point(23, 155);
            this.list_modelList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.list_modelList.MinimumSize = new System.Drawing.Size(1, 1);
            this.list_modelList.Name = "list_modelList";
            this.list_modelList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_modelList.RectColor = System.Drawing.Color.Gray;
            this.list_modelList.ShowText = false;
            this.list_modelList.Size = new System.Drawing.Size(333, 469);
            this.list_modelList.TabIndex = 13;
            this.list_modelList.Text = "uiListBox1";
            this.list_modelList.SelectedIndexChanged += new System.EventHandler(this.list_modelList_SelectedIndexChanged);
            // 
            // btn_listByRole
            // 
            this.btn_listByRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listByRole.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_listByRole.Location = new System.Drawing.Point(212, 98);
            this.btn_listByRole.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_listByRole.Name = "btn_listByRole";
            this.btn_listByRole.Size = new System.Drawing.Size(144, 35);
            this.btn_listByRole.TabIndex = 14;
            this.btn_listByRole.Text = "筛选";
            this.btn_listByRole.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_listByRole.Click += new System.EventHandler(this.btn_listByRole_Click);
            // 
            // btn_listAll
            // 
            this.btn_listAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listAll.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_listAll.Location = new System.Drawing.Point(23, 98);
            this.btn_listAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_listAll.Name = "btn_listAll";
            this.btn_listAll.Size = new System.Drawing.Size(158, 35);
            this.btn_listAll.TabIndex = 15;
            this.btn_listAll.Text = "查看所有";
            this.btn_listAll.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_listAll.Click += new System.EventHandler(this.btn_listAll_Click);
            // 
            // textBox_searchStr
            // 
            this.textBox_searchStr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_searchStr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_searchStr.Location = new System.Drawing.Point(23, 54);
            this.textBox_searchStr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_searchStr.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBox_searchStr.Name = "textBox_searchStr";
            this.textBox_searchStr.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_searchStr.ShowText = false;
            this.textBox_searchStr.Size = new System.Drawing.Size(333, 36);
            this.textBox_searchStr.TabIndex = 16;
            this.textBox_searchStr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox_searchStr.Watermark = "";
            // 
            // Frm_loadShapeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 1025);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundGroupBox3);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundGroupBox2);
            this.Controls.Add(this.roundGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_loadShapeModel";
            this.Text = "Frm_loadShapeModel";
            this.Load += new System.EventHandler(this.Frm_loadShapeModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.roundGroupBox3.ResumeLayout(false);
            this.roundGroupBox3.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_srcImg)).EndInit();
            this.roundGroupBox1.ResumeLayout(false);
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
        private Sunny.UI.UITextBox textBox_searchStr;
        private Sunny.UI.UIButton btn_listAll;
        private Sunny.UI.UIButton btn_listByRole;
    }
}