using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTLEnglish.DAL
{
   public class Listen
    {
        private int progress = -1;
        private int wrongWords = 0;
        private int correctWords = 0;
        private List<int> listRandom =null;
        private List<int> listWrongWord= null;
        private bool firstTimeOfWord =false;
        public int Progress { get => progress; set => progress = value; }
        public int WrongWords { get => wrongWords; set => wrongWords = value; }
        public int CorrectWords { get => correctWords; set => correctWords = value; }
        public List<int> ListRandom { get => listRandom; set => listRandom = value; }
        public List<int> ListWrongWord { get => listWrongWord; set => listWrongWord = value; }
        public bool FirstTimeOfWord { get => firstTimeOfWord; set => firstTimeOfWord = value; }


        private static void ResetData()
        {
            Manage.TopicData.Listen.CorrectWords = 0; // Từ đúng
            Manage.TopicData.Listen.WrongWords = 0; // Từ sai
            Manage.TopicData.Listen.Progress = -1; // Tiến trình học
            Manage.TopicData.Listen.ListRandom = null; // Danh sách Random
            Manage.TopicData.Listen.ListWrongWord = null; // Danh sách từ sai
            Manage.TopicData.Listen.FirstTimeOfWord = false; // Từ có phải lần đầu không
        }
    }
}
