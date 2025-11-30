using IMVSColorTransformModuCs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Core;
using static PunchPressCsharp.Data.Config;

namespace PunchPressCsharp.Data
{
    internal class Config
    {

        #region 界面配置

        internal class LightCfg
        {
            public bool isUpLightOpen = false;
            public bool isDownLightOpen = false;
        }

        internal class ImageCfg
        {
            ColorTransformParam param ;

        }



        internal class CorrectionCfg
        {
            public float centralX = 0;
            public float centralY = 0;
            public float angle = 0;
        }

        internal class CameraCfg
        {
            public int exposureTime = 50000;
            public int gain = 5;
        }

        internal class FrmSetCfg
        {
            public int exposureTime = 50000;
            public int gain = 5;

            public void SaveToFile(string filePath)
            {
                var json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

            public static FrmSetCfg LoadFromFile(string filePath)
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<FrmSetCfg>(json);
            }
        }


        internal class FrmPunchPressCfg
        {
            public LightCfg lightCfg = new LightCfg();
            public CorrectionCfg correction = new CorrectionCfg();
            public CameraCfg cameraCfg = new CameraCfg();
            

            public float PixToWorld = 0.1F;
            public bool isWorkMode = true;
            public bool isDebugMode = false;
            public string lastLoadModelDirPath = "default";

            public void SaveToFile(string filePath)
            {
                var json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

            public static FrmPunchPressCfg LoadFromFile(string filePath)
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<FrmPunchPressCfg>(json);
            }
        }


        internal class FrmConfigurationCfg
        {
            public int exposureTimeMin = 0;
            public int exposureTimeMax = 500000;
            public int exposureTimeStep = 1000;

            public int gainMin = 0;
            public int gainMax = 20;
            public int gainStep = 1;

            public float centralXCorrectionMin = -1000;
            public float centralXCorrectionMax = 1000;
            public float centralXCorrectionStep = 0.1f;

            public float centralYCorrectionMin = -1000;
            public float centralYCorrectionMax = 1000;
            public float centralYCorrectionStep = 0.1f;


            public float angleCorrectionMin = -360;
            public float angleCorrectionMax = 360;
            public float angleCorrectionStep = 0.1f;

            public void SaveToFile(string filePath)
            {
                var json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

            public static FrmConfigurationCfg LoadFromFile(string filePath)
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<FrmConfigurationCfg>(json);
            }
        }

        #endregion

        #region 模型配置

        internal class ModelConfig
        {
            public string trainDate;
            public LightCfg lightCfg = new LightCfg();
            public CorrectionCfg correction = new CorrectionCfg();
            public CameraCfg cameraCfg = new CameraCfg();
            public string modelName="default";
            public void SaveToFile(string filePath)
             {
                var dir = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                var json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

             public static ModelConfig LoadFromFile(string filePath)
             {
                 var json = File.ReadAllText(filePath);
                 return JsonConvert.DeserializeObject<ModelConfig>(json);
             }

        }


        #endregion

        #region 标定界面光源和参数配置
        internal class VisualCorrectionCfg
        {
            public LightCfg lightCfgForDistortion = new LightCfg();
            public CameraCfg cameraCfgForDistortion = new CameraCfg();
            public LightCfg lightCfgForNine = new LightCfg();
            public CameraCfg cameraCfgForNine = new CameraCfg();
            public void SaveToFile(string filePath)
            {
                var dir = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                var json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

            public static VisualCorrectionCfg LoadFromFile(string filePath)
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<VisualCorrectionCfg>(json);
            }
        }
        #endregion

        internal class Configs
        {
            public FrmPunchPressCfg frmPunchPressCfg = new FrmPunchPressCfg();
            public FrmConfigurationCfg frmConfigurationCfg = new FrmConfigurationCfg();
            public VisualCorrectionCfg visualCorrectionCfg = new VisualCorrectionCfg();

            public void SaveConfigs()
            {
                frmPunchPressCfg.SaveToFile(GlobalPath.FrmPunchPressCfgPath);
                frmConfigurationCfg.SaveToFile(GlobalPath.FrmConfigurationCfgPath);
                visualCorrectionCfg.SaveToFile(GlobalPath.VisualCorrectionCfgPath);

                //TODO:保存选择通道参数
             

                try
                {
                    VmSolution.Save();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
            }

            public void LoadConfigs()
            {
                if (File.Exists(GlobalPath.FrmPunchPressCfgPath))
                {
                    frmPunchPressCfg = FrmPunchPressCfg.LoadFromFile(GlobalPath.FrmPunchPressCfgPath);
                }
                else
                {
                    frmPunchPressCfg.SaveToFile(GlobalPath.FrmPunchPressCfgPath);
                }

                if (File.Exists(GlobalPath.FrmConfigurationCfgPath))
                {
                    frmConfigurationCfg = FrmConfigurationCfg.LoadFromFile(GlobalPath.FrmConfigurationCfgPath);
                }
                else
                {
                    frmConfigurationCfg.SaveToFile(GlobalPath.FrmConfigurationCfgPath);
                }
                if (File.Exists(GlobalPath.VisualCorrectionCfgPath))
                {
                    visualCorrectionCfg = VisualCorrectionCfg.LoadFromFile(GlobalPath.VisualCorrectionCfgPath);
                }
                else
                {
                    visualCorrectionCfg.SaveToFile(GlobalPath.VisualCorrectionCfgPath);
                }
            }
        }
    }
}
