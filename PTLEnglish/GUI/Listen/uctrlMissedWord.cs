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
using System.Speech.Synthesis;
namespace PTLEnglish.GUI.Listen
{
    public partial class uctrlMissedWord : UserControl
    {
        // 2 cái biến đầu là cái biến mặc định để đọc được âm thanh khi xài thư viện System.Speech
        PromptBuilder proBuilder = new PromptBuilder();
        SpeechSynthesizer speechSynthes = new SpeechSynthesizer();
        public uctrlMissedWord(int index)
        {
            InitializeComponent();
            load(index);
        }

        /// <param name="textToSpeech">dữ liệu để đọc</param>
        /// <param name="rate">tốc độ đọc</param>
        /// <param name="check"></param>
        void ReadText(string textToSpeech, int rate, bool check = true)
        {
            proBuilder.ClearContent();
            proBuilder.AppendText(textToSpeech);
            speechSynthes.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            speechSynthes.Rate = rate;
            speechSynthes.Volume = 100;
            if (check)
                speechSynthes.SpeakAsync(proBuilder); // Cái này nó đọc âm thanh mà ko bị đứng màn hình. Nó đọc nhanh
            else
                speechSynthes.Speak(proBuilder); // cái này dùng để đọc từng từ
        }
        void load(int index)
        {           
            lbEnglish.Text = Manage.TopicData.WordList[index].Key;
            lbPronunciation.Text = "/ "+Manage.TopicData.WordList[index].Pronunciation+" /";
            lbVietNamese.Text = Manage.TopicData.WordList[index].Mean;
            try
            {
                pbImage.Image = new Bitmap(Manage.TopicData.WordList[index].ImgPath);
            }
            catch (Exception)
            {

                pbImage.Image = Properties.Resources.error_image;
            }
           
            pbSound.Click += delegate
              {
                  ReadText(lbEnglish.Text, 0);
              };
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
