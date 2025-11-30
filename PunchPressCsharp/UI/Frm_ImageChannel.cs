using ImageSourceModuleCs;
using ImageSourceModuleCs;
using IMVSColorTransformModuCs;
using IMVSHPFeatureMatchModuCs;
using IMVSHPFeatureMatchModuCs;
using IMVSImageEnhanceModuCs;
using IMVSImageFilterModuCs;
using IMVSImageMorphModuCs;
using Newtonsoft.Json;
using PunchPressCsharp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VM.Core;
using VM.PlatformSDKCS;
namespace PunchPressCsharp.UI
{
    public partial class Frm_ImageChannel : Form
    { // 硬编码保存路径
        //TODO:硬编码存参位置
        private const string ImageProcessParamAdress = @"D:\zfkjData\PunchPress\Config\ImageProcessParam.json";

        public Frm_ImageChannel()
        {
            InitializeComponent();
        }

        private void Frm_ImageChannel_Load(object sender, EventArgs e)
        {


            //TODO:反序列化图像处理参数
           
            try
            {
                if (File.Exists(ImageProcessParamAdress))
                {
                    GlobalData.LoadImageProcessParam(ImageProcessParamAdress);



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("加载图像处理参数失败: " + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }






#if DEBUG

#else
            FormSizeChange formalizable = new FormSizeChange();
            formalizable.MakeControlsResponsive(this);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
#endif
            var imageSource = (ImageSourceModuleTool)VmSolution.Instance["流程1.图像源1"];

            // 获取颜色转换模块
            IMVSColorTransformModuTool colorConvert = (IMVSColorTransformModuTool)VmSolution.Instance["流程1.颜色转换1"];
            if (GlobalData.imageProcessParam.colorConvert != null)
            {
                colorConvert = GlobalData.imageProcessParam.colorConvert;
            }
            ColorTransformParam TransformParam = (ColorTransformParam)colorConvert.ModuParams;

            // 获取图像增强模块
            IMVSImageEnhanceModuTool ImageEnhance = (IMVSImageEnhanceModuTool)VmSolution.Instance["流程1.图像增强1"];
            if (GlobalData.imageProcessParam.ImageEnhance != null)
            {
                ImageEnhance = GlobalData.imageProcessParam.ImageEnhance;
            }

            ImageEnhanceParam EnhanceParam = (ImageEnhanceParam)ImageEnhance.ModuParams;

            // 获取图像增强模块
            IMVSImageFilterModuTool ImageFilter = (IMVSImageFilterModuTool)VmSolution.Instance["流程1.图像滤波1"];
            if (GlobalData.imageProcessParam.ImageFilter != null)
            {
                ImageFilter = GlobalData.imageProcessParam.ImageFilter;
            }

            ImageFilterParam FilterParam = (ImageFilterParam)ImageFilter.ModuParams;




            vmParamsConfigWithRenderControl1.ModuleSource = colorConvert;
            vmParamsConfigWithRenderControl2.ModuleSource = ImageEnhance;
            vmParamsConfigWithRenderControl3.ModuleSource = ImageFilter;








        }

        private void pic_Close_Click(object sender, EventArgs e)
        {


            // 将全局 ImageProcessParam 序列化并保存到硬编码路径
            // 使用非泛型重载以避免与同名常量冲突：typeof 指定实际类型
            IMVSColorTransformModuTool colorConvert = (IMVSColorTransformModuTool)VmSolution.Instance["流程1.颜色转换1"];
            GlobalData.imageProcessParam.colorConvert = colorConvert;
            IMVSImageEnhanceModuTool ImageEnhance = (IMVSImageEnhanceModuTool)VmSolution.Instance["流程1.图像增强1"];
            GlobalData.imageProcessParam.ImageEnhance = ImageEnhance;
            IMVSImageFilterModuTool ImageFilter = (IMVSImageFilterModuTool)VmSolution.Instance["流程1.图像滤波1"];
            GlobalData.imageProcessParam.ImageFilter = ImageFilter;



            // 序列化 ModuParams 并保存到硬编码路径
            try
            {
                GlobalData.SaveImageProcessParam(ImageProcessParamAdress);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存图像处理参数失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





           // GlobalData.Instance.configs.SaveConfigs();
            this.Close();
        }
        // 本窗体内部 DTO，用于读取/写入 JSON 时仅包含 ModuParams 部分
        private class ImageProcessParamDto
        {
            public ColorTransformParam ColorConvert { get; set; }
            public ImageEnhanceParam ImageEnhance { get; set; }
            public ImageFilterParam ImageFilter { get; set; }
        }
    }
}
