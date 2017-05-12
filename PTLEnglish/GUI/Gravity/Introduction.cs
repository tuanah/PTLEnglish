using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTLEnglish.GUI.Gravity
{
    public partial class Introduction : UserControl
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void btnGetStart_MouseHover(object sender, EventArgs e)
        {
            btnGetStart.BackColor = Color.FromArgb(60, 207, 207);
        }

        private void btnGetStart_MouseLeave(object sender, EventArgs e)
        {
            btnGetStart.BackColor = Color.FromArgb(52, 152, 219);
        }
    }
}
