using ImageSourceModuleCs;
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

namespace PunchPressCsharp
{
    public partial class Frm_CameraSet : Form
    {
        public Frm_CameraSet()
        {
            InitializeComponent();
        }

        private void Frm_SetCamera_Load(object sender, EventArgs e)
        {
            // 设置图像
            var imageSource = (ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];
            vmRenderControl1.ModuleSource = imageSource;
            vmParamsConfigControl1.ModuleSource = imageSource;

            // 实时显示
            //  VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];
            //  vmProcess1.ContinuousRunEnable = true;
        }

        private void Frm_SetCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            //VmSolution.Save();
        }

        private Point mouseOffset;
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
