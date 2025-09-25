using CameraIOModuleCs;
using GlobalCameraModuleCs;
using IMVSCalibTransformModuCs;
using IMVSGeometricTransformModuCs;
using IMVSHPFeatureMatchModuCs;
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
using System.IO;
using System.Threading;
using System.Windows.Forms;
using VM.Core;
using VM.PlatformSDKCS;
using static PunchPressCsharp.Data.Config;

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
            cBox_workMode.Checked = true;
            cBox_debugMode.Checked = false;
           
        }

        private void LoadConfig()
        {
            GlobalData.Instance.configs.LoadConfigs();
            var cfg = GlobalData.Instance.configs.frmPunchPressCfg;
            lb_exposureValue.Text= cfg.cameraCfg.exposureTime.ToString();
            lb_gainValue.Text= cfg.cameraCfg.gain.ToString();
            cBox_workMode.Checked= cfg.isDebugMode;
            cBox_upLight.Checked= cfg.lightCfg.isUpLightOpen;
            cBox_downLight.Checked= cfg.lightCfg.isDownLightOpen;
            cBox_debugMode.Checked=cfg.isWorkMode;
            lb_centralX.Text=cfg.correction.centralX.ToString();
            lb_centralY.Text = cfg.correction.centralY.ToString();

            
            double currentAngle = GlobalData.Instance.configs.frmPunchPressCfg.correction.angle;
            GlobalData.Instance.configs.frmPunchPressCfg.correction.angle = (float)currentAngle;
            lb_angle.Text = currentAngle.ToString("F1");

            //read last loaded model
            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
            vmRenderControl1.ModuleSource = FeatureMatch;
            var lastModelPath = GlobalData.Instance.configs.frmPunchPressCfg.lastLoadModelDirPath + "\\" + GlobalPath.ModelConfigName;
            if (System.IO.File.Exists(lastModelPath))
            {
                byte[] modelData = File.ReadAllBytes(GlobalPath.ModelLoadPath);

                FeatureMatch.ImportModel(modelData);
            }
            else if(System.IO.File.Exists(GlobalPath.ModelLoadPath))
            { 
                byte[] modelData = File.ReadAllBytes(GlobalPath.ModelLoadPath);
                FeatureMatch.ImportModel(modelData);
            }

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


            var lightCfg = GlobalData.Instance.configs.frmPunchPressCfg.lightCfg;
            if (connectResult)
            {
                modbus.writeBool(5013, lightCfg.isUpLightOpen);
                modbus.writeBool(5014, lightCfg.isUpLightOpen);
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

            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
            vmRenderControl1.ModuleSource = FeatureMatch;

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
                    cameraParam.ExposureTime = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.exposureTime;
                    cameraParam.Gain = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.gain;
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
            IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];
            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
            // var angles= fastFeatureMatch.ModuResult.MatchRect;
            var points = CalibTransform.ModuResult.TransPoint;
            var angles = CalibTransform.ModuResult.WorldPointA;
            // bool isPostive = GlobalData.Instance.modbusTool.readbool(330);
            


            if (points.Count == 1)
            {
               

                for (int i = 0; i < points.Count; i++)
                {
                    // 原始点
                    float x = -points[i].X;
                    float y = -points[i].Y;
                    float angle = angles[i];

                    // 偏移参数
                    float offsetx = GlobalData.Instance.configs.frmPunchPressCfg.correction.centralX;
                    float offsety = GlobalData.Instance.configs.frmPunchPressCfg.correction.centralY;
                    float offsetAngle = GlobalData.Instance.configs.frmPunchPressCfg.correction.angle;

                    // 角度转弧度
                    float rad = (angle) * (float)Math.PI / 180f;




                    // 坐标变换：以原始点为原心，角度偏移建立新坐标系
                    float tx = x + offsetx * (float)Math.Cos(rad) - offsety * (float)Math.Sin(rad);
                    float ty = y + offsetx * (float)Math.Sin(rad) + offsety * (float)Math.Cos(rad);
                    float tangle = angle + offsetAngle;

                    // 发送数据
                    float sendx = tx*100;
                    float sendy = ty*100;
                    float sendangle = tangle * 100;


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
                cameraParam.ExposureTime = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.exposureTime;
                cameraParam.Gain = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.gain;

            }
            catch (Exception ex)
            {
                AppendLog($"设置相机参数异常: {ex.Message}");
            }

        }

        #endregion


        #region UI事件触发

        private void btn_templateLearn_Click(object sender, EventArgs e)
        {
                Frm_Learning frm_Learning = new Frm_Learning(true);
                frm_Learning.ShowDialog();
        }


        private bool _isClosing = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_isClosing) return; 
            _isClosing = true;

            GlobalData.Instance.configs.SaveConfigs();
            DesExtraComponent();
            this.Close();
        }

        private void btn_disTemplate_Click(object sender, EventArgs e)
        {
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];
            //设置图像
            IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
            vmRenderControl1.ModuleSource = FeatureMatch;


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

            Frm_Configuration frmSet = new Frm_Configuration();
            frmSet.ShowDialog();
        }

        private void btn_runOnce_Click(object sender, EventArgs e)
        {
            if (GlobalData.Instance.cameraIsConnect)
            {
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;

                cameraParam.TriggerSource = 7; // 设置触发源为软触发

                var procedure = GlobalData.Instance.vmMainProcedure;
                if (!procedure.IsRunning)
                {
                    procedure.Run();
                }
            }
        }

        private void Frm_PunchPress_SizeChanged(object sender, EventArgs e)
        {
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
        }

        private void btn_exposureReduce_Click(object sender, EventArgs e)
        {
            var min = GlobalData.Instance.configs.frmConfigurationCfg.exposureTimeMin;
            var currentExposureValue = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.exposureTime;

            if (Math.Abs(currentExposureValue - min) < 0.001f)
            {
                MessageBox.Show($@"已超过最小值！最小值为：{min}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentExposureValue - GlobalData.Instance.configs.frmConfigurationCfg.exposureTimeStep;
            if (newValue < min)
            {
                newValue = min;
            }
            GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.exposureTime = newValue;
            lb_exposureValue.Text = newValue.ToString();

            UpdateCameraSet();
        }

        private void btn_exposureIncrease_Click(object sender, EventArgs e)
        {
            var max = GlobalData.Instance.configs.frmConfigurationCfg.exposureTimeMax;
            var currentExposureValue = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.exposureTime;

            if (Math.Abs(currentExposureValue - max) < 0.001f)
            {
                MessageBox.Show($@"已超过最大值！最大值为：{max}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentExposureValue + GlobalData.Instance.configs.frmConfigurationCfg.exposureTimeStep;
            if (newValue > max)
            {
                newValue = max;
            }
            GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.exposureTime = newValue;
            lb_exposureValue.Text = newValue.ToString();

            UpdateCameraSet();
        }

        private void btn_gainReduce_Click(object sender, EventArgs e)
        {
            var min = GlobalData.Instance.configs.frmConfigurationCfg.gainMin;
            var currentGainValue = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.gain;

            if (Math.Abs(currentGainValue - min) < 0.001f)
            {
                MessageBox.Show($@"已超过最小值！最小值为：{min}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentGainValue - GlobalData.Instance.configs.frmConfigurationCfg.gainStep;
            if (newValue < min)
            {
                newValue = min;
            }
            GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.gain = newValue;
            lb_gainValue.Text = newValue.ToString();

            UpdateCameraSet();
        }

        private void btn_gainIncrease_Click(object sender, EventArgs e)
        {
            var max = GlobalData.Instance.configs.frmConfigurationCfg.gainMax;
            var currentGainValue = GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.gain;

            if (Math.Abs(currentGainValue - max) < 0.001f)
            {
                MessageBox.Show($@"已超过最大值！最大值为：{max}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentGainValue + GlobalData.Instance.configs.frmConfigurationCfg.gainStep;
            if (newValue > max)
            {
                newValue = max;
            }
            GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.gain = newValue;
            lb_gainValue.Text = newValue.ToString();

            UpdateCameraSet();
        }

        private void cBox_debugMode_Click(object sender, EventArgs e)
        {
                if (cBox_workMode.Checked)
                {
                    GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode = true;
                    GlobalData.Instance.configs.frmPunchPressCfg.isWorkMode = false;
                    cBox_debugMode.Checked = true;
                    cBox_workMode.Checked = false;


                    //禁用模块加速显示

                    IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];
                    IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];
                    IMVSGeometricTransformModuTool GeoTransform = (IMVSGeometricTransformModuTool)VmSolution.Instance["流程1.几何变换1"];
                    //var imageSource = (ImageSourceModuleCs.ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];



                    vmRenderControl1.ModuleSource = FeatureMatch;

                    FeatureMatch.IsForbidden = true;
                    CalibTransform.IsForbidden = true;
                    GlobalData.Instance.vmMainProcedure.ContinuousRunEnable = true;

                    if (GlobalData.Instance.cameraIsConnect)
                    {
                        var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;

                        cameraParam.TriggerSource = 7; // 设置触发源为软触发
                    }

                    modernTabControl1.SelectedIndex = 1;
                }
                else
                {
                    cBox_debugMode.Checked = true;
                }

        }

        private void cBox_workMode_Click(object sender, EventArgs e)
        {
            if (cBox_debugMode.Checked)
            {
                GlobalData.Instance.configs.frmPunchPressCfg.isDebugMode = false;
                GlobalData.Instance.configs.frmPunchPressCfg.isWorkMode = true;
                cBox_debugMode.Checked = false;

                cBox_workMode.Checked = true;

                //禁用模块加速显示
                IMVSHPFeatureMatchModuTool FeatureMatch = (IMVSHPFeatureMatchModuTool)VmSolution.Instance["流程1.高精度匹配1"];

                IMVSCalibTransformModuTool CalibTransform = (IMVSCalibTransformModuTool)VmSolution.Instance["流程1.标定转换1"];

                vmRenderControl1.ModuleSource = FeatureMatch;
                GlobalData.Instance.vmMainProcedure.ContinuousRunEnable = false;


                if (GlobalData.Instance.cameraIsConnect)
                {
                    FeatureMatch.IsForbidden = false;
                    CalibTransform.IsForbidden = false;
                    var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;
                    cameraParam.TriggerSource = 0; // 设置触发源为硬触发
                }

                modernTabControl1.SelectedIndex = 0;
            }
            else
            {
                cBox_workMode.Checked = true;
            }

        }

        private void cBox_upLight_CheckedChanged(object sender, EventArgs e)
        {
            GlobalData.Instance.configs.frmPunchPressCfg.lightCfg.isUpLightOpen = cBox_upLight.Checked;
            GlobalData.Instance.modbusTool.writeBool(5013, GlobalData.Instance.configs.frmPunchPressCfg.lightCfg.isUpLightOpen);
        }

        private void btn_xIncease_Click(object sender, EventArgs e)
        {
            var max = GlobalData.Instance.configs.frmConfigurationCfg.centralXCorrectionMax;
            var currentX = GlobalData.Instance.configs.frmPunchPressCfg.correction.centralX;

            if (Math.Abs(currentX - max) < 0.001f)
            {
                MessageBox.Show($@"已超过最大值！最大值为：{max}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentX + GlobalData.Instance.configs.frmConfigurationCfg.centralXCorrectionStep;
            if (newValue > max)
            {
                newValue = max;
            }
            currentX = newValue;
            GlobalData.Instance.configs.frmPunchPressCfg.correction.centralX = currentX;
            lb_centralX.Text = currentX.ToString("F1");
        }

        private void btn_xDecrease_Click(object sender, EventArgs e)
        {
            var min = GlobalData.Instance.configs.frmConfigurationCfg.centralXCorrectionMin;
            var currentX = GlobalData.Instance.configs.frmPunchPressCfg.correction.centralX;

            if (Math.Abs(currentX - min) < 0.001f)
            {
                MessageBox.Show($@"已超过最小值！最小值为：{min}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentX - GlobalData.Instance.configs.frmConfigurationCfg.centralXCorrectionStep;
            if (newValue < min)
            {
                newValue = min;
            }
            currentX = newValue;
            GlobalData.Instance.configs.frmPunchPressCfg.correction.centralX = currentX;
            lb_centralX.Text = currentX.ToString("F1");




        }

        private void btn_yDecrease_Click(object sender, EventArgs e)
        {
            var min = GlobalData.Instance.configs.frmConfigurationCfg.centralYCorrectionMin;
            var currentY = GlobalData.Instance.configs.frmPunchPressCfg.correction.centralY;

            if (Math.Abs(currentY - min) < 0.001f)
            {
                MessageBox.Show($@"已超过最小值！最小值为：{min}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentY - GlobalData.Instance.configs.frmConfigurationCfg.centralYCorrectionStep;
            if (newValue < min)
            {
                newValue = min;
            }
            currentY = newValue;
            GlobalData.Instance.configs.frmPunchPressCfg.correction.centralY = currentY;
            lb_centralY.Text = currentY.ToString("F1");
        }

        private void btn_yIncease_Click(object sender, EventArgs e)
        {
            var max = GlobalData.Instance.configs.frmConfigurationCfg.centralYCorrectionMax;
            var currentY = GlobalData.Instance.configs.frmPunchPressCfg.correction.centralY;

            if (Math.Abs(currentY - max) < 0.001f)
            {
                MessageBox.Show($@"已超过最大值！最大值为：{max}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newValue = currentY + GlobalData.Instance.configs.frmConfigurationCfg.centralYCorrectionStep;
            if (newValue > max)
            {
                newValue = max;
            }
            currentY = newValue;
            GlobalData.Instance.configs.frmPunchPressCfg.correction.centralY = currentY;
            lb_centralY.Text = currentY.ToString("F1");
        }

        private void btn_angleDecrease_Click(object sender, EventArgs e)
        {
            var min = GlobalData.Instance.configs.frmConfigurationCfg.angleCorrectionMin;
            var currentAngle = GlobalData.Instance.configs.frmPunchPressCfg.correction.angle;
            if (currentAngle - 0.1 <= min)
            {
                MessageBox.Show($@"已超过最小值！最小值为：{min}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            currentAngle -= 0.1f;
            GlobalData.Instance.configs.frmPunchPressCfg.correction.angle = (float)currentAngle;
            lb_angle.Text = currentAngle.ToString("F1");
        }

        private void btn_angleIncease_Click(object sender, EventArgs e)
        {
            var max = GlobalData.Instance.configs.frmConfigurationCfg.angleCorrectionMax;
            var currentAngle = GlobalData.Instance.configs.frmPunchPressCfg.correction.angle;
            if (currentAngle + 0.1 >= max)
            {
                MessageBox.Show($@"已超过最大值！最大值为：{max}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            currentAngle += 0.1f;
            GlobalData.Instance.configs.frmPunchPressCfg.correction.angle = (float)currentAngle;
            lb_angle.Text = currentAngle.ToString("F1");
        }

        private void lb_centralX_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.centralXCorrectionMin, cfg.centralXCorrectionMax);
            numKeyBoard.ShowDialog();
            GlobalData.Instance.configs.frmPunchPressCfg.correction.centralX= float.Parse(lb_centralX.Text);
        }

        private void lb_exposureValue_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.exposureTimeMin, cfg.exposureTimeMax);
            numKeyBoard.ShowDialog();
            GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.exposureTime = int.Parse(lb_exposureValue.Text);
            UpdateCameraSet();

        }

        private void lb_gainValue_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.gainMin, cfg.gainMax);
            numKeyBoard.ShowDialog();
            GlobalData.Instance.configs.frmPunchPressCfg.cameraCfg.gain = int.Parse(lb_gainValue.Text);
            UpdateCameraSet();

        }

        private void lb_centralY_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.centralYCorrectionMin, cfg.centralYCorrectionMax);
            numKeyBoard.ShowDialog();
            GlobalData.Instance.configs.frmPunchPressCfg.correction.centralY = float.Parse(lb_centralY.Text);
        }

        private void lb_angle_Click(object sender, EventArgs e)
        {
            var cfg = GlobalData.Instance.configs.frmConfigurationCfg;
            Frm_InputPage numKeyBoard = new Frm_InputPage((Control)sender, cfg.angleCorrectionMin, cfg.angleCorrectionMax);
            numKeyBoard.ShowDialog();
            GlobalData.Instance.configs.frmPunchPressCfg.correction.angle = float.Parse(lb_angle.Text);
        }

        private void pbtn_templateLoad_Click(object sender, EventArgs e)
        {
            Frm_loadShapeModel frmLoadShapeModel = new Frm_loadShapeModel();
            frmLoadShapeModel.ShowDialog();
        }


        #endregion

        private void btn_changeModel_Click(object sender, EventArgs e)
        {
            Frm_Learning frm_Learning = new Frm_Learning(false);
            frm_Learning.ShowDialog();

        }



        private void cBox_downLight_CheckedChanged(object sender, EventArgs e)
        {
            GlobalData.Instance.configs.frmPunchPressCfg.lightCfg.isDownLightOpen = cBox_downLight.Checked;
            GlobalData.Instance.modbusTool.writeBool(5014, GlobalData.Instance.configs.frmPunchPressCfg.lightCfg.isDownLightOpen);
        }

        private void btn_visualCorrenction_Click(object sender, EventArgs e)
        {
            Frm_visualCorrection frmVisualCorrection=new Frm_visualCorrection();
            frmVisualCorrection.ShowDialog();
        }
    }
}
