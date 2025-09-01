using IMVSCalibTransformModuCs;
using IMVSFastFeatureMatchModuCs;
using PunchPressCsharp.Data;
using PunchPressCsharp.HardwareCom;
using PunchPressCsharp.Utility;
using System;
using System.Drawing;
using System.Windows.Forms;
using VM.Core;

namespace PunchPressCsharp.UI
{
    public partial class Frm_PunchPress : Form
    {
        public Frm_PunchPress()
        {
            InitializeComponent();
            
        }

        #region 窗体生命周期管理
        private void FrmPunchPress_Load(object sender, EventArgs e)
        {
            IniExtraComponent();
        }

        private void FrmPunchPress_FormClosing(object sender, FormClosingEventArgs e)
        {
            DesExtraComponent();
        }

        #endregion

        #region 组件生命周期管理
        private void IniExtraComponent()
        {
            IniModbus();
            IniVMSol();
        }

        private void DesExtraComponent()
        {
            DesVMSol();
        }

        private void IniModbus()
        {
            GlobalData.Instance.modbusTool=new ModbusTool(UtilityValue.ModbusToolAddr, UtilityValue.ModbusToolPort);
            var modbus= GlobalData.Instance.modbusTool;
            var connectResult=modbus.Connect();

            if (connectResult)
            {
                lb_plcStatus.Text= @"连接成功";
                lb_plcStatus.ForeColor = Color.Green;
            }
            else
            {
                lb_plcStatus.Text = @"连接失败";
                lb_plcStatus.ForeColor = Color.Red;
            }

          
        }

        private void IniVMSol()
        {
            string solPath = GlobalPath.vmSolPath;
            if (!System.IO.File.Exists(solPath))
            {
                MessageBox.Show("流程文件不存在，请检查路径是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var version = VmSolution.Instance.GetSolutionVersion(solPath, "");
            if (UtilityValue.VMVersion != version)
            {
                MessageBox.Show(@"方案版本不正确应为" + UtilityValue.VMVersion, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                VmSolution.Load(solPath);
            }
            catch (Exception)
            {
                MessageBox.Show("加载流程失败，请检查流程文件路径是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];
            IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];
            //设置图像
            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            vmRenderControl1.ModuleSource = fastFeatureMatch;

            //vmRenderControl1.ModuleSource = CalibTransform;
            vmProcess1.OnWorkEndStatusCallBack += VMProcedure1OnWorkEndStatusCallBack;
            vmProcess1.Run();
        }

        private void DesVMSol()
        {
            VmSolution.Instance.CloseSolution();
            VmSolution.Instance?.Dispose();

        }

        #endregion

        #region VM触发

        private void VMProcedure1OnWorkEndStatusCallBack(object sender, EventArgs e)
        {
            // IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];
            IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];
            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            // var angles= fastFeatureMatch.ModuResult.MatchRect;
            var points = CalibTransform.ModuResult.TransPoint;
            var angles = CalibTransform.ModuResult.WorldPointA;
            bool isPostive = GlobalData.Instance.modbusTool.readbool(330);



            if (points.Count > 0)
            {
                if (isPostive == false)
                {
                    //冒泡排序按X从小到大
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        for (int j = 0; j < points.Count - 1 - i; j++)
                        {
                            if (points[j].X > points[j + 1].X)
                            {
                                var temp = points[j];
                                points[j] = points[j + 1];
                                points[j + 1] = temp;

                                var temp1 = angles[j];
                                angles[j] = angles[j + 1];
                                angles[j + 1] = temp1;


                            }
                        }
                    }
                }
                else
                {
                    //冒泡排序按X从大到小
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        for (int j = 0; j < points.Count - 1 - i; j++)
                        {
                            if (points[j].X < points[j + 1].X)
                            {
                                var temp = points[j];
                                points[j] = points[j + 1];
                                points[j + 1] = temp;

                                var temp1 = angles[j];
                                angles[j] = angles[j + 1];
                                angles[j + 1] = temp1;


                            }
                        }
                    }

                }

                for (int i = 0; i < points.Count; i++)
                {

                    float x = points[i].X;

                    float y = points[i].Y;

                    float angle = -angles[i];

                    float sendx = x * 100;
                    float sendy = -y * 100;
                    float sendangle = -(angle) * 100;


                    // 在UI中显示结果
                    if (this.IsHandleCreated)
                    {
                        Invoke(new MethodInvoker(() =>
                        {
                            AppendLog($"匹配点 {i + 1}: X={sendx / 100:F2}, Y={sendy / 100:F2},A={sendangle / 100:F2}");
                        }));
                    }

                    int sx = 6100 + i * 10;
                    int sy = 6102 + i * 10;
                    int sa = 6104 + i * 10;
                    int sismessage = 6106 + i * 10;


                    //发送数据到modbus
                    GlobalData.Instance.modbusTool.WriteFloatToPlc(sx, sendx, false);
                    GlobalData.Instance.modbusTool.WriteFloatToPlc(sy, sendy, false);
                    GlobalData.Instance.modbusTool.WriteFloatToPlc(sa, sendangle, false);
                    GlobalData.Instance.modbusTool.WriteMultipleRegisters(sismessage, new int[] { 1 });
                }


                GlobalData.Instance.modbusTool.WriteMultipleRegisters(6004, new int[] { 1 });


            }
            else
            {
                GlobalData.Instance.modbusTool.WriteMultipleRegisters(6004, new int[] { 2 });

            }

        }

        #endregion


        #region 功能性
        private void AppendLog(string message)
        {
            if (uiRichTextBox1.InvokeRequired)
            {
                uiRichTextBox1.Invoke(new Action<string>(AppendLog), message);
                return;
            }
            if (this.IsHandleCreated)
            {
                uiRichTextBox1.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
                uiRichTextBox1.ScrollToCaret();
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
