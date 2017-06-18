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
using System.Threading;
using PTLEnglish.GUI.Listen;
namespace PTLEnglish.GUI.Flash_Card
{
    public partial class uctrlMainFlashCard : UserControl
    {
        // Tạo panel lưu lại lần click vào 2 cái English hoặc Vietnamese:
        public static Panel pnEnglish = new Panel();
        public static Panel pnVietnamese = new Panel();

        List<int> lRandom = null;
        // Hàm kiểm tra các điều kiện như: 
        /* Kiểm tra có click vào Auto Play không:
         * Kiểm tra có được shuffle ko
         * Kiểm tra có click vào cả 2 không:
         */
        bool[] _CheckConditional = { false, false, false };
        // Đường dẫn:
        string filePath;
        // 3 biến user control:
        uctrlEnglish uEnglish;
        uctrlVietnamese uVietnamese;
        uctrlBoth Both;

        // 
        int id = 0;
        public uctrlMainFlashCard()
        {
            InitializeComponent();
            Manage.ThisCourse = "Source\\Economic";
            Manage.ThisTopic = "\\Job";
            filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";
        }

        #region Load dữ liệu
        private void uctrlMainFlashCard_Load(object sender, EventArgs e)
        {
            // Khởi tạo các form - Cho đọc từ đầu tiên:
            uEnglish = new uctrlEnglish(id);
            pnEnglish.Click += PnEnglish_Click;
            // Animation lật dọc là lật tiếng anh - tiếng việt
            flipPanel.Front = uEnglish;
            // Lật ngang là lật từ tiếp theo học từ phía trước:
            flipPanel.TimerInterval = 15;
            // Tăng progressbar
            IncreasingProgressbar();
        }
        #endregion

