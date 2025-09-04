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

        }

        private void btn_exposureReduce_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
