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
            txt_gainMax.Text = cfg.gainMax.ToString();
            txt_gainMin.Text = cfg.gainMin.ToString();
            txt_centralXCorrectionMax.Text = cfg.centralXCorrectionMax.ToString();
            txt_centralXCorrectionMin.Text = cfg.centralXCorrectionMin.ToString();
            txt_centralYCorrectionMax.Text = cfg.centralYCorrectionMax.ToString();
            txt_centralYCorrectionMin.Text = cfg.centralYCorrectionMin.ToString();
            txt_angleCorrectionMax.Text = cfg.angleCorrectionMax.ToString();
            txt_angleCorrectionMin.Text = cfg.angleCorrectionMin.ToString();

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
                cfg.centralYCorrectionMin = float.Parse(txt_centralYCorrectionMin.Text);
                cfg.centralYCorrectionMax = float.Parse(txt_centralYCorrectionMax.Text);
                cfg.angleCorrectionMin = float.Parse(txt_angleCorrectionMin.Text);
                cfg.angleCorrectionMax = float.Parse(txt_angleCorrectionMax.Text);
                cfg.exposureTimeMin = int.Parse(txt_exposureMin.Text);
                cfg.exposureTimeMax = int.Parse(txt_exposureMax.Text);
                cfg.gainMin = int.Parse(txt_gainMin.Text);
                cfg.gainMax = int.Parse(txt_gainMax.Text);

                cfg.SaveToFile(GlobalPath.FrmConfigurationCfgPath);
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
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange=true;
        }

        private void txt_centralXCorrectionMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_centralYCorrectionMin_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_centralYCorrectionMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 10000);
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
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 10000);
            numKeyBoard.ShowDialog();
            _valueIsChange = true;

        }

        private void txt_exposureMax_Click(object sender, EventArgs e)
        {
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, 0, 10000);
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


    }
}
