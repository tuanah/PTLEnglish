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

namespace PTLEnglish.GUI.Game_Gravity
{
    public partial class uctrlState : UserControl
    {
        public uctrlState()
        {
            InitializeComponent();
        }

        List<int> lRandom = new List<int>();
        #region Hàm random dữ liệu
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

        int id = -1;
        void CreateGame()
        {

            // Nếu chạy hết tất cả các từ -> random -> chạy lại từ đầu
            if (id == Manage.TopicData.WordList.Count-1)
            {
                RandomListWord();
                id=0;
            }
        }

        Bitmap b;
        protected override void OnPaint(PaintEventArgs e)
        {
            Random r = new Random();
            b = new Bitmap(Properties.Resources._7_5121, new Size(Properties.Resources.error_image.Width / 2, Properties.Resources.error_image.Height / 2));
            Graphics.FromImage(b).DrawString("Hello", new Font("Cambria", 16), Brushes.Blue, new PointF(40, 155));
            e.Graphics.DrawImage(b, r.Next(145, 425), 80);
            base.OnPaint(e);
        }

        private void timerPictureBox_Tick(object sender, EventArgs e)
        {

        }
    }
}
