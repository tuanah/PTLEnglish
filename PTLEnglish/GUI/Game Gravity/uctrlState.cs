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

namespace PTLEnglish.GUI.Game_Gravity
{
    public partial class uctrlState : UserControl
    {
        public uctrlState()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            RandomListWord();
            CreateGame();
        }

        #region Hàm random dữ liệu
        List<int> lRandom = new List<int>();
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

        /* Các biến sử dụng:
         * id: Biến đếm các từ đã học được
         * Score: Điểm số đã học được
         * word: lấy từ tiếng việt hiện tại 
         * CheckWrong : Biến kiểm tra có ghi lại từ sai hay không
         * locationX, locationY : Biến lưu lại tọa độ
         * checkRefresh : Kiểm tra on paint cho vẽ text hay không cho vẽ text
         */
        int id = 0;
        int Score = 0;
        string word;
        bool CheckWrong = false;
        int locationX, locationY;
        bool checkRefresh = true;
        void CreateGame()
        {
            lbCommand.Text = "TYPE YOUR ANSWER";
            lbCommand.ForeColor = Color.FromArgb(0, 122, 204);
            pnHorizontal.BackColor = Color.FromArgb(0, 122, 204);
            // Nếu chạy hết tất cả các từ -> random -> chạy lại từ đầu
            if (id == Manage.TopicData.WordList.Count - 1)
            {
                // Hàm random list
                RandomListWord();
                id = 0;
            }
            else
            {
                // Random vị trí xuất hiện
                Random r = new Random();
                // Random vị trí:
                locationX = r.Next(145, 425);
                locationY = -20;               
                // Lấy từ hiện tại
                word = Manage.TopicData.WordList[lRandom[id]].Mean;
                // Lưu lại từ đúng và0 tbAnswer.Tag
                tbAnswer.Tag = Manage.TopicData.WordList[lRandom[id]].Key;
                // Chạy timer          
                timerPictureBox.Start();
            }
        }

       /// <summary>
       /// Hàm vẽ
       /// </summary>
       /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black); // Xóa chữ bằng cách tô màu đen đè lên
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Viết chữ
            if (checkRefresh)
                e.Graphics.DrawString(word, new Font("Cambria", 20), Brushes.White, new Point(locationX, locationY));
            base.OnPaint(e);
        }

        /// <summary>
        /// Chờ người dùng nhấn enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // Hàm kiểm tra đúng hay sai
                checkTrueFalse();
                e.Handled = false;
            }
        }

        /// <summary>
        /// Set ẩn hiện các control
        /// </summary>
        /// <param name="check"></param>
        void SetVisible(bool check=true)
        {
            lbCorrectAnswer.Visible = check;
            lbPrompt.Visible = check;           
            lbEnglish.Visible = check;
            lbVietnamese.Visible = check;
            pbImage.Visible = check;
        }
        

        /// <summary>
        /// Hàm kiểm tra từ đúng hay sai
        /// </summary>
        private void checkTrueFalse()
        {
            // Nếu từ đó đúng
            if (tbAnswer.Text == tbAnswer.Tag.ToString())
            {
                timerPictureBox.Stop();
                // Tăng điểm số:
                if (!CheckWrong)
                    Score++;
                else
                {
                    SetVisible(false);
                    checkRefresh = true;
                    CheckWrong = false;   // Reset checkWrong
                }
                lbScore.Text = Score.ToString(); lbScore.Refresh();
                // Set dữ liệu về mặc định:
                tbAnswer.Text = string.Empty;
                // Tăng từ học tiếp theo:
                id++;
                // Tạo game mới
                CreateGame();
                timerPictureBox.Start();
            }
            else
            { // Nếu sai thì hiện kiểu sai
                pnHorizontal.BackColor = Color.Red;
                lbCommand.Text = "NOT CORRECT"; lbCommand.ForeColor = Color.Red; lbCommand.Refresh();
            }
        }

        private void timerPictureBox_Tick(object sender, EventArgs e)
        {
            if (locationY >= Height-75)
            {
                timerPictureBox.Stop();
                checkRefresh = false;
                Invalidate();
                ShowWrongWord(); // Show từ sai
            }
            locationY += 3;
            Invalidate();
        }

        /// <summary>
        /// Người dùng click vào không biết
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbDontKnow_Click(object sender, EventArgs e)
        {
            timerPictureBox.Stop();
            checkRefresh = false;
            Invalidate();
            ShowWrongWord();
        }

        /// <summary>
        /// hàm hiện ra các từ sai
        /// </summary>
        private void ShowWrongWord()
        {
            CheckWrong = true;
            lbCommand.Text = "WRITE AGAIN TO REMEMBER";
            lbCommand.ForeColor = Color.FromArgb(66, 87, 178);
            pnHorizontal.BackColor = Color.BlueViolet;
            lbCommand.Refresh();
            pnHorizontal.Refresh();
            try
            {
                pbImage.Image = new Bitmap(Manage.TopicData.WordList[lRandom[id]].ImgPath);
            }
            catch
            {
                pbImage.Image = Properties.Resources.error_image;
            }
           
            lbEnglish.Text = Manage.TopicData.WordList[lRandom[id]].Key;
            lbVietnamese.Text = Manage.TopicData.WordList[lRandom[id]].Mean;
            SetVisible();            
        }
    }
}
