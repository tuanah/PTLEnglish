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
        // 2 biến user control:
        uctrlEnglish uEnglish;
        uctrlVietnamese uVietnamese;
        // 
        int id=0;
        public uctrlMainFlashCard()
        {
            InitializeComponent();
            Manage.ThisCourse = "Source\\Economic";
            Manage.ThisTopic = "\\Job";
            filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";
        }

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
        #endregion

        private void GetNextNumber()
        {

            // lRandom == null tức là hiện tại mình đang cho chạy caca1 từ học được theo thứ tự
            if (lRandom == null)
                return id++;
        }

        private void PnEnglish_Click(object sender, EventArgs e)
        {
            // Dùng animation lật dọc:
            flipPanel.CheckAnimation = true;
        }
    }

}
