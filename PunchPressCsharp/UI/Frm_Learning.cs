using System;
using System.Drawing;
using System.Windows.Forms;
using ImageSourceModuleCs;
using IMVSFastFeatureMatchModuCs;
using PunchPressCsharp.Func;
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
            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            var imageSource = (ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];
            vmRenderControl1.ModuleSource = fastFeatureMatch;
            vmParamsConfigControl1.ModuleSource = fastFeatureMatch;
            vmParamsConfigControl1.Visible = false;
        }

        private void Frm_Learning_FormClosing(object sender, FormClosingEventArgs e)
        {
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];
            VmSolution.Save();
        }



        #region UI事件触发
        private void btn_learning_Click(object sender, EventArgs e)
        {
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];
            try
            {
                vmProcess1.ContinuousRunEnable = false;
                vmParamsConfigControl1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"操作失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Point _mouseOffset;

        private void btn_close_Click(object sender, EventArgs e)
        {
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
