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

namespace PunchPressCsharp.UI
{
    public partial class Frm_Configuration : Form
    {

        #region 窗体生命周期管理

        public Frm_Configuration()
        {
            InitializeComponent();
        }


        private void Frm_Configuration_Load(object sender, EventArgs e)
        {
            ReadCfg();
        }

        private void ReadCfg()
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            txt_exposureMax.Text = cfg.exposureTimeMax.ToString();
            txt_exposureMin.Text = cfg.exposureTimeMin.ToString();
            txt_exposureStep.Text = cfg.exposureTimeStep.ToString();

            txt_gainMax.Text = cfg.gainMax.ToString();
            txt_gainMin.Text = cfg.gainMin.ToString();
            txt_gainStep.Text = cfg.gainStep.ToString();

            txt_centralXCorrectionMax.Text = cfg.centralXCorrectionMax.ToString("F1");
            txt_centralXCorrectionMin.Text = cfg.centralXCorrectionMin.ToString("F1");
            txt_centralXStep.Text = cfg.centralXCorrectionStep.ToString("F1");

            txt_centralYCorrectionMax.Text = cfg.centralYCorrectionMax.ToString("F1");
            txt_centralYCorrectionMin.Text = cfg.centralYCorrectionMin.ToString("F1");
            txt_centralYStep.Text = cfg.centralYCorrectionStep.ToString("F1");

            txt_angleCorrectionMax.Text = cfg.angleCorrectionMax.ToString("F1");
            txt_angleCorrectionMin.Text = cfg.angleCorrectionMin.ToString("F1");
            txt_angleCorrectionStep.Text = cfg.angleCorrectionStep.ToString("F1");

            var visualConfig= GlobalData.Instance.configs.visualCorrectionCfg;
            btn_exposureForDistortion.Text= visualConfig.cameraCfgForDistortion.exposureTime.ToString();
            btn_gainForDistortion.Text= visualConfig.cameraCfgForDistortion.gain.ToString();
            cbox_upLightForDistortion.Checked= visualConfig.lightCfgForDistortion.isUpLightOpen;
            cbox_downLightForDistortion.Checked= visualConfig.lightCfgForDistortion.isDownLightOpen;

            btn_exposureForNine.Text= visualConfig.cameraCfgForNine.exposureTime.ToString();
            btn_gainForNine.Text= visualConfig.cameraCfgForNine.gain.ToString();
            cbox_upLightForNine.Checked= visualConfig.lightCfgForNine.isUpLightOpen;
            cbox_downLightForNine.Checked= visualConfig.lightCfgForNine.isDownLightOpen;
        }

        #endregion


        #region UI事件触发

        private void uiCheckBoxGroup1_ValueChanged(object sender, Sunny.UI.CheckBoxGroupEventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_valueIsChange)
            {
                var result = MessageBox.Show(@"参数已修改，是否保存？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!SaveCfg())
                    {
                        MessageBox.Show(@"保存失败！\n", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.Close();
        }


        private bool _valueIsChange = false;

        private bool SaveCfg()
        {

            try
            {
                var cfg = GlobalData.Instance.configs.frmConfigurationCfg;

                cfg.centralXCorrectionMin = float.Parse(txt_centralXCorrectionMin.Text);
                cfg.centralXCorrectionMax = float.Parse(txt_centralXCorrectionMax.Text);
                cfg.centralXCorrectionStep = float.Parse(txt_centralXStep.Text);

                cfg.centralYCorrectionMin = float.Parse(txt_centralYCorrectionMin.Text);
                cfg.centralYCorrectionMax = float.Parse(txt_centralYCorrectionMax.Text);
                cfg.centralYCorrectionStep = float.Parse(txt_centralYStep.Text);

                cfg.angleCorrectionMin = float.Parse(txt_angleCorrectionMin.Text);
                cfg.angleCorrectionMax = float.Parse(txt_angleCorrectionMax.Text);
                cfg.angleCorrectionStep= float.Parse(txt_angleCorrectionStep.Text);

                cfg.exposureTimeMin = int.Parse(txt_exposureMin.Text);
                cfg.exposureTimeMax = int.Parse(txt_exposureMax.Text);
                cfg.exposureTimeStep = int.Parse(txt_exposureStep.Text);

                cfg.gainMin = int.Parse(txt_gainMin.Text);
                cfg.gainMax = int.Parse(txt_gainMax.Text);
                cfg.gainStep = int.Parse(txt_gainStep.Text);

                cfg.SaveToFile(GlobalPath.FrmConfigurationCfgPath);
                _valueIsChange = false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveCfg())
            {
                MessageBox.Show(@"保存成功！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"保存失败！\n", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (_valueIsChange)
            {
                var result = MessageBox.Show("参数已修改，是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!SaveCfg())
                    {
                        MessageBox.Show(@"保存失败！\n", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.Close();
        }

        private void txt_centralXCorrectionMin_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, -10000, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange=true;
        }

        private void txt_centralXCorrectionMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, -10000, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_centralYCorrectionMin_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, -10000, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_centralYCorrectionMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, -10000, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_angleCorrectionMin_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, -360, 360);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_angleCorrectionMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, -360, 360);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_exposureMin_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 1000000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_exposureMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 1000000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_gainMin_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 100);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_gainMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 100);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }


        #endregion

        private void txt_centralXStep_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0.1F, 1000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;
        }

        private void txt_centralYStep_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0.1F, 1000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;
        }

        private void txt_angleCorrectionStep_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0.1F, 360);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;
        }

        private void txt_exposureStep_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 1, 1000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;
        }

        private void txt_gainStep_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 1, 100);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;
        }

        private void btn_exposureForVisualCorrection_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.exposureTimeMin, cfg.exposureTimeMax);
            numKeyBoard.ShowDialog();

            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.cameraCfgForDistortion.exposureTime = int.Parse(((Control)sender).Text);
        }

        private void btn_gainForVisualCorrection_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.gainMin, cfg.gainMax);
            numKeyBoard.ShowDialog();

            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.cameraCfgForDistortion.gain = int.Parse(((Control)sender).Text);
        }

        private void cbox_upLight_Click(object sender, EventArgs e)
        {
            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.lightCfgForDistortion.isUpLightOpen = cbox_upLightForDistortion.Checked;
        }

        private void btn_exposureForNine_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.exposureTimeMin, cfg.exposureTimeMax);
            numKeyBoard.ShowDialog();

            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.cameraCfgForNine.exposureTime = int.Parse(((Control)sender).Text);
        }

        private void btn_gainForNine_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.gainMin, cfg.gainMax);
            numKeyBoard.ShowDialog();
            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.cameraCfgForNine.gain = int.Parse(((Control)sender).Text);
        }

        private void cbox_upLightForNine_Click(object sender, EventArgs e)
        {
            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.lightCfgForNine.isUpLightOpen = cbox_upLightForNine.Checked;
        }

        private void cbox_downLightForNine_Click(object sender, EventArgs e)
        {
            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.lightCfgForNine.isDownLightOpen = cbox_downLightForNine.Checked;
        }

        private void cbox_downLightForDistortion_Click(object sender, EventArgs e)
        {
            var visualCfg = GlobalData.Instance.configs.visualCorrectionCfg;
            visualCfg.lightCfgForDistortion.isDownLightOpen = cbox_downLightForDistortion.Checked;
        }
    }
}
