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
            checkHorizontal = 5;
            timerRun.Enabled = true;
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
                    checkHorizontal = 4;
                    timerRun.Enabled = true;
                    CreateGame();
                }
                else if (!checkWriteWrongWordAgain && tbAnswer.Text.Trim() == tbAnswer.Tag.ToString())
                {
                    count++;
                    pnState.Controls[pnState.Controls.Count - 1].Dispose();
                    tbAnswer.Text = "";
                    checkHorizontal = 4;
                    timerRun.Enabled = true;
                    CreateGame();

                }
                else if (tbAnswer.Text.Trim() != tbAnswer.Tag.ToString())
                {
                    checkHorizontal = 3;
                    timerRun.Enabled = true;
                }
            }

        }

        int count = 0;
        List<int> lRandom = null;

        private void State_Load(object sender, EventArgs e)
        {
            lRandom = new List<int>();
            RandomListWord(ref lRandom);
            checkHorizontal = 1;
            timerRun.Enabled = true;
            CreateGame();
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        int checkHorizontal;
        private void timerRun_Tick(object sender, EventArgs e)
        {
            if (checkHorizontal == 1)
            {
                lbCommand.Text = "TYPE ANSWER";
                lbCommand.ForeColor = Color.FromArgb(103, 183, 255);
                lbCommand.Refresh();//151, 165, 177
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.FromArgb(52, 152, 219);
                pnHorizontal.Height = pnHorizontalRun.Height = 4;
            }
            else if (checkHorizontal == 3) // sai
            {
                lbCommand.Text = "NOT CORRECT";
                lbCommand.ForeColor = Color.FromArgb(255, 114, 91);
                lbCommand.Refresh();
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.Red;
            }
            else if (checkHorizontal == 4) // đúng
            {
                lbCommand.Text = "CORRECT";
                lbCommand.ForeColor = Color.FromArgb(120, 200, 0);
                lbCommand.Refresh();
                pnHorizontalRun.Width = 0;
                pnHorizontalRun.BackColor = Color.FromArgb(120, 200, 0);
            }
            else if (checkHorizontal == 5) //Ghi lại
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
            checkHorizontal = 0;
            timerRun.Enabled = false;
            if (lbCommand.Text == "CORRECT")
            {
                Thread.Sleep(1000);
                tbAnswer_Click(senderr, ee);
            }

        }
        object senderr; EventArgs ee;
        private void tbAnswer_Click(object sender, EventArgs e)
        {
            checkHorizontal = 1;
            timerRun.Enabled = true;
        }
    }
}
