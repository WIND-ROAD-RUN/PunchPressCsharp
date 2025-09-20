using ImageSourceModuleCs;
using IMVSHPFeatureMatchModuCs;
using PunchPressCsharp.Data;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VM.Core;
using static PunchPressCsharp.Data.Config;

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
            table_modelInfo.RowCount = 8;
            table_modelInfo.ColumnCount = 2;
            ReadModelHomeDirectory();
            if (list_modelList.Items.Count > 0)
            {
                list_modelList.SelectedIndex = 0;
            }
            else
            {
                SetTableViewTitle();
            }


        }

        private void ReadModelHomeDirectory()
        {
            list_modelList.Items.Clear();

            GlobalData.Instance.modelManager.ReadModelHomeDirectory();

            var listNameWithPath= GlobalData.Instance.modelManager.listNameWithPath;

            foreach (var name in GlobalData.Instance.modelManager.listNameWithPath) {
                list_modelList.Items.Add(name.Key);

            }

        }

        #endregion

        #region UI事件触发

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
            var listNameWithPath = GlobalData.Instance.modelManager.listNameWithPath;

            int idx = list_modelList.SelectedIndex;
            if (idx >= 0 && list_modelList.Items.Count > 0)
            {
                var result = MessageBox.Show(@"确定要删除选中的模型吗？", @"删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (pictureBox_srcImg.Image != null)
                    {
                        pictureBox_srcImg.Image.Dispose();
                        pictureBox_srcImg.Image = null;
                    }

                    string modelName = list_modelList.Items[idx].ToString();
                    if (listNameWithPath.TryGetValue(modelName, out string modelPath))
                    {
                        try
                        {
                            if (System.IO.Directory.Exists(modelPath))
                            {
                                System.IO.Directory.Delete(modelPath, true);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($@"删除模型文件夹失败：{ex.Message}", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        listNameWithPath.Remove(modelName);
                    }
                    list_modelList.Items.RemoveAt(idx);

                    if (list_modelList.Items.Count > 0)
                    {
                        if (idx >= list_modelList.Items.Count)
                        {
                            list_modelList.SelectedIndex = list_modelList.Items.Count - 1;
                        }
                        else
                        {
                            list_modelList.SelectedIndex = idx;
                        }
                    }
                }
            }
        }

        private void list_modelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listNameWithPath = GlobalData.Instance.modelManager.listNameWithPath;

            if (list_modelList.SelectedIndex >= 0)
            {
                string selectedName = list_modelList.SelectedItem.ToString();

                if (listNameWithPath.TryGetValue(selectedName, out string configPath))
                {
                    var modelConfig = ModelConfig.LoadFromFile(configPath + @"\" + GlobalPath.ModelConfigName);

                    table_modelInfo.Controls.Clear();
                    SetTableViewTitle();

                    Label val1 = new Label { Text = modelConfig.trainDate };
                    Label val2 = new Label { Text = modelConfig.cameraCfg.exposureTime.ToString() };
                    Label val3 = new Label { Text = modelConfig.cameraCfg.gain.ToString() };
                    if (modelConfig.lightCfg.isUpLightOpen)
                    {
                        Label val4 = new Label { Text = @"开启" };
                        table_modelInfo.Controls.Add(val4, 1, 3);
                    }
                    else
                    {
                        Label val4 = new Label { Text = @"关闭" };
                        table_modelInfo.Controls.Add(val4, 1, 3);
                    }

                    if (modelConfig.lightCfg.isDownLightOpen)
                    {
                        Label val5 = new Label { Text = @"开启" };
                        table_modelInfo.Controls.Add(val5, 1, 4);
                    }
                    else
                    {
                        Label val5 = new Label { Text = @"关闭" };
                        table_modelInfo.Controls.Add(val5, 1, 4);
                    }



                    Label val6 = new Label { Text = modelConfig.correction.centralX.ToString("F1") };
                    Label val7 = new Label { Text = modelConfig.correction.centralY.ToString("F1") };
                    Label val8 = new Label { Text = modelConfig.correction.angle.ToString("F1") };
                    table_modelInfo.Controls.Add(val1, 1, 0);
                    table_modelInfo.Controls.Add(val2, 1, 1);
                    table_modelInfo.Controls.Add(val3, 1, 2);
                    table_modelInfo.Controls.Add(val6, 1, 5);
                    table_modelInfo.Controls.Add(val7, 1, 6);
                    table_modelInfo.Controls.Add(val8, 1, 7);

                    string srcImgPath = configPath + @"\" + GlobalPath.SourceImgName;

                    if (System.IO.File.Exists(srcImgPath))
                    {
                        using (var fs = new System.IO.FileStream(srcImgPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            pictureBox_srcImg.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        pictureBox_srcImg.Image = null;
                    }
                }
            }
            else
            {
                table_modelInfo.Controls.Clear();
                SetTableViewTitle();
            }

        }

        #endregion

        #region 提炼函数

        private void SetTableViewTitle()
        {
            Label lbl1 = new Label { Text = @"训练日期" };
            Label lbl2 = new Label { Text = @"曝光" };
            Label lbl3 = new Label { Text = @"增益" };
            Label lbl4 = new Label { Text = @"上光源" };
            Label lbl5 = new Label { Text = @"下光源" };
            Label lbl6 = new Label { Text = @"中心坐标x偏移量" };
            Label lbl7 = new Label { Text = @"中心坐标y偏移量" };
            Label lbl8 = new Label { Text = @"角度偏移量" };
            table_modelInfo.Controls.Add(lbl1, 0, 0);
            table_modelInfo.Controls.Add(lbl2, 0, 1);
            table_modelInfo.Controls.Add(lbl3, 0, 2);
            table_modelInfo.Controls.Add(lbl4, 0, 3);
            table_modelInfo.Controls.Add(lbl5, 0, 4);
            table_modelInfo.Controls.Add(lbl6, 0, 5);
            table_modelInfo.Controls.Add(lbl7, 0, 6);
            table_modelInfo.Controls.Add(lbl8, 0, 7);
        }

        private void btn_loadModel_Click(object sender, EventArgs e)
        {
            var listNameWithPath = GlobalData.Instance.modelManager.listNameWithPath;

            // 获取当前选中的模型名称
            string selectedModelName = list_modelList.SelectedItem?.ToString();

            string path = null;
            if (!string.IsNullOrEmpty(selectedModelName) && listNameWithPath.ContainsKey(selectedModelName))
            {
                path = listNameWithPath[selectedModelName] + "\\" + GlobalPath.ModelBinName;
                if (!System.IO.File.Exists(path))
                {
                    MessageBox.Show("未找到模型文件或模型文件丢失", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {

                    System.IO.File.Copy(path, GlobalPath.ModelLoadPath, true);
                }
            }
            else
            {
                MessageBox.Show("未找到模型路径或未选择模型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
            var imageSource = (ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];

            FeatureMatch.ImportModel(path);


            MessageBox.Show($@"加载成功: {selectedModelName}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        #endregion


    }
}
