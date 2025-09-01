using System;
using System.Drawing;
using System.Windows.Forms;
using PunchPressCsharp.Data;
using PunchPressCsharp.HardwareCom;
using PunchPressCsharp.Utility;
using VM.Core;

namespace PunchPressCsharp.UI
{
    public partial class FrmPunchPress : Form
    {
        public FrmPunchPress()
        {
            InitializeComponent();
            
        }
        private void FrmPunchPress_Load(object sender, EventArgs e)
        {
            IniExtraComponent();
        }
        #region 初始化组件

        private void IniExtraComponent()
        {
            IniModbus();
            IniVMSol();
        }

        private void IniModbus()
        {
            GlobalData.Instance.modbusTool=new ModbusTool(UtilityValue.ModbusToolAddr, UtilityValue.ModbusToolPort);
            var modbus= GlobalData.Instance.modbusTool;
            var connectResult=modbus.Connect();

            if (connectResult)
            {
                lb_plcStatus.Text= "连接成功";
                lb_plcStatus.ForeColor = Color.Green;
            }
            else
            {
                lb_plcStatus.Text = "连接失败";
                lb_plcStatus.ForeColor = Color.Red;
            }

          
        }

        private void IniVMSol()
        {
            string solPath = @"C:\Users\rw\Desktop\1.sol";
            if (!System.IO.File.Exists(solPath))
            {
                MessageBox.Show("流程文件不存在，请检查路径是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                var version=VmSolution.Instance.GetSolutionVersion(solPath, "");
            }
            catch (Exception)
            {
                MessageBox.Show("加载流程失败，请检查流程文件路径是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        #endregion


        #region UI事件触发

        private void btn_brightness_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }


        #endregion

       
    }
}
