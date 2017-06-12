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
    public partial class Meteorite_ : UserControl
    {
        public Meteorite_()
        {
            InitializeComponent();
        }

        private void Meteorite__Load(object sender, EventArgs e)
        {
            lbWord.Parent = pbMeteorite;
            lbWord.BackColor = Color.Transparent;
        }
    }
}