        #region Hàm xử lý ProgressBar
        /// <summary>
        /// Tăng ProgressBar
        /// </summary>
        private void IncreasingProgressbar()
        {
            // Tăng progress
            int temp = pnProgressRun.Width + 21;
            while (pnProgressRun.Width < temp)
            {
                pnProgressRun.Width += 1;
                Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Giảm ProgressBar
        /// </summary>
        private void DecreaseProgressbar()
        {
            int temp = pnProgressRun.Width - 21;
            while (pnProgressRun.Width > temp)
            {
                pnProgressRun.Width -= 1;
                Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Đặt progressbar về mặc định
        /// </summary>
        private void ClearProgressbar()
        {
            int dem = 0;
            while (pnProgressRun.Width > 21)
            {
                pnProgressRun.Width -= 1;
                if (dem % 5 == 0)
                    Thread.Sleep(1);
                dem++;
            }
        }
        #endregion

        #region Lấy từ hiện tại - tiếp theo - đằng trước

        /// <summary>
        /// Lấy từ Hiện tại - Tiếp theo - Phía trước
        /// </summary>
        /// <param name="Conditional">Biến điều kiện chọn. 1: tiếp theo .-1: Phía trước . 
        /// Còn lại là hiện tại </param>
        /// <returns></returns>
        private int GetNumber(int Conditional)
        {
            switch (Conditional)
            {
                case -1: id--; break;
                case 1: id++; break;
            }
            // lRandom == null tức là hiện tại mình đang cho chạy các từ học được theo thứ tự
            if (lRandom == null)
                return id;
            // Ngược lại là đang học theo 1 cách lộn xộn. Thì sẽ lấy từ tiếp theo trong lRandom ra
            return lRandom[id];
        }
        #endregion

        #region Click Trái - Phải
        private void pbRight_Click(object sender, EventArgs e)
        {
            // Hiện click trái:            
            pbLeft.Enabled = true;
            // Lấy giá trị tiếp theo:
            int index = GetNumber(1);
            // Dùng animation lật ngang:
            flipPanel.CheckAnimation = false;
            // Xét điều kiện:
            // Nếu hiện tại nút Both được click
            if (_CheckConditional[2] == true)
            {
                // Khởi tạo và gán giá trị tiếp theo vào flipPanel:
                Both = new uctrlBoth(index);
                flipPanel.Behind = Both;
            }
            else
            {
                // Khởi tạo và gán giá trị tiếp theo vào flipPanel:
                uEnglish = new uctrlEnglish(index);
                flipPanel.Behind = uEnglish;
                // Khởi tạo hàm cho phép click vào uEnglish:
                pnEnglish.Click += PnEnglish_Click;
            }
            // Hàm kiểm tra nếu tồn tại quá 2 controls trong flipPanel thì xóa bớt đi 1 cái:
            if (flipPanel.Controls.Count == 3)
                flipPanel.Controls[1].Dispose();
            // Thực hiện hàm lật ngang
            flipPanel.Flip();

            // Tăng Progressbar
            IncreasingProgressbar();
            // Điều kiện dừng:
            if ((lRandom == null && id == Manage.TopicData.WordList.Count-1) || (lRandom != null && id == Manage.TopicData.WordList.Count - 1))
                pbRight.Enabled = false;
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            // Hiện click phải:            
            pbRight.Enabled = true;
            // Lấy giá trị phía trước:
            int index = GetNumber(-1);
            // Dùng animation lật ngang:
            flipPanel.CheckAnimation = false;
            // Xét điều kiện:
            // Nếu hiện tại nút Both được click
            if (_CheckConditional[2] == true)
            {
                // Khởi tạo và gán giá trị tiếp theo vào flipPanel:
                Both = new uctrlBoth(index);
                flipPanel.Behind = Both;
            }
            else
            {
                // Khởi tạo và gán giá trị trước vào flipPanel:
                uEnglish = new uctrlEnglish(index);
                flipPanel.Behind = uEnglish;
                // Khởi tạo hàm cho phép click vào uEnglish:
                pnEnglish.Click += PnEnglish_Click;
            }
            // Hàm kiểm tra nếu tồn tại quá 2 controls trong flipPanel thì xóa bớt đi 1 cái:
            if (flipPanel.Controls.Count == 3)
                flipPanel.Controls[1].Dispose();
            // Thực hiện hàm lật ngang
            flipPanel.Flip();
            // Giảm Progressbar
            DecreaseProgressbar();
            // Điều kiện dừng:
            if ((lRandom == null && id == 0) || (lRandom != null && id==0))
                pbLeft.Enabled = false;
        }
        #endregion

        #region Click Lật hình
        private void PnEnglish_Click(object sender, EventArgs e)
        {
            // Dùng animation lật dọc:
            flipPanel.CheckAnimation = true;
            // Lấy từ hiện tại
            int index = GetNumber(0);
            // Khởi tạo uctrlVietnamese
            uVietnamese = new uctrlVietnamese(index);
            // Lưu vào flip Panel để lật
            flipPanel.Behind = uVietnamese;
            // Sinh hàm click:
            pnVietnamese.Click += PnVietnamese_Click;
            // Xóa phần dư ra trong flipPannel: 
            if (flipPanel.Controls.Count == 3)
                flipPanel.Controls[1].Dispose();
            // Thực hiện flip
            flipPanel.Flip();
        }

        private void PnVietnamese_Click(object sender, EventArgs e)
        {
            // Dùng animation lật dọc:
            flipPanel.CheckAnimation = true;
            // Lấy từ hiện tại
            int index = GetNumber(0);
            // Khởi tạo uctrlEnglish
            uEnglish = new uctrlEnglish(index);
            // Lưu vào flip Panel để lật
            flipPanel.Behind = uEnglish;
            // Sinh hàm click vào uEnglish
            pnEnglish.Click += PnEnglish_Click;
            // Xóa phần dư ra trong flipPannel:
            if (flipPanel.Controls.Count == 3)
                flipPanel.Controls[1].Dispose();
            // Thực hiện flip
            flipPanel.Flip();
        }

        #endregion

        #region Hover - Leave vào các nút trái phải
        private void pbRight_MouseHover(object sender, EventArgs e)
        {
            pbRight.Image = Properties.Resources.Right_3_512_;
        }

        private void pbRight_MouseLeave(object sender, EventArgs e)
        {
            pbRight.Image = Properties.Resources.Right_3_5121;
        }

        private void pbLeft_MouseHover(object sender, EventArgs e)
        {
            pbLeft.Image = Properties.Resources.Left_512_;
        }

        private void pbLeft_MouseLeave(object sender, EventArgs e)
        {
            pbLeft.Image = Properties.Resources.Left_5121;
        }
        #endregion

        #region Auto Play

        /// <summary>
        /// Tự động học từ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbAutoPlay_Click(object sender, EventArgs e)
        {
            // Bây giờ mới click:
            if (_CheckConditional[0] == false)
            {
                _CheckConditional[0] = true;
                pbAutoPlay.Image = Properties.Resources.auto_3; pbAutoPlay.Refresh();
                timerPlay.Enabled = true;
            }
            else // Auto rồi -> tắt auto
            {
                pbAutoPlay.Image = Properties.Resources.auto_2; pbAutoPlay.Refresh();
                _CheckConditional[0] = false;
                timerPlay.Enabled = false;
            }
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            if (pbRight.Enabled == true)
            {
                pbRight_Click(sender, e); // Qua từ tiếp theo
                timerPlay.Interval = 3000; // Cho chờ tầm 3s để thuộc
            }
            else // Nếu nút qua phải đã đến từ cuối cùng thi dừng auto play
            {
                timerPlay.Enabled = false;
                timerPlay.Interval = 100;
                _CheckConditional[0] = false;
                pbAutoPlay.Image = Properties.Resources.auto_2; pbAutoPlay.Refresh();
            }
        }
        private void pbAutoPlay_MouseHover(object sender, EventArgs e)
        {
            if (_CheckConditional[0] == false)
                pbAutoPlay.Image = Properties.Resources.auto_3;
        }

        private void pbAutoPlay_MouseLeave(object sender, EventArgs e)
        {
            if (_CheckConditional[0] == false)
                pbAutoPlay.Image = Properties.Resources.auto_2;
        }
        #endregion

        #region Hàm Random
        List<int> AddNumberIntoList()
        {
            List<int> lInt = new List<int>();
            for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
                lInt.Add(i);
            return lInt;
        }

        void RandomListWord()
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

        #region Hàm trộn từ 
        private void pbShuffle_Click(object sender, EventArgs e)
        {
            // Tắt timer của auto play:
            timerPlay.Enabled = false; timerPlay.Interval = 100;
            // Tắt Auto Play
            _CheckConditional[0] = false;
            // Thay đổi hình Auto Play
            pbAutoPlay.Image = Properties.Resources.auto_2; pbAutoPlay.Refresh();
            // Đặt lại giá trị mặc định:
            id = 0;
            pbLeft.Enabled = false; pbRight.Enabled = true;
            ClearProgressbar();
            int index = 0;
            // = false nghĩa là chưa được click mà bây giờ mới được click thì:
            // Thực hiện random từ:
            if (_CheckConditional[1] == false)
            {
                pbShuffle.Image = Properties.Resources.shuffle_2; pbShuffle.Refresh();
                RandomListWord();
                index = GetNumber(0);
                _CheckConditional[1] = true;
            }
            else // = true nghĩa là đang shuffle -> chạy kiểu bình thường
            {
                pbShuffle.Image = Properties.Resources.shuffle_1; pbShuffle.Refresh();
                lRandom.Clear();
                lRandom = null;
                _CheckConditional[1] = false;

            }

            // Xử lý liên quan đến giao diện:
            flipPanel.Hide(); flipPanel.Controls.Clear(); Thread.Sleep(1000); flipPanel.Show();

            // Xét điều kiện:
            // Nếu hiện tại nút Both được click
            if (_CheckConditional[2] == true)
            {
                Both = new uctrlBoth(index);
                flipPanel.Front = Both;
                while (flipPanel.Controls.Count != 1)
                    flipPanel.Controls[0].Dispose();
            }
            else
            {
                uEnglish = new uctrlEnglish(index);
                uVietnamese = new uctrlVietnamese(index);
                // Gán từng giá trị vài flipPanel tương ứng với từng control:
                // Front là uEnglish và Behind là uVietnamese
                flipPanel.Front = uEnglish;
                flipPanel.Behind = uVietnamese;
                // Bật cho phép click vào uEnglish
                pnEnglish.Click += PnEnglish_Click;
            }
        }

        private void pbShuffle_MouseHover(object sender, EventArgs e)
        {
            if (_CheckConditional[1] == false)
                pbShuffle.Image = Properties.Resources.shuffle_2;
        }

        private void pbShuffle_MouseLeave(object sender, EventArgs e)
        {
            if (_CheckConditional[1] == false)
                pbShuffle.Image = Properties.Resources.shuffle_1;
        }
        #endregion

        #region Học cả hai từ cùng 1 lúc
        private void pbBoth_Click(object sender, EventArgs e)
        {
            // Tắt timer:
            timerPlay.Enabled = false;
            timerPlay.Interval = 100;
            // Chỉnh lại AutoPlay
            _CheckConditional[0] = false;
            // Thay đổi hình btnPlay:
            pbAutoPlay.Image = Properties.Resources.auto_2;
            //
            int index = GetNumber(0);

            // Bây giờ mới được click: -> khởi tạo Both
            if (_CheckConditional[2] == false)
            {
                pbBoth.Image = Properties.Resources.both_2; pbBoth.Refresh();
                Both = new uctrlBoth(index);
                flipPanel.Front = Both;
                // Xóa flip panel dư:
                while (flipPanel.Controls.Count != 1)
                    flipPanel.Controls[0].Dispose();
                _CheckConditional[2] = true;
            }
            else
            {
                pbBoth.Image = Properties.Resources.both_1; pbBoth.Refresh();
                uEnglish = new uctrlEnglish(index);
                uVietnamese = new uctrlVietnamese(index);
                // Gán từng giá trị vài flipPanel tương ứng với từng control:
                // Front là uEnglish và Behind là uVietnamese
                flipPanel.Front = uEnglish;
                flipPanel.Behind = uVietnamese;
                // Bật cho phép click vào uEnglish
                pnEnglish.Click += PnEnglish_Click;
                // Xóa control Both ra khỏi flip panel
                while (flipPanel.Controls.Count != 2)
                    flipPanel.Controls[0].Dispose();
                _CheckConditional[2] = false;
            }
        }

        private void pbBoth_MouseHover(object sender, EventArgs e)
        {
            if (_CheckConditional[2] == false)
                pbBoth.Image = Properties.Resources.both_2;
        }

        private void pbBoth_MouseLeave(object sender, EventArgs e)
        {
            if (_CheckConditional[2] == false)
                pbBoth.Image = Properties.Resources.both_1;
        }

        #endregion

    }

}
