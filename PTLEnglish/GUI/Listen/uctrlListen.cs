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
using AnimatorNS;
using System.Media;
using System.Threading;
using System.IO;

namespace PTLEnglish.GUI.Listen
{

    public partial class uctrlListen : UserControl
    {
        Animator a = new Animator();
        // Hàm lấy hàm từ form khác
        // Lưu ý form này trong form khác phải dc khởi tạo r
        public object GetFunction
        {
            set;
            get;
        }
        // Biến lưu lại khi học xong bài . Kiểm tra xem có được click hay không:
        public static Button btnStartOverr = new Button();
        // 2 cái biến đầu là cái biến mặc định để đọc được âm thanh khi xài thư viện System.Speech
        PromptBuilder proBuilder = new PromptBuilder();
        SpeechSynthesizer speechSynthes = new SpeechSynthesizer();
        // Đếm các từ vựng đã học được hay chưa
        int count = -1;
        // 
        // Biến check là 1 biến quan trọng trong xử lý giao diện
        int check = 0;
        string filePath;
        public uctrlListen()
        {
            InitializeComponent();
            Manage.ThisCourse = "Source\\Economic";
            Manage.ThisTopic = "\\Job";
            filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";

        }
        public void uctrlListen_Load(object sender, EventArgs e)
        {
            // Hiện giao diện trc cho đẹp:
            fpnMain.Refresh();
            lbCorrect.Refresh();
            lbWrong.Refresh();
            lbProgress.Refresh();
            //Manage.SerializeToXML(Manage.TopicData, filePath);
            // Đọc dữ liệu từ Xml lên:
            Manage.TopicData = (Topic)Manage.DeserializeFromXML(Cons.Path + Manage.ThisTopic + ".xml");
            a.AnimationType = AnimationType.Transparent;
            /*
             *  Nếu ProgressOfListen = -1 -> chưa được học lần nào -> tạo khóa học Listen 
             *  Ngược lại Nếu ProgressOfListen != -1 -> đang được học -> học tiếp . Không cần tạo khóa học mới
             */
            List<int> lRandom = new List<int>();
            if (Manage.TopicData.Listen.Progress != -1)
            {
                lRandom = Manage.TopicData.Listen.ListRandom;
                count = Manage.TopicData.Listen.Progress - 1;

                // Phần này chạy giao diện:
                while (pnCorrectRun.Width < Manage.TopicData.Listen.CorrectWords * 21)
                {
                    pnCorrectRun.Width += 1;
                    Thread.Sleep(1);
                }
                while (pnWrongRun.Width < Manage.TopicData.Listen.WrongWords * 21)
                {
                    pnWrongRun.Width += 1;
                    Thread.Sleep(1);
                }
                // Tính toán:
                if (Manage.TopicData.Listen.FirstTimeOfWord)
                    pnProgressRun.Width = (count + 2) * 21;
                else
                    pnProgressRun.Width = (count + 1) * 21;
            }
            else
            {
                RandomListWord(lRandom);
                Manage.TopicData.Listen.ListRandom = lRandom;
                Manage.SerializeToXML(Manage.TopicData, filePath);
                // sửa lỗi </Topic>> 
                //ErrorXml();
            }
            if (Manage.TopicData.Listen.FirstTimeOfWord == false)
                ShowAWord(++count, lRandom);
            else
                ShowAWord(++count, lRandom, 5);
        }

        #region Xử lý giao diện:

        // Không dùng tới:
        void HideBar()
        {
            #region Hide ScrollBar
            fpnMain.AutoScroll = false;
            fpnMain.HorizontalScroll.Enabled = false;
            fpnMain.HorizontalScroll.Visible = false;
            fpnMain.HorizontalScroll.Maximum = 0;

            fpnMain.VerticalScroll.Enabled = false;
            fpnMain.VerticalScroll.Visible = false;
            fpnMain.VerticalScroll.Maximum = 0;
            fpnMain.AutoScroll = true;
            #endregion
        }

        private void pbListen_MouseHover(object sender, EventArgs e)
        {
            pbListen.Image = Properties.Resources.Blue_Sound;
        }

