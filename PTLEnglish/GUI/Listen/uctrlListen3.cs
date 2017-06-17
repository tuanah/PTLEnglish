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
        int learnNumber = -1;
        // Lấy hàm bên pnMain bên uctrlMain
        public static FlowLayoutPanel fpnMain = new FlowLayoutPanel();
        public uctrlListen3(string Filepath)
        {
            InitializeComponent();
            filePath = Filepath;
        }

        private void uctrlListen3_Load(object sender, EventArgs e)
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

        #region Hàm hiện 1 từ lên màn hình
        void ShowAWord(int count, bool _check = true)
        {
            if (learnNumber < Manage.TopicData.WordList.Count) // Nếu chưa học hết các từ
            {
                // Lưu tại từ tiếng anh đúng tí mang ra kiểm tra với từ mình nhập vào
                tbText.Tag = Manage.TopicData.WordList[lRandom[count]].Mean;
                lbWrong.Tag = Manage.TopicData.WordList[lRandom[count]].Key;
                ReadText(lbWrong.Tag.ToString(), 1);
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
                    check = 1;
                    CheckPnHorizontal();
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

        #region Kiểm tra 1 từ đúng hay sai
        void CheckWordTrueFalse()
        {
            if (tbText.Text == tbText.Tag.ToString()) // Đúng
            {
                // Chạy đúng:
                check = 4;
                CheckPnHorizontal();
                // Giao diện: Chạy CORRECT        
                if (GetControlProgressbar is uctrlProgressBar)
                {
                    uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                    // Gọi hàm tăng progress đúng:
                    ProgressBar.IncreasingCorrect();
                }
                // Tăng số lần đúng
                Manage.TopicData.WordList[lRandom[learnNumber]].NumRight++;
                // Tăng số lần đúng trong listen
                Manage.TopicData.Listen.CorrectWords++;
                // Lưu lại vào Topic và serialize xuống
                Manage.SerializeToXML(Manage.TopicData, filePath);
            }
            else
            {
                // Chạy timer và hiện kiểu SAI      
                check = 3;
                CheckPnHorizontal();
                // Giao diện: Chạy WRONG
                if (GetControlProgressbar is uctrlProgressBar)
                {
                    uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                    // Gọi hàm tăng progress sai:
                    ProgressBar.IncreasingWrong();
                }
                // Tăng các từ sai:
                Manage.TopicData.WordList[lRandom[learnNumber]].NumWrong++;
                // Tăng số từ sai trong listen:
                Manage.TopicData.Listen.WrongWords++;
                if (Manage.TopicData.Listen.ListWrongWord == null)
                    Manage.TopicData.Listen.ListWrongWord = new List<int>();
                // Thêm từ này vào danh sách từ sai
                Manage.TopicData.Listen.ListWrongWord.Add(lRandom[learnNumber]);
                // Lưu lại vào Topic và serialize xuống
                Manage.SerializeToXML(Manage.TopicData, filePath);

                // Hiện từ sai lên:
                lbWrong.Text = tbText.Tag.ToString();
                lbWrong.Visible = true;
                lbWrong.Refresh();
            }

            Thread.Sleep(1500);

            Hide();
            lbWrong.Visible = false;
            tbText.Text = string.Empty;
            check = 1;
            CheckPnHorizontal();

            Show();
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
        void CheckPnHorizontal()
        {
            // Mấy hàm trong đây xử lý cái chạy mượt cái pnHorizontal - cái cục ngang trên cái "TYPE WHAT YOU HEAR"
            if (check == 1) // được click
            {
                lbCommand.Text = "TYPE THE MEANING";
                lbCommand.ForeColor = Color.FromArgb(103, 183, 255);
                lbCommand.Refresh();//151, 165, 177
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.FromArgb(52, 152, 219);
                pnHorizontal.Height = pnHorizontalRun.Height = 4;

            }
            else if (check == 2) // Không được click
            {
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.FromArgb(69, 83, 88);
                pnHorizontal.Height = pnHorizontalRun.Height = 3;

            }
            else if (check == 3) // sai
            {
                lbCommand.Text = "NOT CORRECT";
                lbCommand.ForeColor = Color.FromArgb(255, 114, 91);
                lbCommand.Refresh();
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.Red;
            }
            else if (check == 4) // đúng
            {
                lbCommand.Text = "CORRECT";
                lbCommand.ForeColor = Color.FromArgb(120, 200, 0);
                lbCommand.Refresh();
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.FromArgb(120, 200, 0);
            }
            else if (check == 5) //Ghi lại
            {
                lbCommand.Text = "WRITE AGAIN TO REMEMBER";
                lbCommand.ForeColor = Color.FromArgb(66, 87, 178);
                lbCommand.Refresh();
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.BlueViolet;
            }
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
        private void pbSpeakNormal_MouseHover(object sender, EventArgs e)
        {
            pbSpeakNormal.Image = Properties.Resources.click;
        }

        private void pbSpeakNormal_MouseLeave(object sender, EventArgs e)
        {
            pbSpeakNormal.Image = Properties.Resources.normal;
        }

        private void pbSpeakSlowly_MouseHover(object sender, EventArgs e)
        {
            pbSpeakSlowly.Image = Properties.Resources.click;

        }

        private void pbSpeakSlowly_MouseLeave(object sender, EventArgs e)
        {
            pbSpeakSlowly.Image = Properties.Resources.normal;
        }
        #endregion

    }
}
