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

namespace PTLEnglish.GUI.Gravity
{
    public partial class State : UserControl
    {
        public State()
        {
            InitializeComponent();           
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
            CreateGame();
            timerPictureBox.Enabled = true;
            timerPictureBox.Interval = 10;
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
         Bitmap bm;
        void CreateGame()
        {
            // Set transparent
            Ailien = new Ailien_1(2);
            Ailien.Parent = pnState;
            Ailien.BackColor = Color.Transparent;
            pnState.Controls.Add(Ailien);
            // Random:
            Random rand = new Random();
            int Location_X = rand.Next(0, 397);
            Ailien.Tag = -273;
            Ailien.Location = new Point(Location_X, 0);
            Ailien.Size = new Size(300, 271);
            //
            bm = new Bitmap(pnState.Width, pnState.Height);
            Ailien.DrawToBitmap(bm, new Rectangle(Ailien.Location, Ailien.Size));

        }

        void PaintImage(PaintEventArgs e)
        {
            // Bật tính năng vẽ không có răng cưa:
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Ailien.Location = new Point(Ailien.Location.X, Ailien.Location.Y + 1);
            e.Graphics.DrawImageUnscaledAndClipped(bm, new Rectangle(Ailien.Location, Ailien.Size));
        }

        private void timerPictureBox_Tick(object sender, EventArgs e)
        {
            // Ailien.Location = new Point(Ailien.Location.X, Ailien.Location.Y + 1);
            // Ailien.DrawToBitmap(bm, new Rectangle(Ailien.Location, Ailien.Size));
        }
    }
}
