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
    public partial class Ailien_1 : UserControl
    {
        public Ailien_1()
        {
            InitializeComponent();
        }

        private void Ailien_1_Load(object sender, EventArgs e)
        {
            lbWord.Parent = pbAilien;
            lbWord.BackColor = Color.Transparent;
        }
    }
}
