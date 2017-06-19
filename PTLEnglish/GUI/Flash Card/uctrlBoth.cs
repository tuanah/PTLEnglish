using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using PTLEnglish.DAL;

namespace PTLEnglish.GUI.Listen
{
    public partial class uctrlBoth : UserControl
    {
        public uctrlBoth(int index)
        {
            InitializeComponent();
            load(index);
        }

        void load(int index)
        {
            lbEnglish.Text = Manage.TopicData.WordList[index].Key;
            lbVietnamese.Text = Manage.TopicData.WordList[index].Mean;
            try
            {
                pbImage.Image = new Bitmap(Manage.TopicData.WordList[index].ImgPath);
            }
            catch
            {

                pbImage.Image = Properties.Resources.error_image;
            }
            pbImage.Refresh();
            readText();
        }

        PromptBuilder promp = new PromptBuilder();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        void readText()
        {
            promp.ClearContent();
            promp.AppendText(lbEnglish.Text);
            speech.Volume = 100;
            speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            speech.SpeakAsync(promp);
        }

        private void pbSound_Click(object sender, EventArgs e)
        {
            readText();
        }

        private void pbSound_MouseHover(object sender, EventArgs e)
        {
            pbSound.Image = Properties.Resources.Blue_Sound;
        }

        private void pbSound_MouseLeave(object sender, EventArgs e)
        {
            pbSound.Image = Properties.Resources.Room_Sound_Filled_50;
        }
    }
}
