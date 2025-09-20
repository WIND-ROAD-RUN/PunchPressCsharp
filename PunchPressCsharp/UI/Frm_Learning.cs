using ImageSourceModuleCs;
using IMVSHPFeatureMatchModuCs;
using PunchPressCsharp.Func;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AntdUI.Svg;
using VM.Core;
using static PunchPressCsharp.Data.Config;
using PunchPressCsharp.Data;

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

            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
            var imageSource = (ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];

            byte[] modelData = File.ReadAllBytes(GlobalPath.ModelLoadPath);

            FeatureMatch.ImportModel(modelData);
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (isnew == true)
            {
                //弹窗显示名称允许修改，默认为当前日期，如果为孔=空需要报警保护
                var config = GlobalData.Instance.configs;

                ModelConfig modelConfig = new ModelConfig();
                modelConfig.cameraCfg = config.frmPunchPressCfg.cameraCfg;
                modelConfig.correction = config.frmPunchPressCfg.correction;
                modelConfig.lightCfg = config.frmPunchPressCfg.lightCfg;
                var nowTime= DateTime.Now;
                modelConfig.trainDate = nowTime.ToString("yyyy-MM-dd HH:mm:ss");
                var saveDir = GlobalPath.ModelHome + "\\" + nowTime.ToString("yyyyMMddHHmmss") + "\\";

                //Save model cfg
                var modelConfigPath = saveDir + GlobalPath.ModelConfigName;
                modelConfig.SaveToFile(modelConfigPath);

                //save pro img
                vmParamsConfigWithRenderControl1.SaveRenderedImage(saveDir+GlobalPath.SourceImgName);

                //save model
                IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
                byte[] modelData = FeatureMatch.GetModel();
                File.WriteAllBytes(saveDir + GlobalPath.ModelBinName, modelData);

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
                    IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
                    byte[] modelData = FeatureMatch.GetModel();
                    File.WriteAllBytes(olderCfgPath + "\\" + GlobalPath.ModelBinName, modelData);
                }
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


        #endregion

    }
}
