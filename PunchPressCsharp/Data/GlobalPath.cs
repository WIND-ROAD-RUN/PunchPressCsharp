namespace PunchPressCsharp.Data
{
    internal class GlobalPath
    {
        #region 成员

        public static string VMSolPath = @"D:\zfkjData\PunchPress\shibie.sol";

        #endregion 成员

        #region 配置

        private static readonly string _ProjectHome = @"D:\zfkjData\PunchPress";
        private static readonly string _ConfigRootPath = _ProjectHome + @"\Config";
        public static readonly string FrmSetCfgPath = _ConfigRootPath + @"\Frm_setCfg.json";
        public static readonly string FrmPunchPressCfgPath = _ConfigRootPath + @"\Frm_PunchPressCfg.json";
        public static readonly string FrmConfigurationCfgPath = _ConfigRootPath + @"\Frm_ConfigurationCfg.json";

        #endregion 配置

        #region 模型

        public static readonly string ModelHome=_ProjectHome+ @"\Templates";
        public static readonly string ModelConfigName = "ModelConfig.json";
        public static readonly string ProImgName = "proImg.jpg";
        public static readonly string SourceImgName = "sourceImg.jpg";
        #endregion
    }
}