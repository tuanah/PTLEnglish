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
using System.Threading;

namespace PTLEnglish.GUI.Listen
{
    public partial class uctrlListen1 : UserControl
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
        // 2 cái biến đầu là cái biến mặc định để đọc được âm thanh khi xài thư viện System.Speech
        SpeechSynthesizer speechSynthes = new SpeechSynthesizer();
        // Biến dùng đường dẫn và từ đang học:
        string filePath;
        int learnNumber;
        // Lấy hàm bên pnMain bên uctrlMain
        public static FlowLayoutPanel fpnMain = new FlowLayoutPanel();
        // ---------------------------------------------

        public uctrlListen1(string Filepath, int LearnNumber)
        {
            InitializeComponent();
            filePath = Filepath;
            learnNumber = LearnNumber;
        }

        #region Hàm thay đổi giao diện của thanh pnHorizontal     
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
        #endregion

        #region Hàm load dữ liệu lúc mới bắt đầu
        private void uctrlListen1_Load(object sender, EventArgs e)
        {
            pnImageAndMean.Refresh();
            pnReadListenSub.Refresh();
            // Đọc từ đầu tiên:
            if (Manage.TopicData.Listen.FirstTimeOfWord == false)
                ShowAWord(++learnNumber);
            else
                ShowAWord(++learnNumber, 10);
        }

        #endregion

        #region Hàm đọc 1 từ
        /// <param name="textToSpeech">dữ liệu để đọc</param>
        /// <param name="rate">tốc độ đọc</param>
        /// <param name="check"></param>
        void ReadText(string textToSpeech, int rate, bool check = true)
        {
            speechSynthes.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            speechSynthes.Rate = rate;
            speechSynthes.Volume = 100;
            speechSynthes.SpeakAsync(textToSpeech); // Cái này nó đọc âm thanh mà ko bị đứng màn hình. Nó đọc nhanh
        }
        #endregion

        #region Hàm click - Hover - Leave vào Sound
        private void pbListen_Click(object sender, EventArgs e)
        {
            ReadText(tbText.Tag.ToString(), 1);
        }

        private void pbListen_MouseHover(object sender, EventArgs e)
        {
            pbListen.Image = Properties.Resources.Blue_Sound;
        }

        private void pbListen_MouseLeave(object sender, EventArgs e)
        {
            pbListen.Image = Properties.Resources.Room_Sound_Filled_50;
        }
        #endregion

        #region Hàm hiện 1 từ lên màn hình

        bool NotWriteAgain = true;
        void ShowAWord(int count, int _check = 0)
        {
            if (learnNumber < Manage.TopicData.WordList.Count) // Nếu chưa học hết các từ
            {           
                // Lưu tại từ tiếng anh đúng tí mang ra kiểm tra với từ mình nhập vào
                tbText.Tag = Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].Key;
                // Gán hình ảnh cho từ hiện tại:
                pbImage.Image = new Bitmap(Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].ImgPath);
                pbImage.Refresh();
                // Hiện từ tiếng việt:
                lbMean.Text = Manage.TopicData.WordList[Manage.TopicData.Listen.ListRandom[count]].Mean;
                lbMean.Refresh();
                tbText.Focus();
                /*
                 * Biến Manage.TopicData.Listen.FirstTimeOfWord có tác dụng :
                 * Nếu từ đó mà người dùng nhập đúng -> khí chương trình bị tắt đột ngột -> Không sao
                 * Nhưng từ đó người dùng nhập sai thì người ta phải nhập lại cho nhớ .
                        + Trong lúc này mà người dùng tắt đi, thì phải có 1 biến lưu lại để biết rằng
                        + Lần sau nếu được hiện lên thì phải ghi lại từ đó cho thuộc, xong mới được qua từ khác
                        - > ghi đúng . pnProgress tăng                 
                */

