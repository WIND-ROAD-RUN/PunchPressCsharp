using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchPressCsharp.Data
{
    internal class Config
    {

        #region 界面配置
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
            public int exposureTime = 50000;
            public int gain = 5;
            public float centralX = 100;
            public float centralY = 100;
            public float angle = 0;
            public float PixToWorld = 0.1F;
            public bool isWorkMode = true;
            public bool isDebugMode = false;
            public bool isUpLightOpen = false;
            public bool isDownLightOpen = false;
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
            public int exposureTimeMax = 1000;
            public int gainMin = 0;
            public int gainMax = 20;

            public float centralXCorrectionMin = 0;
            public float centralXCorrectionMax = 200;
            public float centralYCorrectionMin = 0;
            public float centralYCorrectionMax = 200;
            public float angleCorrectionMin = -360;
            public float angleCorrectionMax = 360;

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


        internal class Configs
        {
            //public FrmSetCfg frmSetCfg = new FrmSetCfg();
            public FrmPunchPressCfg frmPunchPressCfg = new FrmPunchPressCfg();
            public FrmConfigurationCfg frmConfigurationCfg = new FrmConfigurationCfg();

            public void SaveConfigs()
            {
                //frmSetCfg.SaveToFile(GlobalPath.FrmSetCfgPath);
                frmPunchPressCfg.SaveToFile(GlobalPath.FrmPunchPressCfgPath);
                frmConfigurationCfg.SaveToFile(GlobalPath.FrmConfigurationCfgPath);
            }

            public void LoadConfigs()
            {
                if (File.Exists(GlobalPath.FrmSetCfgPath))
                {
                    //frmSetCfg = FrmSetCfg.LoadFromFile(GlobalPath.FrmSetCfgPath);
                }
                else
                {
                    //frmSetCfg.SaveToFile(GlobalPath.FrmSetCfgPath);
                }

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
            }
        }
    }
}