        private void pbListen_MouseLeave(object sender, EventArgs e)
        {
            pbListen.Image = Properties.Resources.Room_Sound_Filled_50;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Mấy hàm trong đây xử lý cái chạy mượt cái pnHorizontal - cái cục ngang trên cái "TYPE WHAT YOU HEAR"
            if (check == 1) // được click
            {
                lbCommand.Text = "TYPE WHAT YOU HEAR";
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
                pnHorizontalRun.Width = pnHorizontalRun.Width + 1;
            pnHorizontal.BackColor = pnHorizontalRun.BackColor;
            check = 0;
            timer.Stop();
            timer.Interval = 400;
            timer.Dispose();

        }
        void CheckPnHorizontal()
        {
            // Mấy hàm trong đây xử lý cái chạy mượt cái pnHorizontal - cái cục ngang trên cái "TYPE WHAT YOU HEAR"
            if (check == 1) // được click
            {
                lbCommand.Text = "TYPE WHAT YOU HEAR";
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
                pnHorizontalRun.Width = pnHorizontalRun.Width + 1;
            pnHorizontal.BackColor = pnHorizontalRun.BackColor;
        }
        private void tbText_MouseClick(object sender, MouseEventArgs e)
        {
            timer.Start();
            check = 1;
            CheckPnHorizontal();
        }
        #endregion

        #region Hàm Random giá trị:
        List<int> AddNumberIntoList()
        {
            List<int> lInt = new List<int>();
            for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
            {
                lInt.Add(i);
            }
            return lInt;
        }
        void RandomListWord(List<int> lRandom)
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


        #region Các hàm xử lý chính: Đọc - Hiện 1 từ lên màn hình - Kiểm tra từ đó đúng hay sai:

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

        void ShowAWord(int index, List<int> lRandom, int _check = 0)
        {
            if (count >= 25) // Kết thúc Listen -> Hiện lên thực hiện lại từ đầu
            {
                // Giao diện:
                fpnMain.Controls.Clear();
                fpnMain.Refresh();
                fpnMain.FlowDirection = FlowDirection.LeftToRight;
                fpnMain.Refresh();

                // Hiện form kết thúc chương trình học listen:
                uctrlFinish finish = new uctrlFinish();
                fpnMain.Controls.Add(finish);
                // Hiện các từ sai ra màn hình:
                foreach (int item in Manage.TopicData.Listen.ListWrongWord)
                {
                    uctrlMissedWord miss = new uctrlMissedWord(item);
                    fpnMain.Controls.Add(miss);
                }
                // Nếu người dùng click vào học lại listen:
                btnStartOverr.Click += delegate (object sender, EventArgs e)
                {
                    Manage.TopicData.Listen.CorrectWords = 0;
                    Manage.TopicData.Listen.WrongWords = 0;
                    Manage.TopicData.Listen.Progress = -1;
                    Manage.TopicData.Listen.ListRandom = null;
                    Manage.TopicData.Listen.ListWrongWord = null;
                    Manage.TopicData.Listen.FirstTimeOfWord = false;
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    // Khúc này xét xem nếu hàm GetFunction đã get dc fSub
                    // Thì sẽ click vào Listen để chạy lại chương trình:
                    if (GetFunction is fSub)
                    {
                        fSub frm = GetFunction as fSub;
                        frm.pnl_Listen_Click(sender, e);
                    }
                };
            }
            else // Nếu chưa kết thúc - vẫn còn từ học:
            {
                
                tbText.Focus();
                // Lưu tại từ tiếng anh đúng tí mang ra kiểm tra với từ mình nhập vào
                tbText.Tag = Manage.TopicData.WordList[lRandom[index]].Key;
                // ------------ Gán các giá trị: -----------------
                try
                {
                    pbImage.Image = new Bitmap(Manage.TopicData.WordList[lRandom[index]].ImgPath);

                }
                catch 
                {
                    pbImage.Image = Properties.Resources.error_image;
                }
                pbImage.Refresh();
                // Hiện từ tiếng việt:
                lbMean.Text = Manage.TopicData.WordList[lRandom[index]].Mean;
                lbMean.Refresh();

                //  Manage.TopicData.Listen.FirstTimeOfWord có tác dụng :
                /*
                 * Khi từ đó người dùng nhập đúng thì không sao, tắt ứng dụng cũng được
                 * Nhưng từ đó người dùng nhập sai thì người ta phải nhập lại.Trong lúc nhập lại người ta có thể tắt ứng dụng luôn
                 * Thì biến này sẽ có tác dụng lưu lại trạng thái của từ này . Lần sau người ta ghi từ này đúng từ này thì progress sẽ không tăng
                 */

                /* NotWriteAgain là 1 biến có tác dụng . Nếu ghi lại mà người đó còn ghi sai nữa thì không tăng số từ sai lên */

                // Chia nhiều lần kiểm tra biến _check để làm cho giao diện chạy mượt. Đẹp hơn
                if (_check == 0)
                {
                    // Lưu lại vào Topic 
                    Manage.TopicData.Listen.Progress = count;
                    Manage.TopicData.Listen.FirstTimeOfWord = false;
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    // sửa lỗi </Topic>> 
                    //ErrorXml();
                    NotWriteAgain = true;
                    // Tăng giá trị của progressRun - từ học được:
                    int temp = pnProgressRun.Width + 21;
                    while (pnProgressRun.Width < temp)
                    {
                        pnProgressRun.Width += 1;
                        Thread.Sleep(10);
                    }
                }
                else
                {
                    Manage.TopicData.Listen.FirstTimeOfWord = true;
                    Manage.TopicData.Listen.Progress = count;
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    // sửa lỗi </Topic>> 
                    // ErrorXml();
                    NotWriteAgain = false;
                }
                // Đọc
                ReadText(tbText.Tag.ToString(), 1);

                if (_check == 0)
                {
                    lbkey.Visible = false;
                    check = 1;
                    timer.Start();
                }

                // Sinh hàm keypress của tbText:
                // Delegate để sử dụng trực tiếp biến random trong này luôn. Nếu không làm thế thì có thể khởi tạo bình thường và ra bên ngoài sử dụng
                tbText.KeyPress += delegate (object a, KeyPressEventArgs ee)
                {
                    if (ee.KeyChar == 13)
                    {
                        if (tbText.Text != "")
                        {
                            CheckWordTrueOrFalse(lRandom);
                            ee.Handled = true; // Tắt tiếng beep khó chịu
                        }
                    }
                };
            }

        }

        bool NotWriteAgain = true;
        void CheckWordTrueOrFalse(List<int> lRandom)
        {
            // Kiểm tra từ tiếng anh đó đúng hay sai:
            if (tbText.Text == tbText.Tag.ToString())
            {
                // Chạy timer và hiện kiểu đúng      
                check = 4;
                timer.Start();

                if (NotWriteAgain)
                {
                    Manage.TopicData.Listen.ListWrongWord.Add(lRandom[count]);
                    Manage.TopicData.WordList[lRandom[count]].NumRight++;
                    // Lưu lại vào Topic 
                    Manage.TopicData.Listen.CorrectWords++;
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    // sửa lỗi </Topic>> 
                    //ErrorXml();
                    // Giao diện: Chạy CORRECT
                    int temp = pnCorrectRun.Width + 21;
                    while (pnCorrectRun.Width < temp)
                    {
                        pnCorrectRun.Width += 1;
                        Thread.Sleep(10);
                    }
                }

                // Khi xong thì tất cả sẽ biến mất 
                pnReadListenSub.Visible = false;
                tbText.Text = "";
                // Tắt event:
                tbText.KeyPress -= delegate { };
                a.ShowSync(pnReadListenSub);
                // Hiện từ vựng mới                            
                ShowAWord(++count, lRandom);
            }
            else
            {
                // Chạy timer và hiện kiểu SAI      
                check = 3;
                timer.Start();
                if (NotWriteAgain)
                {
                    Manage.TopicData.WordList[lRandom[count]].NumWrong++;
                    // Lưu lại vào Topic và serialize xuống
                    Manage.TopicData.Listen.WrongWords++;
                    if (Manage.TopicData.Listen.ListWrongWord == null)
                        Manage.TopicData.Listen.ListWrongWord = new List<int>();
                    Manage.TopicData.Listen.ListWrongWord.Add(lRandom[count]);
                    Manage.SerializeToXML(Manage.TopicData, filePath);
                    // sửa lỗi </Topic>> 
                    //ErrorXml();
                    //
                    // Giao diện: Chạy WRONG
                    int temp = pnWrongRun.Width + 21;
                    while (pnWrongRun.Width < temp)
                    {
                        pnWrongRun.Width += 1;
                        Thread.Sleep(10);
                    }
                }
			

                // Tắt event:
                tbText.KeyPress -= delegate { };
                tbText.Text = "";
                // Hiện từ tiếng anh ghi sai 
                lbkey.Text = tbText.Tag.ToString();
                a.ShowSync(lbkey);
                // Chạy timer và hiện kiểu WRITE AGAIN      
                check = 5;
                timer.Start();
                // Đọc lại từ cũ:
                ShowAWord(count, lRandom, 5);
            }
        }

        #endregion

        #region Sửa lỗi XML:Bỏ
        void ErrorXml()
        {
            string text = File.ReadAllText(filePath);
            text = text.Replace("</Topic>>", "</Topic>");
            File.WriteAllText(filePath, text);
        }
        #endregion


        private void pbListen_Click(object sender, EventArgs e)
        {
            ReadText(tbText.Tag.ToString(), 1);
        }
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            timer.Start();
            check = 2;
        }
    }
}
