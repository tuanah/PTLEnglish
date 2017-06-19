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
using System.Threading;

namespace PTLEnglish.GUI.Listen
{
    public partial class uctrlListen3 : UserControl
    {  // Hàm lấy hàm từ form khác
        public object GetControlProgressbar
        {
            set;
            get;
        }
        public object GetControlClick
        {
            set;
            get;
        }
        // Biến lưu lại khi học xong bài . Kiểm tra xem có được click hay không:
        public static Button btnStartOverr = new Button();
        // 2 cái biến đầu là cái biến mặc định để đọc được âm thanh khi xài thư viện System.Speech
        SpeechSynthesizer speechSynthes = new SpeechSynthesizer();
        // Biến dùng đường dẫn và từ đang học:
        string filePath;
        int learnNumber = -1;
        // Lấy hàm bên pnMain bên uctrlMain
        public static FlowLayoutPanel fpnMain = new FlowLayoutPanel();
        public uctrlListen3(string Filepath, int LearnNumber)
        {
            InitializeComponent();
            filePath = Filepath;
            learnNumber = LearnNumber;
        }

        private void uctrlListen3_Load(object sender, EventArgs e)
        {
            if (Manage.TopicData.Listen.FirstTimeOfWord == false)
                ShowAWord(++learnNumber);
            else
                ShowAWord(++learnNumber, false);
        }

        #region Hàm đọc 1 từ
        /// <param name="textToSpeech">dữ liệu để đọc</param>
        /// <param name="rate">tốc độ đọc</param>
        void ReadText(string textToSpeech, int rate)
        {
            speechSynthes.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            speechSynthes.Rate = rate;
            speechSynthes.Volume = 100;
            speechSynthes.SpeakAsync(textToSpeech); // Cái này nó đọc âm thanh mà ko bị đứng màn hình. Nó đọc nhanh
        }
        #endregion

