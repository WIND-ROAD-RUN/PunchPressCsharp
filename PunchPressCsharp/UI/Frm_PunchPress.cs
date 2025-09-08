using CameraIOModuleCs;
using GlobalCameraModuleCs;
using IMVSCalibTransformModuCs;
using IMVSFastFeatureMatchModuCs;
using Newtonsoft.Json.Linq;
using PunchPressCsharp.Data;
using PunchPressCsharp.Func;
using PunchPressCsharp.HardwareCom;
using PunchPressCsharp.Utility;
using Sunny.UI.Win32;
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
        }

        #endregion

        #region 组件生命周期管理
        private void IniExtraComponent()
        {
            IniModbus();
            IniVMSol();
            LoadConfig();
            GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode = false;
            GlobalData.Instance.configs.frmPunchPressCfg.isWorkMode = true;
            cBox_debugMode.Checked = false;
            cBox_workMode.Checked = true;
        }

        private void LoadConfig()
        {
            GlobalData.Instance.configs.LoadConfigs();
            var cfg = GlobalData.Instance.configs.frmPunchPressCfg;
            lb_exposureValue.Text= cfg.exposureTime.ToString();
            lb_gainValue.Text= cfg.gain.ToString();
            cBox_debugMode.Checked= cfg.isDebugMode;
            cBox_upLight.Checked= cfg.isUpLightOpen;
            cBox_downLight.Checked= cfg.isDownLightOpen;
            cBox_workMode.Checked=cfg.isWorkMode;
            lb_centralX.Text=cfg.centralX.ToString();
            lb_centralY.Text = cfg.centralY.ToString();
            lb_angle.Text= cfg.angle.ToString();

            UpdateCameraSet();
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
            var path = GlobalPath.VMSolPath;
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("流程文件不存在，请检查路径是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var version = VmSolution.Instance.GetSolutionVersion(path, "");
            if (UtilityValue.VMVersion != version)
            {
                MessageBox.Show(@"方案版本不正确应为" + UtilityValue.VMVersion, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                VmSolution.Load(path);
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
                    cameraParam.ExposureTime = GlobalData.Instance.configs.frmPunchPressCfg.exposureTime;
                    cameraParam.Gain = GlobalData.Instance.configs.frmPunchPressCfg.gain;
                    GlobalData.Instance.cameraIsConnect = true;
                }
            }
            vmProcess1.Run();
        }

        private void DesVMSol()
        {
            //VmSolution.Instance.CloseSolution();
            VmSolution.Instance.Dispose();

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
           // bool isPostive = GlobalData.Instance.modbusTool.readbool(330);



            if (points.Count == 1)
            {
               

                for (int i = 0; i < points.Count; i++)
                {

                    float x = points[i].X;

                    float y = points[i].Y;

                    float angle = -angles[i];

                    float sendx = -x * 100;
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

                    int sx = 1010 ;
                    int sy = 1012;
                    int sa = 1014;
                    int sismessage = 1004 ;


                    //发送数据到modbus
                    GlobalData.Instance.modbusTool.WriteFloatToPlc(sx, sendx, false);
                    GlobalData.Instance.modbusTool.WriteFloatToPlc(sy, sendy, false);
                    GlobalData.Instance.modbusTool.WriteFloatToPlc(sa, sendangle, false);
                    GlobalData.Instance.modbusTool.WriteMultipleRegisters(sismessage, new int[] { 1 });
                }


                GlobalData.Instance.modbusTool.WriteMultipleRegisters(1004, new int[] { 1 });


            }
            else
            {
                GlobalData.Instance.modbusTool.WriteMultipleRegisters(1004, new int[] { 2 });
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

        private void UpdateCameraSet()
        {
            try
            {
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;
                cameraParam.ExposureTime = GlobalData.Instance.configs.frmPunchPressCfg.exposureTime;
                cameraParam.Gain = GlobalData.Instance.configs.frmPunchPressCfg.gain;

            }
            catch (Exception)
            {

              
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
            DesExtraComponent();
            this.Close();
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
            var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;

            cameraParam.TriggerSource = 7; // 设置触发源为硬触发

            var procedure = GlobalData.Instance.vmMainProcedure;
            if (!procedure.IsRunning)
            {
                procedure.Run();
            }
        }

        private void Frm_PunchPress_SizeChanged(object sender, EventArgs e)
        {
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
        }

        private void btn_exposureReduce_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode || !GlobalData.Instance.cameraIsConnect)
            {
                return;
            }

            var currentExposureValue = GlobalData.Instance.configs.frmPunchPressCfg.exposureTime;
            if (currentExposureValue <= UtilityValue.ExposureMinValue)
            {
                return;
            }
            currentExposureValue -= UtilityValue.ExposureSetStepSize;
            GlobalData.Instance.configs.frmPunchPressCfg.exposureTime = currentExposureValue;
            lb_exposureValue.Text = currentExposureValue.ToString();

            UpdateCameraSet();
        }

        private void btn_exposureIncrease_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode || !GlobalData.Instance.cameraIsConnect)
            {
                return;
            }

            var currentExposureValue = GlobalData.Instance.configs.frmPunchPressCfg.exposureTime;
            if (currentExposureValue >= UtilityValue.ExposureMaxValue)
            {
                return;
            }
            currentExposureValue += UtilityValue.ExposureSetStepSize;
            GlobalData.Instance.configs.frmPunchPressCfg.exposureTime = currentExposureValue;
            lb_exposureValue.Text = currentExposureValue.ToString();

            UpdateCameraSet();
        }

        private void btn_gainReduce_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode || !GlobalData.Instance.cameraIsConnect)
            {
                return;
            }

            var currentGainValue = GlobalData.Instance.configs.frmPunchPressCfg.gain;
            if (currentGainValue <= UtilityValue.GainMinValue)
            {
                return;
            }
            currentGainValue -= UtilityValue.GainSetStepSize;
            GlobalData.Instance.configs.frmPunchPressCfg.gain = currentGainValue;
            lb_gainValue.Text = currentGainValue.ToString();

            UpdateCameraSet();
        }

        private void btn_gainIncrease_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode || !GlobalData.Instance.cameraIsConnect)
            {
                return;
            }

            var currentGainValue = GlobalData.Instance.configs.frmPunchPressCfg.gain;
            if (currentGainValue >= UtilityValue.GainMaxValue)
            {
                return;
            }
            currentGainValue += UtilityValue.GainSetStepSize;
            GlobalData.Instance.configs.frmPunchPressCfg.gain = currentGainValue;
            lb_gainValue.Text = currentGainValue.ToString();

            UpdateCameraSet();
            //切换界面给
            uiTabControl1.SelectedIndex = 1;
        }

        private void cBox_debugMode_Click(object sender, EventArgs e)
        {
            GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode = true;
            GlobalData.Instance.configs.frmPunchPressCfg.isWorkMode = false;
            cBox_debugMode.Checked = true;
            cBox_workMode.Checked=false;


            //禁用模块加速显示
            
            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];

            var imageSource = (ImageSourceModuleCs.ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];
            vmRenderControl1.ModuleSource = imageSource;

            fastFeatureMatch.IsForbidden = true;
            CalibTransform.IsForbidden = true;
            GlobalData.Instance.vmMainProcedure.ContinuousRunEnable = true;

            uiTabControl1.SelectedIndex = 0;

        }

        private void cBox_workMode_Click(object sender, EventArgs e)
        {
            GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode = false;
            GlobalData.Instance.configs.frmPunchPressCfg.isWorkMode = true;
            cBox_debugMode.Checked = false;
            cBox_workMode.Checked = true;

            //禁用模块加速显示

            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
            IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];

            vmRenderControl1.ModuleSource = fastFeatureMatch;
            GlobalData.Instance.vmMainProcedure.ContinuousRunEnable = false;

            fastFeatureMatch.IsForbidden = false;
            CalibTransform.IsForbidden = false;
            var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;
            cameraParam.TriggerSource=0; // 设置触发源为硬触发
        }

        private void cBox_upLight_CheckedChanged(object sender, EventArgs e)
        {
            GlobalData.Instance.modbusTool.writeBool(860,true);
        }

        private void btn_xIncease_Click(object sender, EventArgs e)
        {
           
            var currentX = GlobalData.Instance.configs.frmPunchPressCfg.centralX;
            currentX += 100;
            GlobalData.Instance.configs.frmPunchPressCfg.centralX = currentX;
            lb_centralX.Text = currentX.ToString();
        }

        private void btn_xDecrease_Click(object sender, EventArgs e)
        {
            var currentX = GlobalData.Instance.configs.frmPunchPressCfg.centralX;
            currentX -= 100;
            GlobalData.Instance.configs.frmPunchPressCfg.centralX = currentX;
            lb_centralX.Text = currentX.ToString();
        }

        private void btn_yDecrease_Click(object sender, EventArgs e)
        {
            var currentY = GlobalData.Instance.configs.frmPunchPressCfg.centralY;
            currentY -= 100;
            GlobalData.Instance.configs.frmPunchPressCfg.centralY = currentY;
            lb_centralY.Text = currentY.ToString();
        }

        private void btn_yIncease_Click(object sender, EventArgs e)
        {
            var currentY = GlobalData.Instance.configs.frmPunchPressCfg.centralY;
            currentY += 100;
            GlobalData.Instance.configs.frmPunchPressCfg.centralY = currentY;
            lb_centralY.Text = currentY.ToString();
        }

        private void btn_angleDecrease_Click(object sender, EventArgs e)
        {
            var currentAngle = GlobalData.Instance.configs.frmPunchPressCfg.angle;
            currentAngle -= 10;
            GlobalData.Instance.configs.frmPunchPressCfg.angle = currentAngle;
            lb_angle.Text = currentAngle.ToString();
        }

        private void btn_angleIncease_Click(object sender, EventArgs e)
        {
            var currentAngle = GlobalData.Instance.configs.frmPunchPressCfg.angle;
            currentAngle += 10;
            GlobalData.Instance.configs.frmPunchPressCfg.angle = currentAngle;
            lb_angle.Text = currentAngle.ToString();
        }
    }
}
