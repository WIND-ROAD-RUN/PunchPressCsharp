using IMVSFastFeatureMatchModuCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VM.Core;

namespace PunchPressCsharp.UI
{
    public partial class Frm_loadShapeModel : Form
    {
        public Frm_loadShapeModel()
        {
            InitializeComponent();
        }

        private void Frm_loadShapeModel_Load(object sender, EventArgs e)
        {
            IMVSFastFeatureMatchModuTool fastFeatureMatch = (IMVSFastFeatureMatchModuTool)VmSolution.Instance["流程1.快速匹配1"];
                //  准备模板文件路径
                // 可以导入多个模板文件，这里只导入一个
                string[] templatePaths = new string[1] { @"D:\Templates\your_template.fmxml" };

            // 导入模板文件（注意：这会替换模块当前所有模型文件）
            fastFeatureMatch.ImportModelData(templatePaths);
            
        }
    }
}
