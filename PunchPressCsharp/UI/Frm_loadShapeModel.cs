using IMVSFastFeatureMatchModuCs;
using PunchPressCsharp.Data;
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
            table_modelInfo.RowCount = 3;
            table_modelInfo.ColumnCount = 2;
            ReadModelHomeDirectory();
            if (list_modelList.Items.Count > 0)
            {
                list_modelList.SelectedIndex = 0;
            }
            else
            {
                Label lbl1 = new Label { Text = @"训练日期" };
                Label lbl2 = new Label { Text = @"曝光" };
                Label lbl3 = new Label { Text = @"增益" };
                table_modelInfo.Controls.Add(lbl1, 0, 0);
                table_modelInfo.Controls.Add(lbl2, 0, 1);
                table_modelInfo.Controls.Add(lbl3, 0, 3);
            }

            
        }

        private void ReadModelHomeDirectory()
        {
            var path = GlobalPath.ModelHome;
            if (System.IO.Directory.Exists(path))
            {
                var dirs = System.IO.Directory.GetDirectories(path);
                var folderList = new List<(string Name, DateTime Time)>();

                foreach (var dir in dirs)
                {
                    var folderName = System.IO.Path.GetFileName(dir);
                    DateTime time;
                    // 尝试解析为日期
                    if (DateTime.TryParse(folderName, out time))
                    {
                        folderList.Add((folderName, time));
                    }
                    // 如果是纯数字，按数字转为时间（如时间戳或年月日等，可根据实际需求调整）
                    else if (long.TryParse(folderName, out long num))
                    {
                        // 这里假设数字为yyyyMMdd格式
                        if (folderName.Length == 8)
                        {
                            if (DateTime.TryParseExact(folderName, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out time))
                            {
                                folderList.Add((folderName, time));
                            }
                        }
                    }
                }

                var sortedList = folderList
                    .OrderByDescending(f => f.Time)
                    .Select(f => (Name: f.Name, Path: System.IO.Path.Combine(path, f.Name)))
                    .ToList();


                foreach (var dir in sortedList)
                {
                    string modelConfigPath = dir.Path + @"\" + GlobalPath.ModelConfigName;

                    // 检查配置文件是否存在，并捕获异常
                    if (System.IO.File.Exists(modelConfigPath))
                    {
                        try
                        {
                            ModelConfig.LoadFromFile(modelConfigPath);
                            list_modelList.Items.Add(dir.Name);
                            listNameWithPath.Add(dir.Name, dir.Path);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"配置文件格式错误或无法读取：{ex.Message}");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"配置文件不存在！:{dir.Path}");
                        return;
                    }
                }
            }
        }

        public Dictionary<string, string> listNameWithPath = new Dictionary<string, string>();

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

        private void list_modelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_modelList.SelectedIndex >= 0)
            {
                string selectedName = list_modelList.SelectedItem.ToString();

                if (listNameWithPath.TryGetValue(selectedName, out string configPath))
                {
                    //TODO:需要添加保护措施，防止文件不存在或格式错误
                    var modelConfig = ModelConfig.LoadFromFile(configPath + @"\" + GlobalPath.ModelConfigName);
             
                    // 清除旧的标签
                    table_modelInfo.Controls.Clear();
                    // 重新添加标题标签
                    Label lbl1 = new Label { Text = @"训练日期" };
                    Label lbl2 = new Label { Text = @"曝光" };
                    Label lbl3 = new Label { Text = @"增益" };
                    table_modelInfo.Controls.Add(lbl1, 0, 0);
                    table_modelInfo.Controls.Add(lbl2, 0, 1);
                    table_modelInfo.Controls.Add(lbl3, 0, 2);
                    // 添加新的数据标签
                    Label val1 = new Label { Text = modelConfig.trainDate };
                    Label val2 = new Label { Text = modelConfig.exposureTime.ToString() };
                    Label val3 = new Label { Text = modelConfig.gain.ToString() };
                    table_modelInfo.Controls.Add(val1, 1, 0);
                    table_modelInfo.Controls.Add(val2, 1, 1);
                    table_modelInfo.Controls.Add(val3, 1, 2);

                    string proImgPath = configPath + @"\" + GlobalPath.ProImgName;
                    string srcImgPath = configPath + @"\" + GlobalPath.SourceImgName;

                    if (System.IO.File.Exists(proImgPath))
                    {
                        Image proImg = Image.FromFile(proImgPath);
                        pictureBox_proImg.Image = proImg;
                    }
                    else
                    {
                        pictureBox_proImg.Image = null; 
                    }

                    if (System.IO.File.Exists(srcImgPath))
                    {
                        Image srcImg = Image.FromFile(srcImgPath);
                        pictureBox_srcImg.Image = srcImg;
                    }
                    else
                    {
                        pictureBox_srcImg.Image = null; 
                    }

                }
            }
        }
    }
}
