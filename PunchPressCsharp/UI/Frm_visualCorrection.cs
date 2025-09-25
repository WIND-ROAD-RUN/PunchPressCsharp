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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslationCalibModuCs;
using VM.Core;
using VMControls.BaseInterface;

namespace PunchPressCsharp.UI
{
    public partial class Frm_visualCorrection : Form
    {
        private VmProcedure vmProcess1;
        private bool _hasPunch = false;
        private bool _hasCalibrationForDistortion = false;
        private bool _hasCalibrationForNine = false;
        private bool isclickJibianjiaozheng = false;

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
            //设置相机为软触发模式
            GlobalData.Instance.vmMainProcedure.ContinuousRunEnable = true;
            var ImageCorrectCalibModu = (IMVSImageCalibModuCs.IMVSImageCalibModuTool)VmSolution.Instance["流程2.畸变标定1"];
            ImageCorrectCalibModu.IsForbidden = true;
            if (GlobalData.Instance.cameraIsConnect)
            {
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;

                cameraParam.TriggerSource = 7; // 设置触发源为软触发
            }





        }

        private void IniCameraAndLightForNine()
        {
            var config = GlobalData.Instance.configs.visualCorrectionCfg;
            UtilityFunc.ChangeDownLightStatus(config.lightCfgForNine.isDownLightOpen);
            UtilityFunc.ChangeUpLightStatus(config.lightCfgForNine.isUpLightOpen);
            UtilityFunc.UpdateCameraGain(config.cameraCfgForNine.gain);
            UtilityFunc.UpdateCameraExposureTime(config.cameraCfgForNine.exposureTime);

            //设置相机为硬触发模式
            GlobalData.Instance.vmMainProcedure.ContinuousRunEnable = false;


            if (GlobalData.Instance.cameraIsConnect)
            {
               
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;
                cameraParam.TriggerSource = 0; // 设置触发源为硬触发
            }

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
            //畸变矫正界面
            if (tab_stepManager.SelectedIndex == 0&& isclickJibianjiaozheng==true)
            {
                //如果畸变矫正完成
                _hasCalibrationForDistortion = true;
                


            }




        }

       

        private void pic_Close_Click(object sender, EventArgs e)
        {
            ResetCameraAndLight();
            //保存数据

            var translationCalibModuTool = (TranslationCalibModuTool)VmSolution.Instance["流程3.平移旋转标定1"];

            translationCalibModuTool.ModuParams.DoSaveFile(GlobalPath.DataJiudianbiaodingLoadPath);



            Close();
        }

        private void btn_nextStepForDistortion_Click(object sender, EventArgs e)
        {

            if (!_hasCalibrationForDistortion)
            {
                var result = MessageBox.Show(
                    "还没有完成畸变标定，是否要跳过该步骤？",
                    "提示",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            tab_stepManager.SelectedIndex = 1;


            IniCameraAndLightForNine();

            

            
            //加载流程畸变矫正
            vmProcess1 = (VmProcedure)VmSolution.Instance["流程3"];

            var lationCalibModuTool = (TranslationCalibModuTool)VmSolution.Instance["流程3.平移旋转标定"];

            vmRenderControl1.ModuleSource = lationCalibModuTool;
            var ImageCorrectCalibModuTool = (IMVSImageCorrectCalibModuTool)VmSolution.Instance["流程3.畸变矫正1"];

            if (System.IO.File.Exists(GlobalPath.DataJibianJiaoZhengLoadPath))
            {
                ImageCorrectCalibModuTool.ImportModel(GlobalPath.DataJibianJiaoZhengLoadPath);
            }
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
            btn_punchForNine.Enabled=false;
            //开个线程监控这个流程

            Task.Run(() =>
            {
                //再次回原
                GlobalData.Instance.modbusTool.writeBool(3, true);
                int timeoutMs = 10000;
                int elapsedMs = 0;
                while (true)
                {
                    Thread.Sleep(100);
                    elapsedMs += 100;
                    bool state = GlobalData.Instance.modbusTool.getbool(480);
                    if (state == false)
                    {
                        break;
                    }
                    if (elapsedMs >= timeoutMs)
                    {
                        // 超时处理
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show("回原操作超时！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                        break;
                    }
                }
                //开始冲压
                GlobalData.Instance.modbusTool.writeBool(1200, true);
                while (true)
                {
                    Thread.Sleep(100);
                    bool state = GlobalData.Instance.modbusTool.getbool(1210);
                    if (state == false)
                    {
                        break;
                    }
                }

               
                //跨线程安全修改窗体控件
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("冲压完成！", "提示", MessageBoxButtons.OK);
                    
                    btn_punchForNine.Enabled = true;
                }));

            });
                


           


            _hasPunch = true;




            label_info.Visible = true;
        }

        private void btn_calibrationForDistortion_Click(object sender, EventArgs e)
        {

            var ImageCorrectCalibModu = (IMVSImageCalibModuCs.IMVSImageCalibModuTool)VmSolution.Instance["流程2.畸变标定1"];
            ImageCorrectCalibModu.IsForbidden = false;
            vmProcess1.ContinuousRunEnable = false;

            
            ImageCorrectCalibModu.Run();

            // **关键步骤：导出标定文件**
            ImageCorrectCalibModu.ModuParams.DoSaveFile(GlobalPath.DataJibianJiaoZhengLoadPath);



        }

        private void btn_calibrationForNine_Click(object sender, EventArgs e)
        {
            if (!_hasPunch)
            {
                MessageBox.Show(@"请先完成冲压操作！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btn_calibrationForNine.Enabled = false;

            Task.Run(() =>
            {
                //再次回原
                GlobalData.Instance.modbusTool.writeBool(1220, true);
                // 监控如果超时直接跳出循环（超时时间 10 秒）
                int timeoutMs = 10000;
                int elapsedMs = 0;
                while (true)
                {
                    Thread.Sleep(100);
                    elapsedMs += 100;
                    bool state = GlobalData.Instance.modbusTool.getbool(1230);
                    if (state == false)
                    {
                        break;
                    }
                    if (elapsedMs >= timeoutMs)
                    {
                        // 超时处理
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show("九点标定回原操作超时！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                        break;
                    }
                }



                //跨线程安全修改窗体控件
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("九点标定完成！", "提示", MessageBoxButtons.OK);

                    btn_calibrationForDistortion.Enabled = true;
                }));

            });










            _hasCalibrationForNine = true;
        }

    }
}
