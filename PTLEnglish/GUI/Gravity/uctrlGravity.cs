using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.GUI.Gravity;

namespace PTLEnglish.GUI.Gravity
{
    public partial class uctrlGravity : UserControl
    {
        public uctrlGravity()
        {
            InitializeComponent();
        }

        private void uctrlGravity_Load(object sender, EventArgs e)
        {
            Introduction intro = new Introduction();
            pnMain.Controls.Add(intro);
        }
    }
}
