using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchPressCsharp.Utility
{
    internal class UtilityValue
    {
        public static string ModbusToolAddr = "192.168.6.6";
        public static int ModbusToolPort = 502;
        public static string VMVersion = "V4.4.0";

        public static int ExposureMinValue = 1000;
        public static int ExposureSetStepSize = 1000;
        public static int ExposureMaxValue = 800000;

        public static int GainMinValue = 0;
        public static int GainSetStepSize = 1;
        public static int GainMaxValue = 20;
    }
}
