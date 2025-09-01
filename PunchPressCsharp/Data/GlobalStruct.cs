using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PunchPressCsharp.HardwareCom;

namespace PunchPressCsharp.Data
{
    internal class GlobalStruct
    {
        // 私有静态只读实例
        private static readonly GlobalStruct _Instance = new GlobalStruct();

        // 私有构造函数，防止外部实例化
        private GlobalStruct()
        {
        }

        // 公共静态属性获取唯一实例
        public static GlobalStruct Instance
        {
            get { return _Instance; }
        }

        public ModbusTool modbusTool;
    }
}
