namespace PunchPressCsharp.Data
{
    internal class GlobalPath
    {
        #region 配置

        private static readonly string _ProjectHome = @"D:\zfkjData\PunchPress";
        private static readonly string _ConfigRootPath = _ProjectHome + @"\Config";
        public static readonly string FrmSetCfgPath = _ConfigRootPath + @"\Frm_setCfg.json";
        public static readonly string FrmPunchPressCfgPath = _ConfigRootPath + @"\Frm_PunchPressCfg.json";
        public static readonly string FrmConfigurationCfgPath = _ConfigRootPath + @"\Frm_ConfigurationCfg.json";
        public static readonly string VisualCorrectionCfgPath = _ConfigRootPath + @"\VisualCorrectionCfg.json";

        #endregion 配置

        #region 模型

        public static readonly string ModelHome=_ProjectHome+ @"\Templates";
        public static readonly string ModelConfigName = "ModelConfig.json";
        public static readonly string SourceImgName = "sourceImg.jpg";
        public static readonly string ModelBinName = "model.bin";
        public static readonly string ModelLoadPath= _ProjectHome + @"\\model\\"+ ModelBinName;
        #endregion

        #region 解决方案
        public static readonly string SolutionBackupDir = _ProjectHome + @"\sol";

        public static readonly string VMSolPath = SolutionBackupDir+@"\shibie.sol";
        #endregion
    }
}