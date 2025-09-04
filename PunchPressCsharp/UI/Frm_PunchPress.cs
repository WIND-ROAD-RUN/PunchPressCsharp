using GlobalCameraModuleCs;
using IMVSCalibTransformModuCs;
using IMVSFastFeatureMatchModuCs;
using PunchPressCsharp.Data;
using PunchPressCsharp.Func;
using PunchPressCsharp.HardwareCom;
using PunchPressCsharp.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using VM.Core;
using VM.PlatformSDKCS;

namespace PunchPressCsharp.UI
{
    public partial class Frm_PunchPress : Form
    {
        public Frm_PunchPress()
        {
            InitializeComponent();

#if DEBUG

#else
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
#endif

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
            GlobalData.Instance.configs.LoadConfigs();
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
            string solPath = GlobalPath.VMSolPath;
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
            GlobalData.Instance.vmMainProcedure = vmProcess1;

            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            vmRenderControl1.ModuleSource = fastFeatureMatch;

            vmProcess1.OnWorkEndStatusCallBack += VMProcedure1OnWorkEndStatusCallBack;
            VmSolution.OnCameraConnectStatusCallBackEvent += Handle_CameraConnectStatus;

            GlobalCameraModuleTool cameraModule = (GlobalCameraModuleTool)VmSolution.Instance["全局相机1"];
            GlobalData.Instance.cameraModuleTool=cameraModule;
            CameraInfoList cameraInfoList = cameraModule.ModuParams.GetCameraInfoList();

            var hasCamera=cameraInfoList.nNum > 0;

            if (!hasCamera)
            {
                lb_cameraStatus.Text = @"连接失败";
                lb_cameraStatus.ForeColor = Color.Red;
                GlobalData.Instance.cameraIsConnect = false;
            }
            else
            {
                if (!cameraModule.bIsCameraConnect())
                {
                    lb_cameraStatus.Text = @"连接失败";
                    lb_cameraStatus.ForeColor = Color.Red;
                    GlobalData.Instance.cameraIsConnect = false;
                }
                else
                {
                    lb_cameraStatus.Text = @"连接成功";
                    lb_cameraStatus.ForeColor = Color.Green;

                    var cameraParam = cameraModule.ModuParams;
                    cameraParam.ExposureTime = GlobalData.Instance.configs.frmSetCfg.exposureTime;
                    cameraParam.Gain = GlobalData.Instance.configs.frmSetCfg.gain;
                    GlobalData.Instance.cameraIsConnect = true;
                }
            }
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

        private void Handle_CameraConnectStatus(ImvsSdkDefine.IMVS_CAMERA_CONNECT_STATUS_INFO statusInfo)
        {
            // statusInfo.nCameraID: 相机ID
            // statusInfo.nConnectStatus: 连接状态 (1=连接, 0=断开)

            if (statusInfo.nConnectStatus == 0) 
            {
                UpdateCameraStatus(ConnectStatus.Reconnecting);
                GlobalData.Instance.cameraIsConnect = false;
            }
            else
            {
                UpdateCameraStatus(ConnectStatus.Connected);
                GlobalData.Instance.cameraIsConnect = true;
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

        private void UpdateCameraStatus(ConnectStatus status)
        {
            if (lb_cameraStatus.InvokeRequired)
            {
                lb_cameraStatus.Invoke(new Action<ConnectStatus>(UpdateCameraStatus), status);
                return;
            }
            if (status== ConnectStatus.Connected)
            {
                lb_cameraStatus.Text = @"连接成功";
                lb_cameraStatus.ForeColor = Color.Green;
            }
            else if (status == ConnectStatus.Disconnected)
            {
                lb_cameraStatus.Text = @"连接失败";
                lb_cameraStatus.ForeColor = Color.Red;
            }
            else if (status == ConnectStatus.Reconnecting)
            {
                lb_cameraStatus.Text = @"正在重连";
                lb_cameraStatus.ForeColor = Color.Orange;
            }
        }

        #endregion


        #region UI事件触发

        private void btn_templateLearn_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCameraModuleTool cameraModule1 = (GlobalCameraModuleTool)VmSolution.Instance["全局相机1"];
                GlobalCameraModuleTool cameraModule2 = (GlobalCameraModuleTool)VmSolution.Instance["全局相机1"];


                cameraModule1.ModuParams.TriggerSource = 7; // 设置触发源为软件触发
                cameraModule2.ModuParams.TriggerSource = 7; // 设置触发源为软件触发


                Frm_Learning frm_Learning = new Frm_Learning();
                frm_Learning.ShowDialog();

                cameraModule1.ModuParams.TriggerSource = 0; // 设置触发源为硬触发
                cameraModule2.ModuParams.TriggerSource = 0; // 设置触发源为硬触发

            }
            catch (Exception)
            {

                MessageBox.Show(@"相机未连接", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            GlobalData.Instance.configs.SaveConfigs();

            this.Close();
        }

        private void btn_brightnessChange_Click(object sender, EventArgs e)
        {
            Frm_CameraSet frmSetCamera = new Frm_CameraSet();
            frmSetCamera.ShowDialog();
        }

        private void btn_disTemplate_Click(object sender, EventArgs e)
        {
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];
            //设置图像
            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            vmRenderControl1.ModuleSource = fastFeatureMatch;


        }

        private void btn_disCentral_Click(object sender, EventArgs e)
        {
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];

            IMVSCalibTransformModuTool calibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];

            vmRenderControl1.ModuleSource = calibTransform;
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Instance.cameraIsConnect)
            {
                MessageBox.Show(@"相机未连接，请等待重连。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Frm_set frmSet = new Frm_set();
            frmSet.ShowDialog();

            var cameraModule= GlobalData.Instance.cameraModuleTool;
            CameraInfoList cameraInfoList = cameraModule.ModuParams.GetCameraInfoList();
            var cameraParam = cameraModule.ModuParams;
            cameraParam.ExposureTime = 800000;
            GlobalData.Instance.vmMainProcedure.Run();
        }

        private void btn_runOnce_Click(object sender, EventArgs e)
        {
            var procedure = GlobalData.Instance.vmMainProcedure;
            if (!procedure.IsRunning)
            {
                procedure.Run();
            }
        }
    }
}
