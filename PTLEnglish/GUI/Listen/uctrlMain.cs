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

namespace PTLEnglish.GUI.Listen
{
    public partial class uctrlMain : UserControl
    {
        // Hàm lấy hàm từ form khác
        // Lưu ý form này trong form khác phải dc khởi tạo r
        public object GetControl
        {
            set;
            get;
        }
        // Hàm liên quan tới random
        List<int> lRandom = new List<int>();
        string filePath;
        int learnNumber = -1;
        public uctrlMain()
        {
            InitializeComponent();
            Manage.ThisCourse = "Source\\Economic";
            Manage.ThisTopic = "\\Job";
            filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";

            LoadDataToListen();

            ChooseKindOfListen();

        }

        private void ChooseKindOfListen()
        {
            Random rand = new Random();
            uctrlProgressBar _Progress = new uctrlProgressBar(filePath);
            int index = rand.Next(0, 3);
            switch (index)
            {
                case 0:
                    uctrlListen1 u1 = new uctrlListen1(filePath, learnNumber);
                    uctrlListen1.fpnMain = fpnMain;
                    u1.GetControlClick = this;
                    u1.GetControlProgressbar = _Progress;
                    pnMainListen.Controls.Add(u1);
                    u1.Location = new Point(40, 64);
                    break;
                case 1:
                    uctrlListen2 u2 = new uctrlListen2(filePath, learnNumber);
                    uctrlListen2.fpnMain = fpnMain;
                    u2.GetControlClick = this;
                    u2.GetControlProgressbar = _Progress;
                    pnMainListen.Controls.Add(u2);
                    u2.Location = new Point(79, 92);
                    break;
                case 2:
                    uctrlListen3 u3 = new uctrlListen3(filePath, learnNumber);
                    uctrlListen3.fpnMain = fpnMain;
                    u3.GetControlClick = this;
                    u3.GetControlProgressbar = _Progress;
                    pnMainListen.Controls.Add(u3);
                    u3.Location = new Point(79, 92);
                    break;
            }
            pnProgress.Controls.Add(_Progress);
        }

        private void LoadDataToListen()
        {
            // Đọc dữ liệu từ Xml lên:
            Manage.TopicData = (Topic)Manage.DeserializeFromXML(Cons.Path + Manage.ThisTopic + ".xml");
            // Kiểm tra nếu chưa học từ nào thì gọi hàm random ra dùng
            // Ngược lại thì thôi
            if (Manage.TopicData.Listen.Progress != -1)
            {
                lRandom = Manage.TopicData.Listen.ListRandom;
                learnNumber = Manage.TopicData.Listen.Progress - 1;
            }
            else
            {
                RandomListWord();
                Manage.TopicData.Listen.ListRandom = lRandom;
                Manage.SerializeToXML(Manage.TopicData, filePath);
            }
        }

        #region Hàm random
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
    }
}