        #region Hàm hiện 1 từ lên màn hình
        void ShowAWord(int count, bool _check = true)
        {
            if (learnNumber < Manage.TopicData.WordList.Count) // Nếu chưa học hết các từ
            {
                tbText.Focus();
                CheckPnHorizontal("TYPE THE VIETNAMESE", Color.FromArgb(103, 183, 255), Color.FromArgb(52, 152, 219));
                // Lưu tại từ tiếng anh đúng tí mang ra kiểm tra với từ mình nhập vào
                try
                {
                    pbImage.Image = new Bitmap(Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].ImgPath);
                }
                catch 
                {
                    pbImage.Image = Properties.Resources.error_image;
                }
                pbImage.Refresh();
                tbText.Tag = Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].Mean;
                lbWrong.Tag = Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].Key;
                ReadText(lbWrong.Tag.ToString(), 1);
                if (_check)
                {
                    // Tăng process + lưu xuống xml
                    Manage.TopicData.Listen.Progress = count;
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                    // Gọi hàm tăng progress :
                    ProgressBar.IncreasingProgress();
                    CheckPnHorizontal("TYPE THE VIETNAMESE", Color.FromArgb(103, 183, 255), Color.FromArgb(52, 152, 219));
                }
            }
            else // Nếu đã học xong  tất cả các từ
            {
                // xóa tất cả các control trong fpnMain
                fpnMain.Controls.Clear();
                // Hiện form kết thúc chương trình học listen:
                fpnMain.FlowDirection = FlowDirection.LeftToRight; fpnMain.BackColor = Color.White;
                uctrlFinish finish = new uctrlFinish();
                fpnMain.Controls.Add(finish);
                // Hiện các từ sai ra màn hình:
                foreach (int item in Manage.TopicData.Listen.ListWrongWord)
                {
                    uctrlMissedWord miss = new uctrlMissedWord(item);
                    fpnMain.Controls.Add(miss);
                }
                // Reset lại các giá trị như:
                Manage.TopicData.Listen.CorrectWords = 0; // Từ đúng
                Manage.TopicData.Listen.WrongWords = 0; // Từ sai
                Manage.TopicData.Listen.Progress = -1; // Tiến trình học
                Manage.TopicData.Listen.ListRandom = null; // Danh sách Random
                Manage.TopicData.Listen.ListWrongWord = null; // Danh sách từ sai
                Manage.TopicData.Listen.FirstTimeOfWord = false; // Từ có phải lần đầu không
                // Thực hiện lưu xuống xml
                Manage.SerializeToXML(Manage.TopicData, filePath);
                // Tạo hàm inlines cho sự kiện click của btnStartOverr 
                // Có thể dùng Delegate thay cho lamda expressions
                btnStartOverr.Click += (sender, e) =>
                {
                    fSub Sub = (GetControlClick as uctrlMain).GetControl as fSub;
                    Sub.pnl_Listen_Click(sender, e);
                };
            }
        }
        #endregion

        #region Kiểm tra 1 từ đúng hay sai
        void CheckWordTrueFalse()
        {
            if (tbText.Text == tbText.Tag.ToString()) // Đúng
            {
                // Chạy đúng:
                CheckPnHorizontal("CORRECT", Color.FromArgb(120, 200, 0), Color.FromArgb(120, 200, 0));
                // Giao diện: Chạy CORRECT        
                uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                // Gọi hàm tăng progress đúng:
                ProgressBar.IncreasingCorrect();
                // Tăng số lần đúng
                Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[learnNumber]].NumRight++;
                // Tăng số lần đúng trong listen
                Manage.TopicData.Listen.CorrectWords++;
                // Lưu lại vào Topic và serialize xuống
                Manage.SerializeToXML(Manage.TopicData, filePath);
            }
            else
            {
                // Chạy timer và hiện kiểu SAI      
                CheckPnHorizontal("NOT CORRECT. THE CORRECT ANSWER IS:", Color.FromArgb(255, 114, 91), Color.Red);
                // Giao diện: Chạy WRONG
                uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                // Gọi hàm tăng progress sai:
                ProgressBar.IncreasingWrong();
                // Tăng các từ sai:
                Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[learnNumber]].NumWrong++;
                // Tăng số từ sai trong listen:
                Manage.TopicData.Listen.WrongWords++;
                if (Manage.TopicData.Listen.ListWrongWord == null)
                    Manage.TopicData.Listen.ListWrongWord = new List<int>();
                // Thêm từ này vào danh sách từ sai
                Manage.TopicData.Listen.ListWrongWord.Add(Manage.TopicData.Listen.ListRandom[learnNumber]);
                // Lưu lại vào Topic và serialize xuống
                Manage.SerializeToXML(Manage.TopicData, filePath);
                // Hiện từ sai lên:
                lbWrong.Text = tbText.Tag.ToString(); lbWrong.Visible = true; lbWrong.Refresh();
            }
            Thread.Sleep(2500);
            lbWrong.Visible = false;
            tbText.Visible = false; tbText.Text = string.Empty; tbText.Refresh(); tbText.Visible = true;
            ShowAWord(++learnNumber);
        }
        #endregion

        #region Xử lý lúc nhấn enter vào textbox
        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckWordTrueFalse();
                e.Handled = true; // Tắt tiếng beep khó chịu
            }
        }
        #endregion

        /// <summary>
        /// Tạo giao diện
        /// </summary>
        void CheckPnHorizontal(string Name, Color ForeColor, Color BackColor)
        {
            lbCommand.Text = Name;
            lbCommand.ForeColor = ForeColor;
            pnHorizontalRun.Width = 0;
            lbCommand.Refresh();
            pnHorizontalRun.Width = 0;
            pnHorizontalRun.BackColor = BackColor;
            while (pnHorizontalRun.Width < pnHorizontal.Width)
            {
                pnHorizontalRun.Width = pnHorizontalRun.Width + 1;
            }
            pnHorizontal.BackColor = pnHorizontalRun.BackColor;
        }

        #region Hàm click vào sound
        private void pbSpeakNormal_Click(object sender, EventArgs e)
        {
            ReadText(lbWrong.Tag.ToString(), 1);
        }

        private void pbSpeakSlowly_Click(object sender, EventArgs e)
        {
            ReadText(lbWrong.Tag.ToString(), -4);
        }
        #endregion

        #region Giao diện xử lý hình âm thanh          
        private void pbSpeakNormal_MouseHover_1(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.Image = Properties.Resources.click;
        }

        private void pbSpeakNormal_MouseLeave_1(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.Image = Properties.Resources.normal;
        }
        #endregion
    }
}
