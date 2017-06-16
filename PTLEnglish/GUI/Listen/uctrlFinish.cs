using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.DAL;

namespace PTLEnglish.GUI.Listen
{
    public partial class uctrlFinish : UserControl
    {
        public uctrlFinish()
        {
            InitializeComponent();
            uctrlListen1.btnStartOverr = btnStartOver;
            uctrlListen2.btnStartOverr = btnStartOver;
        }

        private void btnStartOver_MouseHover(object sender, EventArgs e)
        {
            btnStartOver.BackColor = Color.FromArgb(36, 129, 77);
        }

        private void btnStartOver_MouseLeave(object sender, EventArgs e)
        {
            btnStartOver.BackColor = Color.SeaGreen;
        }
        
    }
}
