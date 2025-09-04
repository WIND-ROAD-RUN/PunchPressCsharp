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
using PunchPressCsharp.Utility;

namespace PunchPressCsharp.UI
{
    public partial class Frm_set : Form
    {
        public Frm_set()
        {
            InitializeComponent();
        }

        private void Frm_set_Load(object sender, EventArgs e)
        {
            lb_exposureValue.Text = GlobalData.Instance.cameraSetCfg.exposureTime.ToString();
            lb_gainValue.Text = GlobalData.Instance.cameraSetCfg.gain.ToString();
        }

        #region UI事件触发

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_exposureIncrease_Click(object sender, EventArgs e)
        {
            var currentExposureValue = GlobalData.Instance.cameraSetCfg.exposureTime;
            if (currentExposureValue >= UtilityValue.ExposureMaxValue)
            {
                return;
            }
            currentExposureValue += UtilityValue.ExposureSetStepSize;
            GlobalData.Instance.cameraSetCfg.exposureTime = currentExposureValue;
            lb_exposureValue.Text = currentExposureValue.ToString();
        }

        private void btn_exposureReduce_Click(object sender, EventArgs e)
        {
            var currentExposureValue = GlobalData.Instance.cameraSetCfg.exposureTime;
            if (currentExposureValue <= UtilityValue.ExposureMinValue)
            {
                return;
            }
            currentExposureValue -= UtilityValue.ExposureSetStepSize;
            GlobalData.Instance.cameraSetCfg.exposureTime = currentExposureValue;
            lb_exposureValue.Text = currentExposureValue.ToString();
        }


        #endregion

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_gainReduce_Click(object sender, EventArgs e)
        {
            var currentGainValue = GlobalData.Instance.cameraSetCfg.gain;
            if (currentGainValue <= UtilityValue.GainMinValue)
            {
                return;
            }
            currentGainValue -= UtilityValue.GainSetStepSize;
            GlobalData.Instance.cameraSetCfg.gain = currentGainValue;
            lb_gainValue.Text = currentGainValue.ToString();
        }

        private void btn_gainIncrease_Click(object sender, EventArgs e)
        {
            var currentGainValue = GlobalData.Instance.cameraSetCfg.gain;
            if (currentGainValue >= UtilityValue.GainMaxValue)
            {
                return;
            }
            currentGainValue += UtilityValue.GainSetStepSize;
            GlobalData.Instance.cameraSetCfg.gain = currentGainValue;
            lb_gainValue.Text = currentGainValue.ToString();
        }
    }
}
