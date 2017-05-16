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

namespace PTLEnglish.GUI.Gravity
{
    public partial class Ailien_1 : UserControl
    {
        public Ailien_1(int index)
        {
            InitializeComponent();
        }
        void load(int index,bool check)
        {
            if (check)
                lbWord.Text = Manage.TopicData.WordList[index].Key;
            else
                lbWord.Text = Manage.TopicData.WordList[index].Mean;

        }
        private void Ailien_1_Load(object sender, EventArgs e)
        {
            lbWord.Parent = this;
            lbWord.BackColor = Color.Transparent;
        }
    }
}
