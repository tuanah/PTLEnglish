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

namespace PTLEnglish.GUI.Gravity
{
    public partial class State : UserControl
    {
        public State()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

        }

        #region Hàm Random
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
        Ailien_1 Ailien;
        int checkFirstAdd = 0;
        void CreateGame()
        {           
            Ailien = new Ailien_1(lRandom[count]);
            tbAnswer.Tag = Manage.TopicData.WordList[lRandom[count]].Key;
            // Set transparent
            Ailien.Parent = pnState;
            Ailien.BackColor = Color.Transparent;
            if (checkFirstAdd == 0)
                pnState.Controls.Add(Ailien);
            // Random:
            Random rand = new Random();
            int Location_X = rand.Next(145, 425);
            Ailien.Location = new Point(Location_X, -280);
            timerPictureBox.Enabled = true;
            timerPictureBox.Interval = 20;
        }

        ShowWrongWord wrongWord;
        bool checkWriteWrongWordAgain = true;
        void ShowWrongWord()
        {
            Manage.TopicData.WordList[lRandom[count]].NumWrong++;
            wrongWord = new Gravity.ShowWrongWord(lRandom[count]);
            pnState.Controls.Add(wrongWord);
            pnState.Location = new Point(165, 173);
            checkWriteWrongWordAgain = false;
        }

        private void timerPictureBox_Tick(object sender, EventArgs e)
        {
            checkFirstAdd = 1;
            Ailien.Top += 1;
            if (Ailien.Location.Y > pnState.Height)
            {
                timerPictureBox.Enabled = false;
                ShowWrongWord();
            }
        }

        int score = 0;
        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && tbAnswer.Text.Trim() != "")
            {
                e.Handled = true;

                if (tbAnswer.Text.Trim() == tbAnswer.Tag.ToString() && checkWriteWrongWordAgain)
                {
                    Manage.TopicData.WordList[lRandom[count]].NumRight++;
                    score++;
                    lbScore.Text = score.ToString();
                    count++;
                    tbAnswer.Text = "";
                    pnState.Controls[pnState.Controls.Count - 1].Dispose();
                    CreateGame();
                }
                else if (!checkWriteWrongWordAgain && tbAnswer.Text.Trim() == tbAnswer.Tag.ToString())
                {
                    count++;
                    pnState.Controls[pnState.Controls.Count - 1].Dispose();
                    tbAnswer.Text = "";
                    CreateGame();
                }
            }
        }

        int count = 0;
        List<int> lRandom = null;

        private void State_Load(object sender, EventArgs e)
        {
            lRandom = new List<int>();
            RandomListWord(ref lRandom);
            CreateGame();
        }
    }
}
