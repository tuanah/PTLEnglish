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
        // Hàm lấy hàm từ form khác
        // Lưu ý form này trong form khác phải dc khởi tạo r
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
        PromptBuilder proBuilder = new PromptBuilder();
        SpeechSynthesizer speechSynthes = new SpeechSynthesizer();
        // Biến liên quan tới random:
        List<int> lRandom = new List<int>();
        // Biến dùng đường dẫn và từ đang học:
        string filePath;
        int learnNumber=-1;
        // Lấy hàm bên pnMain bên uctrlMain
        public static FlowLayoutPanel fpnMain = new FlowLayoutPanel();
        public uctrlListen2(string Filepath)
        {
            InitializeComponent();
            filePath = Filepath;
        }

        private void uctrlListen2_Load(object sender, EventArgs e)
        {
            // Đọc dữ liệu từ Xml lên:
            Manage.TopicData = (Topic)Manage.DeserializeFromXML(Cons.Path + Manage.ThisTopic + ".xml");
            // Kiểm tra nếu chưa học từ nào thì gọi hàm random ra dùng
            // Ngược lại thì thôi
            if (Manage.TopicData.Listen.Progress != -1)
            {
                lRandom = Manage.TopicData.Listen.ListRandom;
                learnNumber = Manage.TopicData.Listen.Progress - 1;
            }
            else
            {
                RandomListWord();
                Manage.TopicData.Listen.ListRandom = lRandom;
                Manage.SerializeToXML(Manage.TopicData, filePath);
            }
            if (Manage.TopicData.Listen.FirstTimeOfWord == false)
                ShowAWord(++learnNumber);
            else
                ShowAWord(++learnNumber, false);
        }

        #region Hàm random
        List<int> AddNumberIntoList()
        {
            List<int> lInt = new List<int>();
            for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
            {
                lInt.Add(i);
            }
            return lInt;
        }

        void RandomListWord()
        {
            List<int> lInt = AddNumberIntoList();
            Random rand = new Random();
            while (lRandom.Count != Manage.TopicData.WordList.Count)
            {
                // Chọn ngẫu nhiên 1 phần tử 
                int temp = rand.Next(0, lInt.Count);
                // Lấy giá trị 
                int index = lInt[temp];
                // Xóa phần tử đã được random ra khỏi lInt
                lInt.Remove(index);
                // Lưu giá trị random vào listRandom
                lRandom.Add(index);
            }
        }
        #endregion


        #region Hàm đọc 1 từ
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
                speechSynthes.Speak(proBuilder); // cái này dùng để đọc từng từ - ko dùng
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
        void ShowAWord(int count, bool _check=true)
        {
            if (learnNumber < Manage.TopicData.WordList.Count) // Nếu chưa học hết các từ
            {
                pnDown.BackColor = pnLeft.BackColor = pnUp.BackColor = pnRight.BackColor = Color.FromArgb(103, 183, 255);
                // Lưu tại từ tiếng anh đúng tí mang ra kiểm tra với từ mình nhập vào
                lbVietnamese.Tag = Manage.TopicData.WordList[lRandom[count]].Key;
                // Hiện từ tiếng việt:
                lbVietnamese.Text = Manage.TopicData.WordList[lRandom[count]].Mean;
                RandomSound(lRandom[count]);
                if (_check)
                {
                    // Tăng process + lưu xuống xml
                    Manage.TopicData.Listen.Progress = count;
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    if (GetControlProgressbar is uctrlProgressBar)
                    {
                        uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                        // Gọi hàm tăng progress sai:
                        ProgressBar.IncreasingProgress();
                        
                    }
                }
              
            }
            else // Nếu đã học xong  tất cả các từ
            {
                // xóa tất cả các control trong fpnMain
                fpnMain.Controls.Clear();
                // Hiện form kết thúc chương trình học listen:
                fpnMain.FlowDirection = FlowDirection.LeftToRight;
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
                    if (GetControlClick is uctrlMain)
                    {
                        if ((GetControlClick as uctrlMain).GetControl is fSub)
                        {
                            fSub Sub = (GetControlClick as uctrlMain).GetControl as fSub;
                            Sub.pnl_Listen_Click(sender, e);
                        }

                    }
                };
            }
        }
        #endregion

        #region Hàm xử lý pbSound - Giao diện
        bool[] _checkDisplay = { false, false, false, false };
        // Mỗi lần click vào 1 cái pbListen bất kỳ thì lưu lại vị trí được click
        // Biến được chỉnh true là hiện đang được click
        // False là không được click
        private void pbListen1_Click(object sender, EventArgs e)
        {
            ReadText(Manage.TopicData.WordList[lSoundWord[0]].Key, 1);
            btnKiemTra.Tag = Manage.TopicData.WordList[lSoundWord[0]].Mean;
            _checkDisplay[0] = true;
            _checkDisplay[1] = _checkDisplay[2] = _checkDisplay[3] = false;
            pbListen1.Image = Properties.Resources.click;
            pbListen2.Image = Properties.Resources.normal;
            pbListen3.Image = Properties.Resources.normal;
            pbListen4.Image = Properties.Resources.normal;
            btnKiemTra.Enabled = true;
        }

        private void pbListen2_Click(object sender, EventArgs e)
        {
            ReadText(Manage.TopicData.WordList[lSoundWord[1]].Key, 1);
            btnKiemTra.Tag = Manage.TopicData.WordList[lSoundWord[1]].Mean;
            _checkDisplay[1] = true;
            _checkDisplay[0] = _checkDisplay[2] = _checkDisplay[3] = false;
            pbListen2.Image = Properties.Resources.click;
            pbListen1.Image = Properties.Resources.normal;
            pbListen3.Image = Properties.Resources.normal;
            pbListen4.Image = Properties.Resources.normal;
            btnKiemTra.Enabled = true;
        }

        private void pbListen3_Click(object sender, EventArgs e)
        {
            ReadText(Manage.TopicData.WordList[lSoundWord[2]].Key, 1);
            btnKiemTra.Tag = Manage.TopicData.WordList[lSoundWord[2]].Mean;
            _checkDisplay[2] = true;
            _checkDisplay[1] = _checkDisplay[0] = _checkDisplay[3] = false;
            pbListen3.Image = Properties.Resources.click;
            pbListen1.Image = Properties.Resources.normal;
            pbListen2.Image = Properties.Resources.normal;
            pbListen4.Image = Properties.Resources.normal;
            btnKiemTra.Enabled = true;
        }

        private void pbListen4_Click(object sender, EventArgs e)
        {
            ReadText(Manage.TopicData.WordList[lSoundWord[3]].Key, 1);
            btnKiemTra.Tag = Manage.TopicData.WordList[lSoundWord[3]].Mean;
            _checkDisplay[3] = true;
            _checkDisplay[1] = _checkDisplay[2] = _checkDisplay[0] = false;
            pbListen4.Image = Properties.Resources.click;
            pbListen1.Image = Properties.Resources.normal;
            pbListen2.Image = Properties.Resources.normal;
            pbListen3.Image = Properties.Resources.normal;
            btnKiemTra.Enabled = true;
        }
        // -------------- MOUSE LEAVE --------------------
        private void pbListen1_MouseLeave(object sender, EventArgs e)
        {
            if (!_checkDisplay[0])
            {
                pbListen1.Image = Properties.Resources.normal;
            }
        }
        private void pbListen2_MouseLeave(object sender, EventArgs e)
        {
            if (!_checkDisplay[1])
            {
                pbListen2.Image = Properties.Resources.normal;
            }
        }
        private void pbListen3_MouseLeave(object sender, EventArgs e)
        {
            if (!_checkDisplay[2])
            {
                pbListen3.Image = Properties.Resources.normal;
            }
        }
        private void pbListen4_MouseLeave(object sender, EventArgs e)
        {
            if (!_checkDisplay[3])
            {
                pbListen4.Image = Properties.Resources.normal;
            }
        }
        // -------------- MOUSE HOVER --------------------
        private void pbListen1_MouseHover(object sender, EventArgs e)
        {
            pbListen1.Image = Properties.Resources.click;
        }
        private void pbListen2_MouseHover(object sender, EventArgs e)
        {
            pbListen2.Image = Properties.Resources.click;
        }

        private void pbListen3_MouseHover(object sender, EventArgs e)
        {
            pbListen3.Image = Properties.Resources.click;
        }
        private void pbListen4_MouseHover(object sender, EventArgs e)
        {

            pbListen4.Image = Properties.Resources.click;
        }


        #endregion

        #region Button Check Answers
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            btnKiemTra.Enabled = false;
            btnKiemTra.Refresh();
            // Tìm vị trí true trong _checkDisplay
            int result = Array.IndexOf(_checkDisplay, true);
            if (btnKiemTra.Tag.ToString() == lbVietnamese.Text)// Nếu đúng
            {
                // Giao diện khi đúng
                CheckWhenTrue(result);

                // Tăng số lần đúng
                Manage.TopicData.WordList[lRandom[learnNumber]].NumRight++;
                // Tăng số lần đúng trong listen
                Manage.TopicData.Listen.CorrectWords++;
            }
            else // Nếu sai
            {
                // Giao diện khi sai:
                CheckWhenWrong(result);
                // Đọc lại từ đúng
              //  ReadText(lbVietnamese.Tag.ToString(), 1);
                // Tăng số từ sai bên ngoài:
                Manage.TopicData.WordList[lRandom[learnNumber]].NumWrong++;
                // Tăng số từ sai trong listen:
                Manage.TopicData.Listen.WrongWords++;
                if (Manage.TopicData.Listen.ListWrongWord == null)
                    Manage.TopicData.Listen.ListWrongWord = new List<int>();
                // Thêm từ này vào danh sách từ sai
                Manage.TopicData.Listen.ListWrongWord.Add(lRandom[learnNumber]);
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
            // Chỉnh lại giao diện mặc định
            Hide();
            pnLeft.BackColor = pnRight.BackColor = pnUp.BackColor = pnDown.BackColor = Color.FromArgb(103, 183, 255);
            _checkDisplay[0] = _checkDisplay[1] = _checkDisplay[2] = _checkDisplay[3] = false;
            pbListen1.Image = pbListen2.Image = pbListen3.Image = pbListen4.Image = Properties.Resources.normal;
            Refresh();
            Show();
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
            if (GetControlProgressbar is uctrlProgressBar)
            {
                uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                // Gọi hàm tăng progress đúng:
                ProgressBar.IncreasingCorrect();
            }
            // Đổi màu giao diện 
            pnLeft.BackColor = pnRight.BackColor = pnUp.BackColor = pnDown.BackColor = Color.FromArgb(120, 200, 0);
            pnLeft.Refresh();
            pnRight.Refresh();
            pnUp.Refresh();
            pnDown.Refresh();
            // Kiểm tra vị trí đúng và show giao diện đúng 
            switch (result)
            {
                case 0:
                    for (int i = 0; i <5; i++)
                    {
                        pbListen1.Image = Properties.Resources.right;
                        pbListen1.Refresh();
                        Thread.Sleep(150);
                        pbListen1.Image = Properties.Resources.click;
                        pbListen1.Refresh();
                        Thread.Sleep(150);
                    }
                    pbListen1.Image = Properties.Resources.right;
                    pbListen1.Refresh();
                    break;
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        pbListen2.Image = Properties.Resources.right;
                        pbListen2.Refresh();
                        Thread.Sleep(150);
                        pbListen2.Image = Properties.Resources.click;
                        pbListen2.Refresh();
                        Thread.Sleep(150);
                    }
                    pbListen2.Image = Properties.Resources.right;
                    pbListen2.Refresh();
                    break;
                case 2:
                    for (int i = 0; i < 5; i++)
                    {
                        pbListen3.Image = Properties.Resources.right;
                        pbListen3.Refresh();
                        Thread.Sleep(150);
                        pbListen3.Image = Properties.Resources.click;
                        pbListen3.Refresh();
                        Thread.Sleep(150);
                    }
                    pbListen3.Image = Properties.Resources.right;
                    pbListen3.Refresh();
                    break;
                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        pbListen4.Image = Properties.Resources.right;
                        pbListen4.Refresh();
                        Thread.Sleep(150);
                        pbListen4.Image = Properties.Resources.click;
                        pbListen4.Refresh();
                        Thread.Sleep(150);
                    }
                    pbListen4.Image = Properties.Resources.right;
                    pbListen4.Refresh();
                    break;
            }
        }

        /// <summary>
        /// Giao diện khi sai
        /// </summary>
        /// <param name="result"></param>
        void CheckWhenWrong(int result)
        {
            // Đổi màu giao diện 
            pnLeft.BackColor = pnRight.BackColor = pnUp.BackColor = pnDown.BackColor = Color.Red;
            pnLeft.Refresh();
            pnRight.Refresh();
            pnUp.Refresh();
            pnDown.Refresh();
            // Giao diện: Chạy WRONG
            if (GetControlProgressbar is uctrlProgressBar)
            {
                uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                // Gọi hàm tăng progress sai:
                ProgressBar.IncreasingWrong();
            }

            // Tìm vị trí đúng:
            int indexTrue = Array.IndexOf(lSoundWord, lRandom[learnNumber]);
            switch (indexTrue)
            {
                case 0:
                    pbListen1.Image = Properties.Resources.right;
                    pbListen1.Refresh();
                    break;
                case 1:
                    pbListen2.Image = Properties.Resources.right;
                    pbListen2.Refresh();
                    break;
                case 2:
                    pbListen3.Image = Properties.Resources.right;
                    pbListen3.Refresh();
                    break;
                case 3:
                    pbListen4.Image = Properties.Resources.right;
                    pbListen4.Refresh();
                    break;
            }
            Thread.Sleep(10);
            // Tìm vị trí sai
            switch (result)
            {
                case 0:
                    pbListen1.Image = Properties.Resources.wrong;
                    pbListen1.Refresh();
                    break;
                case 1:
                    pbListen2.Image = Properties.Resources.wrong;
                    pbListen2.Refresh();
                    break;
                case 2:
                    pbListen3.Image = Properties.Resources.wrong;
                    pbListen3.Refresh();
                    break;
                case 3:
                    pbListen4.Image = Properties.Resources.wrong;
                    pbListen4.Refresh();
                    break;
            }
            Thread.Sleep(2000);
           
        }
        #endregion
    }
}
