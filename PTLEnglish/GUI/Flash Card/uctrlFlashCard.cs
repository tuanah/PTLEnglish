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
    /*  các hàm quan trong:
     *  
     * 
     
         */
    public partial class uctrlFlashCard : UserControl
    {
        // Tạo panel lưu lại lần click vào 2 cái English hoặc Vietnamese:
        public static Panel pnEnglish = new Panel();
        public static Panel pnVietnamese = new Panel();

        List<int> lRandom = null;
        // Kiểm tra có được shuffle ko
        int checkSuffle = 0;
        // Kiểm tra có click vào Both không:
        int checkBoth = 1;
        // Kiểm tra có click vào Auto Play không:
        int checkAutoPlay = 1;
        // 2 biến này sẽ quyết định nên dùng từ ở phần shuffle hay là không shuffle:
        int countNormal;
        int countRandom;
        //
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

        private void uctrlFlashCard_Load(object sender, EventArgs e)
        {

            // Đếm từ đã học
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
            flipPanel.TimerInterval = 15;
            // Tăng progressbar
            IncreasingProgressbar();
        }

        /// <summary>
        /// Lấy vị trí từ tiếp theo trong lRandom
        /// </summary>
        /// <returns></returns>
        int GetIndex()
        {
            int index = countNormal;
            if (lRandom != null)
                index = lRandom[countRandom];
            return index;
        }

        #region Hàm Xử lý ProgressBar
        /// <summary>
        /// Hàm tăng progress bar
        /// </summary>
        void IncreasingProgressbar()
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
        /// Giảm Progressbar
        /// </summary>
        void DecreaseProgressbar()
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
        void ClearProgressbar()
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

        #region Hàm click vào Các Flash Card English - Vietnamese
        private void PnEnglish_Click(object sender, EventArgs e)
        {
            // Dùng animation lật dọc:
            flipPanel.CheckAnimation = true;
            // Lấy vị trí tiếp theo
            int index = GetIndex();
            uVietnamese = new uctrlVietnamese(index);
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
            // Lấy vị trí tiếp theo
            int index = GetIndex();
            uEnglish = new uctrlEnglish(index);
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

        #region Hàm Random + Shuffle các từ 
        /// <summary>
        /// Hàm add các số vào trong list
        /// </summary>
        /// <returns></returns>
        List<int> AddNumberIntoList()
        {
            List<int> lInt = new List<int>();
            for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
                lInt.Add(i);
            return lInt;
        }

        /// <summary>
        /// Hàm thực hiện Random
        /// </summary>
        /// <param name="lRandom"></param>
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

        /// <summary>
        /// Hàm trộn - Random các từ 1 cách ngẫu nhiên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuffle_Click(object sender, EventArgs e)
        {
            // Tắt timer:
            timerPlay.Enabled = false; timerPlay.Interval = 100;
            // Tắt Auto Play
            checkAutoPlay = 1;
            // Thay đổi hình btnPlay:


            // Đặt lại các giá trị mặc định:
            countNormal = 0; countRandom = 0; pbLeft.Enabled = false; pbRight.Enabled = true;
            ClearProgressbar();
            // 
            int index = 0;
            if (checkSuffle == 1)  // Hiện đang suffle -> tắt suffle
            {
                // Thay đổi hình Shuffle:

                //
                lRandom.Clear(); lRandom = null;
                // Thay đổi trạng thái:
                checkSuffle = 0;
            }
            else // Hiện đang Normal -> Bật suffle
            {
                // Thay đổi hình Shuffle:

                //
                RandomListWord(ref lRandom);
                index = lRandom[0];
                // Thay đổi trạng thái:
                checkSuffle = 1;
            }


            // Xử lý liên quan đến gdien:
            flipPanel.Hide(); flipPanel.Controls.Clear(); Thread.Sleep(1000); flipPanel.Show();

            if (checkBoth == 0)  // Hiện đang dùng kiểu cả 2 Eng - Vie
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
        #endregion

        #region Hàm Click hiện từ mới - từ cũ :
        private void pbRight_Click(object sender, EventArgs e)
        {
            // Ẩn cái click hiện các nút click nhanh

            // Hiện click trái:            
            pbLeft.Enabled = true;

            // Lấy giá trị kế tiếp:
            int index = -1;
            if (lRandom != null)
                index = lRandom[++countRandom];
            else index = ++countNormal;
            // Dùng animation lật ngang:
            flipPanel.CheckAnimation = false;
            if (checkBoth == 0) // Hiện đang dùng kiểu cả 2 Eng - Vie
            {
                // Khởi tạo và gán giá trị tiếp theo vào flipPanel:
                Both = new uctrlBoth(index);
                flipPanel.Behind = Both;
            }
            else // dùng 1 kiểu
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

            // Nếu click phải vượt quá phạm vi quy định thì tắt click phải cho lượt kế tiếp
            if ((GetIndex() == 24 && countNormal != 0) || (lRandom != null && countRandom == lRandom.Count - 1))
                pbRight.Enabled = false;
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            // Tắt cái timer: 
            timerPlay.Enabled = false; timerPlay.Interval = 100;
            // Chỉnh lại chưa bật auto Play
            checkAutoPlay = 1;
            // Thay đổi hình btnPlay:

            // Hiện click phải:            
            pbRight.Enabled = true;
            // Lấy giá trị kế tiếp:
            int index = -1;
            if (lRandom != null)
                index = lRandom[--countRandom];
            else index = --countNormal;
            // Dùng animation lật ngang:
            flipPanel.CheckAnimation = false;
            if (checkBoth == 0) // Hiện đang dùng kiểu cả 2 Eng - Vie
            {
                // Khởi tạo và gán giá trị tiếp theo vào flipPanel:
                Both = new uctrlBoth(index);
                flipPanel.Behind = Both;
            }
            else // Ngược lại:
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
            // Nếu click trái vượt nhỏ hơn phạm vi quy định thì tắt click trái cho lượt kế tiếp
            if ((GetIndex() == 0 && countRandom == 0) || (lRandom != null && countRandom == 0))
                pbLeft.Enabled = false;
        }
        #endregion

        #region Hàm tự động học Flash card - không cần click:   

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Tắt timer:
            timerPlay.Enabled = false;
            timerPlay.Interval = 100;
            if (checkAutoPlay == 1) // Chưa auto -> auto
            {
                // Thay đổi hình btnPlay:

                //
                timerPlay.Enabled = true;
                // Đổi lượt
                checkAutoPlay = 0;
            }
            else // Auto rồi -> tắt auto
            {
                // Thay đổi hình btnPlay:

                //
                checkAutoPlay = 1;
                timerPlay.Enabled = false;
            }

        }

        /// <summary>
        /// Hàm này có tác dụng lật qua từ tiếp theo khi nút auto Play được bật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                checkAutoPlay = 1;
            }
        }
        #endregion

        #region Hàm cho phép hiện cả 2 phần Vietnamese và English ra màn hình:
        uctrlBoth Both;
        private void btnBoth_Click(object sender, EventArgs e)
        {
            // Tắt timer:
            timerPlay.Enabled = false;
            timerPlay.Interval = 100;
            // Chỉnh lại AutoPlay
            checkAutoPlay = 1;
            // Thay đổi hình btnPlay:

            //
            if (checkBoth == 1) // Chưa hiện 2 phần -> hiện 2 phần:
            {
                // Thay đổi hình btnBoth:

                //
                Both = new uctrlBoth(GetIndex());
                flipPanel.Front = Both;
                // Xóa flip panel dư:
                while (flipPanel.Controls.Count != 1)
                    flipPanel.Controls[0].Dispose();
                // Chuyển:
                checkBoth = 0;
            }
            else // Hiện 2 phần -> muốn hiện lại 1 phần
            {
                // Thay đổi hình btnBoth:

                //
                uEnglish = new uctrlEnglish(GetIndex());
                uVietnamese = new uctrlVietnamese(GetIndex());
                // Gán từng giá trị vài flipPanel tương ứng với từng control:
                // Front là uEnglish và Behind là uVietnamese
                flipPanel.Front = uEnglish;
                flipPanel.Behind = uVietnamese;
                // Bật cho phép click vào uEnglish
                pnEnglish.Click += PnEnglish_Click;
                // Xóa control Both ra khỏi flip panel
                while (flipPanel.Controls.Count != 2)
                    flipPanel.Controls[0].Dispose();
                checkBoth = 1;
            }
        }
        #endregion


        /// <summary>
        /// Giao diện
        /// </summary>           

        #region Xử lý Giao diện các nút bấm trái phải:
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

    }
}
