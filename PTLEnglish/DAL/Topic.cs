using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTLEnglish.DAL
{
	[Serializable]
	public class Topic
	{
        
        private Listen listen = new Listen();
        private string topicName;       
        private List<Word> wordList;
		private List<int> wrongWords;
		private List<int> rightWords;
		private int numLearnt = 0;

       
        public Listen Listen { get => listen; set => listen = value; }
        public string TopicName { get => topicName; set => topicName = value; }
		public List<Word> WordList { get => wordList; set => wordList = value; }
		public List<int> WrongWords { get => wrongWords; set => wrongWords = value; }
		public List<int> RightWords { get => rightWords; set => rightWords = value; }
		public int NumLearnt { get => numLearnt; set => numLearnt = value; }
        

        public Topic()
        {
            wrongWords = new List<int>();
            rightWords = new List<int>();
        }       
	}
}
