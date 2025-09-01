using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PunchPressCsharp.HardwareCom;
using PunchPressCsharp.Utility;

namespace PunchPressCsharp.Data
{
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
        #endregion

    }
}
