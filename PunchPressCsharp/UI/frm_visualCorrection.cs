using IMVSImageCorrectCalibModuCs;
using PunchPressCsharp.Data;
using PunchPressCsharp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslationCalibModuCs;
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

            IniCameraAndLightForDistortion();

            _hasPunch = false;
            _hasCalibrationForDistortion = false;
            _hasCalibrationForNine = false;
#if DEBUG

#else
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
#endif
        }

        private void IniCameraAndLightForDistortion()
        {
            var config = GlobalData.Instance.configs.visualCorrectionCfg;
            UtilityFunc.ChangeDownLightStatus(config.lightCfgForDistortion.isDownLightOpen);
            UtilityFunc.ChangeUpLightStatus(config.lightCfgForDistortion.isUpLightOpen);
            UtilityFunc.UpdateCameraGain(config.cameraCfgForDistortion.gain);
            UtilityFunc.UpdateCameraExposureTime(config.cameraCfgForDistortion.exposureTime);
        }

        private void IniCameraAndLightForNine()
        {
            var config = GlobalData.Instance.configs.visualCorrectionCfg;
            UtilityFunc.ChangeDownLightStatus(config.lightCfgForNine.isDownLightOpen);
            UtilityFunc.ChangeUpLightStatus(config.lightCfgForNine.isUpLightOpen);
            UtilityFunc.UpdateCameraGain(config.cameraCfgForNine.gain);
            UtilityFunc.UpdateCameraExposureTime(config.cameraCfgForNine.exposureTime);
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
            label_info.Visible = false;
        }

        private void Frm_visualCorrection_Load(object sender, EventArgs e)
        {

            //加载流程畸变矫正
             vmProcess1 = (VmProcedure)VmSolution.Instance["流程2"];

            vmProcess1.OnWorkEndStatusCallBack += VmProcess1_OnWorkEndStatusCallBack;
           var ImageCorrectCalibModu = (IMVSImageCalibModuCs.IMVSImageCalibModuTool)VmSolution.Instance["流程2.畸变标定1"];

           vmRenderControl1.ModuleSource = ImageCorrectCalibModu;





         

        }

        private void VmProcess1_OnWorkEndStatusCallBack(object sender, EventArgs e)
        {

        }

        private bool _hasPunch = false;
        private bool _hasCalibrationForDistortion = false;
        private bool _hasCalibrationForNine = false;

        private void pic_Close_Click(object sender, EventArgs e)
        {
            ResetCameraAndLight();
            Close();
        }

        private void btn_nextStepForDistortion_Click(object sender, EventArgs e)
        {
            if (!_hasCalibrationForDistortion)
            {
                MessageBox.Show(@"请先完成畸变标定！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tab_stepManager.SelectedIndex = 1;


            IniCameraAndLightForNine();

            //第二部

            //设置相机为硬触发模式

            //加载流程畸变矫正
            vmProcess1 = (VmProcedure)VmSolution.Instance["流程3"];

            var lationCalibModuTool = (TranslationCalibModuTool)VmSolution.Instance["流程3.平移旋转标定"];

            vmRenderControl1.ModuleSource = lationCalibModuTool;


        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (!_hasPunch)
            {
                MessageBox.Show(@"请先完成冲压操作！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!_hasCalibrationForNine)
            {
                MessageBox.Show(@"请先完成九点标定！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pic_Close_Click(sender,e);
        }

        private void btn_punchForNine_Click(object sender, EventArgs e)
        {
            _hasPunch = true;
            label_info.Visible = true;
        }

        private void btn_calibrationForDistortion_Click(object sender, EventArgs e)
        {
            _hasCalibrationForDistortion = true;
        }

        private void btn_calibrationForNine_Click(object sender, EventArgs e)
        {
            if (!_hasPunch)
            {
                MessageBox.Show(@"请先完成冲压操作！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _hasCalibrationForNine = true;
        }

    }
}
