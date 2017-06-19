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
        public static Panel pn = new Panel();
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

        private void btnGetStart_Click(object sender, EventArgs e)
        {
            State state = new State();
            pn.Controls.Add(state);
            while (pn.Controls.Count != 1)
                pn.Controls[0].Dispose();
        }
    }
}
