using IMVSFastFeatureMatchModuCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VM.Core;

namespace PunchPressCsharp.UI
{
    public partial class Frm_loadShapeModel : Form
    {
        #region 模型生命周期管理
        public Frm_loadShapeModel()
        {
            InitializeComponent();
        }

        private void Frm_loadShapeModel_Load(object sender, EventArgs e)
        {
            build_ui();
            //IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            //    //  准备模板文件路径
            //    // 可以导入多个模板文件，这里只导入一个
            //    string[] templatePaths = new string[1] { @"D:\Templates\your_template.fmxml" };

            //// 导入模板文件（注意：这会替换模块当前所有模型文件）
            //fastFeatureMatch.ImportModelData(templatePaths);
        }

        private void build_ui()
        {
            list_modelList.Items.Add("模型1");
            list_modelList.Items.Add("模型2");
            list_modelList.Items.Add("模型3");
            list_modelList.Items.Add("模型4");
            list_modelList.Items.Add("模型5");
            list_modelList.Items.Add("模型6");
            list_modelList.Items.Add("模型7");
    

            table_modelInfo.RowCount = 3;
            table_modelInfo.ColumnCount = 1;
            Label lbl1 = new Label { Text = @"训练日期" };
            Label lbl2 = new Label { Text = @"曝光" };
            Label lbl3 = new Label { Text = @"增益" };
            table_modelInfo.Controls.Add(lbl1, 0, 0);
            table_modelInfo.Controls.Add(lbl2, 0, 1);
            table_modelInfo.Controls.Add(lbl3, 0, 3);

            if (list_modelList.Items.Count > 0)
            {
                list_modelList.SelectedIndex = 0;
            }
        }


        #endregion


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_preModel_Click(object sender, EventArgs e)
        {
            int idx = list_modelList.SelectedIndex;
            if (list_modelList.Items.Count == 0) return;
            if (idx <= 0)
            {
                list_modelList.SelectedIndex = list_modelList.Items.Count - 1;
            }
            else
            {
                list_modelList.SelectedIndex = idx - 1;
            }
        }

        private void btn_nextModel_Click(object sender, EventArgs e)
        {
            int idx = list_modelList.SelectedIndex;
            if (list_modelList.Items.Count == 0) return;
            if (idx >= list_modelList.Items.Count - 1 || idx < 0)
            {
                list_modelList.SelectedIndex = 0;
            }
            else
            {
                list_modelList.SelectedIndex = idx + 1;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int idx = list_modelList.SelectedIndex;
            if (idx >= 0 && list_modelList.Items.Count > 0)
            {
                list_modelList.Items.RemoveAt(idx);

                if (list_modelList.Items.Count > 0)
                {
                    if (idx >= list_modelList.Items.Count)
                        list_modelList.SelectedIndex = list_modelList.Items.Count - 1;
                    else
                        list_modelList.SelectedIndex = idx;
                }
            }
        }
    }
}
