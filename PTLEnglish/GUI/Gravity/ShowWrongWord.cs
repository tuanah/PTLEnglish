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
    public partial class ShowWrongWord : UserControl
    {
        public ShowWrongWord(int index)
        {
            InitializeComponent();
            Load(index);
        }
        void Load(int index,bool check=true)
        {
            pbImage.Image = new Bitmap(Manage.TopicData.WordList[index].ImgPath);
            if (check)
                lbWord.Text = Manage.TopicData.WordList[index].Key;
            else
                lbWord.Text = Manage.TopicData.WordList[index].Mean;
        }
    }
}
