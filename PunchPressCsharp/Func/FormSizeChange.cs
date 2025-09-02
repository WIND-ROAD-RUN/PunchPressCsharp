using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunchPressCsharp.Func
{
    public class FormSizeChange
    {
        public void MakeControlsResponsive(Form form)
        {
            // 保存初始尺寸、位置和字体
            Dictionary<Control, (Size, Point, Font)> initialControlStates = new Dictionary<Control, (Size, Point, Font)>();
            SaveInitialControlStates(form.Controls, initialControlStates);

            float initialFormWidth = form.Width;
            float initialFormHeight = form.Height;

            form.Resize += (sender, e) =>
            {
                float widthRatio = form.Width / initialFormWidth;
                float heightRatio = form.Height / initialFormHeight;

                ResizeControls(form.Controls, initialControlStates, widthRatio, heightRatio);
            };
        }

        private void SaveInitialControlStates(Control.ControlCollection controls, Dictionary<Control, (Size, Point, Font)> initialControlStates)
        {
            foreach (Control control in controls)
            {
                initialControlStates[control] = (control.Size, control.Location, control.Font);
                if (control.Controls.Count > 0)
                {
                    SaveInitialControlStates(control.Controls, initialControlStates);
                }
            }
        }

        private void ResizeControls(Control.ControlCollection controls, Dictionary<Control, (Size, Point, Font)> initialControlStates, float widthRatio, float heightRatio)
        {
            if (controls[0].FindForm().WindowState != FormWindowState.Minimized)
                foreach (Control control in controls)
                {
                    if (initialControlStates.TryGetValue(control, out var initialState))
                    {
                        var (initialSize, initialLocation, initialFont) = initialState;

                        // 调整控件大小
                        control.Width = (int)(initialSize.Width * widthRatio);
                        control.Height = (int)(initialSize.Height * heightRatio);

                        // 调整控件位置
                        control.Left = (int)(initialLocation.X * widthRatio);
                        control.Top = (int)(initialLocation.Y * heightRatio);

                        // 调整控件字体
                        control.Font = new Font(initialFont.FontFamily, initialFont.Size * widthRatio);
                    }

                    if (control.Controls.Count > 0)
                    {
                        ResizeControls(control.Controls, initialControlStates, widthRatio, heightRatio);
                    }
                }
        }



    }
}
