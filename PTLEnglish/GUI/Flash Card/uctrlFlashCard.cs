using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.GUI.Flash_Card;
using PTLEnglish.DAL;
using System.Threading;
using PTLEnglish.GUI.Listen;

namespace PTLEnglish.GUI.Flash_Card
{
    public partial class uctrlFlashCard : UserControl
    {
        // Tạo panel lưu lại làn click vào 2 cái English hoặc Vietnamese:
        public static Panel pnEnglish = new Panel();
        public static Panel pnVietnamese = new Panel();
        // Kiểm tra lượt lật là của English hay Vietnamese:
        int checkFlip = 1;
        List<int> lRandom = null;
        int checkSuffle = 0; // Chưa bật suffle
        int countNormal;
        int countRandom;
        string filePath;
        // 2 biến user control:
        uctrlEnglish uEnglish;
        uctrlVietnamese uVietnamese;
        public uctrlFlashCard()
        {
            InitializeComponent();
            Manage.ThisCourse = "Source\\Economic";
            Manage.ThisTopic = "\\Job";
            filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";

        }

        #region Hàm random - Shuffle
        List<int> AddNumberIntoList()
        {
            List<int> lInt = new List<int>();
            for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
            {
                lInt.Add(i);
            }
            return lInt;
        }
        void RandomListWord(ref List<int> lRandom)
        {
            List<int> lInt = AddNumberIntoList();
            lRandom = new List<int>();
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

        fQuickPress Quick = new fQuickPress();
        private void uctrlFlashCard_Load(object sender, EventArgs e)
        {

            Quick.TopLevel = false;
            pnQuickPress.Controls.Add(Quick);

            countNormal = 0;
            // Khởi tạo các form
            uEnglish = new uctrlEnglish(countNormal);
            pnEnglish.Click += PnEnglish_Click;
            // Animation lật dọc là lật tiếng anh - tiếng việt
            flipPanel.Front = uEnglish;
            // Lật ngang là lật từ tiếp theo học từ phía trước:
            // Do lúc đầu không thể quay ngược lại chữ phía trước được nên chúng ta sẽ enable pbLeft đi:
            pbLeft.Enabled = false;
            //
            // flipPanel.H_Front = uEnglish;
            flipPanel.TimerInterval = 15;

            int temp = pnProgressRun.Width + 21;
            while (pnProgressRun.Width < temp)
            {
                pnProgressRun.Width += 1;
                Thread.Sleep(10);
            }
        }

        private void PnEnglish_Click(object sender, EventArgs e)
        {
            pnQuickPress.Visible = false;
            pbDown.Visible = false;

            flipPanel.CheckAnimation = true;
            int index = countNormal;
            if (lRandom != null)
                index = lRandom[countRandom];
            uVietnamese = new uctrlVietnamese(index);
            flipPanel.Behind = uVietnamese;
            pnVietnamese.Click += PnVietnamese_Click;
            if (flipPanel.Controls.Count == 3)
                flipPanel.Controls[1].Dispose();
            flipPanel.Flip();
        }


        private void PnVietnamese_Click(object sender, EventArgs e)
        {

            pnQuickPress.Visible = false;
            pbDown.Visible = false;
            // DoWhenFlip();
            flipPanel.CheckAnimation = true;
            int index = countNormal;
            if (lRandom != null)
                index = lRandom[countRandom];
            uEnglish = new uctrlEnglish(index);
            flipPanel.Behind = uEnglish;
            pnEnglish.Click += PnEnglish_Click;
            if (flipPanel.Controls.Count == 3)
                flipPanel.Controls[1].Dispose();
            flipPanel.Flip();
        }

        private void btnSuffle_Click(object sender, EventArgs e)
        {
            timerPlay.Enabled = false;
            checkBoth = 1;
            pnQuickPress.Visible = false;
            pbDown.Visible = false;
            #region MyRegion

            int index = 0;
            countNormal = 0;
            countRandom = 0;
            if (checkSuffle == 1)  // Hiện đang suffle -> tắt suffle
            {
                lRandom.Clear();
                lRandom = null;
                checkSuffle = 0;
            }
            else // Hiện đang Normal -> Bật suffle
            {
                RandomListWord(ref lRandom);
                index = lRandom[0];
                checkSuffle = 1;
            }
            uEnglish = new uctrlEnglish(index);
            uVietnamese = new uctrlVietnamese(index);

            flipPanel.Hide();
            flipPanel.Controls.Clear();
            Thread.Sleep(1000);
            flipPanel.Show();
            flipPanel.Front = uEnglish;
            flipPanel.Behind = uVietnamese;
            pnEnglish.Click += PnEnglish_Click;
            int dem = 0;
            while (pnProgressRun.Width > 21)
            {
                pnProgressRun.Width -= 1;
                if (dem % 5 == 0)
                    Thread.Sleep(1);
                dem++;
            }
            pbRight.Enabled = true;
            #endregion      
        }

        private void pbRight_Click(object sender, EventArgs e)
        {

            pnQuickPress.Visible = false;
            pbDown.Visible = false;

            int index = -1;
            if (lRandom != null)
            {
                countRandom++;
                if (countRandom != 25)
                    index = lRandom[countRandom];
            }
            else
            {
                countNormal++;
                index = countNormal;
            }
            if (index <= 24)
            {
                // Tắt enable của pbLeft    
                if (index > 0)
                    pbLeft.Enabled = true;
                //
                flipPanel.CheckAnimation = false;

                if (checkBoth == 0)
                {
                    Both = new uctrlBoth(index);
                    flipPanel.Behind = Both;

                }
                else
                {
                    uEnglish = new uctrlEnglish(index);
                    flipPanel.Behind = uEnglish;

                    pnEnglish.Click += PnEnglish_Click;
                }
                if (flipPanel.Controls.Count == 3)
                    flipPanel.Controls[1].Dispose();
                flipPanel.Flip();
                // Tăng progress
                int temp = pnProgressRun.Width + 21;
                while (pnProgressRun.Width < temp)
                {
                    pnProgressRun.Width += 1;
                    Thread.Sleep(10);
                }

                return;
            }

            if (lRandom != null) countRandom--;
            else countNormal--;
            pbRight.Enabled = false;
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            timerPlay.Enabled = false;
            pnQuickPress.Visible = false;
            pbDown.Visible = false;

            int index = -1;
            if (lRandom != null)
            {
                countRandom--;
                if (countRandom != -1)
                    index = lRandom[countRandom];
            }
            else
            {
                countNormal--;
                index = countNormal;
            }

            if (index >= 0)
            {
                // Tắt enable của pbLeft
                if (index != 24)
                    pbRight.Enabled = true;
                //
                flipPanel.CheckAnimation = false;
                if (checkBoth == 0)
                {
                    Both = new uctrlBoth(index);
                    flipPanel.Behind = Both;

                }
                else
                {
                    uEnglish = new uctrlEnglish(index);
                    flipPanel.Behind = uEnglish;
                    pnEnglish.Click += PnEnglish_Click;
                }
                if (flipPanel.Controls.Count == 3)
                    flipPanel.Controls[1].Dispose();
                flipPanel.Flip();
                // Giảm progress
                int temp = pnProgressRun.Width - 21;
                while (pnProgressRun.Width > temp)
                {
                    pnProgressRun.Width -= 1;
                    Thread.Sleep(10);
                }

                return;
            }
            if (lRandom != null)
                countRandom++;
            else
                countNormal++;
            pbLeft.Enabled = false;

        }


        #region Giao diện
        private void pbLeft_MouseHover(object sender, EventArgs e)
        {
            pbLeft.Image = Properties.Resources.Back_100;
        }

        private void pbLeft_MouseLeave(object sender, EventArgs e)
        {
            pbLeft.Image = Properties.Resources.Back_100__1_;
        }

        private void pbRight_MouseHover(object sender, EventArgs e)
        {
            pbRight.Image = Properties.Resources.Back_100_opt;
        }

        private void pbRight_MouseLeave(object sender, EventArgs e)
        {
            pbRight.Image = Properties.Resources.Back_100__1__opt;
        }
        #endregion

        int checkQuickKeyboardClick = 0;
        private void pbQuickKeyBoard_Click(object sender, EventArgs e)
        {
            // -------- chưa làm ---------
            timerPlay.Enabled = false;
            if (checkQuickKeyboardClick == 0)
            {
                pbDown.Visible = true;
                pnQuickPress.Visible = true;
                Quick.Show();
                checkQuickKeyboardClick = 1;
            }
            else
            {
                pbDown.Visible = false;
                pnQuickPress.Visible = false;
                Quick.Hide();
                checkQuickKeyboardClick = 0;
            }

        }

        private void pbQuickKeyBoard_MouseHover(object sender, EventArgs e)
        {
            pbQuickKeyBoard.Image = Properties.Resources.Keyboard_Filled_50;
        }

        private void pbQuickKeyBoard_MouseLeave(object sender, EventArgs e)
        {
            pbQuickKeyBoard.Image = Properties.Resources.Keyboard_Filled_50__1_;
        }

        int checkAutoPlay = 1;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (checkAutoPlay == 1)
            {
                timerPlay.Enabled = true;
                checkAutoPlay = 0;
            }
            else
            {
                // -------- chưa làm ---------
                checkAutoPlay = 1;
                timerPlay.Enabled = false;
            }

        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            if (pbRight.Enabled == true)
            {
                //Thread.Sleep(2000);
                pbRight_Click(sender, e);
            }
            else timerPlay.Enabled = false;
        }

        int checkBoth = 1;
        uctrlBoth Both;
        private void btnBoth_Click(object sender, EventArgs e)
        {
            if (checkBoth == 1)
            {
                int index = countNormal;
                if (lRandom != null)
                {
                    index = lRandom[countRandom];
                }
                Both = new uctrlBoth(index);
                flipPanel.Front = Both;
                while (flipPanel.Controls.Count != 1)
                    flipPanel.Controls[0].Dispose();
                checkBoth = 0;
            }
            else
            {

                checkBoth = 1;
            }

        }
    }
}
