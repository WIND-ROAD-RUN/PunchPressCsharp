using IMVSImageCorrectCalibModuCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PunchPressCsharp.Data;
using PunchPressCsharp.Utility;
using VM.Core;

namespace PunchPressCsharp.UI
{
    public partial class Frm_visualCorrection : Form
    {
        private VmProcedure vmProcess1;
        public Frm_visualCorrection()
        {
            InitializeComponent();

            IniUi();

            IniCameraAndLight();
#if DEBUG

#else
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
#endif
        }

        private void IniCameraAndLight()
        {
            var config = GlobalData.Instance.configs.visualCorrectionCfg;
            UtilityFunc.ChangeDownLightStatus(config.lightCfg.isDownLightOpen);
            UtilityFunc.ChangeUpLightStatus(config.lightCfg.isUpLightOpen);
            UtilityFunc.UpdateCameraGain(config.cameraCfg.gain);
            UtilityFunc.UpdateCameraExposureTime(config.cameraCfg.exposureTime);
        }

        private void ResetCameraAndLight()
        {
            var config = GlobalData.Instance.configs.frmPunchPressCfg;
            UtilityFunc.ChangeDownLightStatus(config.lightCfg.isDownLightOpen);
            UtilityFunc.ChangeUpLightStatus(config.lightCfg.isUpLightOpen);
            UtilityFunc.UpdateCameraGain(config.cameraCfg.gain);
            UtilityFunc.UpdateCameraExposureTime(config.cameraCfg.exposureTime);
        }

        private void IniUi()
        {
            tab_stepManager.TabVisible = false;
            tab_stepManager.SelectedIndex = 0;

        }

        private void Frm_visualCorrection_Load(object sender, EventArgs e)
        {

           // //加载流程畸变矫正
           //  vmProcess1 = (VmProcedure)VmSolution.Instance["流程2"];

           // vmProcess1.OnWorkEndStatusCallBack += VmProcess1_OnWorkEndStatusCallBack;
           // IMVSImageCorrectCalibModuTool ImageCorrectCalibModu = (IMVSImageCorrectCalibModuTool)VmSolution.Instance["流程2.畸变标定1"];
           //// ImageCorrectCalibModu.ModuParams.CalibPath = "";


        }

        private void VmProcess1_OnWorkEndStatusCallBack(object sender, EventArgs e)
        {



              

        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            ResetCameraAndLight();
            Close();
        }

    }
}
