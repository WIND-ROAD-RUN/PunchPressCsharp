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

        internal class Configs
        {
            public FrmSetCfg frmSetCfg = new FrmSetCfg();

            public void SaveConfigs()
            {
                frmSetCfg.SaveToFile(GlobalPath.FrmSetCfgPath);
            }

            public void LoadConfigs()
            {
                if (File.Exists(GlobalPath.FrmSetCfgPath))
                {
                    frmSetCfg = FrmSetCfg.LoadFromFile(GlobalPath.FrmSetCfgPath);
                }
                else
                {
                    frmSetCfg.SaveToFile(GlobalPath.FrmSetCfgPath);
                }
            }
        }
    }
}
