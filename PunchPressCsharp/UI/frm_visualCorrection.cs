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
using PunchPressCsharp.Func;
using TranslationCalibModuCs;
using VM.Core;
using VMControls.BaseInterface;

namespace PunchPressCsharp.UI
{
    public partial class Frm_visualCorrection : Form
    {
        private bool _hasPunch = false;
        private bool _hasCalibrationForDistortion = false;
        private bool _hasCalibrationForNine = false;
        private bool isclickJibianjiaozheng = false;




        private void inisoljibian()
        {
            var path = GlobalPath.VMSolPathjibian;
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("流程文件不存在，请检查路径是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string version;

            try
            {
                 version = VmSolution.Instance.GetSolutionVersion(path, "");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            
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
        }
        private void inisoljiudian()
        {
            var path = GlobalPath.VMSolPathjiudain;
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
        }

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
            inisoljibian();

             var config = GlobalData.Instance.configs.visualCorrectionCfg;
            UtilityFunc.ChangeDownLightStatus(config.lightCfgForDistortion.isDownLightOpen);
            UtilityFunc.ChangeUpLightStatus(config.lightCfgForDistortion.isUpLightOpen);
            UtilityFunc.UpdateCameraGain(config.cameraCfgForDistortion.gain);
            UtilityFunc.UpdateCameraExposureTime(config.cameraCfgForDistortion.exposureTime);
            //设置相机为软触发模式
            var ImageCorrectCalibModu = (IMVSImageCalibModuCs.IMVSImageCalibModuTool)VmSolution.Instance["流程1.畸变标定1"];
            ImageCorrectCalibModu.IsForbidden = true;
            if (GlobalData.Instance.cameraIsConnect)
            {
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;

                cameraParam.TriggerSource = 7; // 设置触发源为软触发
            }
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];

            try
            {
                vmProcess1.ContinuousRunEnable = true;
                vmRenderControl1.ModuleSource = ImageCorrectCalibModu;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            




        }

        private void IniCameraAndLightForNine()
        {
            inisoljiudian();
              var config = GlobalData.Instance.configs.visualCorrectionCfg;
            UtilityFunc.ChangeDownLightStatus(config.lightCfgForNine.isDownLightOpen);
            UtilityFunc.ChangeUpLightStatus(config.lightCfgForNine.isUpLightOpen);
            UtilityFunc.UpdateCameraGain(config.cameraCfgForNine.gain);
            UtilityFunc.UpdateCameraExposureTime(config.cameraCfgForNine.exposureTime);
            


            if (GlobalData.Instance.cameraIsConnect)
            {
               
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;
                cameraParam.TriggerSource = 0; // 设置触发源为硬触发
            }
            
            var TranslationCalibModu = (TranslationCalibModuTool)VmSolution.Instance["流程1.平移选择标定1"];
           
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];

          
            vmRenderControl1.ModuleSource = TranslationCalibModu;
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

           




         

        }

        private void VmProcess1_OnWorkEndStatusCallBack(object sender, EventArgs e)
        {

           




        }

       

        private void pic_Close_Click(object sender, EventArgs e)
        {
            ResetCameraAndLight();

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



            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];

            //加载流程畸变矫正

            var lationCalibModuTool = (TranslationCalibModuTool)VmSolution.Instance["流程1.平移旋转标定1"];

            vmRenderControl1.ModuleSource = lationCalibModuTool;
            var ImageCorrectCalibModuTool = (IMVSImageCorrectCalibModuTool)VmSolution.Instance["流程1.畸变校正1"];

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


            var translationCalibModuTool = (TranslationCalibModuTool)VmSolution.Instance["流程1.平移旋转标定1"];

            translationCalibModuTool.ModuParams.DoSaveFile(GlobalPath.DataJiudianbiaodingLoadPath);



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

            var ImageCorrectCalibModu = (IMVSImageCalibModuCs.IMVSImageCalibModuTool)VmSolution.Instance["流程1.畸变标定1"];
            ImageCorrectCalibModu.IsForbidden = false;
            VmProcedure vmProcess1 = (VmProcedure)VmSolution.Instance["流程1"];

            vmProcess1.ContinuousRunEnable = false;

            
            ImageCorrectCalibModu.Run();

            // **关键步骤：导出标定文件**
            ImageCorrectCalibModu.ModuParams.DoSaveFile(GlobalPath.DataJibianJiaoZhengLoadPath);


            _hasCalibrationForDistortion = true;
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
                // 监控如果超时直接跳出循环（超时时间 60 秒）
                int timeoutMs = 60000;
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
