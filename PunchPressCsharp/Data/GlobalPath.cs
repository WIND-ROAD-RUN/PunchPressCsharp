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
        // 私有静态只读实例
        private static readonly GlobalPath _Instance = new GlobalPath();

        private GlobalPath()
        {
        }

        public static GlobalPath Instance
        {
            get { return _Instance; }
        }


        #region 成员
         
        public string vmSolPath = @"C:\Users\rw\Desktop\1.sol";

        #endregion
    }
}
