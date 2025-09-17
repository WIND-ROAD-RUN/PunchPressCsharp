using ImageSourceModuleCs;
using IMVSHPFeatureMatchModuCs;
using PunchPressCsharp.Func;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VM.Core;

namespace PunchPressCsharp.UI
{
    public partial class Frm_Learning : Form
    {
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

        private void Frm_Learning_Load(object sender, EventArgs e)
        {
            // 初始化视觉模块

            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
            var imageSource = (ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];
          

            vmParamsConfigWithRenderControl1.ModuleSource = FeatureMatch;
            string savePath = @"C:\Users\zzw\Desktop\saved_template.bin";

            // 4. 从文件读取模板数据
            byte[] modelData = File.ReadAllBytes(savePath);

            // 5. 导入模板
           // FeatureMatch.ImportModel(modelData);






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
            string savePath = @"C:\Users\zzw\Desktop\saved_template1.bin";
            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
          
            // 获取模型数据（字节数组）
            byte[] modelData = FeatureMatch.GetModel();


            // 保存到文件
            File.WriteAllBytes(savePath, modelData);

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
