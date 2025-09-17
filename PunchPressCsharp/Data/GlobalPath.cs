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
        public static string FrmSetCfgPath = _ConfigRootPath + @"\Frm_setCfg.json";
        public static string FrmPunchPressCfgPath = _ConfigRootPath + @"\Frm_PunchPressCfg.json";

        #endregion 配置
    }
}