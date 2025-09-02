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
    public partial class Frm_set : Form
    {
        public Frm_set()
        {
            InitializeComponent();
        }

        #region UI事件触发

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