                //  NotWriteAgain là 1 biến có tác dụng . Nếu ghi lại mà người đó còn ghi sai nữa thì không tăng số từ sai lên
                if (_check == 0)
                {
                    // Tăng progress tiến trình
                    // Giao diện: Chạy CORRECT
                    uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                    // Gọi hàm tăng progress đúng:
                    ProgressBar.IncreasingProgress();
                    // Gọi hàm  Manage.SerializeToXML để lưu lại:               
                    //  Số từ đã học được 
                    Manage.TopicData.Listen.Progress = learnNumber;
                    // Từ mới xuất hiện 1 lần:
                    Manage.TopicData.Listen.FirstTimeOfWord = false;
                    // Thực hiện serialize:
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    // Người đó chưa sai lần nào của từ đó nên chuyển thành true
                    NotWriteAgain = true;
                    // Ẩn cái lb lúc sai nó hiện lên đi
                    lbkey.Visible = false;
                    // Hiện lại cái TYPE WHAT YOU HEAR cho từ mới
                    CheckPnHorizontal("TYPE WHAT YOU HEAR", Color.FromArgb(103, 183, 255), Color.FromArgb(52, 152, 219));
                }
                else
                {
                    // Từ này đã được xuất hiện >=1 lần
                    Manage.TopicData.Listen.FirstTimeOfWord = true;
                    // Tiến trình các từ đã học được 
                    Manage.TopicData.Listen.Progress = count;
                    // Thực hiện serialize:
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    // Người đó đã sai >=1 lần của từ đó nên chuyển thành false
                    NotWriteAgain = false;
                }

            }
            else // Nếu đã học xong  tất cả các từ
            {
                // xóa tất cả các control trong fpnMain
                fpnMain.Controls.Clear();
                fpnMain.FlowDirection = FlowDirection.LeftToRight; fpnMain.BackColor = Color.White;
                // Hiện form kết thúc chương trình học listen:
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
            // Cho đọc cái từ hiện tại:
            ReadText(tbText.Tag.ToString(), 1);
        }

        #endregion

        #region Kiểm tra từ đó đúng hay sai
        void CheckWordTrueOrFalse(List<int> lRandom)
        {
            // Kiểm tra từ tiếng anh đó có đúng không:
            if (tbText.Text == tbText.Tag.ToString())
            {
                // Chạy timer và hiện kiểu đúng      
                CheckPnHorizontal("CORRECT", Color.FromArgb(120, 200, 0), Color.FromArgb(120, 200, 0));
                if (NotWriteAgain) // nếu nó đúng ngay lần đầu
                {
                    // Giao diện: Chạy CORRECT        
                    uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                    // Gọi hàm tăng progress đúng:
                    ProgressBar.IncreasingCorrect();
                    // Tăng số lần đúng
                    Manage.TopicData.WordList[lRandom[learnNumber]].NumRight++;
                    // Tăng số lần đúng trong listen
                    Manage.TopicData.Listen.CorrectWords++;
                    // Lưu lại vào Topic và serialize xuống
                    Manage.SerializeToXML(Manage.TopicData, filePath);

                }
                // Xóa dữ liệu trên tbText
                tbText.Text = string.Empty;
                pnReadListenSub.Visible = false;
                pnReadListenSub.Refresh();
                pnReadListenSub.Visible = true;
                // Hiện từ vựng mới                          
                ShowAWord(++learnNumber);

            }
            else // Nếu từ đó sai
            {
                // Chạy timer và hiện kiểu SAI      
                CheckPnHorizontal("NOT CORRECT. THE CORRECT ANSWER IS:", Color.FromArgb(255, 114, 91), Color.Red);

                if (NotWriteAgain)
                {
                    // Giao diện: Chạy WRONG
                    uctrlProgressBar ProgressBar = GetControlProgressbar as uctrlProgressBar;
                    // Gọi hàm tăng progress sai:
                    ProgressBar.IncreasingWrong();
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
                    lbkey.Visible = false;
                }
                // Xóa dữ liệu trên tbText
                tbText.Text = string.Empty;
                // Hiện từ tiếng anh ghi sai 
                lbkey.Text = tbText.Tag.ToString();
                lbkey.Visible = true;
                // Chạy timer và hiện kiểu WRITE AGAIN      
                CheckPnHorizontal("WRITE AGAIN TO REMEMBER", Color.FromArgb(66, 87, 178), Color.BlueViolet);
                // Đọc lại từ cũ:
                ShowAWord(learnNumber, 10);
            }

        }
        #endregion

        #region Hàm xử lý text box
        private void tbText_MouseClick(object sender, MouseEventArgs e)
        {
            CheckPnHorizontal("TYPE WHAT YOU HEAR", Color.FromArgb(103, 183, 255), Color.FromArgb(52, 152, 219));
        }

        /// <summary>
        /// Hàm kiểm tra khi nào người nhập nhấn enter thì sẽ kiểm tra từ đó đúng hay sai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // Nếu người nhập nhấn enter
            {
                if (tbText.Text != "")
                {
                    // Hàm kiểm tra từ đó đúng hay sai
                    CheckWordTrueOrFalse(Manage.TopicData.Listen.ListRandom);
                    e.Handled = true; // Tắt tiếng beep khó chịu
                }
            }
        }
        #endregion
    }
}