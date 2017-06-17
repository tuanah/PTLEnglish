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
    public partial class uctrlListen2 : UserControl
    {
        // Hàm lấy 1 hàm nào đó từ form khác
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
        // Biến check là 1 biến quan trọng trong xử lý giao diện
        int check = 0;
        // 2 cái biến đầu là cái biến mặc định để đọc được âm thanh khi xài thư viện System.Speech
        SpeechSynthesizer speechSynthes = new SpeechSynthesizer();
        // Biến dùng đường dẫn và từ đang học:
        string filePath;
        int learnNumber = -1;
        // Lấy hàm bên pnMain bên uctrlMain
        public static FlowLayoutPanel fpnMain = new FlowLayoutPanel();
        public uctrlListen2(string Filepath, int LearnNumber)
        {
            InitializeComponent();
            filePath = Filepath;
            learnNumber = LearnNumber;
        }

        private void uctrlListen2_Load(object sender, EventArgs e)
        {
            if (!Manage.TopicData.Listen.FirstTimeOfWord)
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
            speechSynthes.SpeakAsync(textToSpeech.ToString()); // Cái này nó đọc âm thanh mà ko bị đứng màn hình. Nó đọc nhanh
        }
        #endregion


        #region Random Sound
        // Tạo danh sách sound gồm 4 phần tử:
        int[] lSoundWord = { -1, -1, -1, -1 };
        void RandomSound(int count)
        {
            Random rand = new Random();
            // Nhét giá trị đúng vào bất kỳ nơi nào trong lSoundWord
            int randNumber = rand.Next(0, 4);
            lSoundWord[randNumber] = count;
            // Tạo các giá trị sai
            // Chạy từng phần tử trong lSoundWord và kiểm tra
            for (int i = 0; i < lSoundWord.Length; i++)
            {
                if (i == randNumber)
                    continue;
                // Lấy 1 số bất kỳ từ 0 - 24 
                int index = rand.Next(0, Manage.TopicData.WordList.Count);
                // Nếu số đó đã tồn tại trong lSoundWord, thì chúng ta sẽ random lại
                // Do chỉ lấy 4 /25 từ nên khả năng bị trùng rất ít
                while (lSoundWord.Contains(index))
                    index = rand.Next(0, Manage.TopicData.WordList.Count);
                // Nếu không trùng thì lưu lại giá trị đó
                lSoundWord[i] = index;
            }
        }
        #endregion

        #region Hàm hiện 1 từ lên màn hình
        void ShowAWord(int count, bool _check = true)
        {
            if (learnNumber < Manage.TopicData.WordList.Count) // Nếu chưa học hết các từ
            {
                // Lưu tại từ tiếng anh đúng tí mang ra kiểm tra với từ mình nhập vào
                lbVietnamese.Tag = Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].Key;
                // Hiện từ tiếng việt:
                lbVietnamese.Text = Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].Mean;
                RandomSound(Manage.TopicData.Listen.ListRandom[count]);
                if (_check)
                {
                    // Tăng process + lưu xuống xml
                    Manage.TopicData.Listen.Progress = count;
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                    // Gọi hàm tăng progress sai:
                    ProgressBar.IncreasingProgress();
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

        #region Hàm xử lý pbSound - Giao diện
        bool[] _checkDisplay = { false, false, false, false };
        // Mỗi lần click vào 1 cái pbListen bất kỳ thì lưu lại vị trí được click
        // Biến được chỉnh true là hiện đang được click
        // False là không được click
        PictureBox previousPic = null;
        private void pbListen1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            ReadText(Manage.TopicData.WordList[lSoundWord[int.Parse(p.Name[p.Name.Length - 1].ToString()) - 1]].Key, 1);
            btnKiemTra.Tag = Manage.TopicData.WordList[lSoundWord[int.Parse(p.Name[p.Name.Length - 1].ToString()) - 1]].Mean;
            Array.Clear(_checkDisplay, 0, 3);
            _checkDisplay[int.Parse(p.Name[p.Name.Length - 1].ToString()) - 1] = true;
            p.Image = Properties.Resources.click;
            btnKiemTra.Enabled = true;
            if (previousPic != null)
                previousPic.Image = Properties.Resources.normal;
            previousPic = sender as PictureBox;
        }
        // -------------- MOUSE LEAVE --------------------
        private void pbListen1_MouseLeave_1(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (!_checkDisplay[int.Parse(p.Name[p.Name.Length - 1].ToString()) - 1])
                p.Image = Properties.Resources.normal;
        }
        // -------------- MOUSE HOVER --------------------
        private void pbListen1_MouseHover_1(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.Image = Properties.Resources.click;
        }
        #endregion

        #region Button Check Answers
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            btnKiemTra.Enabled = false; btnKiemTra.Refresh();
            // Tìm vị trí được click trong _checkDisplay
            int result = Array.IndexOf(_checkDisplay, true);
            if (btnKiemTra.Tag.ToString() == lbVietnamese.Text)// Nếu đúng
            {
                // Giao diện khi đúng
                CheckWhenTrue(result);
                // Tăng số lần đúng
                Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[learnNumber]].NumRight++;
                // Tăng số lần đúng trong listen
                Manage.TopicData.Listen.CorrectWords++;
            }
            else // Nếu sai
            {
                // Giao diện khi sai:
                CheckWhenWrong(result);
                // Tăng số từ sai bên ngoài:
                Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[learnNumber]].NumWrong++;
                // Tăng số từ sai trong listen:
                Manage.TopicData.Listen.WrongWords++;
                if (Manage.TopicData.Listen.ListWrongWord == null)
                    Manage.TopicData.Listen.ListWrongWord = new List<int>();
                // Thêm từ này vào danh sách từ sai
                Manage.TopicData.Listen.ListWrongWord.Add(Manage.TopicData.Listen.ListRandom[learnNumber]);
            }
            //Lưu lại vào Topic và serialize xuống
            Manage.SerializeToXML(Manage.TopicData, filePath);
            // Tạo lại giao diện mặc định
            SetDefaultDisplay();
            // Hiện từ tiếp theo
            ShowAWord(++learnNumber);
        }

        private void btnKiemTra_MouseMove(object sender, MouseEventArgs e)
        {
            btnKiemTra.BackColor = Color.Yellow; ;
            btnKiemTra.ForeColor = Color.FromArgb(68, 82, 87);
        }

        private void btnKiemTra_MouseLeave(object sender, EventArgs e)
        {
            btnKiemTra.BackColor = Color.FromArgb(60, 207, 207);
            btnKiemTra.ForeColor = Color.White;
        }
        #endregion

        #region Tạo lại giao diện mặc định
        void SetDefaultDisplay()
        {    
            Array.Clear(_checkDisplay, 0, 3);
            pbListen1.Image = pbListen2.Image = pbListen3.Image = pbListen4.Image = Properties.Resources.normal;
        }
        #endregion

        #region Tạo giao diện khi đúng - sai
        /// <summary>
        /// Giao diện khi đúng
        /// </summary>
        /// <param name="result"></param>
        void CheckWhenTrue(int result)
        {
            // Giao diện: Chạy CORRECT        
            uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
            // Gọi hàm tăng progress đúng:
            ProgressBar.IncreasingCorrect();
            // Kiểm tra vị trí đúng và show giao diện đúng 
            PictureBox p = new PictureBox();
            switch (result)
            {
                case 0: p = pbListen1 as PictureBox; break;
                case 1: p = pbListen2 as PictureBox; break;
                case 2: p = pbListen3 as PictureBox; break;
                case 3: p = pbListen4 as PictureBox; break;
            }
            for (int i = 0; i < 5; i++)
            {
                p.Image = Properties.Resources.right;
                p.Refresh();
                Thread.Sleep(150);
                p.Image = Properties.Resources.click;
                p.Refresh();
                Thread.Sleep(150);
            }
            p.Image = Properties.Resources.right;
            p.Refresh();
        }

        /// <summary>
        /// Giao diện khi sai
        /// </summary>
        /// <param name="result"></param>
        void CheckWhenWrong(int result)
        {
            // Giao diện: Chạy WRONG
            uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
            // Gọi hàm tăng progress sai:
            ProgressBar.IncreasingWrong();
            PictureBox p = new PictureBox();
            // Tìm vị trí đúng:
            int indexTrue = Array.IndexOf(lSoundWord, Manage.TopicData.Listen.ListRandom[learnNumber]);
            switch (indexTrue)
            {
                case 0: p = pbListen1 as PictureBox; break;
                case 1: p = pbListen2 as PictureBox; break;
                case 2: p = pbListen3 as PictureBox; break;
                case 3: p = pbListen4 as PictureBox; break;
            }
            p.Image = Properties.Resources.right; p.Refresh();
            Thread.Sleep(10);
            // Tìm vị trí sai
            switch (result)
            {
                case 0: p = pbListen1 as PictureBox; break;
                case 1: p = pbListen2 as PictureBox; break;
                case 2: p = pbListen3 as PictureBox; break;
                case 3: p = pbListen4 as PictureBox; break;
            }
            p.Image = Properties.Resources.wrong; p.Refresh();
            Thread.Sleep(2000);
        }
        #endregion  
    }
}
