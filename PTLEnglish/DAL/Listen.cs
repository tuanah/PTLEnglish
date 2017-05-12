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
    }
}
