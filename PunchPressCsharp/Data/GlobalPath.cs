using PunchPressCsharp.HardwareCom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchPressCsharp.Data
{
    internal class GlobalPath
    {

        #region 成员
         
        public static string VMSolPath = @"C:\Users\rw\Desktop\1.sol";

        #endregion


        #region 配置

        private static readonly string _ProjectHome = @"D:\zfkjData\PunchPress";
        private static readonly string _ConfigRootPath= _ProjectHome+@"\Config";
        public static string FrmSetCfgPath= _ConfigRootPath+@"\Frm_setCfg.json";

        #endregion

    }
}
