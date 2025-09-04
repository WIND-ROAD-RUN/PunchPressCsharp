using GlobalCameraModuleCs;
using Newtonsoft.Json;
using PunchPressCsharp.HardwareCom;
using System.IO;
using VM.Core;

namespace PunchPressCsharp.Data
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

    internal class GlobalData
    {
        // 私有静态只读实例
        private static readonly GlobalData _Instance = new GlobalData();

        // 私有构造函数，防止外部实例化
        private GlobalData()
        {
        }

        // 公共静态属性获取唯一实例
        public static GlobalData Instance
        {
            get { return _Instance; }
        }

        #region 成员

        public ModbusTool modbusTool;
        public VmProcedure vmMainProcedure;
        public GlobalCameraModuleTool cameraModuleTool;
        public Configs configs = new Configs();

        #endregion 成员
    }
}