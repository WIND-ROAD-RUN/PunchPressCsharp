using AntdUI.Svg;
using ImageSourceModuleCs;
using IMVSHPFeatureMatchModuCs;
using Microsoft.VisualBasic;
using PunchPressCsharp.Data;
using PunchPressCsharp.Func;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IMVSFastFeatureMatchModuCs;
using VM.Core;
using static PunchPressCsharp.Data.Config;

namespace PunchPressCsharp.UI
{
   
    public partial class Frm_Learning : Form
    {
        //是否为新模板
        bool isnew = false;

        public Frm_Learning()
        {
            InitializeComponent();

#if DEBUG

#else
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
#endif
        }

        public Frm_Learning(bool isNew)
        {

            InitializeComponent();
            this.isnew=isNew;

#if DEBUG

#else
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
#endif
        }

        private void Frm_Learning_Load(object sender, EventArgs e)
        {
            // 初始化视觉模块

            IMVSFastFeatureMatchModuTool FeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            var imageSource = (ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];


            vmParamsConfigWithRenderControl1.ModuleSource= FeatureMatch;
            if (isnew == true)
            {
                FeatureMatch.ClearModelData();
            }
            //if (File.Exists(GlobalPath.ModelLoadPath))
            //{
            //    byte[] modelData = File.ReadAllBytes(GlobalPath.ModelLoadPath);
            //    FeatureMatch.ImportModel(modelData);
            //}
        }

        private void Frm_Learning_FormClosing(object sender, FormClosingEventArgs e)
        {
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];
            VmSolution.Save();
        }



        #region UI事件触发
        private void btn_learning_Click(object sender, EventArgs e)
        {
           
        }

        private Point _mouseOffset;

        public bool isCreate = false;
        private void btn_close_Click(object sender, EventArgs e)
        {
            IMVSFastFeatureMatchModuTool FeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            byte[] modelData = FeatureMatch.GetModel();

            if (modelData != null)
            {
              
            }
            else
            {
                var dr = MessageBox.Show("没有模板，是否关闭？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //读上一次的模板
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        modelData = System.IO.File.ReadAllBytes(GlobalPath.ModelLoadPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("读取上一次模型二进制文件失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FeatureMatch.ImportModel(modelData);
                    this.Close();
                    isCreate = false;
                    return;
                }
                else
                {
                    // 选择“否”则返回，不做任何操作
                    return;
                }
            }
            //新建一个保存
            if (isnew == true)
            {
                var config = GlobalData.Instance.configs;
                var nowTime = DateTime.Now; // 补充定义

                string defaultName = nowTime.ToString("yyyyMMddHHmmss");
             
                string inputName = ShowInputBox("请输入模型名称：", "模型命名", defaultName,out bool isAccept);

                if (isAccept)
                {
                    if (string.IsNullOrWhiteSpace(inputName))
                    {
                        MessageBox.Show("模型名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ModelConfig modelConfig = new ModelConfig();
                    modelConfig.cameraCfg = config.frmPunchPressCfg.cameraCfg;
                    GlobalData.Instance.configs.frmPunchPressCfg.correction = new CorrectionCfg();
                    modelConfig.correction = config.frmPunchPressCfg.correction;
                    modelConfig.lightCfg = config.frmPunchPressCfg.lightCfg;
                    modelConfig.trainDate = nowTime.ToString("yyyy-MM-dd HH:mm:ss");
                    modelConfig.modelName = inputName;

                    var saveDir = GlobalPath.ModelHome + "\\" + defaultName + "\\";
                    
                    var modelConfigPath = saveDir + GlobalPath.ModelConfigName;
                    modelConfig.SaveToFile(modelConfigPath);

                    vmParamsConfigWithRenderControl1.SaveRenderedImage(saveDir + GlobalPath.SourceImgName);

                    

                    if (modelData !=null)
                    {
                        File.WriteAllBytes(saveDir + GlobalPath.ModelBinName, modelData);
                        GlobalData.Instance.configs.frmPunchPressCfg.lastLoadModelDirPath = saveDir;
                    }
                    else
                    {
                        MessageBox.Show("没有模板请重新创建模板");

                    }

                    isCreate = true;

                }
              
            }
            else
            {
                var olderCfgPath = GlobalData.Instance.modelManager.currentModelDir;
                var modelConfigPath = olderCfgPath + "\\" + GlobalPath.ModelConfigName;
                if (System.IO.File.Exists(modelConfigPath))
                {
                    ModelConfig modelConfig = ModelConfig.LoadFromFile(modelConfigPath);
                    var config = GlobalData.Instance.configs;
                    modelConfig.cameraCfg = config.frmPunchPressCfg.cameraCfg;
                    modelConfig.correction = config.frmPunchPressCfg.correction;
                    modelConfig.lightCfg = config.frmPunchPressCfg.lightCfg;
                    modelConfig.SaveToFile(modelConfigPath);
                    //save pro img
                    vmParamsConfigWithRenderControl1.SaveRenderedImage(olderCfgPath + "\\" + GlobalPath.SourceImgName);
                    //save model
                   
                    if (modelData != null)
                    {
                        File.WriteAllBytes(olderCfgPath + "\\" + GlobalPath.ModelBinName, modelData);
                    }
                    else
                    {
                        MessageBox.Show("没有模板请重新创建模板");

                    }
                }
                isCreate = true;
            }



            this.Close();
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(_mouseOffset.X, _mouseOffset.Y);
                Location = mousePos;
            }
        }

        private string ShowInputBox(string prompt, string title, string defaultValue, out bool isAccept)
        {
            Form inputForm = new Form();
            inputForm.Width = 400;
            inputForm.Height = 150;
            inputForm.Text = title;
            inputForm.StartPosition = FormStartPosition.CenterParent; // 居中显示在父窗体
            Label textLabel = new Label() { Left = 10, Top = 20, Text = prompt, Width = 360 };
            TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 360, Text = defaultValue };
            Button okButton = new Button() { Text = "确定", Left = 220, Width = 70, Top = 80, DialogResult = DialogResult.OK };
            Button cancelButton = new Button() { Text = "取消", Left = 300, Width = 70, Top = 80, DialogResult = DialogResult.Cancel };
            inputForm.Controls.Add(textLabel);
            inputForm.Controls.Add(inputBox);
            inputForm.Controls.Add(okButton);
            inputForm.Controls.Add(cancelButton);
            inputForm.AcceptButton = okButton;
            inputForm.CancelButton = cancelButton;

            var result = inputForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                isAccept = true;
            }
            else { 
                isAccept = false;
            }


                return inputBox.Text;

        }
        #endregion

    }
}
