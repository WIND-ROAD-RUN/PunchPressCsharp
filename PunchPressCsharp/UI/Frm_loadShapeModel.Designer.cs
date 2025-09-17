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
            this.titleBar = new System.Windows.Forms.Panel();
            this.tim_getState = new System.Windows.Forms.Timer(this.components);
            this.list_modelList = new Sunny.UI.UIListBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.label_proImg = new Sunny.UI.UILabel();
            this.label_sourceImg = new Sunny.UI.UILabel();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.table_modelInfo = new Sunny.UI.UITableLayoutPanel();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.btn_delete = new Sunny.UI.UIButton();
            this.btn_loadModel = new Sunny.UI.UIButton();
            this.btn_nextModel = new Sunny.UI.UIButton();
            this.btn_preModel = new Sunny.UI.UIButton();
            this.btn_exit = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1121, 40);
            this.titleBar.TabIndex = 12;
            // 
            // tim_getState
            // 
            this.tim_getState.Enabled = true;
            this.tim_getState.Interval = 5000;
            // 
            // list_modelList
            // 
            this.list_modelList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_modelList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.list_modelList.ItemSelectForeColor = System.Drawing.Color.White;
            this.list_modelList.Location = new System.Drawing.Point(19, 37);
            this.list_modelList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_modelList.MinimumSize = new System.Drawing.Size(1, 1);
            this.list_modelList.Name = "list_modelList";
            this.list_modelList.Padding = new System.Windows.Forms.Padding(2);
            this.list_modelList.ShowText = false;
            this.list_modelList.Size = new System.Drawing.Size(251, 488);
            this.list_modelList.TabIndex = 13;
            this.list_modelList.Text = "uiListBox1";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.list_modelList);
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 45);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(281, 548);
            this.uiGroupBox1.TabIndex = 14;
            this.uiGroupBox1.Text = "模型列表";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.label_proImg);
            this.uiGroupBox2.Controls.Add(this.label_sourceImg);
            this.uiGroupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(302, 45);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(806, 548);
            this.uiGroupBox2.TabIndex = 15;
            this.uiGroupBox2.Text = "模型图片";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_proImg
            // 
            this.label_proImg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_proImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_proImg.Location = new System.Drawing.Point(401, 37);
            this.label_proImg.Name = "label_proImg";
            this.label_proImg.Size = new System.Drawing.Size(367, 488);
            this.label_proImg.TabIndex = 0;
            // 
            // label_sourceImg
            // 
            this.label_sourceImg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sourceImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_sourceImg.Location = new System.Drawing.Point(20, 37);
            this.label_sourceImg.Name = "label_sourceImg";
            this.label_sourceImg.Size = new System.Drawing.Size(347, 488);
            this.label_sourceImg.TabIndex = 0;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.table_modelInfo);
            this.uiGroupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox3.Location = new System.Drawing.Point(13, 603);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(281, 203);
            this.uiGroupBox3.TabIndex = 16;
            this.uiGroupBox3.Text = "模型详细信息";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // table_modelInfo
            // 
            this.table_modelInfo.ColumnCount = 2;
            this.table_modelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.Location = new System.Drawing.Point(19, 35);
            this.table_modelInfo.Name = "table_modelInfo";
            this.table_modelInfo.RowCount = 3;
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_modelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_modelInfo.Size = new System.Drawing.Size(251, 156);
            this.table_modelInfo.TabIndex = 0;
            this.table_modelInfo.TagString = null;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.btn_delete);
            this.uiGroupBox4.Controls.Add(this.btn_loadModel);
            this.uiGroupBox4.Controls.Add(this.btn_nextModel);
            this.uiGroupBox4.Controls.Add(this.btn_preModel);
            this.uiGroupBox4.Controls.Add(this.btn_exit);
            this.uiGroupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox4.Location = new System.Drawing.Point(302, 603);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(806, 203);
            this.uiGroupBox4.TabIndex = 17;
            this.uiGroupBox4.Text = null;
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Location = new System.Drawing.Point(462, 73);
            this.btn_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 69);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除";
            this.btn_delete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_loadModel
            // 
            this.btn_loadModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_loadModel.Location = new System.Drawing.Point(621, 73);
            this.btn_loadModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_loadModel.Name = "btn_loadModel";
            this.btn_loadModel.Size = new System.Drawing.Size(147, 69);
            this.btn_loadModel.TabIndex = 0;
            this.btn_loadModel.Text = "加载";
            this.btn_loadModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_nextModel
            // 
            this.btn_nextModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextModel.Location = new System.Drawing.Point(309, 73);
            this.btn_nextModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_nextModel.Name = "btn_nextModel";
            this.btn_nextModel.Size = new System.Drawing.Size(147, 69);
            this.btn_nextModel.TabIndex = 0;
            this.btn_nextModel.Text = "下一个";
            this.btn_nextModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextModel.Click += new System.EventHandler(this.btn_nextModel_Click);
            // 
            // btn_preModel
            // 
            this.btn_preModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preModel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_preModel.Location = new System.Drawing.Point(156, 73);
            this.btn_preModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_preModel.Name = "btn_preModel";
            this.btn_preModel.Size = new System.Drawing.Size(147, 69);
            this.btn_preModel.TabIndex = 0;
            this.btn_preModel.Text = "上一个";
            this.btn_preModel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_preModel.Click += new System.EventHandler(this.btn_preModel_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(3, 73);
            this.btn_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(147, 69);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "退出";
            this.btn_exit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Frm_loadShapeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 820);
            this.Controls.Add(this.uiGroupBox4);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.titleBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_loadShapeModel";
            this.Text = "Frm_loadShapeModel";
            this.Load += new System.EventHandler(this.Frm_loadShapeModel_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Timer tim_getState;
        private Sunny.UI.UIListBox list_modelList;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel label_proImg;
        private Sunny.UI.UILabel label_sourceImg;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UITableLayoutPanel table_modelInfo;
        private Sunny.UI.UIButton btn_loadModel;
        private Sunny.UI.UIButton btn_nextModel;
        private Sunny.UI.UIButton btn_preModel;
        private Sunny.UI.UIButton btn_exit;
        private Sunny.UI.UIButton btn_delete;
    }
}