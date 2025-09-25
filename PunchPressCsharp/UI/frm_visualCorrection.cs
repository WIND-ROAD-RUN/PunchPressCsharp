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

            _hasPunch = false;
            _hasCalibrationForDistortion = false;
            _hasCalibrationForCalibration = false;
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

        private bool _hasPunch = false;
        private bool _hasCalibrationForDistortion = false;
        private bool _hasCalibrationForCalibration = false;

        private void pic_Close_Click(object sender, EventArgs e)
        {
            ResetCameraAndLight();
            Close();
        }

        private void btn_nextStepForDistortion_Click(object sender, EventArgs e)
        {
            if (!_hasPunch)
            {
                MessageBox.Show(@"请先完成冲压操作！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!_hasCalibrationForDistortion)
            {
                MessageBox.Show(@"请先完成畸变标定！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tab_stepManager.SelectedIndex = 1;
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (!_hasCalibrationForCalibration)
            {
                MessageBox.Show(@"请先完成九点标定！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pic_Close_Click(sender,e);
        }

        private void btn_punchForDistortion_Click(object sender, EventArgs e)
        {
            _hasPunch = true;
        }

        private void btn_calibrationForDistortion_Click(object sender, EventArgs e)
        {
            _hasCalibrationForDistortion = true;
        }

        private void btn_calibrationForCalibration_Click(object sender, EventArgs e)
        {
            _hasCalibrationForCalibration = true;
        }
    }
}
