using GlobalCameraModuleCs;
using IMVSColorTransformModuCs;
using IMVSImageEnhanceModuCs;
using IMVSImageFilterModuCs;
using Newtonsoft.Json;
using PunchPressCsharp.Func;
using PunchPressCsharp.HardwareCom;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using VM.Core;

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

       

        public ModbusTool modbusTool;
        public VmProcedure vmMainProcedure;
        public GlobalCameraModuleTool cameraModuleTool;
        public Config.Configs configs = new Config.Configs();
        public ModelManager modelManager = new ModelManager();
        public volatile bool cameraIsConnect = false;


        //TODO:序列化反序列化函数
        public static ImageProcessParam imageProcessParam=new ImageProcessParam();
        /// <summary>
        /// 将当前全局图像处理参数序列化并保存到指定路径（只保存各模块的 ModuParams）
        /// 返回 true 表示保存成功，false 表示失败。
        /// </summary>
        public static bool SaveImageProcessParam(string path)
        {
            try
            {
                var dto = new ImageProcessParamDto
                {
                    ColorConvert = imageProcessParam?.colorConvert?.ModuParams as ColorTransformParam,
                    ImageEnhance = imageProcessParam?.ImageEnhance?.ModuParams as ImageEnhanceParam,
                    ImageFilter = imageProcessParam?.ImageFilter?.ModuParams as ImageFilterParam
                };

                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented
                };

                string json = JsonConvert.SerializeObject(dto, settings);

                string dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.WriteAllText(path, json, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 从指定路径读取并反序列化图像处理参数，反序列化后会把参数赋回 VmSolution 中的对应模块并更新 GlobalData.imageProcessParam 的引用。
        /// 返回 true 表示成功，false 表示失败（文件不存在或反序列化异常）。
        /// </summary>
        public static bool LoadImageProcessParam(string path)
        {
            try
            {
                if (!File.Exists(path)) return false;

                string json = File.ReadAllText(path, Encoding.UTF8);

                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };

                var dto = JsonConvert.DeserializeObject<ImageProcessParamDto>(json, settings);
                if (dto == null) return false;

                // 获取模块并赋回参数（仅当参数非空时才赋值）
                var colorTool = (IMVSColorTransformModuTool)VmSolution.Instance["流程1.颜色转换1"];
                if (dto.ColorConvert != null)
                {
                    colorTool.ModuParams = dto.ColorConvert;
                }

                var enhanceTool = (IMVSImageEnhanceModuTool)VmSolution.Instance["流程1.图像增强1"];
                if (dto.ImageEnhance != null)
                {
                    enhanceTool.ModuParams = dto.ImageEnhance;
                }

                var filterTool = (IMVSImageFilterModuTool)VmSolution.Instance["流程1.图像滤波1"];
                if (dto.ImageFilter != null)
                {
                    filterTool.ModuParams = dto.ImageFilter;
                }

                // 更新全局引用，确保其他代码读取到最新的模块对象
                imageProcessParam.colorConvert = colorTool;
                imageProcessParam.ImageEnhance = enhanceTool;
                imageProcessParam.ImageFilter = filterTool;

                return true;
            }
            catch
            {
                return false;
            }
        }

    }

    // TODO：仅序列化模块参数（ModuParams），避免序列化复杂的模块工具对象内部状态
    internal class ImageProcessParamDto
    {
        public ColorTransformParam ColorConvert { get; set; }
        public ImageEnhanceParam ImageEnhance { get; set; }
        public ImageFilterParam ImageFilter { get; set; }
    }

}

    //TODO:
    // 全局图像处理参数结构，Json.NET 可序列化
    public class ImageProcessParam
    {
        // 将颜色转换参数暴露为公有属性便于序列化/反序列化
        public IMVSColorTransformModuTool colorConvert { get; set; }
        public IMVSImageEnhanceModuTool ImageEnhance { get; set; }
        public IMVSImageFilterModuTool ImageFilter { get; set; }

        public ImageProcessParam()
        {
            colorConvert = (IMVSColorTransformModuTool)VmSolution.Instance["流程1.颜色转换1"];
             ImageEnhance = (IMVSImageEnhanceModuTool)VmSolution.Instance["流程1.图像增强1"];
              ImageFilter = (IMVSImageFilterModuTool)VmSolution.Instance["流程1.图像滤波1"];


        }

    }







