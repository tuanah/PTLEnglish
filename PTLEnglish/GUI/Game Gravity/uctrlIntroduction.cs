using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTLEnglish.GUI.Game_Gravity
{
    public partial class uctrlIntroduction : UserControl
    {
        public static Panel pn = new Panel();
        public uctrlIntroduction()
        {
            InitializeComponent();
        }

        private void btnGetStart_Click(object sender, EventArgs e)
        {
            uctrlState state = new uctrlState();
            pn.Controls.Add(state);
            while (pn.Controls.Count != 1)
                pn.Controls[0].Dispose();
        }
    }
}
