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
    public partial class uctrlGravityMain : UserControl
    {
        public uctrlGravityMain()
        {
            InitializeComponent();
            
        }

        private void uctrlGravityMain_Load(object sender, EventArgs e)
        {
            uctrlIntroduction Introduction = new uctrlIntroduction();
            uctrlIntroduction.pn = pnMain;
            pnMain.Controls.Add(Introduction);
        }
    }
}
