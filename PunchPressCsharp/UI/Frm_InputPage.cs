using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunchPressCsharp.UI
{
    public partial class Frm_InputPage : Form
    {
        private Control _externalControl;
        private float min = 0;
        private float max = 1000000;

        // 存储当前输入值
        public string InputValue { get; private set; } = "0";

        public Frm_InputPage()
        {
            InitializeComponent();
        }

        // 构造函数，传入任意控件
        public Frm_InputPage(Control externalControl,float min,float max)
        {
            InitializeComponent();
            _externalControl = externalControl;
            this.min = min;
            this.max = max;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InputValue = "0";
            uiTextBox1.Text = InputValue;
        }
        // 小数点按钮
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!InputValue.Contains("."))
            {
                if (InputValue == "")
                    InputValue = "0";
                InputValue += ".";
                uiTextBox1.Text = InputValue;
            }
        }
        // 负号按钮
        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (InputValue.StartsWith("-"))
            {
                InputValue = InputValue.Substring(1);
            }
            else
            {
                if (InputValue == "0")
                    InputValue = "-";
                else
                    InputValue = "-" + InputValue;
            }
            uiTextBox1.Text = InputValue;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 1. 检查输入是否为空
            if (string.IsNullOrWhiteSpace(InputValue) || InputValue == "-")
            {
                ShowErrorAlert("输入值不能为空");
                return;
            }

            // 2. 尝试转换为数值
            if (!double.TryParse(InputValue, out double value))
            {
                ShowErrorAlert("输入值不是有效的数字");
                return;
            }

            if (value<min||value>max)
            {

                ShowErrorAlert("小于设定数值"+ min.ToString()+"---"+max.ToString());
                return;
            }

            _externalControl.Text = InputValue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // 显示错误警告框
        private void ShowErrorAlert(string message)
        {
            // 使用MessageBox显示错误警告
            MessageBox.Show(message, "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        private void btn7_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn7.Text != ".")
                InputValue = "";
            InputValue += btn7.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn8.Text != ".")
                InputValue = "";
            InputValue += btn8.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn9.Text != ".")
                InputValue = "";
            InputValue += btn9.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn4.Text != ".")
                InputValue = "";
            InputValue += btn4.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn5.Text != ".")
                InputValue = "";
            InputValue += btn5.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn5.Text != ".")
                InputValue = "";
            InputValue += btn6.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn1.Text != ".")
                InputValue = "";
            InputValue += btn1.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn2.Text != ".")
                InputValue = "";
            InputValue += btn2.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn3.Text != ".")
                InputValue = "";
            InputValue += btn3.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (InputValue == "0" && btn0.Text != ".")
                InputValue = "";
            InputValue += btn0.Text;
            uiTextBox1.Text = InputValue;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            // 删除最后一个字符
            if (InputValue.Length > 0)
            {
                InputValue = InputValue.Substring(0, InputValue.Length - 1);

                // 如果删除了所有字符，恢复为0
                if (InputValue == "" || InputValue == "-")
                    InputValue = "0";

                uiTextBox1.Text = InputValue;
            }
        }
    }
}
