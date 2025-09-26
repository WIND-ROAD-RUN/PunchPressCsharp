using PunchPressCsharp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchPressCsharp.Utility
{
    enum ConnectStatus
    {
        Connected = 0,
        Disconnected = 1,
        Reconnecting = 2

    }

    internal class UtilityFunc
    {
        public static bool UpdateCameraGain(int value)
        {
            try
            {
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;
                cameraParam.Gain = value;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UpdateCameraExposureTime(int value)
        {
            try
            {
                var cameraParam = GlobalData.Instance.cameraModuleTool.ModuParams;
                cameraParam.ExposureTime = value;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static void ChangeUpLightStatus(bool status)
        {
            GlobalData.Instance.modbusTool.writeBool(5013, status);
        }

        public static void ChangeDownLightStatus(bool status)
        {
            GlobalData.Instance.modbusTool.writeBool(5014, status);
        }
    }


}
